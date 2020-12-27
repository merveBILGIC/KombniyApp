using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KombniyApp.Core;
using FluentValidation;
using FluentValidation.Validators;
using FluentValidation.AspNetCore;

namespace KombniyAppAccount.Validation
{
	public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {


            RuleFor(x => x.Name).NotNull().WithMessage("İsim Alanı Boş Olamaz").MinimumLength(3);
            RuleFor(x => x.Surname).NotNull().WithMessage("Soyad Alanı Boş Olamaz").MinimumLength(3);
            RuleFor(x => x.Email).NotNull().WithMessage("E-Mail Alanı Boş Olamaz");
            RuleFor(x => x.Email).EmailAddress(EmailValidationMode.AspNetCoreCompatible).WithMessage("E-Mail Formatı Doğru Değil");
            RuleFor(x => x.Username).NotNull().WithMessage("Kullanıcı Adı Alanı Boş Olamaz");
            RuleFor(x => x.Password).NotNull().WithMessage("Şifre Alanı Boş Olamaz");
            RuleFor(x => x.Repassword).NotNull().WithMessage("Şifre Alanı Boş Olamaz");
            RuleFor(x => x.Repassword).Matches(x => x.Password).When(x => !String.IsNullOrEmpty(x.Password)).WithMessage("Şifreniz Eşleşmedi");
            RuleFor(x => x.About).MaximumLength(1000);
                
                

        }
    }
}
