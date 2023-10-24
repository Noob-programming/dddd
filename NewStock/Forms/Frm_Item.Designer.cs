namespace NewStock.Forms
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
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
			this.treeList1 = new DevExpress.XtraTreeList.TreeList();
			this.colitemcode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colitemName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colitemPrice = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colitemPriceSingle = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colitemPriceMany = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colISGroup = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colDateOfInsert = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.billsDB2 = new NewStock.BillsDB();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.billsDB1 = new NewStock.BillsDB();
			this.tB_ItemTableAdapter1 = new NewStock.BillsDBTableAdapters.TB_ItemTableAdapter();
			this.tBItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tB_ItemTableAdapter2 = new NewStock.BillsDBTableAdapters.TB_ItemTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
			this.panelControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDB2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDB1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBItemBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.panelControl3);
			this.panelControl1.Controls.Add(this.panelControl2);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(799, 452);
			this.panelControl1.TabIndex = 0;
			// 
			// panelControl3
			// 
			this.panelControl3.Controls.Add(this.treeList1);
			this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl3.Location = new System.Drawing.Point(202, 2);
			this.panelControl3.Name = "panelControl3";
			this.panelControl3.Size = new System.Drawing.Size(595, 448);
			this.panelControl3.TabIndex = 1;
			// 
			// treeList1
			// 
			this.treeList1.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.treeList1.Appearance.TreeLine.BorderColor = System.Drawing.Color.White;
			this.treeList1.Appearance.TreeLine.ForeColor = System.Drawing.Color.Black;
			this.treeList1.Appearance.TreeLine.Options.UseBackColor = true;
			this.treeList1.Appearance.TreeLine.Options.UseBorderColor = true;
			this.treeList1.Appearance.TreeLine.Options.UseForeColor = true;
			this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colitemcode,
            this.colitemName,
            this.colitemPrice,
            this.colitemPriceSingle,
            this.colitemPriceMany,
            this.colISGroup,
            this.colDateOfInsert});
			this.treeList1.DataMember = "TB_Item";
			this.treeList1.DataSource = this.billsDB2;
			this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeList1.ImeMode = System.Windows.Forms.ImeMode.On;
			this.treeList1.KeyFieldName = "itemGuid";
			this.treeList1.Location = new System.Drawing.Point(2, 2);
			this.treeList1.Name = "treeList1";
			this.treeList1.ParentFieldName = "parentGuid";
			this.treeList1.Size = new System.Drawing.Size(591, 444);
			this.treeList1.TabIndex = 0;
			this.treeList1.DoubleClick += new System.EventHandler(this.treeList1_DoubleClick);
			// 
			// colitemcode
			// 
			this.colitemcode.FieldName = "itemcode";
			this.colitemcode.Name = "colitemcode";
			this.colitemcode.OptionsColumn.AllowEdit = false;
			this.colitemcode.Visible = true;
			this.colitemcode.VisibleIndex = 0;
			// 
			// colitemName
			// 
			this.colitemName.FieldName = "itemName";
			this.colitemName.Name = "colitemName";
			this.colitemName.OptionsColumn.AllowEdit = false;
			this.colitemName.Visible = true;
			this.colitemName.VisibleIndex = 1;
			// 
			// colitemPrice
			// 
			this.colitemPrice.FieldName = "itemPrice";
			this.colitemPrice.Name = "colitemPrice";
			this.colitemPrice.OptionsColumn.AllowEdit = false;
			this.colitemPrice.Visible = true;
			this.colitemPrice.VisibleIndex = 2;
			// 
			// colitemPriceSingle
			// 
			this.colitemPriceSingle.FieldName = "itemPriceSingle";
			this.colitemPriceSingle.Name = "colitemPriceSingle";
			this.colitemPriceSingle.OptionsColumn.AllowEdit = false;
			this.colitemPriceSingle.Visible = true;
			this.colitemPriceSingle.VisibleIndex = 3;
			// 
			// colitemPriceMany
			// 
			this.colitemPriceMany.FieldName = "itemPriceMany";
			this.colitemPriceMany.Name = "colitemPriceMany";
			this.colitemPriceMany.OptionsColumn.AllowEdit = false;
			this.colitemPriceMany.Visible = true;
			this.colitemPriceMany.VisibleIndex = 4;
			// 
			// colISGroup
			// 
			this.colISGroup.FieldName = "ISGroup";
			this.colISGroup.Name = "colISGroup";
			this.colISGroup.OptionsColumn.AllowEdit = false;
			this.colISGroup.Visible = true;
			this.colISGroup.VisibleIndex = 5;
			// 
			// colDateOfInsert
			// 
			this.colDateOfInsert.FieldName = "DateOfInsert";
			this.colDateOfInsert.Name = "colDateOfInsert";
			this.colDateOfInsert.OptionsColumn.AllowEdit = false;
			this.colDateOfInsert.Visible = true;
			this.colDateOfInsert.VisibleIndex = 6;
			// 
			// billsDB2
			// 
			this.billsDB2.DataSetName = "BillsDB";
			this.billsDB2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// panelControl2
			// 
			this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelControl2.Location = new System.Drawing.Point(2, 2);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(200, 448);
			this.panelControl2.TabIndex = 0;
			// 
			// billsDB1
			// 
			this.billsDB1.DataSetName = "BillsDB";
			this.billsDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tB_ItemTableAdapter1
			// 
			this.tB_ItemTableAdapter1.ClearBeforeFill = true;
			// 
			// tBItemBindingSource
			// 
			this.tBItemBindingSource.DataMember = "TB_Item";
			this.tBItemBindingSource.DataSource = this.billsDB1;
			// 
			// tB_ItemTableAdapter2
			// 
			this.tB_ItemTableAdapter2.ClearBeforeFill = true;
			// 
			// Frm_Item
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(799, 452);
			this.Controls.Add(this.panelControl1);
			this.Name = "Frm_Item";
			this.Text = "Frm_Item";
			this.Load += new System.EventHandler(this.Frm_Item_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
			this.panelControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDB2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDB1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBItemBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.PanelControl panelControl3;
		private DevExpress.XtraTreeList.TreeList treeList1;
		private DevExpress.XtraEditors.PanelControl panelControl2;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemcode;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemName;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemPrice;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemPriceSingle;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemPriceMany;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colISGroup;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colDateOfInsert;
		private BillsDB billsDB1;
		private BillsDBTableAdapters.TB_ItemTableAdapter tB_ItemTableAdapter1;
		private System.Windows.Forms.BindingSource tBItemBindingSource;
		private BillsDB billsDB2;
		private BillsDBTableAdapters.TB_ItemTableAdapter tB_ItemTableAdapter2;
	}
}