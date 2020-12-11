using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KombniyApp.Core.Repository
{
	public interface IUserRepository:IRepository<User>
	{
		Task<IEnumerable<User>> GetAllWithWardrobeAsync();
		Task<User> GetWithWardrobeByIdAsync(int id);
	}
}
