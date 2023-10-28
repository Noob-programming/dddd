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
			this.colitemcode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colitemName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colitemPrice = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colitemPriceSingle = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colitemPriceMany = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colISGroup = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colDateOfInsert = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.billsData1 = new ItemStockRepoPattern.BillsData();
			this.tBItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tBItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.billsData = new ItemStockRepoPattern.BillsData();
			this.tBItemBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.tB_ItemTableAdapter = new ItemStockRepoPattern.BillsDataTableAdapters.TB_ItemTableAdapter();
			this.tB_ItemTableAdapter1 = new ItemStockRepoPattern.BillsDataTableAdapters.TB_ItemTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsData1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBItemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBItemBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBItemBindingSource2)).BeginInit();
			this.SuspendLayout();
			// 
			// treeList1
			// 
			this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colitemcode,
            this.colitemName,
            this.colitemPrice,
            this.colitemPriceSingle,
            this.colitemPriceMany,
            this.colISGroup,
            this.colDateOfInsert});
			this.treeList1.DataMember = "TB_Item";
			this.treeList1.DataSource = this.billsData1;
			this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeList1.KeyFieldName = "itemGuid";
			this.treeList1.Location = new System.Drawing.Point(0, 0);
			this.treeList1.Name = "treeList1";
			this.treeList1.OptionsPrint.PrintAllNodes = true;
			this.treeList1.OptionsPrint.PrintPreview = true;
			this.treeList1.ParentFieldName = "parentGuid";
			this.treeList1.Size = new System.Drawing.Size(1125, 512);
			this.treeList1.TabIndex = 0;
			this.treeList1.DoubleClick += new System.EventHandler(this.treeList1_DoubleClick);
			// 
			// colitemcode
			// 
			this.colitemcode.FieldName = "itemcode";
			this.colitemcode.Name = "colitemcode";
			this.colitemcode.OptionsColumn.ReadOnly = true;
			this.colitemcode.Visible = true;
			this.colitemcode.VisibleIndex = 0;
			// 
			// colitemName
			// 
			this.colitemName.FieldName = "itemName";
			this.colitemName.Name = "colitemName";
			this.colitemName.OptionsColumn.ReadOnly = true;
			this.colitemName.Visible = true;
			this.colitemName.VisibleIndex = 1;
			// 
			// colitemPrice
			// 
			this.colitemPrice.FieldName = "itemPrice";
			this.colitemPrice.Name = "colitemPrice";
			this.colitemPrice.OptionsColumn.ReadOnly = true;
			this.colitemPrice.Visible = true;
			this.colitemPrice.VisibleIndex = 2;
			// 
			// colitemPriceSingle
			// 
			this.colitemPriceSingle.FieldName = "itemPriceSingle";
			this.colitemPriceSingle.Name = "colitemPriceSingle";
			this.colitemPriceSingle.OptionsColumn.ReadOnly = true;
			this.colitemPriceSingle.Visible = true;
			this.colitemPriceSingle.VisibleIndex = 3;
			// 
			// colitemPriceMany
			// 
			this.colitemPriceMany.FieldName = "itemPriceMany";
			this.colitemPriceMany.Name = "colitemPriceMany";
			this.colitemPriceMany.OptionsColumn.ReadOnly = true;
			this.colitemPriceMany.Visible = true;
			this.colitemPriceMany.VisibleIndex = 4;
			// 
			// colISGroup
			// 
			this.colISGroup.FieldName = "ISGroup";
			this.colISGroup.Name = "colISGroup";
			this.colISGroup.OptionsColumn.ReadOnly = true;
			this.colISGroup.Visible = true;
			this.colISGroup.VisibleIndex = 5;
			// 
			// colDateOfInsert
			// 
			this.colDateOfInsert.FieldName = "DateOfInsert";
			this.colDateOfInsert.Name = "colDateOfInsert";
			this.colDateOfInsert.OptionsColumn.ReadOnly = true;
			this.colDateOfInsert.Visible = true;
			this.colDateOfInsert.VisibleIndex = 6;
			// 
			// billsData1
			// 
			this.billsData1.DataSetName = "BillsData";
			this.billsData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tBItemBindingSource1
			// 
			this.tBItemBindingSource1.DataMember = "TB_Item";
			// 
			// billsData
			// 
			this.billsData.DataSetName = "BillsData";
			this.billsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tBItemBindingSource2
			// 
			this.tBItemBindingSource2.DataMember = "TB_Item";
			this.tBItemBindingSource2.DataSource = this.billsData;
			// 
			// tB_ItemTableAdapter
			// 
			this.tB_ItemTableAdapter.ClearBeforeFill = true;
			// 
			// tB_ItemTableAdapter1
			// 
			this.tB_ItemTableAdapter1.ClearBeforeFill = true;
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
			((System.ComponentModel.ISupportInitialize)(this.billsData1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBItemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBItemBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBItemBindingSource2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraTreeList.TreeList treeList1;

		private System.Windows.Forms.BindingSource tBItemBindingSource;

		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemcode;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemName;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemPrice;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemPriceSingle;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemPriceMany;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colISGroup;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colDateOfInsert;

		private System.Windows.Forms.BindingSource tBItemBindingSource1;
		private BillsData billsData;
		private System.Windows.Forms.BindingSource tBItemBindingSource2;
		private BillsDataTableAdapters.TB_ItemTableAdapter tB_ItemTableAdapter;
		private BillsData billsData1;
		private BillsDataTableAdapters.TB_ItemTableAdapter tB_ItemTableAdapter1;
	}
}