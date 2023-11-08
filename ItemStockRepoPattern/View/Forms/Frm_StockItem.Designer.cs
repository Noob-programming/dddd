namespace ItemStockRepoPattern.View.Forms
{
	partial class Frm_StockItem
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
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.Lookitem = new DevExpress.XtraEditors.LookUpEdit();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
			this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.tBStockItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.billsData = new ItemStockRepoPattern.BillsData();
			this.tB_StockItemTableAdapter = new ItemStockRepoPattern.BillsDataTableAdapters.TB_StockItemTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Lookitem.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBStockItemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsData)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.layoutControl1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1086, 540);
			this.panelControl1.TabIndex = 0;
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.labelControl1);
			this.layoutControl1.Controls.Add(this.Lookitem);
			this.layoutControl1.Controls.Add(this.gridControl1);
			this.layoutControl1.Controls.Add(this.simpleButton3);
			this.layoutControl1.Controls.Add(this.simpleButton2);
			this.layoutControl1.Controls.Add(this.simpleButton1);
			this.layoutControl1.Controls.Add(this.toggleSwitch1);
			this.layoutControl1.Controls.Add(this.textEdit2);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(2, 2);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(1082, 536);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(12, 84);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(60, 21);
			this.labelControl1.StyleController = this.layoutControl1;
			this.labelControl1.TabIndex = 12;
			this.labelControl1.Text = "Status";
			// 
			// Lookitem
			// 
			this.Lookitem.Location = new System.Drawing.Point(114, 12);
			this.Lookitem.Name = "Lookitem";
			this.Lookitem.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lookitem.Properties.Appearance.Options.UseFont = true;
			this.Lookitem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Lookitem.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("itemName", "Item Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("itemGuid", "Guid", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.Lookitem.Properties.NullText = "";
			this.Lookitem.Size = new System.Drawing.Size(956, 32);
			this.Lookitem.StyleController = this.layoutControl1;
			this.Lookitem.TabIndex = 11;
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(12, 182);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1058, 342);
			this.gridControl1.TabIndex = 10;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
			// 
			// simpleButton3
			// 
			this.simpleButton3.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButton3.Appearance.Options.UseFont = true;
			this.simpleButton3.Location = new System.Drawing.Point(543, 114);
			this.simpleButton3.Name = "simpleButton3";
			this.simpleButton3.Size = new System.Drawing.Size(527, 30);
			this.simpleButton3.StyleController = this.layoutControl1;
			this.simpleButton3.TabIndex = 9;
			this.simpleButton3.Text = "Save";
			this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
			// 
			// simpleButton2
			// 
			this.simpleButton2.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButton2.Appearance.Options.UseFont = true;
			this.simpleButton2.Location = new System.Drawing.Point(12, 148);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(1058, 30);
			this.simpleButton2.StyleController = this.layoutControl1;
			this.simpleButton2.TabIndex = 8;
			this.simpleButton2.Text = "Delete";
			this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
			// 
			// simpleButton1
			// 
			this.simpleButton1.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButton1.Appearance.Options.UseFont = true;
			this.simpleButton1.Location = new System.Drawing.Point(12, 114);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(527, 30);
			this.simpleButton1.StyleController = this.layoutControl1;
			this.simpleButton1.TabIndex = 7;
			this.simpleButton1.Text = "ADD";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// toggleSwitch1
			// 
			this.toggleSwitch1.Location = new System.Drawing.Point(76, 84);
			this.toggleSwitch1.Name = "toggleSwitch1";
			this.toggleSwitch1.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toggleSwitch1.Properties.Appearance.Options.UseFont = true;
			this.toggleSwitch1.Properties.OffText = "OUT";
			this.toggleSwitch1.Properties.OnText = "IN";
			this.toggleSwitch1.Size = new System.Drawing.Size(994, 26);
			this.toggleSwitch1.StyleController = this.layoutControl1;
			this.toggleSwitch1.TabIndex = 6;
			// 
			// textEdit2
			// 
			this.textEdit2.Location = new System.Drawing.Point(114, 48);
			this.textEdit2.Name = "textEdit2";
			this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textEdit2.Properties.Appearance.Options.UseFont = true;
			this.textEdit2.Size = new System.Drawing.Size(956, 32);
			this.textEdit2.StyleController = this.layoutControl1;
			this.textEdit2.TabIndex = 5;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem1,
            this.layoutControlItem8,
            this.layoutControlItem5,
            this.layoutControlItem6});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1082, 536);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem2.Control = this.textEdit2;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 36);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(1062, 36);
			this.layoutControlItem2.Text = "Quintity";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(90, 21);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.toggleSwitch1;
			this.layoutControlItem3.Location = new System.Drawing.Point(64, 72);
			this.layoutControlItem3.MinSize = new System.Drawing.Size(114, 30);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(998, 30);
			this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.simpleButton1;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 102);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(531, 34);
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem7
			// 
			this.layoutControlItem7.Control = this.gridControl1;
			this.layoutControlItem7.Location = new System.Drawing.Point(0, 170);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Size = new System.Drawing.Size(1062, 346);
			this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem7.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem1.Control = this.Lookitem;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1062, 36);
			this.layoutControlItem1.Text = "Item Name";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(90, 21);
			// 
			// layoutControlItem8
			// 
			this.layoutControlItem8.Control = this.labelControl1;
			this.layoutControlItem8.Location = new System.Drawing.Point(0, 72);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Size = new System.Drawing.Size(64, 30);
			this.layoutControlItem8.Text = "Status";
			this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem8.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.simpleButton2;
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 136);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(1062, 34);
			this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.simpleButton3;
			this.layoutControlItem6.Location = new System.Drawing.Point(531, 102);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(531, 34);
			this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			// 
			// tBStockItemBindingSource
			// 
			this.tBStockItemBindingSource.DataMember = "TB_StockItem";
			this.tBStockItemBindingSource.DataSource = this.billsData;
			// 
			// billsData
			// 
			this.billsData.DataSetName = "BillsData";
			this.billsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tB_StockItemTableAdapter
			// 
			this.tB_StockItemTableAdapter.ClearBeforeFill = true;
			// 
			// Frm_StockItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1086, 540);
			this.Controls.Add(this.panelControl1);
			this.Name = "Frm_StockItem";
			this.Text = "StockItem";
			this.Load += new System.EventHandler(this.Frm_StockItem_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Lookitem.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBStockItemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsData)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraEditors.TextEdit textEdit2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LookUpEdit Lookitem;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.SimpleButton simpleButton3;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
		private BillsData billsData;
		private System.Windows.Forms.BindingSource tBStockItemBindingSource;
		private BillsDataTableAdapters.TB_StockItemTableAdapter tB_StockItemTableAdapter;
	}
}