using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using KombniyApp.Core.Models;

namespace KombniyApp.Core
{
	class Wardrobe
    {
		public Wardrobe()
		{

		}
		[Key]
		public int WardrobeId { get; set; }
		public ICollection<Product> products { get; set; }
		

	}
}
