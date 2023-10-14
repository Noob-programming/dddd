using itemStock.Forms.InterFaces;
using itemStock.Logic.Service;
using itemStock.Model;
using System;
using System.Data;
using System.Linq;

namespace itemStock.Logic.Presnter
{
	public class StockPresnter
	{
		private IStock stock;
		StockModel model = new StockModel();

		public StockPresnter(IStock stock)
		{
			this.stock = stock;
		}

		private void conntionBetweenInterFaceAndModel()
		{
			model.ItemGuid = stock.ItemGuid;
			model.status = stock.status;
			model.Quintity = stock.Quintity;
			model.Dgv = stock.Dgv;
		}


		public bool Save()
		{
			conntionBetweenInterFaceAndModel();
			bool checker = StockService.StockSave(model);
			return checker;
		}

		public void GetData()
		{
			stock.Dgv = StockService.GetData();
		}

		public object FillCbx()
		{
			try
			{
				var dataTable = stock.Dgv as DataTable;
				var res =
					//StockService.GetData()
					dataTable.ToChangeList(
						x => new StockModel
						{
							status = (string)x["status"]
						}).Select(x => x).Distinct();

				//var newfild = res.SelectMany(x => x.status);

				stock.status = res;
			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show($@"{e}");
			}

			return null;
		}
	}
}