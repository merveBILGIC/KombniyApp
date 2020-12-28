using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using AutoMapper.Configuration;
using System.Reflection;
using System.Linq;

namespace KombinyAPP.MapConfig.ConfigProfile
{
	public class MapperFactory
	{
		private static readonly object locker = new object();
		private static IMapper _mapper;
		public static IMapper CurrentMapper
		{
			get 
			{
				lock (locker)
				{
					if(_mapper == null)
					{
						throw new Exception("Mapper not initialize");
							
					}
					return _mapper;
				}
			}
			set 
			{
				_mapper = value;


			}
		}
		public static void RegisterMapper()
		{
			_mapper = null;

			var profileTypes = Assembly.GetCallingAssembly().ExportedTypes.Where(z => z.BaseType == typeof(ProfileBase));
			MapperConfigurationExpression exp = new MapperConfigurationExpression();
			foreach (var profileType in profileTypes)
			{
				exp.AddProfile(profileType);
			}


			MapperConfiguration config = new MapperConfiguration(exp);
			_mapper = config.CreateMapper();
		}







	}
}
