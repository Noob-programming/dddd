using System;
using System.Windows.Forms;

namespace NewStock.Logic.Services
{
	public static class OrderService
	{
		public static bool SaveData()
		{
			try
			{
				return false;
			}
			catch (Exception e)
			{
				MessageBox.Show($@"{e}");
				throw;
			}
		}
	}
}