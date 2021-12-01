using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;
using System.Threading.Tasks;
using Thynk.Covid19Pcr.Application.Interfaces.Shared;
using Thynk.Covid19Pcr.Application.Models.Request;
using Thynk.Covid19Pcr.Application.Models.Settings;

namespace Thynk.Covid19Pcr.Infrastructure.Shared.Services
{
    public class SmtpMailService : IMailService
    {
        public MailSettings _mailSettings { get; }
        public ILogger<SmtpMailService> _logger { get; }

        public SmtpMailService(IOptions<MailSettings> mailSettings, ILogger<SmtpMailService> logger)
        {
            _mailSettings = mailSettings.Value;
            _logger = logger;
        }

        public async Task SendAsync(MailRequest request)
        {
            try
            {
                var email = new MimeMessage
                {
                    Sender = MailboxAddress.Parse(request.From ?? _mailSettings.From)
                };
                email.To.Add(MailboxAddress.Parse(request.To));
                email.Subject = request.Subject;
                var builder = new BodyBuilder
                {
                    HtmlBody = request.Body
                };
                email.Body = builder.ToMessageBody();
                using var smtp = new SmtpClient();
                smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
                smtp.Authenticate(_mailSettings.UserName, _mailSettings.Password);
                await smtp.SendAsync(email);
                smtp.Disconnect(true);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex.Message, ex);
            }
        }
    }
}
