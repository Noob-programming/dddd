namespace StockMarcte
{
	partial class BillItem
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
			this.tBBillBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.billsDataSet1 = new StockMarcte.BillsDataSet1();
			this.tBBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tBBillBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.billsDataSet = new StockMarcte.BillsDataSet();
			this.tB_BillTableAdapter = new StockMarcte.BillsDataSet1TableAdapters.TB_BillTableAdapter();
			this.tB_BillTableAdapter1 = new StockMarcte.BillsDataSetTableAdapters.TB_BillTableAdapter();
			this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Billcode = new DevExpress.XtraEditors.TextEdit();
			this.txtguid = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtNotes = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.DateBill = new DevExpress.XtraEditors.DateEdit();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.Deletes = new DevExpress.XtraEditors.SimpleButton();
			this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			((System.ComponentModel.ISupportInitialize)(this.tBBillBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBBillBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBBillBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Billcode.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtguid.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DateBill.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DateBill.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tBBillBindingSource2
			// 
			this.tBBillBindingSource2.DataMember = "TB_Bill";
			this.tBBillBindingSource2.DataSource = this.billsDataSet1;
			// 
			// billsDataSet1
			// 
			this.billsDataSet1.DataSetName = "BillsDataSet1";
			this.billsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tBBillBindingSource
			// 
			this.tBBillBindingSource.DataMember = "TB_Bill";
			this.tBBillBindingSource.DataSource = this.billsDataSet1;
			// 
			// tBBillBindingSource1
			// 
			this.tBBillBindingSource1.DataMember = "TB_Bill";
			this.tBBillBindingSource1.DataSource = this.billsDataSet;
			// 
			// billsDataSet
			// 
			this.billsDataSet.DataSetName = "BillsDataSet";
			this.billsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tB_BillTableAdapter
			// 
			this.tB_BillTableAdapter.ClearBeforeFill = true;
			// 
			// tB_BillTableAdapter1
			// 
			this.tB_BillTableAdapter1.ClearBeforeFill = true;
			// 
			// sqlDataSource1
			// 
			this.sqlDataSource1.Name = "sqlDataSource1";
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.tBBillBindingSource2;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridControl1.Location = new System.Drawing.Point(2, 275);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1162, 408);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "BillGuid";
			this.gridColumn1.FieldName = "BillGuid";
			this.gridColumn1.Name = "gridColumn1";
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Billcode";
			this.gridColumn2.FieldName = "Billcode";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 0;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "Billdate";
			this.gridColumn3.FieldName = "BillDate";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 1;
			// 
			// gridColumn4
			// 
			this.gridColumn4.Caption = "Notes";
			this.gridColumn4.FieldName = "Notes";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 2;
			// 
			// gridColumn5
			// 
			this.gridColumn5.Caption = "Type";
			this.gridColumn5.FieldName = "Type";
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.Visible = true;
			this.gridColumn5.VisibleIndex = 3;
			// 
			// Billcode
			// 
			this.Billcode.Enabled = false;
			this.Billcode.Location = new System.Drawing.Point(155, 12);
			this.Billcode.Name = "Billcode";
			this.Billcode.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Billcode.Properties.Appearance.Options.UseFont = true;
			this.Billcode.Size = new System.Drawing.Size(227, 28);
			this.Billcode.TabIndex = 1;
			// 
			// txtguid
			// 
			this.txtguid.Location = new System.Drawing.Point(155, 175);
			this.txtguid.Name = "txtguid";
			this.txtguid.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtguid.Properties.Appearance.Options.UseFont = true;
			this.txtguid.Size = new System.Drawing.Size(227, 28);
			this.txtguid.TabIndex = 1;
			this.txtguid.Visible = false;
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(19, 15);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(90, 21);
			this.labelControl1.TabIndex = 2;
			this.labelControl1.Text = "Bill Code";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(19, 53);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(90, 21);
			this.labelControl2.TabIndex = 4;
			this.labelControl2.Text = "Bill Date";
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(155, 80);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNotes.Properties.Appearance.Options.UseFont = true;
			this.txtNotes.Size = new System.Drawing.Size(227, 28);
			this.txtNotes.TabIndex = 5;
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(19, 87);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(50, 21);
			this.labelControl3.TabIndex = 6;
			this.labelControl3.Text = "Notes";
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Location = new System.Drawing.Point(19, 127);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(90, 21);
			this.labelControl4.TabIndex = 6;
			this.labelControl4.Text = "Bill Type";
			// 
			// DateBill
			// 
			this.DateBill.EditValue = null;
			this.DateBill.Location = new System.Drawing.Point(155, 46);
			this.DateBill.Name = "DateBill";
			this.DateBill.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateBill.Properties.Appearance.Options.UseFont = true;
			this.DateBill.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.DateBill.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.DateBill.Size = new System.Drawing.Size(227, 28);
			this.DateBill.TabIndex = 8;
			// 
			// simpleButton1
			// 
			this.simpleButton1.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButton1.Appearance.Options.UseFont = true;
			this.simpleButton1.Location = new System.Drawing.Point(466, 12);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(164, 54);
			this.simpleButton1.TabIndex = 9;
			this.simpleButton1.Text = "Save";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// Deletes
			// 
			this.Deletes.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Deletes.Appearance.Options.UseFont = true;
			this.Deletes.Location = new System.Drawing.Point(466, 72);
			this.Deletes.Name = "Deletes";
			this.Deletes.Size = new System.Drawing.Size(164, 54);
			this.Deletes.TabIndex = 9;
			this.Deletes.Text = "Delete";
			this.Deletes.Click += new System.EventHandler(this.Deletes_Click);
			// 
			// toggleSwitch1
			// 
			this.toggleSwitch1.Location = new System.Drawing.Point(155, 126);
			this.toggleSwitch1.Name = "toggleSwitch1";
			this.toggleSwitch1.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toggleSwitch1.Properties.Appearance.Options.UseFont = true;
			this.toggleSwitch1.Properties.OffText = "Sell";
			this.toggleSwitch1.Properties.OnText = "Buy";
			this.toggleSwitch1.Size = new System.Drawing.Size(227, 26);
			this.toggleSwitch1.TabIndex = 10;
			// 
			// simpleButton2
			// 
			this.simpleButton2.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButton2.Appearance.Options.UseFont = true;
			this.simpleButton2.Location = new System.Drawing.Point(466, 132);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(164, 54);
			this.simpleButton2.TabIndex = 11;
			this.simpleButton2.Text = "new";
			this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.simpleButton2);
			this.panelControl1.Controls.Add(this.toggleSwitch1);
			this.panelControl1.Controls.Add(this.Deletes);
			this.panelControl1.Controls.Add(this.simpleButton1);
			this.panelControl1.Controls.Add(this.DateBill);
			this.panelControl1.Controls.Add(this.labelControl4);
			this.panelControl1.Controls.Add(this.labelControl3);
			this.panelControl1.Controls.Add(this.txtNotes);
			this.panelControl1.Controls.Add(this.labelControl2);
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Controls.Add(this.txtguid);
			this.panelControl1.Controls.Add(this.Billcode);
			this.panelControl1.Controls.Add(this.gridControl1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1166, 685);
			this.panelControl1.TabIndex = 0;
			// 
			// BillItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1166, 685);
			this.Controls.Add(this.panelControl1);
			this.Name = "BillItem";
			this.Text = "BillItem";
			this.Load += new System.EventHandler(this.BillItem_Load);
			((System.ComponentModel.ISupportInitialize)(this.tBBillBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBBillBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBBillBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Billcode.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtguid.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DateBill.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DateBill.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private BillsDataSet1 billsDataSet1;
		private System.Windows.Forms.BindingSource tBBillBindingSource;
		private BillsDataSet1TableAdapters.TB_BillTableAdapter tB_BillTableAdapter;
		private BillsDataSet billsDataSet;
		private System.Windows.Forms.BindingSource tBBillBindingSource1;
		private BillsDataSetTableAdapters.TB_BillTableAdapter tB_BillTableAdapter1;
		private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
		private System.Windows.Forms.BindingSource tBBillBindingSource2;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
		private DevExpress.XtraEditors.TextEdit Billcode;
		private DevExpress.XtraEditors.TextEdit txtguid;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit txtNotes;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.DateEdit DateBill;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.SimpleButton Deletes;
		private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraEditors.PanelControl panelControl1;
	}
}