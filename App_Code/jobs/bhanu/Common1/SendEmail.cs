using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace MovieKiran.Common
{
    public class SendEmail
    {
        public string SendMail(string SendToEmail, string CC, string Bcc, string Subject, string Body)
        {
            // To Send the mail
            string messageStatus = "";
            string error = "";
            MailMessage objMailMessage = new MailMessage();
            objMailMessage.From = new MailAddress("chandrabhanp@gmail.com");
            objMailMessage.IsBodyHtml = true;
            objMailMessage.To.Add(SendToEmail);
            if(CC!="")
            objMailMessage.CC.Add(CC);
            if (Bcc != "")
            objMailMessage.Bcc.Add(Bcc);
            objMailMessage.Subject = Subject;
            objMailMessage.Body = Body;
            SmtpClient objSmtpClient = new SmtpClient("smtp.gmail.com");
            objSmtpClient.Port = 587;
            objSmtpClient.Credentials = new System.Net.NetworkCredential("chandrabhanp@gmail.com", "hellomax9023514045");
            objSmtpClient.EnableSsl = true;
            try
            {
                objSmtpClient.Send(objMailMessage);
            }


            catch (SmtpException ex)
            {
                HttpContext.Current.Response.Write(ex.Message);
            }

            return messageStatus;
        }
    }
}