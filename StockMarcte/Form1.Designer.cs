namespace StockMarcte
{
	partial class Form1
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
			this.NewItem = new DevExpress.XtraEditors.SimpleButton();
			this.status = new DevExpress.XtraEditors.ToggleSwitch();
			this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.txtQuintity = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.tBStockItemBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.billsDataSet1 = new StockMarcte.BillsDataSet1();
			this.tBStockItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.viewShowstockBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.billsDataSet = new StockMarcte.BillsDataSet();
			this.billsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.view_Show_stockTableAdapter = new StockMarcte.BillsDataSet1TableAdapters.View_Show_stockTableAdapter();
			this.tB_StockItemTableAdapter = new StockMarcte.BillsDataSet1TableAdapters.TB_StockItemTableAdapter();
			this.tBStockItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.tBStockItemBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.tB_StockItemTableAdapter1 = new StockMarcte.BillsDataSetTableAdapters.TB_StockItemTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.status.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQuintity.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBStockItemBindingSource3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBStockItemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.viewShowstockBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBStockItemBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBStockItemBindingSource2)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.NewItem);
			this.panelControl1.Controls.Add(this.status);
			this.panelControl1.Controls.Add(this.lookUpEdit1);
			this.panelControl1.Controls.Add(this.simpleButton2);
			this.panelControl1.Controls.Add(this.simpleButton1);
			this.panelControl1.Controls.Add(this.txtQuintity);
			this.panelControl1.Controls.Add(this.labelControl3);
			this.panelControl1.Controls.Add(this.labelControl2);
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Controls.Add(this.gridControl1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(993, 620);
			this.panelControl1.TabIndex = 1;
			// 
			// NewItem
			// 
			this.NewItem.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NewItem.Appearance.Options.UseFont = true;
			this.NewItem.Location = new System.Drawing.Point(168, 182);
			this.NewItem.Name = "NewItem";
			this.NewItem.Size = new System.Drawing.Size(196, 41);
			this.NewItem.TabIndex = 12;
			this.NewItem.Text = "New";
			this.NewItem.Click += new System.EventHandler(this.NewItem_Click);
			// 
			// status
			// 
			this.status.Location = new System.Drawing.Point(168, 45);
			this.status.Name = "status";
			this.status.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.status.Properties.Appearance.Options.UseFont = true;
			this.status.Properties.OffText = "In";
			this.status.Properties.OnText = "Out";
			this.status.Size = new System.Drawing.Size(196, 26);
			this.status.TabIndex = 11;
			// 
			// lookUpEdit1
			// 
			this.lookUpEdit1.Location = new System.Drawing.Point(168, 9);
			this.lookUpEdit1.Name = "lookUpEdit1";
			this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
			this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("itemGuid", "Name1", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("itemName", "Name2")});
			this.lookUpEdit1.Properties.NullText = "";
			this.lookUpEdit1.Size = new System.Drawing.Size(196, 28);
			this.lookUpEdit1.TabIndex = 10;
			// 
			// simpleButton2
			// 
			this.simpleButton2.Location = new System.Drawing.Point(370, 182);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(196, 41);
			this.simpleButton2.TabIndex = 9;
			this.simpleButton2.Text = "Delete";
			this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(168, 121);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(196, 38);
			this.simpleButton1.TabIndex = 8;
			this.simpleButton1.Text = "Save";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// txtQuintity
			// 
			this.txtQuintity.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.txtQuintity.Location = new System.Drawing.Point(168, 77);
			this.txtQuintity.Name = "txtQuintity";
			this.txtQuintity.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuintity.Properties.Appearance.Options.UseFont = true;
			this.txtQuintity.Size = new System.Drawing.Size(196, 28);
			this.txtQuintity.TabIndex = 7;
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(12, 80);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(80, 21);
			this.labelControl3.TabIndex = 5;
			this.labelControl3.Text = "Quintity";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(12, 46);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(60, 21);
			this.labelControl2.TabIndex = 4;
			this.labelControl2.Text = "status";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(12, 12);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(90, 21);
			this.labelControl1.TabIndex = 3;
			this.labelControl1.Text = "item Name";
			// 
			// gridControl1
			// 
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridControl1.Location = new System.Drawing.Point(2, 286);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(989, 332);
			this.gridControl1.TabIndex = 1;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowFooter = true;
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "ItemGuid";
			this.gridColumn1.FieldName = "itemGuid";
			this.gridColumn1.Name = "gridColumn1";
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "itemName";
			this.gridColumn2.FieldName = "itemName";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 0;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "status";
			this.gridColumn3.FieldName = "status";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 1;
			// 
			// gridColumn4
			// 
			this.gridColumn4.Caption = "Quintity";
			this.gridColumn4.FieldName = "Quintity";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 2;
			// 
			// tBStockItemBindingSource3
			// 
			this.tBStockItemBindingSource3.DataMember = "TB_StockItem";
			this.tBStockItemBindingSource3.DataSource = this.billsDataSet1;
			// 
			// billsDataSet1
			// 
			this.billsDataSet1.DataSetName = "BillsDataSet1";
			this.billsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tBStockItemBindingSource
			// 
			this.tBStockItemBindingSource.DataMember = "TB_StockItem";
			this.tBStockItemBindingSource.DataSource = this.billsDataSet1;
			// 
			// viewShowstockBindingSource
			// 
			this.viewShowstockBindingSource.DataMember = "View_Show_stock";
			this.viewShowstockBindingSource.DataSource = this.billsDataSet1;
			// 
			// billsDataSet
			// 
			this.billsDataSet.DataSetName = "BillsDataSet";
			this.billsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// billsDataSetBindingSource
			// 
			this.billsDataSetBindingSource.DataSource = this.billsDataSet;
			this.billsDataSetBindingSource.Position = 0;
			// 
			// view_Show_stockTableAdapter
			// 
			this.view_Show_stockTableAdapter.ClearBeforeFill = true;
			// 
			// tB_StockItemTableAdapter
			// 
			this.tB_StockItemTableAdapter.ClearBeforeFill = true;
			// 
			// tBStockItemBindingSource1
			// 
			this.tBStockItemBindingSource1.DataMember = "TB_StockItem";
			this.tBStockItemBindingSource1.DataSource = this.billsDataSet1;
			// 
			// tBStockItemBindingSource2
			// 
			this.tBStockItemBindingSource2.DataMember = "TB_StockItem";
			this.tBStockItemBindingSource2.DataSource = this.billsDataSetBindingSource;
			// 
			// tB_StockItemTableAdapter1
			// 
			this.tB_StockItemTableAdapter1.ClearBeforeFill = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(993, 620);
			this.Controls.Add(this.panelControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.status.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQuintity.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBStockItemBindingSource3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBStockItemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.viewShowstockBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBStockItemBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBStockItemBindingSource2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.TextEdit txtQuintity;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private System.Windows.Forms.BindingSource billsDataSetBindingSource;
		private BillsDataSet billsDataSet;
		private BillsDataSet1 billsDataSet1;
		private System.Windows.Forms.BindingSource viewShowstockBindingSource;
		private BillsDataSet1TableAdapters.View_Show_stockTableAdapter view_Show_stockTableAdapter;
		private System.Windows.Forms.BindingSource tBStockItemBindingSource;
		private BillsDataSet1TableAdapters.TB_StockItemTableAdapter tB_StockItemTableAdapter;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
		private System.Windows.Forms.BindingSource tBStockItemBindingSource1;
		private DevExpress.XtraEditors.ToggleSwitch status;
		private System.Windows.Forms.BindingSource tBStockItemBindingSource2;
		private BillsDataSetTableAdapters.TB_StockItemTableAdapter tB_StockItemTableAdapter1;
		private System.Windows.Forms.BindingSource tBStockItemBindingSource3;
		private DevExpress.XtraEditors.SimpleButton NewItem;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
	}
}

