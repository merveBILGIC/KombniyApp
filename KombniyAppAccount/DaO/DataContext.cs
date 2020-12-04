using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.AspNetCore.Http;
using KombniyAppAccount.Models.UsersModel;

namespace KombniyAppAccount.Models
{
	public class DataContext: DbContext
	{
		private static DataContext _context = null;
		private static readonly object padlock = new object();
		private DataContext()
		{

		}

		public DataContext(DbContextOptions<DataContext> options) : base (options) { }
		
		
		public DbSet<User> User { get; set; }
		public DbSet<UserMates> UserMates { get; set; }
		public DbSet<Mail> Mail { get; set; }
		public DbSet<PasswordCode> PasswordCode { get; set; }


		public static DataContext getContext()
		{
			if (_context == null)
			{
				lock (padlock)
				{
					if (_context == null)
					{
						_context = new DataContext();
					}
				}
			}
			return _context;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=KombniyApp");
			}
		} 
	}
}
