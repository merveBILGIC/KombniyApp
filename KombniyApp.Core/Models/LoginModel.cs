using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace KombniyApp.Core.Models
{
	public class LoginModel
	{

		[Required(ErrorMessage = "Email Required")]
		[EmailAddress(ErrorMessage = "Invalid email")]
		[Display(Name = "Email")]
		public string Email { get; set; }



		[Display(Name = "Password")]
		[Required(ErrorMessage = "Invalid Password")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

	}
}
