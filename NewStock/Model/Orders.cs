using System.Collections.Generic;

namespace NewStock.Model
{
	public class Orders
	{
		public List<ItemModel> itemModels { get; set; }
		public List<BillModel> billModels { get; set; }
		public BillItemModel billItemModel { get; set; }
	}
}