using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KombniyApp.Core.Repository;
using Microsoft.EntityFrameworkCore;
using KombniyApp.Core;
using KombniyApp.Core.Models;


namespace KombiyApp.Data.Repository
{
	class UserRepository : Repository<User>, IUserRepository
	{
		public static UserRepository instance = null;
		public User User = null;
		public Observer observer = null;

		

		public UserRepository(AppDbContext context) : base(context)
		{

		}
		private AppDbContext AppDbContext
		{
			get { return _context as AppDbContext; }
		}
		public Task<User>GetUser(int id)
		{
			return AppDbContext.Users
				.Include(a => a.UserId)
				.SingleAsync(a => a.UserId == id);
		}
		public async Task<IEnumerable<User>> GetAllWithWardrobeAsync()
		{
			return await AppDbContext.Users
				.Include(a => a.Wardrobe)
				.ToListAsync();
		}

		public  Task<User> GetWithWardrobeByIdAsync(int id)
		{
			return  AppDbContext.Users
				.Include(a => a.Wardrobe)
				.SingleOrDefaultAsync(a => a.UserId == id);
		}
		
	    public Task<User> GetWithUserMatesByIdAsync(int id)
		{

			return AppDbContext.Users
				.Include(a => a.mates)
				.SingleOrDefaultAsync(a => a.MatesId == id);



			/*List<User> flist = new List<User>();
			List<UserMates> userMates = GetContext().UserMates.Where(w => w.UserId == id).ToList();
			foreach (var item in userMates)
			{
				var tmp = GetContext().User.FirstOrDefault(w => w.Id == item.MateId);
				flist.Add(tmp);
			}
			return flist;
			*/
		}
		public Task<User>Find(string email)
		{
			return AppDbContext.Users
				.Include(w => w.Email)
			.SingleOrDefaultAsync(w => w.Email == email);
		}
		
		public Task<PasswordCodeModel>GetPassword(string code)
		{
			return AppDbContext.Passwords
				.Include(w => w.Code)
				.SingleOrDefaultAsync(w => w.Code == code);
		}
		
		public async Task<User>FindUser()
		{
			return  AppDbContext.Users
				.Find(User);
		
		}


	}
}
