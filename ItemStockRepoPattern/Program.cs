﻿using System;
using System.Windows.Forms;
using ItemStockRepoPattern.View.Forms;

namespace ItemStockRepoPattern
{
	internal static class Program
	{
		/// <summary>
		///     The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Frm_Item());
		}
	}
}