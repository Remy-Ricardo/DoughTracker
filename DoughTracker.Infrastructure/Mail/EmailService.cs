using DoughTracker.Application.Contracts.Infrastructure;
using DoughTracker.Application.Models.Mail;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DoughTracker.Infrastructure.Mail
{
    public class EmailService : IEmailService
    {
        private EmailSettings EmailSettings { get; }

        public EmailService(IOptions<EmailSettings> mailSettings) 
        {
            EmailSettings = mailSettings.Value;
        }

        public async Task<bool> SendEmail(Email email)
        {
            bool emailSuccesfullySent = false;
            SendGridClient client = new SendGridClient(EmailSettings.ApiKey);
            EmailAddress emailTo = new EmailAddress(email.To);
            String emailSubject = email.Subject;
            String emailBody = email.Body;


            EmailAddress emailFrom = new EmailAddress
            {
                Email = EmailSettings.FromAddress,
                Name = EmailSettings.FromName
            };

            SendGridMessage sendGridMessage = MailHelper.CreateSingleEmail(emailFrom, emailTo, emailSubject, emailBody, emailBody);
            Response response = (await client.SendEmailAsync(sendGridMessage));

            if (response.StatusCode == System.Net.HttpStatusCode.Accepted || response.StatusCode == System.Net.HttpStatusCode.OK) { emailSuccesfullySent = true; }

            return emailSuccesfullySent;
        }
    }
}
