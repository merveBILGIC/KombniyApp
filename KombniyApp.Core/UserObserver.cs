using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace KombniyApp.Core
{
	class UserObserver : Observer
	{
		public override void Create(object obj)
		{
			User user = (User)obj;
			string mailto = user.Email;
			string subject = "KombniyApp Kayıt";
			string text = "<h1><b>Sayın " + user.Name + " " + user.Surname + "</b></h1> Kombniyapp Proje Planlama ve Yönetim sistemine hoşgeldiniz! ";
			string sender = "noreplykombniyapp@gmail.com";
			MailMessage msg = new MailMessage(sender, mailto, subject, text);
			msg.IsBodyHtml = true;
			SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
			sc.UseDefaultCredentials = false;
			NetworkCredential cre = new NetworkCredential(sender, "Kombniyapp2811");
			sc.Credentials = cre;
			sc.EnableSsl = true;
			sc.Send(msg);
		}
		public override void Update(object obj)
		{
			User user = (User)obj;
			string mailto = user.Email;
			string subject = "KombniyApp";
			string text = "<h1><b>Sayın " + user.Name + " " + user.Surname + "</b></h1> Profil bilgileriniz güncellenmiştir.";
			string sender = "noreplykombniyapp@gmail.com";
			MailMessage msg = new MailMessage(sender, mailto, subject, text);
			msg.IsBodyHtml = true;
			SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
			sc.UseDefaultCredentials = false;
			NetworkCredential cre = new NetworkCredential(sender, "KombniyApp2811");
			sc.Credentials = cre;
			sc.EnableSsl = true;
			sc.Send(msg);
		}



	}
}
