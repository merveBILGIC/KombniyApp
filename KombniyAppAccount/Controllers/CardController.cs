using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KombniyAppAccount.Controllers
{
	public partial class CardController : Controller
	{
		public IActionResult SwipeableCard()
		{
			return View();
		}
	}
}
