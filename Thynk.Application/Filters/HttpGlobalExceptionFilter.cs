using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using Thynk.Covid19Pcr.Application.DTOs.Response;
using Thynk.Covid19Pcr.Domain.Enums;
using Thynk.Covid19Pcr.Domain.Helpers;

namespace Thynk.Covid19Pcr.Application.Filters
{
    public class HttpGlobalExceptionFilter : IExceptionFilter
    {
        private readonly IWebHostEnvironment _env;
        private readonly ILogger<HttpGlobalExceptionFilter> _logger;

        public HttpGlobalExceptionFilter(IWebHostEnvironment env, ILogger<HttpGlobalExceptionFilter> logger)
        {
            _env = env;
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            _logger.LogError(new EventId(context.Exception.HResult),
                context.Exception,
                context.Exception.Message);
            ExecutedResult<string> apiResponse = new ExecutedResult<string>()
            {
                Response = ResponseCode.ProcessingError,
                Result = null
            };
            if (context.Exception.GetType() == typeof(Exception))
            {
                apiResponse.Message = context.Exception.Message.ToString();
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;

                context.Result = new BadRequestObjectResult(apiResponse);
            }

            else if (context.Exception.GetType() == typeof(DbUpdateException))
            {
                var dbUpdateEx = context.Exception as DbUpdateException;
                var sqlEx = dbUpdateEx?.InnerException as SqlException;
                if (sqlEx != null && (sqlEx.Number == 2627 || sqlEx.Number == 2601))
                {
                    apiResponse.Message = UniqueErrorFormatter(sqlEx, dbUpdateEx.Entries);
                    context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;

                    context.Result = new BadRequestObjectResult(apiResponse);
                }
                else
                {
                    var logKey = Utils.RandomString(15);
                    var errorDetails = Utils.FormatException(context.Exception);
                    Serilog.Log.Error($"ErrorID={logKey} {Environment.NewLine} {errorDetails}");
                }
            }
            else
            {
                apiResponse.Message = "An error occurred please try again";
                if (_env.IsDevelopment())
                {
                    apiResponse.Message = context.Exception.ToString();
                }
                // Result asigned to a result object but in destiny the response is empty. This is a known bug of .net core 1.1
                // It will be fixed in .net core 1.1.2. See https://github.com/aspnet/Mvc/issues/5594 for more information
                context.Result = new BadRequestObjectResult(apiResponse);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                var logKey = Utils.RandomString(15);
                apiResponse.Message = $"{apiResponse.Message}  LOG-KEY: {logKey}";
                var errorDetails = Utils.FormatException(context.Exception);
                Serilog.Log.Error($"ErrorID={logKey} {Environment.NewLine} {errorDetails}");
            }
            context.ExceptionHandled = true;
        }

        public static string UniqueErrorFormatter(SqlException ex, IReadOnlyList<EntityEntry> entitiesNotSaved)
        {
            var message = ex.Errors[0].Message;
            var matches = UniqueConstraintRegex.Matches(message);

            if (matches.Count == 0)
            {
                return null;
            }

            //currently the entitiesNotSaved is empty for unique constraints - see https://github.com/aspnet/EntityFrameworkCore/issues/7829
            var entityDisplayName = entitiesNotSaved.Count == 1
                ? entitiesNotSaved.Single().Entity.GetType().Name
                : matches[0].Groups[1].Value;

            return $"{entityDisplayName} with matching {matches[0].Groups[2].Value} already exists";
        }

        private static readonly Regex UniqueConstraintRegex =
            new Regex("IX_([a-zA-Z0-9]*)_([a-zA-Z0-9]*)'", RegexOptions.Compiled);

    }
}
