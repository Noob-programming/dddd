using System;
using DevExpress.XtraEditors;

namespace StockMarcte.Fomes
{
	public partial class Frm_Item : XtraForm
	{
		public Frm_Item()
		{
			InitializeComponent();

			tB_ItemTableAdapter1.Fill(new BillsDataSet1.TB_ItemDataTable(billsdata1.TB_Item));
		}

		private void simpleButton4_Click(object sender, EventArgs e)
		{
		}

		private void Frm_Item_Load(object sender, EventArgs e)
		{
		}
	}
}