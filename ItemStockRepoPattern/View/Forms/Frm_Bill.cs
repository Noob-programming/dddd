using DevExpress.XtraEditors;
using ItemStockRepoPattern.Logic.Repository;
using ItemStockRepoPattern.Model;
using System;
using System.Windows.Forms;

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

			billModelBindingSource.DataSource = new BillModel();
			BindingSource dt = new BindingSource();
			dt.DataSource = repository.GetAll();
			gridControl1.DataSource = dt;
		}

		private void Frm_Bill_Load(object sender, EventArgs e)
		{
			SetData();
		}

		private void Save_Click(object sender, EventArgs e)
		{
			var items = (BillModel)billModelBindingSource.DataSource;
			var ch = repository.Save(items);
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

		private void Delete_Click(object sender, EventArgs e)
		{

			var a = (BillModel)billModelBindingSource.DataSource;
			var ch = repository.Delete(a.BillGuid);
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
	}
}