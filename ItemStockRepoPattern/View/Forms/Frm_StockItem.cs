using ItemStockRepoPattern.Logic.Repository;
using ItemStockRepoPattern.Model;
using System;
using System.Windows.Forms;

namespace ItemStockRepoPattern.View.Forms
{
	public partial class Frm_StockItem : DevExpress.XtraEditors.XtraForm
	{
		public Frm_StockItem()
		{
			InitializeComponent();
		}

		private void Frm_StockItem_Load(object sender, EventArgs e)
		{
			SetData();
		}

		private readonly StockReposition _reposition = new StockReposition();

		void SetData()
		{
			gridControl1.DataSource = _reposition.GetAll();

			Lookitem.Properties.DataSource = _reposition.FillLook();
			Lookitem.Properties.DisplayMember = "itemName";
			Lookitem.Properties.ValueMember = "itemGuid";
		}

		private StockModel stock = new StockModel();

		void SetUp()
		{
			stock.ItemGuid = new Guid(Lookitem.EditValue.ToString());
			stock.Quantity = Convert.ToDecimal(textEdit2.Text);
			stock.Status = toggleSwitch1.IsOn ? "IN" : "OUT";

		}

		private readonly StockReposition _stockReposition = new StockReposition();
		private void simpleButton3_Click(object sender, EventArgs e)
		{
			SetUp();
			var ch = _stockReposition.Save(stock);
			if (ch == 0)
			{
				MessageBox.Show(@"ERROR");
			}
			else if (ch == 1)
			{
				MessageBox.Show(@"Done Insert");
				SetData();
			}
			else if (ch == 2)
			{
				MessageBox.Show(@"Done Update");
				SetData();
			}
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			textEdit2.Text = string.Empty;
			toggleSwitch1.IsOn = false;
			Lookitem.EditValue = null;
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			var re = _stockReposition.Delete(stock.ItemGuid);
			if (re == 0)
				MessageBox.Show(@"Error delete");
			if (re == 1)
			{
				MessageBox.Show(@"Done Delete");
				SetData();
			}

		}

		private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			Lookitem.EditValue = gridView1.GetFocusedRowCellValue("ItemGuid").ToString();
			textEdit2.Text = gridView1.GetFocusedRowCellValue("Quantity").ToString();
			toggleSwitch1.IsOn = gridView1.GetFocusedRowCellValue("Status").ToString() == "IN";

		}
	}
}