using ItemStockRepoPattern.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ItemStockRepoPattern.Logic.Repository
{
	public class ItemRepository : IRepository<ItemModel>
	{
		/// <inheritdoc />

		private SqlCommand _command;


		private SqlConnection _connection;

		private static SqlConnection Connection()
		{

			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
			{
				DataSource = @"DESKTOP-LPLR64V\NEWSQL",
				InitialCatalog = "Bills",
				IntegratedSecurity = true,
			};

			return new SqlConnection(builder.ConnectionString);
		}

		public ItemModel GetByGuid(Guid guid)
		{
			throw new NotImplementedException();
		}

		/// <inheritdoc />
		public IEnumerable<ItemModel> GetAll()
		{
			throw new NotImplementedException();
		}

		/// <inheritdoc />
		public bool Save(ItemModel item)
		{
			try
			{
				using (_connection = Connection())
				{
					_command = new SqlCommand("TB_Item_OnlySave", _connection);
					_command.CommandType = CommandType.StoredProcedure;
					SqlParameter[] parameters =
					{
						new SqlParameter
						{
							ParameterName = "@ItemGuid",
							DbType = DbType.Guid,
							Value = item.itemGuid
						},
						new SqlParameter
						{
							ParameterName = "@ItemCode",
							DbType = DbType.Int32,
							Value = item.itemCode
						},
						new SqlParameter
						{
							ParameterName = "@ItemName",
							DbType = DbType.String,
							Value = item.itemName
						},
						new SqlParameter
						{
							ParameterName = "@ParentGuid",
							DbType = DbType.Guid,
							Value = item.parentGuid
						},
						new SqlParameter
						{
							ParameterName = "@itemPrice",
							DbType = DbType.Decimal,
							Value = item.itemPrice
						},
						new SqlParameter
						{
							ParameterName = "@itemPriceSingle",
							DbType = DbType.Decimal,
							Value = item.itemPriceSingle
						},
						new SqlParameter
						{
							ParameterName = "@itemPriceMany",
							DbType = DbType.Decimal,
							Value = item.itemPriceMany
						},
						new SqlParameter
						{
							ParameterName = "@IsGroup",
							DbType = DbType.Boolean,
							Value = item.ISgroup
						}
					};
					SqlParameter p = new SqlParameter
					{
						ParameterName = "@return",
						DbType = DbType.Int32,
						Direction = ParameterDirection.ReturnValue
					};
					_connection.Open();
					_command.Parameters.AddRange(parameters);
					_command.Parameters.Add(p);
					_command.ExecuteNonQuery();
					_connection.Close();
					return Convert.ToBoolean(p.Value);
				}
			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show($@"{e}");
				throw;
			}
		}

		/// <inheritdoc />
		public void Delete(ItemModel item)
		{
			throw new NotImplementedException();
		}
	}
}