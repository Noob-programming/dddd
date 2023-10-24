using NewStock.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace NewStock.Logic.Services
{
	public static class BillItemService
	{
		public static DataTable GetData(string sql)
		=> DbHelper.GetData(sql, () => { });


		private static void SetParameter(BillItemModel model,
			SqlCommand command, SqlParameter parameter)
		{
			parameter.ParameterName = "@return";
			parameter.DbType = DbType.Int32;

			command.Parameters.Add(parameter);

			command.Parameters.Add
				("@guid", SqlDbType.UniqueIdentifier).Value = model.BillitemGuid;

			command.Parameters.Add
				("@BillGuid", SqlDbType.UniqueIdentifier).Value = model.BillGuid;

			command.Parameters.Add
				("@ItemGuid", SqlDbType.UniqueIdentifier).Value = model.ItemGuid;

			command.Parameters.Add
				("@billitemid", SqlDbType.Int).Value = model.BillitemID;

			command.Parameters.Add
				("@Quantity", SqlDbType.Int).Value = model.Quantity;

			command.Parameters.Add
				("@Price", SqlDbType.Decimal).Value = model.Price;

		}

		public static bool SaveData(BillItemModel model)
			=> DbHelper.ExcuteData("TB_BillItem_Save",
				() => SetParameter(model, DbHelper.Command, DbHelper.Parameters));

		static void SetParameterDelete(Guid guid, SqlCommand
			command, SqlParameter parameter)
		{
			parameter.ParameterName = "@return";
			parameter.DbType = DbType.Int32;

			command.Parameters.Add(parameter);

			command.Parameters.Add
				("@BillitemGUID", SqlDbType.UniqueIdentifier).Value = guid;

		}

		public static bool DeleteOrder(Guid orderGuid) =>
			DbHelper.ExcuteData("TB_BillItem_Delete", () =>
				SetParameterDelete(orderGuid, DbHelper.Command, DbHelper.Parameters));
	}
}