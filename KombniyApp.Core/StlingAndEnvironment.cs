using System;
using System.Collections.Generic;
using System.Text;
using KombniyApp.Core;

namespace KombniyApp.Core
{
	public class StlingAndEnvironment
	{
		public int StlingAndEnvironmentId { get; set; }
		public string Name { get; set; }
		public ICollection<Product> Products { get; set; }

		
	}
}
