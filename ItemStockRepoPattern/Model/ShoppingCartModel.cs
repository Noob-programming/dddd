using System;
using System.ComponentModel.DataAnnotations;

namespace ItemStockRepoPattern.Model
{
	public class ShoppingCartModel
	{
		[Display(Name = "Sales Address")] public Guid SalesOrderId { get; set; }

		[Display(Name = "اسم المادة")] public Guid ItemGuid { get; set; }
		[Display(Name = "رقم الفاتورة")] public Guid BillGuid { get; set; }
		[Display(Name = "رقم الطلب")] public int ShoppingOrderId { get; set; }

		[Display(Name = "سعر")] public decimal Prices { get; set; }
		[Display(Name = "المجموع الكلي")] public decimal Total { get; set; }

		[Display(Name = "كمية")] public decimal Quantity { get; set; }
		[Display(Name = "اسم المنتج")] public string ItemName { get; set; }
		[Display(Name = "رقم الفاتورة")] public int BillCode { get; set; }
	}
}