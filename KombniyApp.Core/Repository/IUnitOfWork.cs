using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KombniyApp.Core.Repository;

namespace KombniyApp.Core.Repository
{
	public interface IUnitOfWork : IDisposable
	{

		IUserRepository Users { get; }
		IStylinManageRepo stylinManageRepo { get; }
		IImageRepository ımageRepository { get; }


		Task<int> CommitAsync();
	}
}
