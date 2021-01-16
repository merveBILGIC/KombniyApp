using System;
using System.Collections.Generic;
using System.Text;
using KombinyAPP.MapConfig.ConfigProfile;
using KombniyApp.Core;
using KombniyApp.DTO;
using AutoMapper;

namespace KombinyAPP.MapConfig.ProjectMapping
{
	 public class UserProfile:ProfileBase
	{
		public UserProfile()
		{
			CreateMap<User,UserDTO>().ReverseMap();
		}
	}
}
