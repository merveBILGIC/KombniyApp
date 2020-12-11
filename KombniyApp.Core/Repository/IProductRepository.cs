using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KombniyApp.Core;

namespace KombniyApp.Core.Repository
{
	public interface IProductRepository:IRepository<Product>
	{
		Task<IEnumerable<Product>> GetAllWithWardrobeAsync();
		Task<IEnumerable<Product>> GetAllWithStlingAndEnvironmentAsync();
		Task<Product> GetWithWardrobeByIdAsync(int id);
		Task<Product> GetWithStlingAndEnvironmentByIdAsync(int id);
		Task<IEnumerable<Product>> GetAllWithWardrobeByWardrobeIdAsync(int wardrobeId);
		Task<IEnumerable<Product>> GetAllWithStlingAndEnvironmentByStlingAndEnvironmenIdAsync(int stlingAndEnvironmenId);
	}
}
