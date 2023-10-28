using System;
using System.Collections.Generic;

namespace ItemStockRepoPattern.Logic.Repository
{
	public interface IRepository<T> where T : class
	{
		T GetByGuid(Guid guid);
		IEnumerable<T> GetAll(Guid itemGuid);
		bool Save(T item);
		bool Delete(Guid item);

	}
}