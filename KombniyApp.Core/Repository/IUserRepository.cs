using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KombniyApp.Core.Models;

namespace KombniyApp.Core.Repository
{
	public interface IUserRepository:IRepository<User>
	{
		Task<IEnumerable<User>> GetAllWithWardrobeAsync();
		Task<User> GetWithWardrobeByIdAsync(int id);
		Task<User> GetWithUserMatesByIdAsync(int id);
		Task<User> GetUser(int id);
		Task<PasswordCodeModel> GetPassword(string code);
		Task<User> FindUser();
		//Task<bool> InsertCode();

	}
}
