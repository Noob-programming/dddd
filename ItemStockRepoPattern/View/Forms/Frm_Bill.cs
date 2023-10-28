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

		void SetBill(BillModel Bill)
		{
			bill.billGuid = new Guid(txtGuid.Text);
			bill.BillCode = Convert.ToInt32(txtCode.Text);
			bill.Notes = txtNotes.Text;
			bill.BillDate = Convert.ToDateTime(txtDate.Text);
			bill.BillType = TbillType.IsOn;
		}

		private void simpleButton1_Click(object sender, System.EventArgs e)
		{
			SetBill(bill);
			bool ch = repository.Save(bill);
			if (!ch)
			{
				MessageBox.Show(@"Error");
				return;
			}
			MessageBox.Show(@"Done Save");
			SetData();
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
			var a = gridView1.GetFocusedRowCellValue("BillGuid").ToString();
			bool ch = repository.Delete(new Guid(a));

			if (!ch)
			{
				MessageBox.Show(@"Error");
				return;
			}
			MessageBox.Show(@"Done Save");
			SetData();

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