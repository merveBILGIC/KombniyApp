using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace KombniyApp.Core.Manage
{
	public class MailManage
	{

        public static async Task<bool> ResetPasswordCode(string mailto, string code)
        {
            string subject = "Parola Sıfırlama";
            string text = "<h1><b>Kodunuz:</b> " + code + "</h1>";
            string sender = "noreplykombniyapp@gmail.com";
            MailMessage msg = new MailMessage(sender, mailto, subject, text);
            msg.IsBodyHtml = true;
            SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
            sc.UseDefaultCredentials = false;
            NetworkCredential cre = new NetworkCredential(sender, "KombniyApp2811");
            sc.Credentials = cre;
            sc.EnableSsl = true;
            await sc.SendMailAsync(msg);
            return true;

        }
    }
}
