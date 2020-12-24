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
				.Include(t => t.Product)
				.ToListAsync();
		}

		public Task<Wardrobe> GetWithProductByIdAsync(int id)
		{
			return AppDbContext.Wardrobes
			.Include(m => m.Product)

			.SingleOrDefaultAsync(m => m.ProductId == id);
		}

		public async Task<IEnumerable<Wardrobe>> GetAllWithProductByProductIdAsync(int productid)
		{
			return await AppDbContext.Wardrobes
				.Include(m => m.Product)
				.Where(m => m.ProductId == productid)
				.ToListAsync();
		}

		public async Task<Wardrobe> GetWardrobeByUserId(int userid)
		{
			return await AppDbContext.Wardrobes
				.Include(m => m.WardrobeId)
				.SingleOrDefaultAsync(m => m.WardrobeId == userid);
		}
	}
}
