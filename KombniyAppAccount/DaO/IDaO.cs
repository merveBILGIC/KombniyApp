using KombniyAppAccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace KombniyAppAccount.UserDaO
{
	interface IDaO<T>
    {
        public Task<Boolean> Insert(Object obj);
        //   public Task<List<T>> Read(int id);
        public Task<Boolean> Modify(Object obj);
        public Task<Boolean> Erase(int id);

        public DataContext GetContext();

    }
}
