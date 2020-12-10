using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KombniyApp.Core;

namespace KombniyApp.Core.Repository
{
	public interface IProductRepository:IRepository<Product>
	{
		Task<IEnumerable<Product>> GetAllProducts();
		Task<Product> GetProductById(int id);
		Task<Product> CreateProduct(User newProduct);
		Task UpdateProduct(Product ProductToBeUpdated, Product product);
		Task DeleteProduct(Product product);
	}
}
