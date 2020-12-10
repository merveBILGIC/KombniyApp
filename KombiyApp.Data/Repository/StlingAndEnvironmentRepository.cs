using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using KombniyApp.Core.Models;
using KombniyApp.Core.Repository;
using System.Threading.Tasks;
namespace KombiyApp.Data.Repository
{
	class StlingAndEnvironmentRepository:Repository<StlingAndEnvironmentRepository>,IStlinAndEnvironmentRepo
	{
		public StlingAndEnvironmentRepository(AppDbContext context):base(context)
		{
		}

		private AppDbContext AppDbContext
		{
			get { return _context as AppDbContext; }

		}
		public async Task<IEnumerable<StlingAndEnviroment>> GetAllWithProductAsync()
		{
			return await AppDbContext.StlingAndEnviroments
				.Include(m => m.Products)
				.ToListAsync();
		}

		public async Task<IEnumerable<StlingAndEnvironment>> GetAllWithProductAsync()
		{
			return await AppDbContext.StlingAndEnviroments
						 .Include(m => m.Products)
						 .ToListAsync();
		}

		public async Task<IEnumerable<StlingAndEnvironment>> GetAllWithProductByIdAsync(int productid)
		{
			return await AppDbContext.StlingAndEnviroments
			.Include(m => m.Products)
			.Where(m => m.ProductId == productrid)
			.ToListAsync();
		}

		public async Task<StlingAndEnvironmen> GetWithProductByIdAsync(int id)
		{
			return await AppDbContext.StlingAndEnviroments
				.Include(m => m.Product)
				.SingleOrDefaultAsync(m => m.ProductId == id);
		}

	}
}
