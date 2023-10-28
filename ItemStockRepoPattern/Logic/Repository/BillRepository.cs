using ItemStockRepoPattern.Logic.Extension;
using ItemStockRepoPattern.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ItemStockRepoPattern.Logic.Repository
{
	public class BillRepository : IRepository<BillModel>
	{
		public BillModel GetByGuid(Guid guid = default)
		{
			try
			{
				using (SqlConnection _connection = DbHelper.GetConnection())
				{
					DbHelper.Command = new SqlCommand("TB_Bill_GET", _connection);
					DbHelper.Command.CommandType = CommandType.StoredProcedure;

					SqlParameter param = new SqlParameter
					{
						ParameterName = "@guid",
						DbType = DbType.Guid,
						Value = guid
					};
					DbHelper.Command.Parameters.Add(param);
					_connection.Open();
					SqlDataAdapter adapter = new SqlDataAdapter(DbHelper.Command);
					DataTable dt = new DataTable();

					adapter.Fill(dt);


					return dt.ChangeForType(x => new BillModel()
					{
						billGuid = new Guid(x["BillGuid"].ToString()),
						BillCode = Convert.ToInt32(x["Billcode"].ToString()),
						BillDate = Convert.ToDateTime(x["BillDate"].ToString()),
						BillType = Convert.ToBoolean(x["Type"].ToString() == "Buy"),
						Notes = x["Notes"].ToString()
					});
				}
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
				List<BillModel> list = new List<BillModel>();
				using (SqlConnection _connection = DbHelper.GetConnection())
				{
					DbHelper.Command = new SqlCommand("TB_Bill_GET", _connection);
					DbHelper.Command.CommandType = CommandType.StoredProcedure;


					_connection.Open();
					using (var reader = DbHelper.Command.ExecuteReader())
					{
						while (reader.Read())
						{
							list.Add(new BillModel
							{
								billGuid = new Guid(reader["BillGuid"].ToString()),
								BillCode = Convert.ToInt32(reader["Billcode"].ToString()),
								BillDate = Convert.ToDateTime(reader["BillDate"].ToString()),
								Notes = reader["Notes"].ToString(),
								BillType = Convert.ToBoolean(reader["Type"].ToString() == "Buy")

							});
						}
						return list;
					}
				}
			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show($@"{e}");
				throw;
			}

		}

		public bool Save(BillModel item)
		{
			try
			{
				using (var connection = DbHelper.GetConnection())
				{
					DbHelper.Command = new SqlCommand("TB_Bill_Save", connection);
					DbHelper.Command.CommandType = CommandType.StoredProcedure;
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


					DbHelper.Command.Parameters.AddRange(parameters);
					connection.Open();
					DbHelper.Command.ExecuteNonQuery();
					connection.Close();
					return Convert.ToBoolean(parameters
						.FirstOrDefault(x => x.ParameterName == "@return")?.Value);
				}
			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show($@"{e}");
				throw;
			}
		}

		public bool Delete(Guid item)
		{
			try
			{
				using (var connection = DbHelper.GetConnection())
				{
					DbHelper.Command = new SqlCommand("TB_Bill_Delete", connection);
					DbHelper.Command.CommandType = CommandType.StoredProcedure;
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
					DbHelper.Command.Parameters.AddRange(parameters);
					connection.Open();
					DbHelper.Command.ExecuteNonQuery();
					connection.Close();
					return Convert.ToBoolean(parameters
						.FirstOrDefault(x => x.ParameterName == "@return")?.Value);
				}
			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show($@"{e}");
				throw;
			}

		}
	}
}