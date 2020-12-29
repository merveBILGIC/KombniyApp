using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KombniyAppAccount.Models;
using KombniyApp.Core.Models;
using KombniyApp.Core.Services;

namespace KombniyAppAccount.Controllers
{
	public class GalleryController : Controller
	{
		private readonly IImage _imageService;

		public GalleryController(IImage ımage)
		{
			_imageService = ımage;
		}

		public IActionResult Index()
		{
			var imageList = _imageService.GetAll();
			var model = new GalleryIndexModel()
			{
				Images = imageList,
				SearcQuery = ""
			}
			return View(model);

		}

		
	
	}
}
