using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KombniyApp.Core.Services
{
	public interface IStylingAndEnvironment
	{
		Task<IEnumerable<StlingAndEnvironment>> GetAllWithArtist();
		Task<StlingAndEnvironment> GetMusicById(int id);
		Task<IEnumerable<StlingAndEnvironment>> GetMusicsByArtistId(int productId);
		Task<StlingAndEnvironment> CreateMusic(StlingAndEnvironment newStlingAndEvironment);
		Task UpdateMusic(StlingAndEnvironment stlingAndEnvironmentToBeUpdated, StlingAndEnvironment stlingAndEnvironment);
		Task DeleteMusic(StlingAndEnvironment stlingAndEnvironment);

	}
}
