using System;
using System.Collections.Generic;
using System.Text;
using KombniyApp.Core;
using System.Threading.Tasks;
namespace KombniyApp.Core.Services
{
	public interface IUser
	{
		Task<IEnumerable<User>> GetAllUsers();
		Task<User> GetUserById(int id);
		Task<User> CreateUser(User newUser);
		Task UpdateUser(User UserToBeUpdated, User user);
		Task DeleteUser(User user);

	}
}
