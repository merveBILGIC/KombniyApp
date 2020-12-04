using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace KombniyAppAccount.Models.UsersModel
{
	public class LoginModel
	{

		[Required(ErrorMessage = "Email Required")]
		[EmailAddress(ErrorMessage = "Invalid email")]
		[Display(Name="Email")]
		public string Email { get; set; }

		

		[Display(Name ="Password")]
		[Required(ErrorMessage = "Invalid Password")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		
	}
}
