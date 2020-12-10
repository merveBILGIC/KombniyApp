using System;
using System.Collections.Generic;
using System.Text;

namespace KombniyApp.Core.Repository
{
	public interface IWardrobeRepository
	{
		Task<IEnumerable<Wardrobe>> GetAllWithUserAsync();
		Task<Wardrobe> GetWithUserByIdAsync(int id);
		Task<IEnumerable<Wardrobe>> GetAllWithUserByUserIdAsync(int userId);
	}
}
