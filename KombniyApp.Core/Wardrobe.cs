using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using KombniyApp.Core;

namespace KombniyApp.Core
{
	public class Wardrobe
	{
		public Wardrobe()
		{

		}
		[Key]
		public int WardrobeId { get; set; }
		public int ProductId { get; set; }
		public  Product Product { get; set; }
		public ICollection<Product> Products { get; set; }


	}
}
