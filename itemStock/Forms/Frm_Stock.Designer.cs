namespace itemStock.Forms
{
	partial class Frm_Stock
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
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtQuin = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtGuid = new DevExpress.XtraEditors.TextEdit();
			this.gcStock = new DevExpress.XtraGrid.GridControl();
			this.tBStockItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bills = new itemStock.Bills();
			this.gvStock = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colitemGuid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuintity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.tB_StockItemTableAdapter = new itemStock.BillsTableAdapters.TB_StockItemTableAdapter();
			this.cbxStatus = new DevExpress.XtraEditors.LookUpEdit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtQuin.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGuid.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcStock)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBStockItemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bills)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvStock)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbxStatus.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.cbxStatus);
			this.panelControl1.Controls.Add(this.simpleButton1);
			this.panelControl1.Controls.Add(this.labelControl3);
			this.panelControl1.Controls.Add(this.txtQuin);
			this.panelControl1.Controls.Add(this.labelControl2);
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Controls.Add(this.txtGuid);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Margin = new System.Windows.Forms.Padding(5);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1008, 997);
			this.panelControl1.TabIndex = 0;
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(170, 134);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(166, 32);
			this.simpleButton1.TabIndex = 7;
			this.simpleButton1.Text = "Save";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(14, 97);
			this.labelControl3.Margin = new System.Windows.Forms.Padding(5);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(80, 21);
			this.labelControl3.TabIndex = 5;
			this.labelControl3.Text = "Quintity";
			// 
			// txtQuin
			// 
			this.txtQuin.Location = new System.Drawing.Point(170, 90);
			this.txtQuin.Margin = new System.Windows.Forms.Padding(5);
			this.txtQuin.Name = "txtQuin";
			this.txtQuin.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuin.Properties.Appearance.Options.UseFont = true;
			this.txtQuin.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtQuin.Properties.MaskSettings.Set("mask", "d");
			this.txtQuin.Size = new System.Drawing.Size(167, 28);
			this.txtQuin.TabIndex = 4;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(13, 53);
			this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(60, 21);
			this.labelControl2.TabIndex = 3;
			this.labelControl2.Text = "status";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(13, 19);
			this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(90, 21);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Item Name";
			// 
			// txtGuid
			// 
			this.txtGuid.Location = new System.Drawing.Point(170, 14);
			this.txtGuid.Margin = new System.Windows.Forms.Padding(5);
			this.txtGuid.Name = "txtGuid";
			this.txtGuid.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGuid.Properties.Appearance.Options.UseFont = true;
			this.txtGuid.Size = new System.Drawing.Size(167, 28);
			this.txtGuid.TabIndex = 0;
			// 
			// gcStock
			// 
			this.gcStock.DataSource = this.tBStockItemBindingSource;
			this.gcStock.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gcStock.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
			this.gcStock.Location = new System.Drawing.Point(0, 325);
			this.gcStock.MainView = this.gvStock;
			this.gcStock.Margin = new System.Windows.Forms.Padding(5);
			this.gcStock.Name = "gcStock";
			this.gcStock.Size = new System.Drawing.Size(1008, 336);
			this.gcStock.TabIndex = 1;
			this.gcStock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStock});
			// 
			// tBStockItemBindingSource
			// 
			this.tBStockItemBindingSource.DataMember = "TB_StockItem";
			this.tBStockItemBindingSource.DataSource = this.bills;
			// 
			// bills
			// 
			this.bills.DataSetName = "Bills";
			this.bills.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gvStock
			// 
			this.gvStock.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colitemGuid,
            this.colstatus,
            this.colQuintity});
			this.gvStock.DetailHeight = 565;
			this.gvStock.GridControl = this.gcStock;
			this.gvStock.Name = "gvStock";
			this.gvStock.OptionsEditForm.PopupEditFormWidth = 1333;
			this.gvStock.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvStock_FocusedRowChanged);
			// 
			// colitemGuid
			// 
			this.colitemGuid.FieldName = "itemGuid";
			this.colitemGuid.Name = "colitemGuid";
			this.colitemGuid.Visible = true;
			this.colitemGuid.VisibleIndex = 0;
			// 
			// colstatus
			// 
			this.colstatus.FieldName = "status";
			this.colstatus.Name = "colstatus";
			this.colstatus.Visible = true;
			this.colstatus.VisibleIndex = 1;
			// 
			// colQuintity
			// 
			this.colQuintity.FieldName = "Quintity";
			this.colQuintity.Name = "colQuintity";
			this.colQuintity.Visible = true;
			this.colQuintity.VisibleIndex = 2;
			// 
			// tB_StockItemTableAdapter
			// 
			this.tB_StockItemTableAdapter.ClearBeforeFill = true;
			// 
			// cbxStatus
			// 
			this.cbxStatus.Location = new System.Drawing.Point(170, 54);
			this.cbxStatus.Name = "cbxStatus";
			this.cbxStatus.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxStatus.Properties.Appearance.Options.UseFont = true;
			this.cbxStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cbxStatus.Size = new System.Drawing.Size(163, 28);
			this.cbxStatus.TabIndex = 8;
			// 
			// Frm_Stock
			// 
			this.Appearance.Options.UseFont = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 661);
			this.Controls.Add(this.gcStock);
			this.Controls.Add(this.panelControl1);
			this.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Frm_Stock";
			this.Text = "Frm_Stock";
			this.Load += new System.EventHandler(this.Frm_Stock_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtQuin.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGuid.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcStock)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBStockItemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bills)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvStock)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbxStatus.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit txtGuid;
		private DevExpress.XtraGrid.GridControl gcStock;
		private DevExpress.XtraGrid.Views.Grid.GridView gvStock;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.TextEdit txtQuin;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private Bills bills;
		private System.Windows.Forms.BindingSource tBStockItemBindingSource;
		private BillsTableAdapters.TB_StockItemTableAdapter tB_StockItemTableAdapter;
		private DevExpress.XtraGrid.Columns.GridColumn colitemGuid;
		private DevExpress.XtraGrid.Columns.GridColumn colstatus;
		private DevExpress.XtraGrid.Columns.GridColumn colQuintity;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.LookUpEdit cbxStatus;
	}
}