namespace ItemStockRepoPattern.View.Forms
{
	partial class Frm_ParentItem
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
			DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ParentItem));
			this.treeList1 = new DevExpress.XtraTreeList.TreeList();
			this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
			this.colitemName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
			this.SuspendLayout();
			// 
			// treeList1
			// 
			this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colitemName});
			this.treeList1.DataMember = "TB_Item_GetParentData";
			this.treeList1.DataSource = this.sqlDataSource1;
			this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeList1.KeyFieldName = "itemGuid";
			this.treeList1.Location = new System.Drawing.Point(0, 0);
			this.treeList1.Name = "treeList1";
			this.treeList1.ParentFieldName = "parentGuid";
			this.treeList1.Size = new System.Drawing.Size(841, 459);
			this.treeList1.TabIndex = 0;
			this.treeList1.DoubleClick += new System.EventHandler(this.treeList1_DoubleClick);
			// 
			// sqlDataSource1
			// 
			this.sqlDataSource1.ConnectionName = "ItemStockRepoPattern.Properties.Settings.BillsConnectionString";
			this.sqlDataSource1.Name = "sqlDataSource1";
			storedProcQuery1.Name = "TB_Item_GetParentData";
			storedProcQuery1.StoredProcName = "TB_Item_GetParentData";
			this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
			this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
			// 
			// colitemName
			// 
			this.colitemName.FieldName = "itemName";
			this.colitemName.Name = "colitemName";
			this.colitemName.Visible = true;
			this.colitemName.VisibleIndex = 0;
			// 
			// Frm_ParentItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(841, 459);
			this.Controls.Add(this.treeList1);
			this.Name = "Frm_ParentItem";
			this.Text = "Frm_ParentItem";
			((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraTreeList.TreeList treeList1;
		private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemName;
	}
}