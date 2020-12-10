using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using KombiyApp.Core.Models;
using KombiyApp.Core.Repository;
using System.Linq;
using System.Threading.Tasks;
using KombiyApp.Data;


namespace KombiyApp.Data.Repository
{
	class WardrobeRepository : Repository<Wardrobe>,IWardrobeRepository
	{
		public WardrobeRepository(AppDbContext context):base(context)
		{

		}
		private AppDbContext AppDbContext
		{
			get { return _context as AppDbContext; }

		}
		public async Task<IEnumerable<Wardobe>> GetAllWithUserAsync()
		{
			return await AppDbContext.Wardrobes
				.Include(m => m.User)
				.ToListAsync();
		}

		public async Task<IEnumerable<Wardrobe>> GetAllWithUserAsync()
		{
			return await AppDbContext.Wardrobes
				         .Include(m => m.User)
				         .ToListAsync();
		}
		 
		public async Task<IEnumerable<Wardrobe>> GetAllWithUserByIdAsync(int userid)
		{
			return await AppDbContext.Wardrobes
			.Include(m => m.User)
			.Where(m => m.UserId == userid)
			.ToListAsync();
		}

		public async Task<Wardrobe> GetWithUserByIdAsync(int id)
		{
			return await AppDbContext.Wardrobes
				.Include(m => m.User)
				.SingleOrDefaultAsync(m => m.UserId == id);
		}

	}
}
