using System.Data;
using System.Data.SqlClient;

namespace StockMarcte
{
	public static class Executable
	{

		public static void parameterItem(Items item, SqlCommand command)
		{
			command.Parameters.Add("@ItemGuid", SqlDbType.UniqueIdentifier).Value
				= item.itemGuid;
			command.Parameters.Add("@ItemCode", SqlDbType.Int).Value
				= item.itemcode;
			command.Parameters.Add("@ItemName", SqlDbType.NVarChar).Value
				= item.itemname;
			command.Parameters.Add("@ParentGuid", SqlDbType.UniqueIdentifier).Value
				= item.ParentGuid;
			command.Parameters.Add("@itemPrice", SqlDbType.Decimal).Value
				= item.itemprice;
			command.Parameters.Add("@itemPriceSingle", SqlDbType.Decimal).Value
				= item.itempricesingel;
			command.Parameters.Add("@itemPriceMany", SqlDbType.Decimal).Value
				= item.itempricemany;
			command.Parameters.Add("@IsGroup", SqlDbType.Bit).Value
				= item.isgroup;
		}

		public static void parmterStock(Stock stock, SqlCommand command)
		{
			command.Parameters.Add("@guid", SqlDbType.UniqueIdentifier).Value = stock.guid;

			command.Parameters.Add("@status", SqlDbType.NVarChar).Value = stock.status;
			command.Parameters.Add("@Quin", SqlDbType.Decimal).Value = stock.quintitiy;
		}

		public static void parmeterdelete(Stock stock, SqlCommand cmd) => cmd.Parameters.Add("@guid", SqlDbType.UniqueIdentifier).Value = stock.guid;


		public static void parmterBill(Bills bill, SqlCommand command)
		{
			command.Parameters.Add("@guid", SqlDbType.UniqueIdentifier)
				.Value = bill.Billguid;

			command.Parameters.Add("@billcode", SqlDbType.Int).Value =
				bill.billcode;

			command.Parameters.Add("@notes", SqlDbType.NVarChar).Value =
				bill.notes;

			command.Parameters.Add("@date", SqlDbType.DateTime).Value =
				bill.DateTime;

			command.Parameters.Add("@Billtype", SqlDbType.Bit).Value =
				bill.billtye;
		}


		public static void ParameterDelete(Bills bill, SqlCommand cmd) => cmd.Parameters.Add("@guid", SqlDbType.UniqueIdentifier)
				.Value = bill.Billguid;

		public static void parmeteterItemDelete(Items stock, SqlCommand cmd) => cmd.Parameters.Add("@guid", SqlDbType.UniqueIdentifier).Value = stock.itemGuid;

	}
}