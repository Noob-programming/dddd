using System;
using System.ComponentModel.DataAnnotations;

namespace Testsource
{
	public class BillItem1
	{
		// [Required]
		[Display(Name = "Bill Guid")]
		public Guid BillGuid { get; set; } = Guid.NewGuid();
		// [Required]
		[Display(Name = "Bill Code")] public int BillCode { get; set; } = 0;
		// [Required]
		[Display(Name = "تاريخ الفاتورة")]
		public DateTime BillDate { get; set; } = DateTime.Now;
		// [Required]
		[Display(Name = "ملاحظات")]
		public string Notes { get; set; } = string.Empty;
		// [Required]
		[Display(Name = "نوع الفاتورة")]
		public bool BillType { get; set; } = false;
	}
}