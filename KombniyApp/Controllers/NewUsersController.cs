using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KombniyApp.Controllers
{
	public class NewUsersController: Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		
		public IActionResult NewUsersPage()
		{
			return View();
		}

		[HttpPost]
		public IActionResult NewUsersPage(FormCollection form)
		{
			return View();
		}
	}
}
