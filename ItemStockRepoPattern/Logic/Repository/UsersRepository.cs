using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ItemStockRepoPattern.Model;

namespace ItemStockRepoPattern.Logic.Repository
{
	public class UsersRepository : IRepository<UsersModel>
	{
		/// <inheritdoc />
		public UsersModel GetByGuid(Guid guid)
		{
			throw new NotImplementedException();
		}

		/// <inheritdoc />
		public IEnumerable<UsersModel> GetAll()
		{
			throw new NotImplementedException();
		}

		/// <inheritdoc />
		public int Save(UsersModel item)
		{
			try
			{
				SqlParameter[] p =
				{
					new SqlParameter
					{
						ParameterName = "@guid", DbType = DbType.Guid,
						Value = item.UserGuid
					},
					new SqlParameter
					{
						ParameterName = "@username",
						DbType = DbType.String,
						Value = item.UserName
					},
					new SqlParameter
					{
						ParameterName = "@password",
						DbType = DbType.String,
						Value = item.Password
					},
					new SqlParameter
					{
						ParameterName = "@return",
						DbType = DbType.Int32,
						Direction = ParameterDirection.ReturnValue
					}
				};

				return DbHelper.ExecuteData("TB_Users_Save", p);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		/// <inheritdoc />
		public int Delete(Guid item)
		{
			throw new NotImplementedException();
		}
	}
}