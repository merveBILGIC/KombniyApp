using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using KombniyApp.Core;
using KombniyApp.Core.Repository;
using System.Linq;
using System.Threading.Tasks;



namespace KombiyApp.Data.Repository
{
	class WardrobeRepository : Repository<Wardrobe>, IWardrobeRepository
	{
		public WardrobeRepository(AppDbContext context) : base(context)
		{

		}
		private AppDbContext AppDbContext
		{
			get { return _context as AppDbContext; }

		}
		public async Task<IEnumerable<Wardrobe>> GetAllWithProductAsync()
		{
			return await AppDbContext.Wardrobes
				.Include(t => t.products)
				.ToListAsync();
		}

		public Task<Wardrobe> GetWithProductByIdAsync(int id)
		{
			return AppDbContext.Wardrobes
			.Include(m => m.products)
			.SingleOrDefaultAsync(m => m.ProductId == id);
		}

		public async Task<IEnumerable<Wardrobe>> GetAllWithProductByProductIdAsync(int productid)
		{
			return await AppDbContext.Wardrobes
				.Include(m => m.products)
				.Where(m => m.ProductId == productid)
				.ToListAsync();
		}

	}
}
