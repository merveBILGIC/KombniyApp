using System;
using System.Collections.Generic;
using System.Text;

namespace KombniyApp.Core
{
	class StlingAndEnvironment
	{
		public int StlingAndEnvironmentId { get; set; }
		public string Name { get; set; }
		public Product Product { get; set;}
		public ICollection<Product> Products { get; set; }
	}
}
