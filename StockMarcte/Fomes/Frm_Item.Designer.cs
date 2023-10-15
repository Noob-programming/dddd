namespace StockMarcte.Fomes
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
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.billsDataSet2 = new StockMarcte.BillsDataSet2();
			this.tBItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tB_ItemTableAdapter = new StockMarcte.BillsDataSet2TableAdapters.TB_ItemTableAdapter();
			this.treeListBand1 = new DevExpress.XtraTreeList.Columns.TreeListBand();
			this.treeList1 = new DevExpress.XtraTreeList.TreeList();
			this.billsdata1 = new StockMarcte.Billsdata();
			this.tB_ItemTableAdapter1 = new StockMarcte.BillsDataSet1TableAdapters.TB_ItemTableAdapter();
			this.colitemcode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colitemName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colitemPrice = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colitemPriceSingle = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colitemPriceMany = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colISGroup = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colDateOfInsert = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			this.panelControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBItemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsdata1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.panelControl2);
			this.groupControl1.Controls.Add(this.panelControl1);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupControl1.Location = new System.Drawing.Point(0, 0);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(873, 454);
			this.groupControl1.TabIndex = 0;
			this.groupControl1.Text = "groupControl1";
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.simpleButton1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelControl1.Location = new System.Drawing.Point(2, 23);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(200, 429);
			this.panelControl1.TabIndex = 0;
			// 
			// panelControl2
			// 
			this.panelControl2.Controls.Add(this.treeList1);
			this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl2.Location = new System.Drawing.Point(202, 23);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(669, 429);
			this.panelControl2.TabIndex = 1;
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(23, 5);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(159, 63);
			this.simpleButton1.TabIndex = 0;
			this.simpleButton1.Text = "simpleButton1";
			// 
			// billsDataSet2
			// 
			this.billsDataSet2.DataSetName = "BillsDataSet2";
			this.billsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tBItemBindingSource
			// 
			this.tBItemBindingSource.DataMember = "TB_Item";
			this.tBItemBindingSource.DataSource = this.billsDataSet2;
			// 
			// tB_ItemTableAdapter
			// 
			this.tB_ItemTableAdapter.ClearBeforeFill = true;
			// 
			// treeListBand1
			// 
			this.treeListBand1.Caption = "treeListBand1";
			this.treeListBand1.Name = "treeListBand1";
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
			this.treeList1.DataSource = this.billsdata1;
			this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeList1.KeyFieldName = "itemGuid";
			this.treeList1.Location = new System.Drawing.Point(2, 2);
			this.treeList1.Name = "treeList1";
			this.treeList1.ParentFieldName = "parentGuid";
			this.treeList1.Size = new System.Drawing.Size(665, 425);
			this.treeList1.TabIndex = 0;
			// 
			// billsdata1
			// 
			this.billsdata1.DataSetName = "Billsdata";
			this.billsdata1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tB_ItemTableAdapter1
			// 
			this.tB_ItemTableAdapter1.ClearBeforeFill = true;
			// 
			// colitemcode
			// 
			this.colitemcode.FieldName = "itemcode";
			this.colitemcode.Name = "colitemcode";
			this.colitemcode.Visible = true;
			this.colitemcode.VisibleIndex = 0;
			// 
			// colitemName
			// 
			this.colitemName.FieldName = "itemName";
			this.colitemName.Name = "colitemName";
			this.colitemName.Visible = true;
			this.colitemName.VisibleIndex = 1;
			// 
			// colitemPrice
			// 
			this.colitemPrice.FieldName = "itemPrice";
			this.colitemPrice.Name = "colitemPrice";
			this.colitemPrice.Visible = true;
			this.colitemPrice.VisibleIndex = 2;
			// 
			// colitemPriceSingle
			// 
			this.colitemPriceSingle.FieldName = "itemPriceSingle";
			this.colitemPriceSingle.Name = "colitemPriceSingle";
			this.colitemPriceSingle.Visible = true;
			this.colitemPriceSingle.VisibleIndex = 3;
			// 
			// colitemPriceMany
			// 
			this.colitemPriceMany.FieldName = "itemPriceMany";
			this.colitemPriceMany.Name = "colitemPriceMany";
			this.colitemPriceMany.Visible = true;
			this.colitemPriceMany.VisibleIndex = 4;
			// 
			// colISGroup
			// 
			this.colISGroup.FieldName = "ISGroup";
			this.colISGroup.Name = "colISGroup";
			this.colISGroup.Visible = true;
			this.colISGroup.VisibleIndex = 5;
			// 
			// colDateOfInsert
			// 
			this.colDateOfInsert.FieldName = "DateOfInsert";
			this.colDateOfInsert.Name = "colDateOfInsert";
			this.colDateOfInsert.Visible = true;
			this.colDateOfInsert.VisibleIndex = 6;
			// 
			// Frm_Item
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(873, 454);
			this.Controls.Add(this.groupControl1);
			this.Name = "Frm_Item";
			this.Text = "Frm_Item";
			this.Load += new System.EventHandler(this.Frm_Item_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			this.panelControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBItemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsdata1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.PanelControl panelControl2;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private BillsDataSet2 billsDataSet2;
		private System.Windows.Forms.BindingSource tBItemBindingSource;
		private BillsDataSet2TableAdapters.TB_ItemTableAdapter tB_ItemTableAdapter;
		private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand1;
		private DevExpress.XtraTreeList.TreeList treeList1;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemcode;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemName;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemPrice;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemPriceSingle;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemPriceMany;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colISGroup;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colDateOfInsert;
		private Billsdata billsdata1;
		private BillsDataSet1TableAdapters.TB_ItemTableAdapter tB_ItemTableAdapter1;
	}
}