using System;
using System.Collections.Generic;
using System.Text;
using KombiyApp.Core;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace KombiyApp.Data.Repository
{
	class ProductRepository: Repository<Prodact>,IProductRepository
	{
		public ProductRepository(AppDbContext context):base(context)
		{
        }

		private AppDbContext AppDbContext
		{
			get { return _context as AppDbContext; }

		}
		public async Task<IEnumerable<Product>> GetAllWithWardrobeAsync()
		{
			return await AppDbContext.Products
				.Include(x => x.Wardrobe)
				.ToListAsync();
	
		}

		public async Task<IEnumerable<Product>>GetAllWithStlingAndEnvireonmetAsync()
		{
			return await AppDbContext.Products
				.Include(x => x.StlingAndEnvironment)
				.ToListAsync();

		}
		public async Task<IEnumerable<Product>> GetAllWithWardrobeByWardrobeIdAsync(int wardrobeid)
		{
			return await AppDbContext.Products
				.Inculude(x => x.Wardrobe)
				.Where(x => x.WardrobeId == wardrobeid)
				.ToListAsync();
		}
		public async Task<IEnumerable<Product>> GetAllWithWardrobeByStlingAndEnvironmentIdAsync(int stlingAndEnvironmentid)
		{
			return await AppDbContext.Products
				.Inculude(x => x.StlingAndEnvironment)
				.Where(x => x.StlingAndEnvironmentId == stlingAndEnvironmentid)
				.ToListAsync();
		}

		public async Task<Product> GetWithWardrobeByIdAsync(int wardrobeid)
		{
			return await AppDbContext.Products
										.Include(x=>x.Wardrobe)
										.SingleOrDefaultAsync(x => x.WardrobeId == wardrobeid);
		}
		public async Task<Product> GetWithStlingAndEnvironmentByIdAsync(int stlingAndEnvironmentid)
		{
			return await AppDbContext.Products
										.Include(x => x.StlingAndEnvironment)
										.SingleOrDefaultAsync(x => x.StlingAndEnvironmentId == stlingAndEnvironmentid);
		}

	}
}
