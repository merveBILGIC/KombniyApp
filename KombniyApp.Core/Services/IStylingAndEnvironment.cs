using System;
using System.Collections.Generic;
using System.Text;

namespace KombniyApp.Core.Services
{
	interface IStylingAndEnvironment
	{
		Task<IEnumerable<StlingAndEnvironment>> GetAllStlingAmdEnvironment();
		Task<StlingAndEnvironment> GetStlingAndEnvironmentById(int id);
		Task<StlingAndEnvironment> CreateStlingAndEnvironment(StlingAndEnvironment newStlingAndEnvironment);
		Task UpdateStlingAndEnvironment(StlingAndEnvironment StlingAndEnvironmentToBeUpdated, StlingAndEnvironment stlingAndEnvironment);
		Task DeleteStlingAndEnvironment(StlingAndEnvironment stlingAndEnvironment);

	}
}
