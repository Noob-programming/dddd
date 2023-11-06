﻿using ItemStockRepoPattern.Logic.Extension;
using ItemStockRepoPattern.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ItemStockRepoPattern.Logic.Repository
{
	public class ShoppingRepository : IRepository<StoppingCartModel>
	{
		public StoppingCartModel GetByGuid(Guid guid)
		{
			SqlParameter[] param =
			{
				new SqlParameter
				{
					ParameterName = "@guid",
					DbType = DbType.Guid,
					Value = guid
				}
			};

			return DbHelper.GetDataTable("TB_ShoppingCart_Get", param)
				.ChangeForType(x => new StoppingCartModel
				{
					SalesOrderId = new Guid(x["SalesOrderGuid"].ToString()),
					StoppingOrderId = Convert.ToInt32(x["ShoppingID"].ToString()),

					ItemGuid = new Guid(x["ItemGuid"].ToString()),
					BillGuid = new Guid(x["BillGuid"].ToString()),
					Quantity = Convert.ToDecimal(x["Quantity"].ToString()),
					Prices = Convert.ToDecimal(x["Price"].ToString()),
					Total = Convert.ToDecimal(x["Total"].ToString())

				});
		}

		/// <inheritdoc />
		public IEnumerable<StoppingCartModel> GetAll()
		{

			try
			{
				return DbHelper.GetDataTable("TB_ShoppingCart_Get")
					  .ChangeList(x => new StoppingCartModel
					  {
						  SalesOrderId = new Guid(x["SalesOrderGuid"].ToString()),
						  StoppingOrderId = Convert.ToInt32(x["ShoppingID"].ToString()),
						  ItemGuid = new Guid(x["ItemGuid"].ToString()),
						  BillGuid = new Guid(x["BillGuid"].ToString()),
						  Quantity = Convert.ToDecimal(x["Quantity"].ToString()),
						  Prices = Convert.ToDecimal(x["Price"].ToString()),
						  Total = Convert.ToDecimal(x["Total"].ToString())

					  });
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}


		}

		public int Save(StoppingCartModel item)
		{
			try
			{
				var p = new[]
				{
					new SqlParameter
					{
						ParameterName = "@SalesOrderGuid",
						DbType = DbType.Guid,
						Value = item.SalesOrderId
					},
					new SqlParameter
					{
						ParameterName = "@ItemGuid",
						DbType = DbType.Guid,
						Value = item.ItemGuid
					},
					new SqlParameter
					{
						ParameterName = "@BillGuid",
						DbType = DbType.Guid,
						Value = item.BillGuid
					},
					new SqlParameter
					{
						ParameterName ="@Price",
						DbType = DbType.Decimal,
						Value = item.Quantity
					},
					new SqlParameter
					{
						ParameterName = "@Quantity",
						DbType = DbType.Decimal,
						Value = item.Quantity
					},
					new SqlParameter
					{
						ParameterName = "@return",
						DbType = DbType.Int32,
						Direction = ParameterDirection.ReturnValue
					}
				};


				return DbHelper.ExecuteData("TB_ShoppingCart_Save", p);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}


		public int Delete(Guid item)
		{
			try
			{
				SqlParameter[] p =
				{
					new SqlParameter
					{
						ParameterName = "@guid",
						DbType = DbType.Guid,
						Value = item
					},new SqlParameter
					{
						ParameterName = "@return",
						DbType = DbType.Int32,
						Direction = ParameterDirection.ReturnValue
					}
				};

				return DbHelper.ExecuteData("TB_ShoppingCart_Delete", p);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
	}
}