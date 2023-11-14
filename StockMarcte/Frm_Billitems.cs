using System;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace StockMarcte
{
	public partial class Frm_Billitems : XtraForm
	{
		public Frm_Billitems()
		{
			InitializeComponent();
		}

		private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
		{
		}

		private void Frm_Billitems_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'billsDataSet1.TB_Billitems' table. You can move, or remove it, as needed.
			//	this.tB_BillitemsTableAdapter.Fill(this.billsDataSet1.TB_Billitems);
			GetData();
		}

		private void LookBill()
		{
			LUpBillGuid.Properties.DataSource = DbHelper.GetData("");
		}

		private void LookItem()
		{
			LUpitemGuid.Properties.DataSource = DbHelper.GetData("");
		}

		private void GetData()
		{
			gridControl1.DataSource = DbHelper.GetData("TB_BillItem_GET");
		}
	}

	/*BillitemGuid	uniqueidentifier	Unchecked
	   BillitemID	int	Unchecked
	   BillGuid	uniqueidentifier	Checked
	   itemGuid	uniqueidentifier	Checked
	   Quantity	int	Unchecked
	   Price	decimal(10, 2)	Unchecked
	   Total	decimal(10, 2)	Unchecked
	   Unchecked*/
	public class Billitem
	{
		public Guid billitemGuid { get; set; }
		public Guid billGuid { get; set; }
		public Guid itemGuid { get; set; }
		public int billitemid { get; set; }
		public decimal quantity { get; set; }
		public decimal price { get; set; }
		public decimal total { get; set; }
	}
}