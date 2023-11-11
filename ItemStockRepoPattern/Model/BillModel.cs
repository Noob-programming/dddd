using System;
using System.ComponentModel.DataAnnotations;

namespace ItemStockRepoPattern.Model
{
	public class BillModel
	{
		[Required]
		[Display(Name = "Bill Guid")]
		public Guid BillGuid { get; set; }

		// [Required]
		[Display(Name = "Bill Code")] public int BillCode { get; set; }

		// [Required]
		[Display(Name = "تاريخ الفاتورة")] public DateTime BillDate { get; set; }

		// [Required]
		[Display(Name = "ملاحظات")] public string Notes { get; set; }

		// [Required]
		[Display(Name = "نوع الفاتورة")] public bool BillType { get; set; }
	}
}