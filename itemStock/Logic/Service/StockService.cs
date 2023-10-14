using System.Collections.Generic;
using itemStock.Model;
using System.Data;
using System.Data.SqlClient;
using DevExpress.DocumentServices.ServiceModel.DataContracts;

namespace itemStock.Logic.Service
{
	public static class StockService
	{
		/*@Guid AS UNIQUEIDENTIFIER,
		   @Status AS NVARCHAR(10),
		   @Quin AS INT*/
		private static void StockParameter(StockModel model, SqlCommand command)
		{
			if (model == null) return;
			command.Parameters.Add("@Guid", SqlDbType.UniqueIdentifier)
				.Value = model.ItemGuid;
			command.Parameters.Add("@Status", SqlDbType.NVarChar)
				.Value = model.status;
			command.Parameters.Add("@Quin", SqlDbType.Int)
				.Value = model.Quintity;
		}

		public static bool StockSave(StockModel model)
			=> DBHelper.ExcuteData("TB_StockItem_Save",
				() => StockParameter(model, DBHelper.Command));

		public static DataTable GetData()
		{
			return DBHelper.GetData("TB_Stock_Get", () => { });
		}

		public static List<string> FillCBX()
		{
			return DBHelper.
				FillComboBoxWithSPResult
					("TB_Stock_Get", () => { });
		}
		
	}
}