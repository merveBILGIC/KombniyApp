using System;
using System.Collections.Generic;
using System.Text;
using KombniyApp.Core;
using System.Threading.Tasks;
using KombniyApp.Core.Models;
using KombniyApp.DTO;
	
namespace KombniyApp.Core.Services
{
	public interface IUser
	{
		Task<IEnumerable<User>> GetAllUsers();
		Task<User> GetUserById(int id);
		Task<User> CreateUser(User newUser);
		Task UpdateUser(User UserToBeUpdated, User user);
		Task DeleteUser(User user);
		Task<User> FindUser();
		Task<PasswordCodeModel> GetPassword(string code);
		UserDTO LoginUser(UserDTO loginUser);
		UserDTO CheckUser(string Username, string Email);
	}
}
