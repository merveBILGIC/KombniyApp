using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KombniyApp.Core.Services
{
	public interface IStylingManage
	{

		Task<IEnumerable<StylingManage>> GetAllStylingManage();
		Task<StylingManage> GetStylingManageById(int id);
		Task<StylingManage> CreateStylingManage(StylingManage newStylingManage);
		Task DeleteStylingManage(StylingManage stylingManage);
	}
}
