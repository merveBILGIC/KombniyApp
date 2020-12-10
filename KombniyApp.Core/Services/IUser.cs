using System;
using System.Collections.Generic;
using System.Text;
using KombniyApp.Core.Models;
namespace KombniyApp.Core.Services
{
	public interface IUser:IRepository<User>
	{
		Task<IEnumerable<User>> GetAllUsers();
		Task<User> GetUserById(int id);
		Task<User> CreateUser(User newUser);
		Task UpdateUser(User UserToBeUpdated, User user);
		Task DeleteUser(User user);

	}
}
