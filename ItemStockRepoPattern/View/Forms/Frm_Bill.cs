using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using ItemStockRepoPattern.Logic.Repository;
using ItemStockRepoPattern.Model;

namespace ItemStockRepoPattern.View.Forms
{
	public partial class Frm_Bill : XtraForm
	{
		private readonly BillModel bill = new BillModel();
		private readonly BillRepository repository = new BillRepository();

		public Frm_Bill()
		{
			InitializeComponent();
		}

		private void SetData()
		{
			gridControl1.DataSource = repository.GetAll();
		}

		private void Frm_Bill_Load(object sender, EventArgs e)
		{
			SetData();
		}

		private void SetBill(BillModel bills)
		{
			bill.billGuid = new Guid(txtGuid.Text);
			bill.BillCode = Convert.ToInt32(txtCode.Text);
			bill.Notes = txtNotes.Text;
			bill.BillDate = Convert.ToDateTime(txtDate.Text);
			bill.BillType = TbillType.IsOn;
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			SetBill(bill);
			var ch = repository.Save(bill);
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
			txtCode.Text = $@"{repository.GetMaxId()}";
			txtNotes.Text = string.Empty;
			txtGuid.Text = Guid.Empty.ToString();

			txtDate.Text = DateTime.Now.ToLongDateString();
			TbillType.IsOn = false;
		}

		private void simpleButton3_Click(object sender, EventArgs e)
		{
			var a = gridView1.GetFocusedRowCellValue("billGuid").ToString();
			var ch = repository.Delete(new Guid(a));
			if (ch == 0)
			{
				MessageBox.Show(@"Error");
				return;
			}

			if (ch == 1)
			{
				MessageBox.Show(@"Done Delete");
				SetData();
			}
		}

		private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
		{
			txtGuid.Text = gridView1.GetFocusedRowCellValue("billGuid").ToString();
			txtCode.Text = gridView1.GetFocusedRowCellValue("BillCode").ToString();
			txtNotes.Text = gridView1.GetFocusedRowCellValue("BillDate").ToString();
			txtDate.Text = gridView1.GetFocusedRowCellValue("Notes").ToString();
			TbillType.IsOn = (bool)gridView1.GetFocusedRowCellValue("BillType");
		}
	}
}