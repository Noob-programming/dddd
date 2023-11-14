using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Windows.Forms;

namespace StockMarcte
{
	public partial class Form1 : XtraForm
	{
		private readonly Stock stock = new Stock();

		public Form1()
		{
			InitializeComponent();
		}

		private void LookupDateFill()
		{
			var data = DbHelper.GetData("TB_Item_GetItemandName");
			lookUpEdit1.Properties.DataSource = data;
			lookUpEdit1.Properties.DisplayMember = "itemName";
			lookUpEdit1.Properties.ValueMember = "itemGuid";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			getdata();
			LookupDateFill();
		}

		private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
		{
			lookUpEdit1.EditValue = gridView1.GetFocusedRowCellValue("itemGuid").ToString();
			txtQuintity.Text = gridView1.GetFocusedRowCellValue("Quintity").ToString();

			status.IsOn = gridView1.GetFocusedRowCellValue("status").ToString() == "OUT";
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			try
			{
				stock.guid = string.IsNullOrEmpty(lookUpEdit1.EditValue.ToString())
					? Guid.Empty
					: Guid.Parse(lookUpEdit1.EditValue.ToString());
				stock.quintitiy = Convert.ToDecimal(txtQuintity.Text);
				stock.status = bool.Parse(status.EditValue.ToString()) ? "OUT" : "IN";
				var re = DbHelper.ExcuteData("TB_StockItem_Save", () => Executable.parmterStock(stock, DbHelper.cmd));

				if (re)
				{
					getdata();
					LookupDateFill();
				}

				MessageBox.Show(re ? "save" : "error");
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
				throw;
			}
		}

		private void getdata()
		{
			var res = DbHelper.GetData("TB_Stock_Get");
			gridControl1.DataSource = res;
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			var re = DbHelper.DeleteData("TB_Stock_Delete", () => Executable.parmeterdelete(stock, DbHelper.cmd));
			if (re)
			{
				getdata();
				LookupDateFill();
			}

			MessageBox.Show(re ? "save" : "error");
		}

		private void NewItem_Click(object sender, EventArgs e)
		{
			lookUpEdit1.EditValue = null;
			status.IsOn = false;
			txtQuintity.Text = string.Empty;
		}
	}
}