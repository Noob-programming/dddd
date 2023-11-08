using System;

namespace ItemStockRepoPattern.Model
{
	public class UsersModel
	{
		public Guid UserGuid { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
	}
}