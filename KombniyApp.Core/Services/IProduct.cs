using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KombniyApp.Core.Services
{
	public interface IProduct//fotorof yolu olarak tasarlıycaz foto 
	{

		Task<IEnumerable<Product>> GetAllProducts();
		Task<Product> GetProductById(int id);
		Task<Product> CreateProduct(Product newProduct);
		Task UpdateProduct(Product ProductToBeUpdated, Product product);
		Task DeleteProduct(Product product);

		

	}
}
