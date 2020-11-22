using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KombniyApp.Models
{
	public class NewUsersModel
	{

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
		public string  Email{ get; set; }

		[Required(ErrorMessage = "Phone Required")]
		[Phone(ErrorMessage ="Invalid phone number")]
		public short Phone { get; set; }

		[Required(ErrorMessage ="Invalid Password")]
	    //pasword dogrulama yapcaz
		public string Password { get; set; }

		public string City { get; set; }

		[DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
		[Display(Name = "Birth Date")]
		public DateTime? BirthDate { get; set; }
	}
}
