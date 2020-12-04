using KombniyAppAccount.Models;
using KombniyAppAccount.UserDaO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KombniyAppAccount.DaO
{
	public class Daoperations
    {
        public DataContext _context = null;

        private static readonly Daoperations instance = null;
        private static readonly object padlock = new object();

		internal static UserDao GetUserDao()
		{
			throw new NotImplementedException();
		}
	}
}
