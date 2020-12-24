using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KombniyAppAccount.Observer
{
	public abstract class Observer
	{
		public abstract void Update(Object obj);
		public abstract void Create(Object obj);
	}
}
