using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using KombniyApp.Models;

namespace KombniyApp.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

	   [HttpGet]
		public IActionResult LoginPage()
		{
			return View();
		}

		[HttpPost]
		public IActionResult LoginPage(LoginModel model )
		{
			return View(model);
		}
	}
}
