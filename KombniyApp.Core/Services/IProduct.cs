using System;
using System.Collections.Generic;
using System.Text;

namespace KombniyApp.Core.Services
{
	public interface IProduct
	{
		Task<IEnumerable<Product>> GetAllProducts();
		Task<Product> GetProductById(int id);
		Task<Product> CreateProduct(User newProduct);
		Task UpdateProduct(Product ProductToBeUpdated, Product product);
		Task DeleteProduct(Product product);

	}
}
