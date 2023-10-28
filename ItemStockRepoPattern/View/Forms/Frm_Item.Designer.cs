namespace ItemStockRepoPattern.View.Forms
{
	partial class Frm_Item
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.treeList1 = new DevExpress.XtraTreeList.TreeList();
			this.colitemGuid = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colitemcode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colitemName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colitemPrice = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colitemPriceSingle = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colitemPriceMany = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colparentGuid = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colISGroup = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colDateOfInsert = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.tBItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.billsDataSet = new ItemStockRepoPattern.BillsDataSet();
			this.tB_ItemTableAdapter = new ItemStockRepoPattern.BillsDataSetTableAdapters.TB_ItemTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBItemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// treeList1
			// 
			this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colitemGuid,
            this.colitemcode,
            this.colitemName,
            this.colitemPrice,
            this.colitemPriceSingle,
            this.colitemPriceMany,
            this.colparentGuid,
            this.colISGroup,
            this.colDateOfInsert});
			this.treeList1.DataSource = this.tBItemBindingSource;
			this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeList1.Location = new System.Drawing.Point(0, 0);
			this.treeList1.Name = "treeList1";
			this.treeList1.OptionsPrint.PrintAllNodes = true;
			this.treeList1.OptionsPrint.PrintPreview = true;
			this.treeList1.Size = new System.Drawing.Size(1125, 512);
			this.treeList1.TabIndex = 0;
			this.treeList1.RowClick += new DevExpress.XtraTreeList.RowClickEventHandler(this.treeList1_RowClick);
			// 
			// colitemGuid
			// 
			this.colitemGuid.FieldName = "itemGuid";
			this.colitemGuid.Name = "colitemGuid";
			this.colitemGuid.OptionsColumn.ReadOnly = true;
			this.colitemGuid.Visible = true;
			this.colitemGuid.VisibleIndex = 0;
			// 
			// colitemcode
			// 
			this.colitemcode.FieldName = "itemcode";
			this.colitemcode.Name = "colitemcode";
			this.colitemcode.OptionsColumn.ReadOnly = true;
			this.colitemcode.Visible = true;
			this.colitemcode.VisibleIndex = 1;
			// 
			// colitemName
			// 
			this.colitemName.FieldName = "itemName";
			this.colitemName.Name = "colitemName";
			this.colitemName.OptionsColumn.ReadOnly = true;
			this.colitemName.Visible = true;
			this.colitemName.VisibleIndex = 2;
			// 
			// colitemPrice
			// 
			this.colitemPrice.FieldName = "itemPrice";
			this.colitemPrice.Name = "colitemPrice";
			this.colitemPrice.OptionsColumn.ReadOnly = true;
			this.colitemPrice.Visible = true;
			this.colitemPrice.VisibleIndex = 3;
			// 
			// colitemPriceSingle
			// 
			this.colitemPriceSingle.FieldName = "itemPriceSingle";
			this.colitemPriceSingle.Name = "colitemPriceSingle";
			this.colitemPriceSingle.OptionsColumn.ReadOnly = true;
			this.colitemPriceSingle.Visible = true;
			this.colitemPriceSingle.VisibleIndex = 4;
			// 
			// colitemPriceMany
			// 
			this.colitemPriceMany.FieldName = "itemPriceMany";
			this.colitemPriceMany.Name = "colitemPriceMany";
			this.colitemPriceMany.OptionsColumn.ReadOnly = true;
			this.colitemPriceMany.Visible = true;
			this.colitemPriceMany.VisibleIndex = 5;
			// 
			// colparentGuid
			// 
			this.colparentGuid.FieldName = "parentGuid";
			this.colparentGuid.Name = "colparentGuid";
			this.colparentGuid.OptionsColumn.ReadOnly = true;
			this.colparentGuid.Visible = true;
			this.colparentGuid.VisibleIndex = 6;
			// 
			// colISGroup
			// 
			this.colISGroup.FieldName = "ISGroup";
			this.colISGroup.Name = "colISGroup";
			this.colISGroup.OptionsColumn.ReadOnly = true;
			this.colISGroup.Visible = true;
			this.colISGroup.VisibleIndex = 7;
			// 
			// colDateOfInsert
			// 
			this.colDateOfInsert.FieldName = "DateOfInsert";
			this.colDateOfInsert.Name = "colDateOfInsert";
			this.colDateOfInsert.OptionsColumn.ReadOnly = true;
			this.colDateOfInsert.Visible = true;
			this.colDateOfInsert.VisibleIndex = 8;
			// 
			// tBItemBindingSource
			// 
			this.tBItemBindingSource.DataMember = "TB_Item";
			this.tBItemBindingSource.DataSource = this.billsDataSet;
			// 
			// billsDataSet
			// 
			this.billsDataSet.DataSetName = "BillsDataSet";
			this.billsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tB_ItemTableAdapter
			// 
			this.tB_ItemTableAdapter.ClearBeforeFill = true;
			// 
			// Frm_Item
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1125, 512);
			this.Controls.Add(this.treeList1);
			this.Name = "Frm_Item";
			this.Text = "Frm_Item";
			this.Load += new System.EventHandler(this.Frm_Item_Load);
			((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBItemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraTreeList.TreeList treeList1;
		private BillsDataSet billsDataSet;
		private System.Windows.Forms.BindingSource tBItemBindingSource;
		private BillsDataSetTableAdapters.TB_ItemTableAdapter tB_ItemTableAdapter;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemGuid;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemcode;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemName;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemPrice;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemPriceSingle;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemPriceMany;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colparentGuid;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colISGroup;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colDateOfInsert;
	}
}