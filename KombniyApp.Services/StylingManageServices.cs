using System;
using System.Collections.Generic;
using System.Text;
using KombniyApp.Core.Repository;
using KombniyApp.Core.Services;
using System.Threading.Tasks;
using KombniyApp.Core;
 

namespace KombniyApp.Services
{
	public class StylingManageServices:IStylingManage
	{
		private IUnitOfWork _unitOfWork;

		public StylingManageServices(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;

		}

		public async Task<IEnumerable<StylingManage>>GetAllStylingManage()
		{
			return await _unitOfWork.stylinManageRepo.GetAllAsync();

				
		}

		public async Task <StylingManage>GetStylingManageById(int id)
		{
			return await _unitOfWork.stylinManageRepo.GetByIdAsync(id);
		}


		public async Task<StylingManage> CreateStylingManage(StylingManage newStylingManage)
		{
			await _unitOfWork.stylinManageRepo.AddAsync(newStylingManage);
			await _unitOfWork.CommitAsync();
			return newStylingManage;

		}
		public async Task DeleteStylingManage(StylingManage stylingManage)
		{
			_unitOfWork.stylinManageRepo.Remove(stylingManage);
			await _unitOfWork.CommitAsync();
		}
		

	}
}
