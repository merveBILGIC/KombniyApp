using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace KombniyApp.Core.Models
{
	public class RegisterViewModel
	{
		[Key]
		public int registerId { get; set; }


		[Required(ErrorMessage = "Your  users name Required")]
		[StringLength(50, ErrorMessage = "5 to 50 characters.", MinimumLength = 3)]
		public string UserName { get; set; }


		[Required(ErrorMessage = "Your name Required")]
		[StringLength(50, ErrorMessage = "5 to 50 characters.", MinimumLength = 3)]
		public string Name { get; set; }



		[Required(ErrorMessage = "Your surname Required")]
		[StringLength(50, ErrorMessage = "5 to 50 characters.", MinimumLength = 3)]
		public string SurName { get; set; }

		[Required(ErrorMessage = "Email Required")]
		[EmailAddress(ErrorMessage = "Invalid email")]
		[Display(Name = "Email")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Phone Required")]
		[Phone(ErrorMessage = "Invalid phone number")]
		public short Phone { get; set; }

		[Display(Name = "Password")]
		[Required(ErrorMessage = "Invalid Password")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Display(Name = "Password Tekrar ")]
		[Required(ErrorMessage = "lütfen tekrar girin")]
		[Compare("Password", ErrorMessage = " Passwordler eşleşmedi")]
		[DataType(DataType.Password)]
		public string PasswordTekrar { get; set; }

		public string City { get; set; }
	}
}
