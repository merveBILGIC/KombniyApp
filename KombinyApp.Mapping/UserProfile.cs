using System;
using KombniyApp.Core;
using KombniyApp.DTO;
using AutoMapper;
using KombinyAPP.MapConfig.ConfigProfile;
using AutoMapper;

namespace KombinyApp.Mapping
{
	public class UserProfile: ProfileBase
	{
		public UserProfile()
		{
			CreateMap<User, UserDTO>().ReverseMap();
		}

	}
}
