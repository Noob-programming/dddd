using System;
using System.Collections.Generic;

namespace ItemStockRepoPattern.Logic.Repository
{
	public class MainRepository<T> : IRepository<T> where T : class
	{
		/// <inheritdoc />
		public T GetByGuid(Guid guid)
		{
			throw new NotImplementedException();
		}

		/// <param name="itemGuid"></param>
		/// <inheritdoc />
		public IEnumerable<T> GetAll(Guid itemGuid)
		{
			throw new NotImplementedException();
		}

		/// <inheritdoc />
		public bool Save(T item)
		{
			throw new NotImplementedException();
		}

		/// <inheritdoc />
		public bool Delete(Guid item)
		{
			throw new NotImplementedException();
		}

		/// <inheritdoc />
		public bool Delete(T item)
		{
			throw new NotImplementedException();
		}
	}
}