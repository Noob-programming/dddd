using ItemStockRepoPattern.Logic.Repository;
using System;

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

		Stockreposition reposition = new Stockreposition();

		void SetData()
		{
			gridControl1.DataSource = reposition.GetAll();

			Lookitem.Properties.DataSource = reposition.FillLookUp();
			Lookitem.Properties.DisplayMember = "itemName";
			Lookitem.Properties.ValueMember = "itemGuid";

		}
	}
}