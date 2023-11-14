using System;
using System.Data;
using System.Data.SqlClient;
using NewStock.Model;

namespace NewStock.Logic.Services
{
	public static class StockService
	{
		public static DataTable GetData()
		{
			return DbHelper.GetData("TB_Stock_Get",
				() => { });
		}

		private static void parameterstock(StockModel model, SqlCommand command, SqlParameter parameter)
		{
			parameter.ParameterName = "@return";
			parameter.SqlDbType = SqlDbType.Int;

			command.Parameters.Add(parameter);

			command.Parameters.Add("@Guid",
				SqlDbType.UniqueIdentifier).Value = model.itemGuid;
			command.Parameters.Add("@Status",
				SqlDbType.NVarChar).Value = model.status;
			command.Parameters.Add("@Quin",
				SqlDbType.Decimal).Value = model.quintity;
		}

		public static bool SaveStock(StockModel model)
		{
			return DbHelper.ExcuteData("TB_Stock_Save",
				() => parameterstock(model, DbHelper.Command, DbHelper.Parameters));
		}


		public static DataTable FillLookUp(string sql)
		{
			return DbHelper.GetData(sql, () => { });
		}

		private static void pareterdelete(Guid id, SqlCommand command, SqlParameter parameter)
		{
			parameter.ParameterName = "@return";
			parameter.SqlDbType = SqlDbType.Int;

			command.Parameters.Add(parameter);

			command.Parameters.Add("@guid",
				SqlDbType.UniqueIdentifier).Value = id;
		}

		public static bool deleteStock(Guid guid = default)
		{
			return DbHelper.ExcuteData("TB_Stock_Delete",
				() => pareterdelete(guid, DbHelper.Command, DbHelper.Parameters));
		}
	}
}