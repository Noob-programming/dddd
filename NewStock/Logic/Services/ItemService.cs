using NewStock.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace NewStock.Logic.Services
{
	public static class ItemService
	{

		private static void ParameterItem(ItemModel item, SqlCommand command)
		{
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

		public static bool IsItem(ItemModel item)
		{
			return DbHelper.ExcuteData("TB_Item_OnlySave",
				() => ParameterItem(item, DbHelper.Command));
		}

		private static void ParmeterDelete(Guid item, SqlCommand command) =>
			 command.Parameters.Add("@guid", SqlDbType.UniqueIdentifier).Value
				 = item;

		public static bool IsDelete(Guid item)
			=> DbHelper.ExcuteData("TB_Item_Delete",
					() => ParmeterDelete(item, DbHelper.Command));


		public static DataTable GetData(Guid guid)
			=> DbHelper.GetData("TB_item_GET",
				() => SelectParameter(guid, DbHelper.Command));
		private static void SelectParameter(Guid guid, SqlCommand command)
			=> command.Parameters.Add("@guid", SqlDbType.UniqueIdentifier).Value
				= guid;

		public static DataTable GetParent() =>
			DbHelper.GetData("TB_Item_GetParentData", () => { });
	}
}