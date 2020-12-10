using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KombniyApp.Core.Repository
{
	public interface IWardrobeRepository:IRepository<Wardrobe>
	{
		Task<IEnumerable<Wardrobe>> GetAllWithUserAsync();
		Task<Wardrobe> GetWithUserByIdAsync(int id);
		Task<IEnumerable<Wardrobe>> GetAllWithUserByUserIdAsync(int userId);
	}
}
