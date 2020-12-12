﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KombniyApp.Core.Repository
{
	public interface IRepository<T> where T : class
	{
		ValueTask<T> GetByIdAsync(int id);
		Task<IEnumerable<T>> GetAllAsync(); // IEnumerable<T> GetAll()

		IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
		Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);

		Task AddAsync(T entity);
		Task AddRangeAsync(IEnumerable<T> entities);

		void Remove(T entity);
		void RemoveRange(IEnumerable<T> entities);

		




	}
}
