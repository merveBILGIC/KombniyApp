using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using KombniyApp.Core;
using KombniyApp.Core.Repository;
using System.Threading.Tasks;
using KombniyApp.Core.Services;
using System.Linq;

namespace KombiyApp.Data.Repository
{
	class StlingAndEnvironmentRepository:Repository<StlingAndEnvironment>,IStlinAndEnvironmentRepo
	{
		public StlingAndEnvironmentRepository(AppDbContext context):base(context)
		{
		}

		private AppDbContext AppDbContext
		{
			get { return _context as AppDbContext; }

		}
		public async Task<IEnumerable<StlingAndEnvironment>> GetAllWithProductAsync()
		{
			return await AppDbContext.StlingAndEnviroments
				.Include(m => m.Products)
				.ToListAsync();
		}

		public  Task<StlingAndEnvironment> GetWithProductByIdAsync( int id)
		{
			return AppDbContext.StlingAndEnviroments
						 .Include(m => m.Products)
						 .SingleOrDefaultAsync(m => m.ProductId == id);
		}

		public async Task<IEnumerable<StlingAndEnvironment>> GetAllWithProductByProductIdAsync(int productid)
		{
			return await AppDbContext.StlingAndEnviroments
			.Include(m => m.Products)
			.Where(m => m.ProductId == productid)
			.ToListAsync();
		}

		
	}
}
