using System;
using DevExpress.XtraEditors;

namespace NewStock.Forms
{
	public partial class Frm_Info : XtraForm
	{
		public Frm_Info()
		{
			InitializeComponent();
		}

		private void Frm_Info_Load(object sender, EventArgs e)
		{
			var randomFact =
				"The Great Wall of China is not\n a single continuous\n wall but a series of walls and \nfortifications\n built by different Chinese dynasties\n over centuries.";
			var yourString = "Here's a random fact for you: " + randomFact;
			labelControl1.Text = yourString;
		}
	}
}