using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KombniyApp.Core;
using KombniyApp.Core.Repository;
using KombniyApp.Core.Services;
namespace KombniyApp.Services
{
	public class StlingAndEnvironmentSrcs:IStylingAndEnvironment
	{
		private IUnitOfWork _unitOfWork;

		public StlingAndEnvironmentSrcs(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public async Task<IEnumerable<StlingAndEnvironment>>GetAllWithProduct()
		{
			return await _unitOfWork.stlinAndEnvironmentRepo.GetAllWithProductAsync();
		}

		public async Task<IEnumerable<StlingAndEnvironment>>GetStlingAndEnvironmentByProductId(int productId)
		{
			return await _unitOfWork.stlinAndEnvironmentRepo.GetAllWithProductByProductIdAsync(productId);

		}

		public async Task<StlingAndEnvironment>GetStlingAndEnvironmentById(int id)
		{
			return await _unitOfWork.stlinAndEnvironmentRepo.GetByIdAsync(id);

		}

		public async Task<StlingAndEnvironment> CreateStlingAndEnvironment(StlingAndEnvironment newStlingAndEnvironment)
		{
			await _unitOfWork.stlinAndEnvironmentRepo.AddAsync(newStlingAndEnvironment);
			await _unitOfWork.CommitAsync();
			return newStlingAndEnvironment;
		}

		public async Task DeleteStlingAndEnvironment(StlingAndEnvironment stlingAndEnvironment)
		{
			_unitOfWork.stlinAndEnvironmentRepo.Remove(stlingAndEnvironment);
			await _unitOfWork.CommitAsync();
		}

	}
}
