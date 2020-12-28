using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KombniyApp.Core.Models;

namespace KombniyAppAccount.Models
{
	public class GalleryIndexModel
	{
		public IEnumerable<GalleryImage> Images { get; set; }
		public string SearcQuery { get; set;  }

	}
}
