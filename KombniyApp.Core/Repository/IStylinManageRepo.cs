using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KombniyApp.Core.Repository
{
	public interface IStylinManageRepo:IRepository<StylingManage>
	{
		Task<IEnumerable<StylingManage>> GetAllWithUsersAsync();
		Task<StylingManage> GetWithUsersByIdAsync(int id);

		Task<IEnumerable<StylingManage>> GetAllWithGetUsersAsync();
		Task<StylingManage> GetWithGetUsersByIdAsync(int id);

		Task<IEnumerable<StylingManage>> GetAllWithGiveUsersAsync();
		Task<StylingManage> GetWithGiveUsersByIdAsync(int id);

	}
}
