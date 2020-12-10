using System;
using System.Collections.Generic;
using System.Text;

namespace KombniyApp.Core.Services
{
	public interface IStylingManage
	{

		Task<IEnumerable<StylingManage>> GetAllStylingManage();
		Task<StylingManage> GetStylingManageById(int id);
		Task<StylingManage> CreateStylingManage(StylingManage newStylingManage);
		Task UpdateStylingManage(StylingManage StylingManageToBeUpdated, StylingManage  stylingManage);
		Task DeleteStylingManage(StylingManage stylingManage);
	}
}
