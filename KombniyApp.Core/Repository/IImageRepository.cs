using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KombniyApp.Core.Models;

namespace KombniyApp.Core.Repository
{
	public interface IImageRepository:IRepository<GalleryImage>
	{
		IEnumerable<GalleryImage> GetAll();
		IEnumerable<GalleryImage> GetWithTag(string tag);
		Task<GalleryImage> GetById(int id);
	}
}
