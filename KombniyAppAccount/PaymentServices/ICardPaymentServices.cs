using KombniyAppAccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace KombniyAppAccount.PaymentServices
{
	public interface ICardPaymentServices
	{
		CardPaymentReceiptViewModel Create(CardPaymentViewModel viewModel);
	}
}
