using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using KombniyApp.Core.Models;
using KombniyApp.Core;
using Microsoft.AspNetCore.Http;
using KombniyApp.Core.Manage;
using KombniyApp.Core.Repository;
using KombniyApp.Core.Services;





namespace KombniyAppAccount.Controllers
{
	public class AccountController : Controller
    {
	    
		private string code = null;
		private readonly IUser _Iuser;
		

		public AccountController(IUser user)
		{
			_Iuser = user;

		}

		

		public IActionResult Index()
		{
			if (HttpContext.Session.GetInt32("id").HasValue)
			{
				return Redirect("/Account/Index");
			}

			if (HttpContext.Session.GetInt32("error") == null)
			{
				HttpContext.Session.SetInt32("error", 0);
			}
			return View();
		}
		public async Task<IActionResult> ChangePassword(string current, string pass)
		{
			int uid = HttpContext.Session.GetInt32("id").Value;
			if (uid != 0 && current != null && pass != null)
			{
				var user = await _Iuser.GetUserById(uid);

				if (current.Equals(user.Password))
				{
					user.Password = pass;
					//await _Iuser.UpdateUser(userToBeUpdate,user.Password );
						
				}

			}
			return Redirect("Index");
		}
		public IActionResult ForgotPassword()
		{
			if (HttpContext.Session.GetInt32("id").HasValue)
			{
				return Redirect("Index");
			}
			HttpContext.Session.SetInt32("error", 0);
			return View();
		}
		/*
		public IActionResult Friends()
		{
			return View(getDao().FriendList((int)HttpContext.Session.GetInt32("id")));
		}
		public IActionResult FriendsList()
		{
			return Json(getDao().FriendList((int)HttpContext.Session.GetInt32("id")));
		}
		*/
		[HttpPost]
		public async Task<IActionResult> Login(User model)
		{
			User user = await _Iuser.FindUser();
			if (user != null)
			{
				HttpContext.Session.SetInt32("id", user.UserId);
				HttpContext.Session.SetString("name", user.Name);
				HttpContext.Session.SetString("surname", user.Surname);
				HttpContext.Session.SetString("username", user.Username);
				HttpContext.Session.SetInt32("error", 0);
				return Redirect("/Account/Index");
			}
			HttpContext.Session.SetInt32("error", 1);
			return RedirectToAction(nameof(Index));
		}


		[HttpPost]
		public IActionResult LogOut()
		{
			HttpContext.Session.Clear();
			return Redirect("Index");
		}


		

		public async Task<IActionResult> Profile()
		{
			int? id = HttpContext.Session.GetInt32("id");
			if (!id.HasValue)
			{
				return Redirect("Index");
			}

			return View(await _Iuser.GetUserById(id.Value));
				
		}
		[HttpPost]
		public async Task<IActionResult> Register(User user)
		{
			User newUser = user;
			await _Iuser.CreateUser(newUser);
			
			return Json(true);
		}
		/*public async Task<IActionResult> Remove(int Id)
		{
			int? uid = HttpContext.Session.GetInt32("id");
			await getDao().RemoveFriend(uid.Value, Id);
			return Redirect("Friends");
		}
		
		public async Task<IActionResult> SendACode(string email)
		{
			User tmp = await _Iuser.Find(email);

			if (tmp != null)
			{
				await MailManage.ResetPasswordCode(email, getCode());
				await getDao().InserCode(new PasswordCodeModel { UserId = tmp.UserId, Code = getCode() });
			}
			else
			{
				return Json(false);
			}
			return Redirect("ResetPassword");
		}*/

		public IActionResult Settings()
		{
			if (!HttpContext.Session.GetInt32("id").HasValue)
			{
				return Redirect("NotFound");
			}
			return View();
		}
		public IActionResult SignUp()
		{
			if (HttpContext.Session.GetInt32("id").HasValue)
			{
				return Redirect("/Account/Index");
			}
			return View();
		}

		/*[HttpPost]
		public async Task<IActionResult> UpdateProfile(User usr)
		{
			await getDao().Modify(usr);
			return Json(true);
		}

		public async Task<IActionResult> UpdatePassword(string code, string Password)
		{

			PasswordCodeModel psd = await _Iuser.GetPassword(code);
			User userToBeUpdate;
				
			if (psd != null)
			{
				User user = await _Iuser.GetUserById(psd.PaswordId);
					
				user.Password = Password;

				await _Iuser.UpdateUser(userToBeUpdate.Password, user.Password);
					
				await _Iuser.(psd);
			}

			return RedirectToAction(nameof(Index));
		}
		*/


		public string getCode()
		{
			if (code == null)
			{
				Random random = new Random();
				code = "";
				for (int i = 0; i < 6; i++)
				{
					char tmp = Convert.ToChar(random.Next(48, 58));
					code += tmp;
				}
			}

			return code;
		}

	}
}
