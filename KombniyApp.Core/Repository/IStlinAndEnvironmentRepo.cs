using System;
using System.Collections.Generic;
using System.Text;
using KombniyApp.Core.Models;

namespace KombniyApp.Core.Repository
{
	public interface IStlinAndEnvironmentRepo
	{
		Task<IEnumerable<StlingAndEnvironment>> GetAllWithProductrAsync();
		Task<StlingAndEnvironment> GetWithProductByIdAsync(int id);
		Task<IEnumerable<StlingAndEnvironment>> GetAllWithProductByProductIdAsync(int ProductId);
	}
}
