using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KombniyApp.Core.Repository;
using Microsoft.EntityFrameworkCore;
using KombniyApp.Core;


namespace KombiyApp.Data.Repository
{
	class UserRepository : Repository<User>, IUserRepository
	{
		

		public UserRepository(AppDbContext context) : base(context)
		{

		}
		private AppDbContext AppDbContext
		{
			get { return _context as AppDbContext; }
		}
		public async Task<IEnumerable<User>> GetAllWithWardrobeAsync()
		{
			return await AppDbContext.Users
				.Include(a => a.Wardrobe)
				.ToListAsync();
		}

		public  Task<User> GetWithWardrobeByIdAsync(int id)
		{
			return  AppDbContext.Users
				.Include(a => a.Wardrobe)
				.SingleOrDefaultAsync(a => a.UserId == id);
		}




	}
}
