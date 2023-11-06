﻿using ItemStockRepoPattern.Logic.Extension;
using ItemStockRepoPattern.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ItemStockRepoPattern.Logic.Repository
{
	public class BillRepository : IRepository<BillModel>
	{
		public BillModel GetByGuid(Guid guid = default)
		{
			try
			{
				var parameters = new[]
				{
					new SqlParameter
					{
						ParameterName = "@guid",
						DbType = DbType.Guid,
						Value = guid
					},
					new SqlParameter
					{
						ParameterName = "@return",
						DbType = DbType.Int32,
						Direction = ParameterDirection.ReturnValue
					}
				};
				return DbHelper.GetDataTable("TB_Bill_GET", parameters).ChangeForType(
					x => new BillModel
					{
						billGuid = new Guid(x["BillGuid"].ToString()),
						BillCode = Convert.ToInt32(x["Billcode"].ToString()),
						BillDate = Convert.ToDateTime(x["BillDate"].ToString()),
						BillType = Convert.ToBoolean(x["Type"].ToString() == "Buy"),
						Notes = x["Notes"].ToString()
					});
			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show($@"{e}");
				throw;
			}

		}

		public IEnumerable<BillModel> GetAll()
		{
			try
			{
				return DbHelper.GetDataTable("TB_Bill_GET").ChangeList
				(reader =>
						new BillModel
						{
							billGuid = new Guid(reader["BillGuid"].ToString()),
							BillCode = Convert.ToInt32(reader["Billcode"].ToString()),
							BillDate = Convert.ToDateTime(reader["BillDate"].ToString()),
							Notes = reader["Notes"].ToString(),
							BillType = Convert.ToBoolean(reader["Type"].ToString() == "Buy")
						});
			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show($@"{e}");
				throw;
			}
		}

		public int Save(BillModel item)
		{
			try
			{
				SqlParameter[] parameters =
				{
					new SqlParameter
					{
						ParameterName = "@guid",
						DbType = DbType.Guid,
						Value = item.billGuid
					},
					new SqlParameter
					{
						ParameterName = "@billcode",
						DbType = DbType.Int32,
						Value = item.BillCode
					},
					new SqlParameter
					{
						ParameterName = "@notes",
						DbType = DbType.String,
						Value = item.Notes
					},
					new SqlParameter
					{
						ParameterName = "@date",
						DbType = DbType.DateTime,
						Value = item.BillDate
					},
					new SqlParameter
					{
						ParameterName = "@Billtype",
						DbType = DbType.Boolean,
						Value = item.BillType
					},

					new SqlParameter
					{
						ParameterName = "@return",
						DbType = DbType.Int32,
						Direction = ParameterDirection.ReturnValue
					}
				};

				return DbHelper.ExecuteData("TB_Bill_Save", parameters);
			}

			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show($@"{e}");
				throw;
			}
		}

		public int Delete(Guid item)
		{
			try
			{
				SqlParameter[] parameters =
				{
					new SqlParameter
					{
						ParameterName = "@guid",
						DbType = DbType.Guid,
						Value = item
					},
					new SqlParameter
					{
						ParameterName = "@return",
						DbType = DbType.Int32,
						Direction = ParameterDirection.ReturnValue
					}
				};
				return DbHelper.ExecuteData("TB_Bill_Delete", parameters);
			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show($@"{e}");
				throw;
			}
		}
	}
}