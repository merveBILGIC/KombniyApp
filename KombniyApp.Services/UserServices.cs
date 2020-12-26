using System;
using KombniyApp.Core;
using KombniyApp.Core.Repository;
using KombniyApp.Core.Services;
using System.Threading.Tasks;
using System.Collections.Generic;
using KombniyApp.Core.Models;
using KombniyApp.DTO;

namespace KombniyApp.Services
{
	public class UserServices:IUser
	{
		private readonly IUnitOfWork _unitOfWork;

		public UserServices(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;

		}
		public async Task<User> CreateUser(User newUser)
		{
			await _unitOfWork.Users.AddAsync(newUser);
			await _unitOfWork.CommitAsync();
			return newUser;
		}

		public async Task DeleteUser(User user)
		{

			 _unitOfWork.Users.Remove(user);
			await _unitOfWork.CommitAsync();
		}
		

		public async Task<IEnumerable<User>>GetAllUsers()
		{
			return await _unitOfWork.Users.GetAllAsync();

		}

		public async Task<User>GetUserById(int id)
		{
			return await _unitOfWork.Users.GetByIdAsync(id);
		}

		public async Task UpdateUser(User userToBeUpdate, User user)
		{
			userToBeUpdate.Name = user.Name;
			userToBeUpdate.Username = user.Username;
			userToBeUpdate.Password = user.Password;
			await _unitOfWork.CommitAsync();

		}
		public async Task<User>FindUser()
		{
			
			return await _unitOfWork.Users.FindUser();
		}


		public async Task<PasswordCodeModel>GetPassword(string code)
		{
			return await _unitOfWork.Users.GetPassword(code);
		}

		public UserDTO LoginUser(UserDTO loginUser)
		{
			throw new NotImplementedException();
				
		}
	    public UserDTO CheckUser(string Username,string Email)
		{
			var chechUser = _unitOfWork.Users.Find(z => (z.Email == Email || z.Username == Username));
			//MapperFactory.CurrentMapper.Map<UserDTO>(checkUser);
			throw new NotImplementedException();
		}

	}
}
