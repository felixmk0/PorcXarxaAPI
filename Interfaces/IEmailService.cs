using PorcXarxaAPI.Services;
using System.Net.Mail;

namespace PorcXarxaAPI.Interfaces
{
    public interface IEmailService
    {
        Task<ServiceResult<bool>> SendEmailAsync(string to, string subject, string templateName, Dictionary<string, string>? variables = null, IEnumerable<Attachment>? attachments = null);
    }
}