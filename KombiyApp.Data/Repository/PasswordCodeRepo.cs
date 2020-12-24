using System;
using System.Collections.Generic;
using System.Text;
using KombniyApp.Core.Models;
using KombniyApp.Core.Repository;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace KombiyApp.Data.Repository
{
	public class PasswordCodeRepo:Repository<PasswordCodeModel>
	{
		public PasswordCodeRepo(AppDbContext context): base(context)
		{

		}

		private AppDbContext AppDbContext
		{
			get { return _context as AppDbContext; }
		}

		

		public new void Remove(PasswordCodeModel Code )
		{
		}




	}
}
