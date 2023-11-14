using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NewStock.Logic;

namespace NewStock.Forms
{
	public partial class Frm_Item : XtraForm
	{
		public Frm_Item()
		{
			InitializeComponent();
		}

		private void SetData()
		{
			try
			{
				tB_ItemTableAdapter2.Fill(billsDB2.TB_Item);
			}
			catch (Exception e)
			{
				MessageBox.Show($@"{e}");
			}
		}

		private void treeList1_DoubleClick(object sender, EventArgs e)
		{
			SaveGuid.guidSave = new Guid
				(treeList1.GetFocusedRowCellValue("itemGuid").ToString());
			var form = new Frm_ItemForms();
			form.ShowDialog();
			form.Close();
			SetData();
		}

		private void Frm_Item_Load(object sender, EventArgs e)
		{
			SetData();
		}
	}
}