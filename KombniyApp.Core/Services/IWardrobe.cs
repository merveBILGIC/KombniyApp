using System;
using System.Collections.Generic;
using System.Text;
using KombniyApp.Core.Models;
using System.Threading.Tasks;

namespace KombniyApp.Core.Services
{
	public interface IWardrobe:IRepository<Wardrobe>
	{

		Task<IEnumerable<User>> GetAllWithUser();
		Task<Wardrobe> GetUserById(int id);
		Task<IEnumerable<Wardrobe>> GetWardrobeByUserId(int userId);
		Task<Wardrobe> CreateWardrobe(Wardrobe newWardrobe);
		Task UpdateWardrobe(Wardrobe wardrobeToBeUpdated, Wardrobe wardrobe);
		Task DeleteWardrobe(Wardrobe wardrobe);
	}
}
