using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KombniyApp.Core.Models;
using KombniyApp.Core.Repository;
using KombniyApp.Core.Services;
namespace KombniyApp.Services
{
	public class ImageService : IImage
	{
		private IUnitOfWork _unitOfWork;
		public ImageService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;

		}
		public IEnumerable<GalleryImage> GetAll()
		{
			return _unitOfWork.ımageRepository.GetAll();
		}

		public async Task<GalleryImage> GetById(int id)
		{
			return await _unitOfWork.ımageRepository.GetById(id);
		}

		public IEnumerable<GalleryImage> GetWithTag(string tag)
		{
			return _unitOfWork.ımageRepository.GetWithTag(tag);
		}
	}
}
