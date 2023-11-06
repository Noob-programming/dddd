using ItemStockRepoPattern.Logic.Repository;
using ItemStockRepoPattern.Model;
using System;
using System.Windows.Forms;

namespace ItemStockRepoPattern.View.Forms
{
	public partial class Frm_Bill : DevExpress.XtraEditors.XtraForm
	{
		public Frm_Bill()
		{
			InitializeComponent();

		}
		BillRepository repository = new BillRepository();
		void SetData()
		{
			gridControl1.DataSource = repository.GetAll();
		}

		private void Frm_Bill_Load(object sender, System.EventArgs e)
		{
			SetData();
		}
		BillModel bill = new BillModel();

		void SetBill(BillModel bills)
		{
			this.bill.billGuid = new Guid(txtGuid.Text);
			this.bill.BillCode = Convert.ToInt32(txtCode.Text);
			this.bill.Notes = txtNotes.Text;
			this.bill.BillDate = Convert.ToDateTime(txtDate.Text);
			this.bill.BillType = TbillType.IsOn;
		}

		private void simpleButton1_Click(object sender, System.EventArgs e)
		{
			SetBill(bill);
			int ch = repository.Save(bill);
			if (ch == 0)
			{
				MessageBox.Show(@"Error");
				return;
			}

			if (ch == 1)
			{
				MessageBox.Show(@"Done Save");
				SetData();
			}
			else if (ch == 2)
			{
				MessageBox.Show(@"Done UPdate");
				SetData();
			}
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			txtCode.Text = string.Empty;
			txtNotes.Text = string.Empty;
			txtGuid.Text = Guid.Empty.ToString();

			txtDate.Text = DateTime.Now.ToLongDateString();
			TbillType.IsOn = false;

		}

		private void simpleButton3_Click(object sender, EventArgs e)
		{
			var a = gridView1.GetFocusedRowCellValue("billGuid").ToString();
			int ch = repository.Delete(new Guid(a));
			if (ch == 0)
			{
				MessageBox.Show(@"Error");
				return;
			}
			else if (ch == 1)
			{
				MessageBox.Show(@"Done Delete");
				SetData();
			}
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			txtGuid.Text = gridView1.GetFocusedRowCellValue("billGuid").ToString();
			txtCode.Text = gridView1.GetFocusedRowCellValue("BillCode").ToString();
			txtNotes.Text = gridView1.GetFocusedRowCellValue("BillDate").ToString();
			txtDate.Text = gridView1.GetFocusedRowCellValue("Notes").ToString();
			TbillType.IsOn = (bool)gridView1.GetFocusedRowCellValue("BillType");
		}
	}
}