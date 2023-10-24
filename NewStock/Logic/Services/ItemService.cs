using NewStock.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace NewStock.Logic.Services
{
	public static class ItemService
	{

		private static void ParameterItem(ItemModel item, SqlCommand command, SqlParameter parameter)
		{
			parameter.ParameterName = "@return";

			parameter.DbType = DbType.Int32;

			command.Parameters.Add(parameter);

			command.Parameters.Add("@ItemGuid", SqlDbType.UniqueIdentifier).Value
				= item.itemGuid;
			command.Parameters.Add("@ItemCode", SqlDbType.Int).Value
				= item.itemCode;
			command.Parameters.Add("@ItemName", SqlDbType.NVarChar).Value
				= item.itemName;
			command.Parameters.Add("@ParentGuid", SqlDbType.UniqueIdentifier).Value
				= item.parentGuid;
			command.Parameters.Add("@itemPrice", SqlDbType.Decimal).Value
				= item.itemPrice;
			command.Parameters.Add("@itemPriceSingle", SqlDbType.Decimal).Value
				= item.itemPriceSingle;
			command.Parameters.Add("@itemPriceMany", SqlDbType.Decimal).Value
				= item.itemPriceMany;
			command.Parameters.Add("@IsGroup", SqlDbType.Bit).Value
				= item.isGroup;
		}

		// private static void ParameterItem(ItemModel item, SqlCommand command, SqlParameter[] parameters)
		// {
		// 	if (parameters == null)
		// 	{
		// 		throw new ArgumentNullException(nameof(parameters));
		// 	}
		//
		// 	command.Parameters.AddRange(parameters);
		//
		// 	parameters[0] = new SqlParameter("@return", SqlDbType.Int)
		// 	{
		// 		Direction = ParameterDirection.ReturnValue
		// 	};
		//
		// 	parameters[1] = new SqlParameter("@ItemGuid", SqlDbType.UniqueIdentifier)
		// 	{
		// 		Value = item.itemGuid
		// 	};
		//
		// 	parameters[2] = new SqlParameter("@ItemCode", SqlDbType.Int)
		// 	{
		// 		Value = item.itemCode
		// 	};
		//
		// 	parameters[3] = new SqlParameter("@ItemName", SqlDbType.NVarChar)
		// 	{
		// 		Value = item.itemName
		// 	};
		//
		// 	parameters[4] = new SqlParameter("@ParentGuid", SqlDbType.UniqueIdentifier)
		// 	{
		// 		Value = item.parentGuid
		// 	};
		//
		// 	parameters[5] = new SqlParameter("@itemPrice", SqlDbType.Decimal)
		// 	{
		// 		Value = item.itemPrice
		// 	};
		//
		// 	parameters[6] = new SqlParameter("@itemPriceSingle", SqlDbType.Decimal)
		// 	{
		// 		Value = item.itemPriceSingle
		// 	};
		//
		// 	parameters[7] = new SqlParameter("@itemPriceMany", SqlDbType.Decimal)
		// 	{
		// 		Value = item.itemPriceMany
		// 	};
		//
		// 	parameters[8] = new SqlParameter("@IsGroup", SqlDbType.Bit)
		// 	{
		// 		Value = item.isGroup
		// 	};
		// }

		public static bool IsItem(ItemModel item)
		{
			return DbHelper.ExcuteData("TB_Item_OnlySave",
				() => ParameterItem(item, DbHelper.Command, DbHelper.Parameters));
		}

		private static void ParmeterDelete(Guid item, SqlCommand command, SqlParameter sqlParameter)
		{
			if (sqlParameter == null) throw new ArgumentNullException(nameof(sqlParameter));


			sqlParameter.ParameterName = "@return";
			sqlParameter.DbType = DbType.Int32;

			command.Parameters.Add(sqlParameter);

			command.Parameters.Add("@guid", SqlDbType.UniqueIdentifier).Value
				= item;


		}

		public static bool IsDelete(Guid item)
			=> DbHelper.ExcuteData("TB_Item_Delete",
					() => ParmeterDelete(item, DbHelper.Command, DbHelper.Parameters));


		public static DataTable GetData(Guid guid = default)
			=> DbHelper.GetData("TB_item_GET",
				() => SelectParameter(guid, DbHelper.Command));
		private static void SelectParameter(Guid guid, SqlCommand command)
			=> command.Parameters.Add("@guid", SqlDbType.UniqueIdentifier).Value
				= guid;

		public static DataTable GetParent() =>
			DbHelper.GetData("TB_Item_GetParentData", () => { });
	}
}