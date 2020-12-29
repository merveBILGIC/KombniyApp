using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KombniyApp.Core.Models;
using KombniyApp.Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace KombiyApp.Data.Repository
{
	class ImageRepo:Repository<GalleryImage>,IImageRepository
	{
           public ImageRepo(AppDbContext context):base(context)
	       {

	       }
		private AppDbContext AppDbContext
		{
			get { return _context as AppDbContext; }
		}
		public IEnumerable<GalleryImage>GetAll()
		{
			return AppDbContext.GalleryImages
				.Include(img => img.Tags);
				
	    }
		public async Task<GalleryImage> GetById(int id)
		{
			return await AppDbContext.GalleryImages
				.Include(img => img.Id)
				.SingleOrDefaultAsync(x => x.Id == id);
		}

		public IEnumerable<GalleryImage>GetWithTag(string tag)
		{
			return GetAll().Where(img
				=> img.Tags
				.Any(t => t.Description == tag));
		}
			


	}
}
