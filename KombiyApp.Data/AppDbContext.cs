using KombniyApp.Core;
using KombniyApp.Core.Models;
using Microsoft.EntityFrameworkCore;
namespace KombiyApp.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
		{

		}

		public DbSet<User> Users { get; set; }
		public DbSet<Wardrobe> Wardrobes{ get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<StylingManage> stylingManagers { get; set; }
		public DbSet<StlingAndEnvironment> StlingAndEnviroments { get; set; }
		public DbSet<UserMates> userMates { get; set; }
		public DbSet<PasswordCodeModel> Passwords { get; set; }
		public DbSet<RegisterViewModel> registerViewModels { get; set; }
		public DbSet<MailModel> mailModels { get; set; }
		

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}


			
	}
}
