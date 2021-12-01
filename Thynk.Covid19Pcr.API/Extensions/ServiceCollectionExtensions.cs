using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Hangfire;
using Hangfire.SqlServer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System;
using System.Reflection;
using Thynk.Covid19Pcr.Application.Filters;
using Thynk.Covid19Pcr.Application.Interfaces.Context;
using Thynk.Covid19Pcr.Application.Interfaces.Repositories;
using Thynk.Covid19Pcr.Application.Interfaces.Service;
using Thynk.Covid19Pcr.Application.Interfaces.Shared;
using Thynk.Covid19Pcr.Application.Mappings;
using Thynk.Covid19Pcr.Application.Models.Settings;
using Thynk.Covid19Pcr.Application.Services;
using Thynk.Covid19Pcr.Infrastructure.DbContexts;
using Thynk.Covid19Pcr.Infrastructure.Repositories;
using Thynk.Covid19Pcr.Infrastructure.Shared.Services;

namespace Thynk.Covid19Pcr.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static T AddConfig<T>(this IServiceCollection services, IConfiguration configuration)
           where T : class, new()
        {
            return services.AddConfig<T>(configuration, options => { });
        }

        public static TSettings AddConfig<TSettings>(this IServiceCollection services, IConfiguration configuration, Action<BinderOptions> configureOptions)
            where TSettings : class, new()
        {
            if (services == null) { throw new ArgumentNullException(nameof(services)); }
            if (configuration == null) { throw new ArgumentNullException(nameof(configuration)); }

            TSettings setting = configuration.Get<TSettings>(configureOptions);
            services.TryAddSingleton(setting);
            return setting;
        }

        public static void AddEssentials(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddControllers(opt =>
            {
                opt.Filters.Add(typeof(ModelStateValidationFilterAttribute));
                opt.Filters.Add(typeof(HttpGlobalExceptionFilter));
            }).AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            }).AddFluentValidation();

            services.AddConfig<CovidSettings>(Configuration.GetSection(nameof(CovidSettings)));
            services.AddConfig<MailSettings>(Configuration.GetSection(nameof(MailSettings)));

            services.RegisterSwagger();
            services.AddVersioning();

            // Add Hangfire services.
            services.AddHangfire(configuration => configuration
                .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseRecommendedSerializerSettings()
                .UseSqlServerStorage(Configuration.GetConnectionString("HangfireConnection"), new SqlServerStorageOptions
                {
                    CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                    SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                    QueuePollInterval = TimeSpan.Zero,
                    UseRecommendedIsolationLevel = true,
                    UsePageLocksOnDequeue = true,
                    DisableGlobalLocks = true
                }));

            services.AddHttpContextAccessor();

            services.AddHangfireServer();
        }

        public static void AddCrossOriginResource(this IServiceCollection services)
        {
            services.AddCors(opt =>
            {
                opt.AddPolicy("ApiCorsPolicy", policy =>
                {
                    policy.AllowAnyMethod().AllowAnyHeader().WithOrigins("*");
                });
            });
        }

        private static void RegisterSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Thynk Covid19 PCR",
                    License = new OpenApiLicense()
                    {
                        Name = "MIT License",
                        Url = new Uri("https://opensource.org/licenses/MIT")
                    }
                });
            });
        }

        private static void AddVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
            });
        }

        public static void AddApplicationLayer(this IServiceCollection services)
        {
            // AutoMapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public static void AddContextInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                   options.UseInMemoryDatabase("ApplicationDb"));
            }
            else
            {
                services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ApplicationConnection"), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            }

            #region Services

            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IPatientService, PatienceService>();
            services.AddScoped<IReportService, ReportService>();

            #endregion Services
        }

        public static void AddPersistenceContexts(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            #region Repositories

            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            #endregion Repositories
        }

        public static void AddSharedInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IMailService, SmtpMailService>();
        }
    }
}
