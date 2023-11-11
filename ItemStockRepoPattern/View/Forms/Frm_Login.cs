using System;
using DevExpress.XtraEditors;

namespace ItemStockRepoPattern.View.Forms
{
	public partial class Frm_Login : XtraForm
	{
		public Frm_Login()
		{
			InitializeComponent();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			var frm = new Frm_Main();
			frm.ShowDialog();
			frm.Close();
		}
	}
}