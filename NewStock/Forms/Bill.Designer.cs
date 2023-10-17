namespace NewStock.Forms
{
	partial class Bill
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
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.billsDB1 = new NewStock.BillsDB();
			this.tB_BillTableAdapter1 = new NewStock.BillsDBTableAdapters.TB_BillTableAdapter();
			this.colBillGuid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBillcode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBillDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBillType = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDB1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.DataMember = "TB_Bill";
			this.gridControl1.DataSource = this.billsDB1;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1007, 538);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBillGuid,
            this.colBillcode,
            this.colBillDate,
            this.colNotes,
            this.colBillType});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
			// 
			// billsDB1
			// 
			this.billsDB1.DataSetName = "BillsDB";
			this.billsDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tB_BillTableAdapter1
			// 
			this.tB_BillTableAdapter1.ClearBeforeFill = true;
			// 
			// colBillGuid
			// 
			this.colBillGuid.FieldName = "BillGuid";
			this.colBillGuid.Name = "colBillGuid";
			this.colBillGuid.Visible = true;
			this.colBillGuid.VisibleIndex = 0;
			// 
			// colBillcode
			// 
			this.colBillcode.FieldName = "Billcode";
			this.colBillcode.Name = "colBillcode";
			this.colBillcode.Visible = true;
			this.colBillcode.VisibleIndex = 1;
			// 
			// colBillDate
			// 
			this.colBillDate.FieldName = "BillDate";
			this.colBillDate.Name = "colBillDate";
			this.colBillDate.Visible = true;
			this.colBillDate.VisibleIndex = 2;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 3;
			// 
			// colBillType
			// 
			this.colBillType.FieldName = "BillType";
			this.colBillType.Name = "colBillType";
			this.colBillType.Visible = true;
			this.colBillType.VisibleIndex = 4;
			// 
			// Bill
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1007, 538);
			this.Controls.Add(this.gridControl1);
			this.Name = "Bill";
			this.Text = "Bills";
			this.Load += new System.EventHandler(this.Bill_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDB1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private BillsDB billsDB1;
		private DevExpress.XtraGrid.Columns.GridColumn colBillGuid;
		private DevExpress.XtraGrid.Columns.GridColumn colBillcode;
		private DevExpress.XtraGrid.Columns.GridColumn colBillDate;
		private DevExpress.XtraGrid.Columns.GridColumn colNotes;
		private DevExpress.XtraGrid.Columns.GridColumn colBillType;
		private BillsDBTableAdapters.TB_BillTableAdapter tB_BillTableAdapter1;
	}
}