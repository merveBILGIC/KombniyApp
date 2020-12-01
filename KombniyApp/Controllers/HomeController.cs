using KombniyApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KombniyApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			ViewBag.RenderCarousel = true;
			return View();
			
		}
		public ActionResult Product()
		{
			ViewBag.RenderCarousel = false;
			return View();
		}

		public ActionResult Checkout()
		{
			ViewBag.RenderCarousel = false;
			return View();
		}
	}
}
