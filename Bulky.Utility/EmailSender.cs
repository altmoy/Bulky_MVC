using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Utility
{

    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //Logic to send email
            SmtpClient smtpClient = new SmtpClient
            {
                Port = 8889,
                Host = "mail.aftacaa.us",
                EnableSsl = false,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("Account_Management@aftacaa.us", "#EDCFT^3edcft6")

            };
            var from = "Account_Management@aftacaa.us";
            return smtpClient.SendMailAsync(from, email, subject, htmlMessage);
        }
    }
}
