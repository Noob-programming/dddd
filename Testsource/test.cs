using System;
using System.Windows.Forms;
using DevExpress.Utils.Behaviors;

namespace Testsource
{
	public partial class test : DevExpress.XtraEditors.XtraForm
	{
		public test()
		{
			InitializeComponent();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			var r = (BillItem1)billItem1BindingSource.DataSource;

			MessageBox.Show($@"{r}");
		}

		void set()
		{
			billItem1BindingSource.DataSource = new BillItem1();

		}
		private void test_Load(object sender, EventArgs e)
		{
			set();
		}
	}
}