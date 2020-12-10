using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KombniyApp.Core;



namespace KombniyApp.Core
{
	public class Product
	{
		public Product()
		{

		}
		[Key]
		public int ProductId { get; set; }
		public IFormFile ImageFile { get; set; }
		public string ImageSrc { get; set; }

		public int WardrobeId { get; set; }
		public Wardrobe Wardrobe { get; set; }
		public int StlingAndEnvironmentId { get; set; }

		public StlingAndEnvironment StlingAndEnvironment { get; set; }

	}
}
