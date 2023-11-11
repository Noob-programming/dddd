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
			this.Delete = new DevExpress.XtraEditors.SimpleButton();
			this.Add = new DevExpress.XtraEditors.SimpleButton();
			this.Save = new DevExpress.XtraEditors.SimpleButton();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.stockModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colItemGuid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitemName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			this.QuantityTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.ItemGuidTextEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.StatusTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.ItemForItemGuid = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForStatus = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForQuantity = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stockModelBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
			this.dataLayoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.QuantityTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemGuidTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StatusTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForItemGuid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForQuantity)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.layoutControl1);
			this.panelControl1.Controls.Add(this.dataLayoutControl1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1086, 740);
			this.panelControl1.TabIndex = 0;
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.Delete);
			this.layoutControl1.Controls.Add(this.Add);
			this.layoutControl1.Controls.Add(this.Save);
			this.layoutControl1.Controls.Add(this.gridControl1);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(2, 158);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(1082, 580);
			this.layoutControl1.TabIndex = 1;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// Delete
			// 
			this.Delete.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Delete.Appearance.Options.UseFont = true;
			this.Delete.Location = new System.Drawing.Point(12, 80);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(1058, 30);
			this.Delete.StyleController = this.layoutControl1;
			this.Delete.TabIndex = 7;
			this.Delete.Text = "Delete";
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// Add
			// 
			this.Add.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Add.Appearance.Options.UseFont = true;
			this.Add.Location = new System.Drawing.Point(12, 46);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(1058, 30);
			this.Add.StyleController = this.layoutControl1;
			this.Add.TabIndex = 6;
			this.Add.Text = "Add";
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// Save
			// 
			this.Save.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Save.Appearance.Options.UseFont = true;
			this.Save.Location = new System.Drawing.Point(12, 12);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(1058, 30);
			this.Save.StyleController = this.layoutControl1;
			this.Save.TabIndex = 5;
			this.Save.Text = "Save";
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.stockModelBindingSource;
			this.gridControl1.Location = new System.Drawing.Point(12, 114);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1058, 454);
			this.gridControl1.TabIndex = 4;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// stockModelBindingSource
			// 
			this.stockModelBindingSource.DataSource = typeof(ItemStockRepoPattern.Model.StockModel);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemGuid,
            this.colitemName,
            this.colStatus,
            this.colQuantity});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
			// 
			// colItemGuid
			// 
			this.colItemGuid.FieldName = "ItemGuid";
			this.colItemGuid.Name = "colItemGuid";
			// 
			// colitemName
			// 
			this.colitemName.FieldName = "itemName";
			this.colitemName.Name = "colitemName";
			this.colitemName.Visible = true;
			this.colitemName.VisibleIndex = 0;
			// 
			// colStatus
			// 
			this.colStatus.FieldName = "Status";
			this.colStatus.Name = "colStatus";
			this.colStatus.Visible = true;
			this.colStatus.VisibleIndex = 1;
			// 
			// colQuantity
			// 
			this.colQuantity.FieldName = "Quantity";
			this.colQuantity.Name = "colQuantity";
			this.colQuantity.Visible = true;
			this.colQuantity.VisibleIndex = 2;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(1082, 580);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gridControl1;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 102);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1062, 458);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.Save;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(1062, 34);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.Add;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 34);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(1062, 34);
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.Delete;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 68);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(1062, 34);
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// dataLayoutControl1
			// 
			this.dataLayoutControl1.Controls.Add(this.QuantityTextEdit);
			this.dataLayoutControl1.Controls.Add(this.ItemGuidTextEdit);
			this.dataLayoutControl1.Controls.Add(this.StatusTextEdit);
			this.dataLayoutControl1.DataSource = this.stockModelBindingSource;
			this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.dataLayoutControl1.Location = new System.Drawing.Point(2, 2);
			this.dataLayoutControl1.Name = "dataLayoutControl1";
			this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1270, 0, 650, 400);
			this.dataLayoutControl1.Root = this.Root;
			this.dataLayoutControl1.Size = new System.Drawing.Size(1082, 156);
			this.dataLayoutControl1.TabIndex = 0;
			this.dataLayoutControl1.Text = "dataLayoutControl1";
			// 
			// QuantityTextEdit
			// 
			this.QuantityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stockModelBindingSource, "Quantity", true));
			this.QuantityTextEdit.Location = new System.Drawing.Point(114, 76);
			this.QuantityTextEdit.Name = "QuantityTextEdit";
			this.QuantityTextEdit.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.QuantityTextEdit.Properties.Appearance.Options.UseFont = true;
			this.QuantityTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.QuantityTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.QuantityTextEdit.Properties.MaskSettings.Set("mask", "G");
			this.QuantityTextEdit.Size = new System.Drawing.Size(956, 28);
			this.QuantityTextEdit.StyleController = this.dataLayoutControl1;
			this.QuantityTextEdit.TabIndex = 6;
			// 
			// ItemGuidTextEdit
			// 
			this.ItemGuidTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stockModelBindingSource, "ItemGuid", true));
			this.ItemGuidTextEdit.Location = new System.Drawing.Point(114, 12);
			this.ItemGuidTextEdit.Name = "ItemGuidTextEdit";
			this.ItemGuidTextEdit.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemGuidTextEdit.Properties.Appearance.Options.UseFont = true;
			this.ItemGuidTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ItemGuidTextEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("itemGuid", "Name1", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("itemName", "اسم العنصر")});
			this.ItemGuidTextEdit.Properties.NullText = "";
			this.ItemGuidTextEdit.Size = new System.Drawing.Size(956, 28);
			this.ItemGuidTextEdit.StyleController = this.dataLayoutControl1;
			this.ItemGuidTextEdit.TabIndex = 4;
			// 
			// StatusTextEdit
			// 
			this.StatusTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stockModelBindingSource, "Status", true));
			this.StatusTextEdit.EditValue = "";
			this.StatusTextEdit.Location = new System.Drawing.Point(114, 44);
			this.StatusTextEdit.Name = "StatusTextEdit";
			this.StatusTextEdit.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StatusTextEdit.Properties.Appearance.Options.UseFont = true;
			this.StatusTextEdit.Size = new System.Drawing.Size(956, 28);
			this.StatusTextEdit.StyleController = this.dataLayoutControl1;
			this.StatusTextEdit.TabIndex = 5;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1082, 156);
			this.Root.TextVisible = false;
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.AllowDrawBackground = false;
			this.layoutControlGroup2.GroupBordersVisible = false;
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForItemGuid,
            this.ItemForStatus,
            this.ItemForQuantity});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup2.Name = "autoGeneratedGroup0";
			this.layoutControlGroup2.Size = new System.Drawing.Size(1062, 136);
			// 
			// ItemForItemGuid
			// 
			this.ItemForItemGuid.AppearanceItemCaption.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemForItemGuid.AppearanceItemCaption.Options.UseFont = true;
			this.ItemForItemGuid.Control = this.ItemGuidTextEdit;
			this.ItemForItemGuid.Location = new System.Drawing.Point(0, 0);
			this.ItemForItemGuid.Name = "ItemForItemGuid";
			this.ItemForItemGuid.Size = new System.Drawing.Size(1062, 32);
			this.ItemForItemGuid.Text = "Item Guid";
			this.ItemForItemGuid.TextSize = new System.Drawing.Size(90, 21);
			// 
			// ItemForStatus
			// 
			this.ItemForStatus.AppearanceItemCaption.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemForStatus.AppearanceItemCaption.Options.UseFont = true;
			this.ItemForStatus.Control = this.StatusTextEdit;
			this.ItemForStatus.Location = new System.Drawing.Point(0, 32);
			this.ItemForStatus.Name = "ItemForStatus";
			this.ItemForStatus.Size = new System.Drawing.Size(1062, 32);
			this.ItemForStatus.Text = "Status";
			this.ItemForStatus.TextSize = new System.Drawing.Size(90, 21);
			// 
			// ItemForQuantity
			// 
			this.ItemForQuantity.AppearanceItemCaption.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemForQuantity.AppearanceItemCaption.Options.UseFont = true;
			this.ItemForQuantity.Control = this.QuantityTextEdit;
			this.ItemForQuantity.Location = new System.Drawing.Point(0, 64);
			this.ItemForQuantity.Name = "ItemForQuantity";
			this.ItemForQuantity.Size = new System.Drawing.Size(1062, 72);
			this.ItemForQuantity.Text = "Quantity";
			this.ItemForQuantity.TextSize = new System.Drawing.Size(90, 21);
			// 
			// Frm_StockItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1086, 740);
			this.Controls.Add(this.panelControl1);
			this.Name = "Frm_StockItem";
			this.Text = "StockItem";
			this.Load += new System.EventHandler(this.Frm_StockItem_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stockModelBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
			this.dataLayoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.QuantityTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemGuidTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StatusTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForItemGuid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForQuantity)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private System.Windows.Forms.BindingSource stockModelBindingSource;
		private DevExpress.XtraEditors.TextEdit QuantityTextEdit;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem ItemForItemGuid;
		private DevExpress.XtraLayout.LayoutControlItem ItemForStatus;
		private DevExpress.XtraLayout.LayoutControlItem ItemForQuantity;
		private DevExpress.XtraEditors.SimpleButton Delete;
		private DevExpress.XtraEditors.SimpleButton Add;
		private DevExpress.XtraEditors.SimpleButton Save;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraEditors.LookUpEdit ItemGuidTextEdit;
		private DevExpress.XtraEditors.TextEdit StatusTextEdit;
		private DevExpress.XtraGrid.Columns.GridColumn colItemGuid;
		private DevExpress.XtraGrid.Columns.GridColumn colitemName;
		private DevExpress.XtraGrid.Columns.GridColumn colStatus;
		private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
	}
}