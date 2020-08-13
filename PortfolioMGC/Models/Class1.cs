using System;
using System.Threading.Tasks;
using System.Web.UI;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace PortfolioMGC.Models
{
    class Mail
    {
   
        public Mail(String name, String message, String email)
        {
            var apiKey = "";
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("marygracebusloncordoto@gmail.com", "DX Team"),
                Subject = "Hello World from the SendGrid CSharp SDK!",
                PlainTextContent = "Hello, Email!",
                HtmlContent = "<div style='width: 100%; background-color: #6e1485; padding-top: 30px; padding-bottom: 30px;'>" +
                "<center>" +
                "<div style='width: 300px; background-color: white; word-wrap: break-word;>" +
                "<br><br><h3>Hi Mary Grace</h3>" +
                "<p style='margin:0px;'><b>"+ name +"'s</b> message from your porfolio:</p>" +
                "<p style='padding:0px;'>"+ message + "</p><br>" +
                "<p>Contact him/her on: <b>" + email + "</b></p>" +
                "<br><br></div>" +
                "</center>" +
                "</div>"
            };
            msg.AddTo(new EmailAddress("scarlettlove00018@gmail.com", "Test User"));
            var response = client.SendEmailAsync(msg);
            
        }
    }
}