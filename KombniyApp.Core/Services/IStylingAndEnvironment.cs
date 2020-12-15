using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KombniyApp.Core.Services
{
	public interface IStylingAndEnvironment
	{
		Task<IEnumerable<StlingAndEnvironment>> GetAllWithProduct();
		Task<StlingAndEnvironment> GetStlingAndEnvironmentById(int id);
		Task<IEnumerable<StlingAndEnvironment>> GetStlingAndEnvironmentByProductId(int productId);
		Task<StlingAndEnvironment> CreateStlingAndEnvironment(StlingAndEnvironment newStlingAndEvironment);
		Task DeleteStlingAndEnvironment(StlingAndEnvironment stlingAndEnvironment);

	}
}
