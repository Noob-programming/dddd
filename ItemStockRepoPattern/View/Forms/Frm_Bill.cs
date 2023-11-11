using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ItemStockRepoPattern.Logic.Repository;
using ItemStockRepoPattern.Model;

namespace ItemStockRepoPattern.View.Forms
{
	public partial class Frm_Bill : XtraForm
	{
		private readonly BillModel _bill = new BillModel();
		private readonly BillRepository _repository = new BillRepository();

		public Frm_Bill()
		{
			InitializeComponent();
		}

		private void SetData()
		{
			billModelBindingSource.DataSource = new BillModel();
			var dt = new BindingSource();
			dt.DataSource = _repository.GetAll();
			gridControl1.DataSource = dt;
		}

		private void Frm_Bill_Load(object sender, EventArgs e)
		{
			SetData();
		}

		private void Save_Click(object sender, EventArgs e)
		{
			try
			{
				var items = (BillModel)billModelBindingSource.DataSource;
				var ch = _repository.Save(items);
				switch (ch)
				{
					case 0:
						MessageBox.Show(@"Error");
						return;
					case 1:
						MessageBox.Show(@"Done Save");
						SetData();
						break;
					case 2:
						MessageBox.Show(@"Done UPdate");
						SetData();
						break;
				}
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
				throw;
			}
		}

		private void Delete_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("are you ready to delete", "delete", MessageBoxButtons.OKCancel) !=
				    DialogResult.OK) return;
				var a = (BillModel)billModelBindingSource.DataSource;
				var ch = _repository.Delete(a.BillGuid);
				switch (ch)
				{
					case 0:
						MessageBox.Show(@"Error");
						return;
					case 1:
						MessageBox.Show(@"Done Delete");
						SetData();
						break;
				}
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
				throw;
			}
		}

		private void gridControl1_DoubleClick(object sender, EventArgs e)
		{
			try
			{
				billModelBindingSource.DataSource = (BillModel)gridView1.GetRow(gridView1.FocusedRowHandle);
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
				throw;
			}
		}
	}
}