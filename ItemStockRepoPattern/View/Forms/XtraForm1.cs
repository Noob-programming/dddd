using ItemStockRepoPattern.Logic.Extension;
using ItemStockRepoPattern.Logic.Repository;

namespace ItemStockRepoPattern.View.Forms
{
	public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
	{
		public XtraForm1()
		{
			InitializeComponent();
		}

		ItemRepository item = new ItemRepository();

		private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{



			var form = new Frm_ParentItem();
			form.ShowDialog();

			var s = item.GetByGuid(GuidHelper.SaveGuid);
			buttonEdit1.EditValue = $@"{s.ItemName}";

		}

	}
}