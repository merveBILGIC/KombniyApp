using System;
using System.Collections.Generic;
using System.Text;
using KombniyApp.Core;
using KombniyApp.Core.Repository;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KombiyApp.Data.Repository
{
	public class StylingManageRepo : Repository<StylingManage>, IStylinManageRepo
	{
		public StylingManageRepo(AppDbContext context) : base(context)
		{

		}

		private AppDbContext AppDbContext
		{
			get { return _context as AppDbContext; }
		}

		public async Task<IEnumerable<StylingManage>> GetAllWithUsersAsync()
		{
			return await AppDbContext.stylingManagers
				.Include(a => a.StylingGetUserId)
				.ToListAsync();
		}

		public Task<StylingManage> GetWithUsersByIdAsync(int id)
		{
			return AppDbContext.stylingManagers
				.Include(a => a.StylingGetUserId)
				.SingleOrDefaultAsync(a => a.StylingGetUserId == id);
		}
		public async Task<IEnumerable<StylingManage>> GetAllWithGiveUsersAsync()
		{
			return await AppDbContext.stylingManagers
				.Include(a => a.StylingGetUserId)
				.ToListAsync();
		}

		public Task<StylingManage> GetWithGiveUsersByIdAsync(int id)
		{
			return AppDbContext.stylingManagers
				.Include(a => a.StylingGiveUserId)
				.SingleOrDefaultAsync(a => a.StylingGiveUserId == id);
		}

		public async Task<IEnumerable<StylingManage>> GetAllWithGetUsersAsync()
		{
			return await AppDbContext.stylingManagers
				.Include(a => a.StylingGetUserId)
				.ToListAsync();

		}


		public Task<StylingManage> GetWithGetUsersByIdAsync(int id)
		{
			return AppDbContext.stylingManagers
				.Include(a => a.StylingGetUserId)
				.SingleOrDefaultAsync(a => a.StylingGetUserId == id);
		}
	}

}
