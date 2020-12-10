using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KombniyApp.Core.Repository;

namespace KombiyApp.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Repository(DbContext context)
        {
            _context = context;
        }

        protected readonly DbContext _context;


        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity); //context.Artists.Add(entity)
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _context.Set<T>().AddRangeAsync(entities);

        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public ValueTask<T> GetByIdAsync(int id)
        {
            return _context.Set<T>().FindAsync(id);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);

            /*
            foreach (var item in entities)
            {
                _context.Set<T>().Remove(item);
            }

            foreach (var item in entities)
            {
                Remove(item);
            }
            */
        }

        public Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().SingleOrDefaultAsync(predicate);
        }
    }
}