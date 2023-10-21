using NewStock.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace NewStock.Logic.Services
{
	public static class BillService
	{
		private static void BillParameter(BillModel model, SqlCommand command, SqlParameter parameter)
		{
			parameter = new SqlParameter("@return", SqlDbType.Bit)
			{
				Direction = ParameterDirection.ReturnValue
			};
			command.Parameters.Add(parameter);
			command.Parameters.Add("@guid", SqlDbType.UniqueIdentifier).Value
				= model.billGuid;

			command.Parameters.Add("@billcode", SqlDbType.Int).Value
				= model.Billcode;
			command.Parameters.Add("@date", SqlDbType.DateTime).Value
				= model.billdate;
			command.Parameters.Add("@notes", SqlDbType.NVarChar).Value
				= model.notes;
			command.Parameters.Add("@Billtype", SqlDbType.Bit).Value
				= model.billType;
		}

		public static bool BillExistsSave(BillModel model)
		{
			return DbHelper.ExcuteData("TB_Bill_Save",
				() => BillParameter(model, DbHelper.Command, DbHelper.Parameters));
		}

		private static void ParmeterDelete(Guid item, SqlCommand command, SqlParameter sqlParameter)
		{
			if (sqlParameter == null) throw new ArgumentNullException(nameof(sqlParameter));
			sqlParameter = new SqlParameter("@return", SqlDbType.Bit)
			{
				Direction = ParameterDirection.ReturnValue
			};

			command.Parameters.Add(sqlParameter);

			command.Parameters.Add("@guid", SqlDbType.UniqueIdentifier).Value
				= item;


		}

		public static bool IsDelete(Guid item)
			=> DbHelper.ExcuteData("TB_Bill_Delete",
				() => ParmeterDelete(item, DbHelper.Command, DbHelper.Parameters));


		public static DataTable GetData(Guid guid = default)
			=> DbHelper.GetData("TB_Bill_GET",
				() => SelectParameter(guid, DbHelper.Command));
		private static void SelectParameter(Guid guid, SqlCommand command)
			=> command.Parameters.Add("@guid", SqlDbType.UniqueIdentifier).Value
				= guid;


	}
}