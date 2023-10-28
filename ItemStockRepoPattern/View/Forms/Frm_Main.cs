namespace ItemStockRepoPattern.View.Forms
{
	public partial class Frm_Main : DevExpress.XtraEditors.XtraForm
	{
		public Frm_Main()
		{
			InitializeComponent();
		}

		private void guna2Button1_Click(object sender, System.EventArgs e)
		{
			Frm_Item f = new Frm_Item();
			f.ShowDialog();

			f.Close();
		}

		private void guna2Button2_Click(object sender, System.EventArgs e)
		{
			Frm_Bill f = new Frm_Bill();
			f.ShowDialog();

			f.Close();
		}
	}
}