using System;
using System.Collections.Generic;
using System.Text;
using KombniyApp.Core;
using KombniyApp.Core.Repository;
using KombniyApp.Core.Services;
using System.Threading.Tasks;


namespace KombniyApp.Services
{
	public class ProductServices : IProduct
	{
		private IUnitOfWork _unitOfWork;
		public ProductServices(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;

		}

		public async Task<IEnumerable<Product>> GetAllProducts()
		{
			return await _unitOfWork.Product.GetAllAsync();
		}

		public async Task<Product> GetProductById(int id)
		{
			return await _unitOfWork.Product.GetByIdAsync(id);
        }

		public async Task<Product>CreateProduct(Product newProduct)
		{
			await _unitOfWork.Product.AddAsync(newProduct);
			return newProduct;
		}

		public async Task UpdateProduct(Product productToBeUpdated, Product product)
		{
			//productToBeUpdated.ImageFile = product.ImageFile;
			productToBeUpdated.ImageSrc = product.ImageSrc;

		}

		public async Task DeleteProduct(Product product)
		{
			_unitOfWork.Product.Remove(product);
			await _unitOfWork.CommitAsync();
		}

	}
}
