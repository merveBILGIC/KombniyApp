using System;
using System.Collections.Generic;
using System.Text;
using KombniyApp.Core;
using System.Threading.Tasks;

namespace KombniyApp.Core.Services
{
	public interface IWardrobe
	{

		Task<IEnumerable<User>> GetAllWithUser();
		Task<Wardrobe> GetUserById(int id);
		Task<Wardrobe> GetWardrobeByUserId(int userId);
		Task<Wardrobe> CreateWardrobe(Wardrobe newWardrobe);
		Task DeleteWardrobe(Wardrobe wardrobe);
	}
}
