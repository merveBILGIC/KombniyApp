using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KombniyApp.Core.Models;

namespace KombniyApp.Core.Services
{
	public interface IImage
	{
		IEnumerable<GalleryImage> GetAll();
		IEnumerable<GalleryImage> GetWithTag(string tag); 
		Task< GalleryImage> GetById(int id);
	}
}
