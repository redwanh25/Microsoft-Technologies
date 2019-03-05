using Microsoft.AspNet.Identity;
//using SendGrid;
using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Linq;
//using System.Net;
//using System.Threading.Tasks;
//using System.Web;

//namespace SignUp.Services
//{
//    public class EmailService : IIdentityMessageService
//    {
//        public async Task SendAsync(IdentityMessage message)
//        {
//            await configSendGridasync(message);
//        }

//        // Use NuGet to install SendGrid (Basic C# client lib) 
//        private async Task configSendGridasync(IdentityMessage message)
//        {

//            var myMessage = new SendGridMessage();

//            myMessage.AddTo(message.Destination);
//            myMessage.From = new System.Net.Mail.MailAddress("bimal.pixel@gmail.com", "Bimal Das");
//            myMessage.Subject = message.Subject;
//            myMessage.Text = message.Body;
//            myMessage.Html = message.Body;

//            var credentials = new NetworkCredential(ConfigurationManager.AppSettings["emailService:Account"],
//                                                    ConfigurationManager.AppSettings["emailService:Password"]);

//            var cr = new NetworkCredential("bimal.pixel@gmail.com", "Bimaldasfkt@2014");

//            // Create a Web transport for sending email.
//            var transportWeb = new Web(cr);

//            // Send the email.
//            if (transportWeb != null)
//            {
//                await transportWeb.DeliverAsync(myMessage);
//            }
//            else
//            {
//                //Trace.TraceError("Failed to create Web transport.");
//                await Task.FromResult(0);
//            }
//        }
//    }
//}