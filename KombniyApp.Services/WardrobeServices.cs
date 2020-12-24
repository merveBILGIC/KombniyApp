 using System;
using System.Collections.Generic;
using System.Text;
using KombniyApp.Core.Repository;
using KombniyApp.Core;
using System.Threading.Tasks;
using KombniyApp.Core.Services;

namespace KombniyApp.Services
{
	public class WardrobeServices:IWardrobe
	{
		private IUnitOfWork _unitOfWork;

		public WardrobeServices(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		
		public async Task<Wardrobe>CreateWardrobe(Wardrobe newWardrobe)
		{
			await _unitOfWork.Wardrobes.AddAsync(newWardrobe);
			return newWardrobe;
		}

		public async Task DeleteWardrobe(Wardrobe wardrobe)
		{
			_unitOfWork.Wardrobes.Remove(wardrobe);
			await _unitOfWork.CommitAsync();

		}

		public async Task<IEnumerable<User>>GetAllWithUser()
		{
			return await _unitOfWork.Users.GetAllAsync();
		}

		public async Task<Wardrobe>GetWardrobeByUserId( int  userId)
		{
			return await _unitOfWork.Wardrobes.GetWardrobeByUserId(userId);
		}

		public async Task<Wardrobe>GetUserById(int id)
		{
			return await _unitOfWork.Wardrobes.GetByIdAsync(id);
		}


	}
}
