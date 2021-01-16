using System;
using System.Collections.Generic;
using System.Text;
using KombniyApp.Core.Repository;
using KombiyApp.Data.Repository;
using System.Threading.Tasks;

namespace KombiyApp.Data
{
	public class UnitOfWork : IUnitOfWork
	{
		public UnitOfWork(AppDbContext context)
		{
			_context = context;
		}
		private readonly AppDbContext _context;
		
		private UserRepository _userRepository;
		
		private StylingManageRepo _stylingManageRepo;
		private ImageRepo _ımageRepo;

		public IUserRepository Users => _userRepository ?? new UserRepository(_context);
		public IStylinManageRepo stylinManageRepo => _stylingManageRepo ?? new StylingManageRepo(_context);
		public IImageRepository ımageRepository => _ımageRepo ?? new ImageRepo(_context);



		public async Task<int> CommitAsync()
		{
			return await _context.SaveChangesAsync();

		}


		public void Dispose()
		{
			_context.Dispose();
			_userRepository = null;
			_stylingManageRepo = null;


		}

		
	}
}
