using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KombniyAppAccount.Models;
using KombniyAppAccount.PaymentServices;
using KombniyApp.Core.Models;
using System.Diagnostics;

namespace KombniyAppAccount.Controllers
{
	public class PaymentController : Controller
	{
		private readonly ICardPaymentServices _cardPaymentService;


		public PaymentController(ICardPaymentServices cardPaymentService)
		{
			this._cardPaymentService = cardPaymentService;
		}


		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}


		[HttpPost]
		public IActionResult Index(CardPaymentViewModel viewModel)
		{
			var receiptViewModel = _cardPaymentService.Create(viewModel);

			return RedirectToAction("Receipt", "Home", receiptViewModel);
		}
		[HttpGet]
		public IActionResult Receipt(CardPaymentReceiptViewModel viewModel)
		{
			return View(viewModel);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
