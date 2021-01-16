using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace KombinyAPP.MapConfig.ConfigProfile
{
	public class MapperConfig
	{
		public static void RegisterMapper()
		{
			MapperFactory.RegisterMapper();
		}
	}
	
}
