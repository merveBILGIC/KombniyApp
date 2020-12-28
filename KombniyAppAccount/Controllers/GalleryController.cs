using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KombniyAppAccount.Models;
using KombniyApp.Core.Models;

namespace KombniyAppAccount.Controllers
{
	public class GalleryController : Controller
	{
		public IActionResult Index()
		{
			var davet = new List<ImageTag>();
			var gunduz = new List<ImageTag>();
			var gece = new List<ImageTag>();

			var tag1 = new ImageTag()
			{
				Description = "Davet ortamı",
				Id = 0
			};
			var tag2 = new ImageTag()
			{
				Description = "günlük şıklık",
				Id = 1
			};
			var tag3 = new ImageTag()
			{
				Description = "gece şıklığı",
				Id = 2
			};


			davet.Add(tag1);
			gunduz.Add(tag2);
			gece.Add(tag3);



			var imageList = new List<GalleryImage>()
			{
				new GalleryImage()
				{
					Title="Abiye elbiseler",
					Url="https://www.pexels.com/tr-tr/fotograf/moda-kadin-romantik-model-3867110/",
					Created=DateTime.Now,
					Tags=davet
				},
				new GalleryImage()
				{
					Title="Günlük Elbise",
					Url="https://www.pexels.com/tr-tr/fotograf/kiz-lady-urban-arabalar-2085118/",
					Created=DateTime.Now,
					Tags=gunduz
				},
				new GalleryImage()
				{
					Title="Gece Elbisesi",
					Url="https://www.pexels.com/tr-tr/fotograf/asindirmak-asinmak-elbise-giyinmek-1375736/",
					Created=DateTime.Now,
					Tags=gece
				},
			};

			var model = new GalleryIndexModel()
			{
				Images = imageList ,
				SearcQuery=""
			};
			return View(model);
		}
	}
}
