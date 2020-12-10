using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using KombniyApp.Core;
using KombniyApp.Core.Repository;
using System.Threading.Tasks;
using KombniyApp.Core.Services;

namespace KombiyApp.Data.Repository
{
	class StlingAndEnvironmentRepository:Repository<StlingAndEnvironment>,IStylinAndEnvironment
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

		public async Task<IEnumerable<StlingAndEnvironment>> GetAllWithProductByIdAsync()
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

		
	}
}
