using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Validators;
using KombniyAppAccount.Models;

namespace KombniyAppAccount.Validation
{
	public class UserLoginValidator:AbstractValidator<UserLoginViewModels>
	{
		public UserLoginValidator()
		{
			RuleFor(x => x.Email).EmailAddress(EmailValidationMode.AspNetCoreCompatible).NotNull().WithMessage("E-Mail Alanı Boş Olamaz");
			RuleFor(x => x.Password).NotNull().WithMessage("Şifre Alanı Boş Olamaz");  
		}
	}
}
