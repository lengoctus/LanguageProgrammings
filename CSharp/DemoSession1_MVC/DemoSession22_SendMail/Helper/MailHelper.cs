using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace DemoSession22_SendMail.Helper
{
    public class MailHelper
    {

        public IConfiguration Configuration { get; }

        public MailHelper(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public MailHelper()
        {
        }

        public bool SendMail(string to, string Subject, string content)
        {

            try
            {
                // Thong tin tai khoan gui mail

                var username = Configuration["Gmail:Username"];
                var password = Configuration["Gmail:Password"];
                var enable = Configuration["Gmail:SMTP:starttls:enable"];


                var smtpClient = new SmtpClient
                {
                    Host = Configuration["Gmail:Host"],
                    Port = Convert.ToInt32(Configuration["Gmail:Port"]),
                    EnableSsl = Convert.ToBoolean(enable),
                    Credentials = new NetworkCredential(username, password)
                };

                var mailMess = new MailMessage(username, to);
                mailMess.Subject = Subject;
                mailMess.Body = content;
                mailMess.IsBodyHtml = true;

               smtpClient.Send(mailMess);
                
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }
    }
}
