using System;
using System.Collections.Generic;

namespace ItemStockRepoPattern.Logic.Repository
{
	public interface IRepository<T> where T : class
	{
		T GetByGuid(Guid guid);
		IEnumerable<T> GetAll();
		int Save(T item);
		int Delete(Guid item);
	}
}