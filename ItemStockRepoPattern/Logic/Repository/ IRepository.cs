using System;
using System.Collections.Generic;

namespace ItemStockRepoPattern.Logic.Repository
{
	public interface IRepository<T>
	{
		T GetByGuid(Guid guid);
		IEnumerable<T> GetAll();

		bool Save(T item);
		void Delete(T item);

	}
}