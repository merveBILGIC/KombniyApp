using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KombniyAppAccount.Models;
using KombniyAppAccount.Observer;


namespace KombniyAppAccount.UserDaO
{

    public class UserDao :IDao<User>
    {

        public static UserDao instance = null;
        public User user = null;
        public UserObserver observer = null;

		public UserDao()
		{
		}

		public async Task<bool> Create(object obj)
        {
            User user = (User)obj;
            await GetContext().AddAsync(user);
            await GetContext().SaveChangesAsync();
            getObserver().Create(user);
            return true;
        }

		private object getContext()
		{
			throw new NotImplementedException();
		}

		public async Task<User> Find(User model)
        {
            User user = await GetContext().User.FirstOrDefaultAsync(w => (w.Email == model.Email || w.Username == model.Email)
                        && w.Password == model.Password);
            return user;
        }

        public List<User> FriendList(int id)
        {
            List<User> flist = new List<User>();
            List<UserMates> userMates = GetContext().UserMates.Where(w => w.UserId == id).ToList();
            foreach (var item in userMates)
            {
                var tmp = GetContext().User.FirstOrDefault(w => w.Id == item.MateId);
                flist.Add(tmp);
            }
            return flist;
        }

        public static UserDao getInstance()
        {
            return instance == null ? instance = new UserDao() : instance;
        }

        public async Task<bool> Insert(object obj)
        {
            User user = (User)obj;
            await GetContext().AddAsync(user);
            await GetContext().SaveChangesAsync();
            return true;
        }

        public Task<List<User>> Read(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Modify(object obj)
        {
            User tmp = (User)obj;
            var user = GetContext().User.First(w => w.Id == tmp.Id);
            GetContext().Entry(user).CurrentValues.SetValues(tmp);
            await GetContext().SaveChangesAsync();
            getObserver().Update(tmp);
            return true;
        }

        public async Task<bool> Erase(int id)
        {
            var user = await GetContext().User.FindAsync(id);
            GetContext().Remove(user);
            await GetContext().SaveChangesAsync();
            return true;
        }

        public async Task<bool> RemoveFriend(int uid, int mid)
        {
            UserMates usm1 = await GetContext().UserMates.FirstOrDefaultAsync(w => w.UserId == uid && w.MateId == mid);
            UserMates usm2 = await GetContext().UserMates.FirstOrDefaultAsync(w => w.UserId == mid && w.MateId == uid);

            GetContext().Remove(usm1);
            GetContext().Remove(usm2);
            await GetContext().SaveChangesAsync();
            return true;
        }

        public async Task<User> GetUser(int id)
        {
            return await GetContext().User.FindAsync(id);
        }

        public async Task<User> Find(string email)
        {
            return await GetContext().User.FirstOrDefaultAsync(w => w.Email == email);
        }

        public async Task<bool> InserCode(PasswordCode passwordCode)
        {
            await GetContext().AddAsync(passwordCode);
            await GetContext().SaveChangesAsync();
            return true;
        }

        public async Task<PasswordCode> getPasswordCode(string code)
        {
            return await GetContext().PasswordCode.FirstOrDefaultAsync(w => w.Code.Equals(code));
        }

        public async Task<bool> RemoveCode(PasswordCode psd)
        {
            GetContext().Remove(psd);
            await GetContext().SaveChangesAsync();
            return true;
        }

        public DataContext GetContext()
        {
            return DataContext.getContext();
        }

        public UserObserver getObserver()
        {
            if (observer == null)
            {
                observer = new UserObserver();
            }
            return observer;
        }
    }
}
