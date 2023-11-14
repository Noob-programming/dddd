using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using NewStock.Logic;
using NewStock.Logic.Services;
using NewStock.Model;
using System;
using System.Windows.Forms;

namespace NewStock.Forms
{
	public partial class Stock : XtraForm
	{
		private bool _check;

		private readonly StockModel stock;

		public Stock()
		{
			InitializeComponent();
			stock = new StockModel();
		}

		private void Stock_Load(object sender, EventArgs e)
		{
			GetData();
			FillLookUp();
		}

		private void FillLookUp()
		{
			var data = StockService.FillLookUp("TB_Item_GetItemandName");
			lookupitem.Properties.DataSource = data;
			lookupitem.Properties.DisplayMember = "itemName";
			lookupitem.Properties.ValueMember = "itemGuid";
		}

		private void GetData()
		{
			gridControl1.DataSource = StockService.GetData();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			stock.itemGuid = new Guid(lookupitem.EditValue.ToString());
			stock.quintity = Convert.ToDecimal(txtQuintity.Text);
			stock.status = status.IsOn ? "IN" : "OUT";
			_check = StockService.SaveStock(stock);
			GetData();
			MessageBox.Show(_check ? @"Save Data" : "Error");
		}

		private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
		{
			lookupitem.EditValue = gridView1.GetFocusedRowCellValue("itemGuid").ToString();
			txtQuintity.Text = gridView1.GetFocusedRowCellValue("Quintity").ToString();
			status.IsOn = gridView1.GetFocusedRowCellValue("status").ToString() == "IN";
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			lookupitem.EditValue = Guid.Empty;
			txtQuintity.Text = string.Empty;
			status.IsOn = false;
		}

		private void simpleButton3_Click(object sender, EventArgs e)
		{
			SaveGuid.guidSave = new Guid(lookupitem.EditValue.ToString());
			_check = StockService.deleteStock(SaveGuid.guidSave);

			GetData();
			MessageBox.Show(_check ? @"Delete Done" : @"Error delete");
		}
	}
}