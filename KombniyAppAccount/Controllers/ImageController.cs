using KombniyAppAccount.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KombniyAppAccount.Controllers
{
	public class ImageController : Controller
	{
		public IActionResult Upload()
		{
			var model = new UploadImageModel();
			return View();
		}

		[HttpPost]
		public IActionResult UploadNewImage()
		{
			return Ok();
		}
	}
}
