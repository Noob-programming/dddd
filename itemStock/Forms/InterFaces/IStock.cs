using System;
using System.Collections.Generic;
using itemStock.Model;

namespace itemStock.Forms.InterFaces
{
	public interface IStock
	{
		Guid ItemGuid { get; set; }
		string status { get; set; }
		int Quintity { get; set; }
		object Dgv { get; set; }
		object CbxDisplayName { get; set; }
	}
}