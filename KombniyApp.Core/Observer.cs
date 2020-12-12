using System;
using System.Collections.Generic;
using System.Text;

namespace KombniyApp.Core
{
	public abstract class Observer
	{
		public abstract void Update(Object obj);
		public abstract void Create(Object obj);
	}
}
