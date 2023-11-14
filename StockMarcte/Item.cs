using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace StockMarcte
{
	public partial class Item : XtraForm
	{
		private readonly Items item = new Items();

		public Item()
		{
			InitializeComponent();
		}

		private Guid parseguid(string guid)
		{
			return string.IsNullOrEmpty(guid) ? Guid.Empty : Guid.Parse(guid);
		}

		private void FillLockUpData(DataTable dt)
		{
			var res = dt.ToBillList(x => new
			{
				itemGuid = Guid.Parse(x["itemGuid"].ToString()),
				ParentGuid = parseguid(x["parentGuid"].ToString()),
				itemName = x["itemName"].ToString()
			});
			parentguid.Properties.DataSource = res;
			parentguid.Properties.DisplayMember = "itemName";
			parentguid.Properties.ValueMember = "itemGuid";
		}

		private void GetData()
		{
			var source = new BindingSource();
			var sos = DbHelper.GetData("TB_item_GET");

			source.DataSource = sos;
			gridControl1.DataSource = source;

			FillLockUpData(sos);
		}

		private void Item_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'billsdata.TB_Item' table. You can move, or remove it, as needed.
			tB_ItemTableAdapter1.Fill(billsdata.TB_Item);
			// TODO: This line of code loads data into the 'billsDataSet1.TB_Item' table. You can move, or remove it, as needed.
			// this.tB_ItemTableAdapter.Fill(this.billsDataSet1.TB_Item);
			GetData();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtGuid.Text) || txtGuid.Text == @"0x00")
					item.itemGuid = Guid.Empty;
				else item.itemGuid = Guid.Parse(txtGuid.Text);
				item.itemcode = Convert.ToInt32(itemcode.Text);
				item.itemname = itemname.Text;
				item.itemprice = Convert.ToDecimal(itemprice.Text);
				item.itempricesingel = Convert.ToDecimal(itempricesingel.Text);
				item.itempricemany = Convert.ToDecimal(itempricemany.Text);
				if (string.IsNullOrEmpty(parentguid.Text) || parentguid.Text == @"0x0")
					item.ParentGuid = Guid.Empty;
				else item.ParentGuid = Guid.Parse(parentguid.EditValue.ToString());

				item.isgroup = isgroup.IsOn;


				var re = DbHelper.ExcuteData("TB_Item_OnlySave",
					() => Executable.parameterItem(item, DbHelper.cmd));

				if (re) GetData();
				MessageBox.Show(re ? @"Save" : @"Error");
			}
			catch (Exception exception)
			{
				MessageBox.Show($@"{exception}");
			}
		}

		private bool CheckitemGuid()
		{
			var sameGuid = item.ParentGuid.TestGuid(item.itemGuid);
			return sameGuid;
		}

		private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
		{
			try
			{
				txtGuid.Text = gridView1.GetFocusedRowCellValue("itemGuid").ToString();
				itemcode.Text = gridView1.GetFocusedRowCellValue("itemcode").ToString();
				itemname.Text = gridView1.GetFocusedRowCellValue("itemName").ToString();
				itemprice.Text = gridView1.GetFocusedRowCellValue("itemPrice").ToString();
				itempricesingel.Text = gridView1.GetFocusedRowCellValue("itemPriceSingle").ToString();
				itempricemany.Text = gridView1.GetFocusedRowCellValue("itemPriceMany").ToString();
				parentguid.EditValue = gridView1.GetFocusedRowCellValue("parentGuid").ToString();
				if (Convert.ToBoolean(gridView1.GetFocusedRowCellValue("isgroup").ToString()))

					isgroup.IsOn = true;
				else isgroup.IsOn = false;
			}
			catch (Exception exception)
			{
				MessageBox.Show($@"{exception}");
				throw;
			}
		}

		private void gridView1_RowClick(object sender, RowClickEventArgs e)
		{
			try
			{
				txtGuid.Text = gridView1.GetFocusedRowCellValue("itemGuid").ToString();
				itemcode.Text = gridView1.GetFocusedRowCellValue("itemcode").ToString();
				itemname.Text = gridView1.GetFocusedRowCellValue("itemName").ToString();
				itemprice.Text = gridView1.GetFocusedRowCellValue("itemPrice").ToString();
				itempricesingel.Text = gridView1.GetFocusedRowCellValue("itemPriceSingle").ToString();
				itempricemany.Text = gridView1.GetFocusedRowCellValue("itemPriceMany").ToString();
				parentguid.EditValue = gridView1.GetFocusedRowCellValue("parentGuid").ToString();

				isgroup.IsOn = bool.Parse(gridView1.GetFocusedRowCellValue("ISGroup").ToString());
			}
			catch (Exception exception)
			{
				MessageBox.Show($@"{exception}");
			}
		}


		private void simpleButton2_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtGuid.Text) || txtGuid.Text == @"0x00")
					item.itemGuid = Guid.Empty;
				else item.itemGuid = Guid.Parse(txtGuid.Text);

				var check = DbHelper.ExcuteData("TB_Item_Delete",
					() => Executable.parmeteterItemDelete(item, DbHelper.cmd));
				GetData();
				MessageBox.Show(check ? "done delete" : "error delete");
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
				throw;
			}
		}

		private void simpleButton3_Click(object sender, EventArgs e)
		{
			txtGuid.Text = string.Empty;
			itemcode.Text = string.Empty;
			itemname.Text = string.Empty;
			itemprice.Text = string.Empty;
			itempricesingel.Text = string.Empty;
			itempricemany.Text = string.Empty;
			parentguid.EditValue = string.Empty;
		}

		private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
		{
			txtGuid.Text = gridView1.GetFocusedRowCellValue("itemGuid").ToString();
			itemcode.Text = gridView1.GetFocusedRowCellValue("itemcode").ToString();
			itemname.Text = gridView1.GetFocusedRowCellValue("itemName").ToString();
			itemprice.Text = gridView1.GetFocusedRowCellValue("itemPrice").ToString();
			itempricesingel.Text = gridView1.GetFocusedRowCellValue("itemPriceSingle").ToString();
			itempricemany.Text = gridView1.GetFocusedRowCellValue("itemPriceMany").ToString();
			parentguid.EditValue = gridView1.GetFocusedRowCellValue("parentGuid").ToString();
			isgroup.IsOn = bool.Parse(gridView1.GetFocusedRowCellValue("ISGroup").ToString());
		}
	}


	public class Items
	{
		public Guid itemGuid { get; set; }
		public int itemcode { get; set; }
		public string itemname { get; set; }
		public decimal itemprice { get; set; }
		public decimal itempricemany { get; set; }
		public decimal itempricesingel { get; set; }
		public Guid ParentGuid { get; set; }
		public bool isgroup { get; set; }
	}
}