namespace ItemStockRepoPattern.View.Forms
{
	partial class Frm_Bill
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
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.TbillType = new DevExpress.XtraEditors.ToggleSwitch();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.txtDate = new DevExpress.XtraEditors.DateEdit();
			this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.txtNotes = new DevExpress.XtraEditors.TextEdit();
			this.txtCode = new DevExpress.XtraEditors.TextEdit();
			this.txtGuid = new DevExpress.XtraEditors.TextEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
			this.billsData1 = new ItemStockRepoPattern.BillsData();
			this.tB_BillTableAdapter1 = new ItemStockRepoPattern.BillsDataTableAdapters.TB_BillTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TbillType.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGuid.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsData1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.layoutControl1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Margin = new System.Windows.Forms.Padding(5);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1205, 713);
			this.panelControl1.TabIndex = 0;
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.TbillType);
			this.layoutControl1.Controls.Add(this.gridControl1);
			this.layoutControl1.Controls.Add(this.txtDate);
			this.layoutControl1.Controls.Add(this.simpleButton3);
			this.layoutControl1.Controls.Add(this.simpleButton2);
			this.layoutControl1.Controls.Add(this.simpleButton1);
			this.layoutControl1.Controls.Add(this.txtNotes);
			this.layoutControl1.Controls.Add(this.txtCode);
			this.layoutControl1.Controls.Add(this.txtGuid);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(2, 2);
			this.layoutControl1.Margin = new System.Windows.Forms.Padding(5);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(1201, 709);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// TbillType
			// 
			this.TbillType.Location = new System.Drawing.Point(12, 156);
			this.TbillType.Name = "TbillType";
			this.TbillType.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TbillType.Properties.Appearance.Options.UseFont = true;
			this.TbillType.Properties.OffText = "Sell";
			this.TbillType.Properties.OnText = "Buy";
			this.TbillType.Size = new System.Drawing.Size(1177, 26);
			this.TbillType.StyleController = this.layoutControl1;
			this.TbillType.TabIndex = 14;
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(12, 280);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1177, 417);
			this.gridControl1.TabIndex = 13;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// txtDate
			// 
			this.txtDate.EditValue = null;
			this.txtDate.Location = new System.Drawing.Point(114, 120);
			this.txtDate.Margin = new System.Windows.Forms.Padding(5);
			this.txtDate.Name = "txtDate";
			this.txtDate.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDate.Properties.Appearance.Options.UseFont = true;
			this.txtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtDate.Size = new System.Drawing.Size(1075, 32);
			this.txtDate.StyleController = this.layoutControl1;
			this.txtDate.TabIndex = 12;
			// 
			// simpleButton3
			// 
			this.simpleButton3.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButton3.Appearance.Options.UseFont = true;
			this.simpleButton3.Location = new System.Drawing.Point(12, 216);
			this.simpleButton3.Margin = new System.Windows.Forms.Padding(5);
			this.simpleButton3.Name = "simpleButton3";
			this.simpleButton3.Size = new System.Drawing.Size(1177, 26);
			this.simpleButton3.StyleController = this.layoutControl1;
			this.simpleButton3.TabIndex = 11;
			this.simpleButton3.Text = "Delete";
			this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
			// 
			// simpleButton2
			// 
			this.simpleButton2.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButton2.Appearance.Options.UseFont = true;
			this.simpleButton2.Location = new System.Drawing.Point(12, 186);
			this.simpleButton2.Margin = new System.Windows.Forms.Padding(5);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(586, 26);
			this.simpleButton2.StyleController = this.layoutControl1;
			this.simpleButton2.TabIndex = 10;
			this.simpleButton2.Text = "Add";
			this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
			// 
			// simpleButton1
			// 
			this.simpleButton1.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButton1.Appearance.Options.UseFont = true;
			this.simpleButton1.Location = new System.Drawing.Point(602, 186);
			this.simpleButton1.Margin = new System.Windows.Forms.Padding(5);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(587, 26);
			this.simpleButton1.StyleController = this.layoutControl1;
			this.simpleButton1.TabIndex = 9;
			this.simpleButton1.Text = "Save";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(114, 84);
			this.txtNotes.Margin = new System.Windows.Forms.Padding(5);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNotes.Properties.Appearance.Options.UseFont = true;
			this.txtNotes.Size = new System.Drawing.Size(1075, 32);
			this.txtNotes.StyleController = this.layoutControl1;
			this.txtNotes.TabIndex = 6;
			// 
			// txtCode
			// 
			this.txtCode.Location = new System.Drawing.Point(114, 48);
			this.txtCode.Margin = new System.Windows.Forms.Padding(5);
			this.txtCode.Name = "txtCode";
			this.txtCode.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCode.Properties.Appearance.Options.UseFont = true;
			this.txtCode.Size = new System.Drawing.Size(1075, 32);
			this.txtCode.StyleController = this.layoutControl1;
			this.txtCode.TabIndex = 5;
			// 
			// txtGuid
			// 
			this.txtGuid.Location = new System.Drawing.Point(114, 12);
			this.txtGuid.Margin = new System.Windows.Forms.Padding(5);
			this.txtGuid.Name = "txtGuid";
			this.txtGuid.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGuid.Properties.Appearance.Options.UseFont = true;
			this.txtGuid.Size = new System.Drawing.Size(1075, 32);
			this.txtGuid.StyleController = this.layoutControl1;
			this.txtGuid.TabIndex = 4;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlItem4,
            this.layoutControlItem9,
            this.layoutControlItem5,
            this.layoutControlItem7});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1201, 709);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem1.Control = this.txtGuid;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1181, 36);
			this.layoutControlItem1.Text = "Bill Guid";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(90, 21);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 234);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(1181, 34);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem2.Control = this.txtCode;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 36);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(1181, 36);
			this.layoutControlItem2.Text = "Bill Code";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(90, 21);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem3.Control = this.txtNotes;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(1181, 36);
			this.layoutControlItem3.Text = "Notes";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(90, 21);
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.simpleButton1;
			this.layoutControlItem6.Location = new System.Drawing.Point(590, 174);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(591, 30);
			this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			// 
			// layoutControlItem8
			// 
			this.layoutControlItem8.Control = this.simpleButton3;
			this.layoutControlItem8.Location = new System.Drawing.Point(0, 204);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Size = new System.Drawing.Size(1181, 30);
			this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem8.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem4.Control = this.txtDate;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 108);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(1181, 36);
			this.layoutControlItem4.Text = "Date";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(90, 21);
			// 
			// layoutControlItem9
			// 
			this.layoutControlItem9.Control = this.gridControl1;
			this.layoutControlItem9.Location = new System.Drawing.Point(0, 268);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Size = new System.Drawing.Size(1181, 421);
			this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem9.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.TbillType;
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 144);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(1181, 30);
			this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			// 
			// layoutControlItem7
			// 
			this.layoutControlItem7.Control = this.simpleButton2;
			this.layoutControlItem7.Location = new System.Drawing.Point(0, 174);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Size = new System.Drawing.Size(590, 30);
			this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem7.TextVisible = false;
			// 
			// billsData1
			// 
			this.billsData1.DataSetName = "BillsData";
			this.billsData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tB_BillTableAdapter1
			// 
			this.tB_BillTableAdapter1.ClearBeforeFill = true;
			// 
			// Frm_Bill
			// 
			this.Appearance.Options.UseFont = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1205, 713);
			this.Controls.Add(this.panelControl1);
			this.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Frm_Bill";
			this.Text = "Frm_Bill";
			this.Load += new System.EventHandler(this.Frm_Bill_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.TbillType.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGuid.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsData1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraEditors.TextEdit txtNotes;
		private DevExpress.XtraEditors.TextEdit txtCode;
		private DevExpress.XtraEditors.TextEdit txtGuid;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraEditors.SimpleButton simpleButton3;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private BillsData billsData1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.DateEdit txtDate;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
		private BillsDataTableAdapters.TB_BillTableAdapter tB_BillTableAdapter1;
		private DevExpress.XtraEditors.ToggleSwitch TbillType;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
	}
}