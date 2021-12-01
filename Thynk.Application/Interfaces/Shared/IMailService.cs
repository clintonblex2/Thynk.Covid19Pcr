using System.Threading.Tasks;
using Thynk.Covid19Pcr.Application.Models.Request;

namespace Thynk.Covid19Pcr.Application.Interfaces.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}
