using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Identity.UI.Services;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbergueAnimais.Areas.Identity.Services
{
    public class EmailSenders : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var msg = new MimeMessage();
            msg.From.Add(new MailboxAddress("Email Confirmação", "m7.gpr.1718@gmail.com"));
            msg.To.Add(new MailboxAddress("User", email));
            msg.Subject = subject + "GROUP NOTIFICATIONS";
            msg.Body = new TextPart("html")
            {
                //Text = "Please < a href 😕"https://albergueanimais.azurewebsites.net > login</a>"
                Text = message
            };

            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect("smtp.gmail.com", 465, SecureSocketOptions.Auto);
                client.Authenticate("m7.gpr.1718@gmail.com", "gpr_m7_1718");
                client.Send(msg);
                client.Disconnect(true);
            }
            return Task.CompletedTask;
        }

    //    using (var client = new SmtpClient()) {
    //client.ServerCertificateValidationCallback = (s, c, h, e) => true;

    //client.Connect(hostName, port, SecureSocketOptions.Auto);

    // ...
}
    
}
