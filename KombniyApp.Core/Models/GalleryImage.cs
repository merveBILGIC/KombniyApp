using System;
using System.Collections.Generic;
using System.Text;
using KombniyApp.Core.Models;
namespace KombniyApp.Core.Models
{
	public class GalleryImage
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public DateTime Created { get; set;  }
		public string Url { get; set;  }
		public virtual IEnumerable<ImageTag>Tags { get; set; }
	}
}
