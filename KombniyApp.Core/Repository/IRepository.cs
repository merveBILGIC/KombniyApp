using System;
using System.Collections.Generic;
using System.Text;

namespace KombniyApp.Core.Repository
{
	public interface IRepository<T> where T : class
	{
		ValueTask<T> GetByIdAsync(int id);
		Task<IEnumerable<T>> GetAllAsync(); // IEnumerable<T> GetAll()

		IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
		Task<TEntitiy> SingleOrDefaultAsync(Expression<Func<TEntitiy, bool>> predicate);

		Task AddAsync(T entity);
		Task AddRangeAsync(IEnumerable<T> entities);

		void Remove(T entity);
		void RemoveRange(IEnumerable<T> entities);






	}
}
