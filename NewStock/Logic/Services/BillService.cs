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

			// [BillGuid]
			// ,[Billcode]
			// ,[BillDate]
			// ,[Notes]
			// ,[BillType]

			command.Parameters.Add("@BillGuid", SqlDbType.UniqueIdentifier).Value
				= model.billGuid;

			command.Parameters.Add("@Billcode", SqlDbType.Int).Value
				= model.billGuid;
			command.Parameters.Add("@BillDate", SqlDbType.DateTime).Value
				= model.billGuid;
			command.Parameters.Add("@Notes", SqlDbType.NVarChar).Value
				= model.billGuid;
			command.Parameters.Add("@BillType", SqlDbType.Bit).Value
				= model.billGuid;
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
			=> DbHelper.ExcuteData("TB_Item_Delete",
				() => ParmeterDelete(item, DbHelper.Command, DbHelper.Parameters));


		public static DataTable GetData(Guid guid = default)
			=> DbHelper.GetData("TB_Bill_GET",
				() => SelectParameter(guid, DbHelper.Command));
		private static void SelectParameter(Guid guid, SqlCommand command)
			=> command.Parameters.Add("@guid", SqlDbType.UniqueIdentifier).Value
				= guid;


	}
}