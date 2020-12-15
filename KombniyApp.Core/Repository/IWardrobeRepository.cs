using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KombniyApp.Core.Repository
{
	public interface IWardrobeRepository:IRepository<Wardrobe>
	{
		Task<Wardrobe> GetWardrobeByUserId(int userid);
		Task<IEnumerable<Wardrobe>> GetAllWithProductAsync();
		Task<Wardrobe> GetWithProductByIdAsync(int id);
		Task<IEnumerable<Wardrobe>> GetAllWithProductByProductIdAsync(int productId);
	}
}
