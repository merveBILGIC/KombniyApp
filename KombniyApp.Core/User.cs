using System;
using System.ComponentModel.DataAnnotations;
using KombniyApp.Core;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace KombniyApp.Core
{
	public class User

	{

		public int UserId { get; set; }
		
		
		public string Name { get; set; }
		
		public string Surname { get; set; }
		
		public string Username { get; set; }
		
		public string Email { get; set; }
		
		
		public string Password { get; set; }
		public string Repassword { get; set; }

		public string photoPath { get; set; }

		
		public string About { get; set; } = "Bir bilgi girilmedi";

		public int WardrobeId { get; set; }

		public Wardrobe Wardrobe { get; set; }

		public IEnumerable<Wardrobe> Wardrobes { get; set; }


	}
}
