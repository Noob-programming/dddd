using System;
using System.ComponentModel.DataAnnotations;

namespace ItemStockRepoPattern.Model
{
	public class ShoppingCartModel
	{
		[Required]
		[Display(Name = "رقم العملية")]
		public Guid SalesOrderId { get; set; } = Guid.Empty;

		[Display(Name = "اسم المادة")] public Guid ItemGuid { get; set; }

		[Display(Name = "رقم الفاتورة")] public Guid BillGuid { get; set; }

		[Display(Name = "رقم الطلب")]
		[RegExEditMask(@"\d+")]
		public int ShoppingOrderId { get; set; }

		[Display(Name = "سعر")]
		[RegularEditMask(@"^\$?\d+(\.(\d{2}))?$")]
		public decimal Prices { get; set; }

		[Display(Name = "المجموع الكلي")]
		[RegularEditMask(@"^\$?\d+(\.(\d{2}))?$")]
		public decimal Total { get; set; }

		[Display(Name = "كمية")]
		[RegularEditMask(@"^\$?\d+(\.(\d{2}))?$")]
		public decimal Quantity { get; set; }

		[Display(Name = "اسم المنتج")]
		[StringLength(5)]
		public string ItemName { get; set; }

		[Display(Name = "رقم الفاتورة")]
		[RegularEditMask(@"^\$?\d+(\.(\d{2}))?$")]
		public int BillCode { get; set; }
	}
}