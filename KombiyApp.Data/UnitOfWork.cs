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
		private ProductRepository _productRepository;
		private UserRepository _userRepository;
		private WardrobeRepository _wardrobeRepository;
		private StlingAndEnvironmentRepository _environmentRepository;
		private StylingManageRepo _stylingManageRepo;

		public IUserRepository Users => _userRepository ?? new UserRepository(_context);
		public IProductRepository Product => _productRepository ?? new ProductRepository(_context);
		public IWardrobeRepository Wardrobes => _wardrobeRepository ?? new WardrobeRepository(_context);
		public IStlinAndEnvironmentRepo stlinAndEnvironmentRepo => _environmentRepository ?? new StlingAndEnvironmentRepository(_context);
		public IStylinManageRepo stylinManageRepo => _stylingManageRepo ?? new StylingManageRepo(_context);

		
		public async Task<int> CommitAsync()
		{
			return await _context.SaveChangesAsync();

		}


		public void Dispose()
		{
			_context.Dispose();
			_userRepository = null;
			_wardrobeRepository = null;
			_productRepository = null;
			_environmentRepository = null;
			_stylingManageRepo = null;


		}

		
	}
}
