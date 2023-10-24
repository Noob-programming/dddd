using System.Data.SqlClient;

namespace ItemStockRepoPattern.Logic.Repository
{
	public class UnitofWork
	{
		public static UnitofWork Instace = null;

		private SqlConnection conn = null;

		private UnitofWork()
		{
		}
	}
}