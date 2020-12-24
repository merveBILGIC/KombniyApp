using System;
using System.Collections.Generic;
using System.Text;
using KombniyApp.Core;
using System.Threading.Tasks;

namespace KombniyApp.Core.Repository
{
	public interface IStlinAndEnvironmentRepo : IRepository<StlingAndEnvironment>
	{

		Task<IEnumerable<StlingAndEnvironment>> GetAllWithProductAsync();
		Task<StlingAndEnvironment> GetWithProductByIdAsync(int id);
		Task<IEnumerable<StlingAndEnvironment>> GetAllWithProductByProductIdAsync(int ProductId);
	}
}
