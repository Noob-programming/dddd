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
			this.components = new System.ComponentModel.Container();
			this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			this.BillGuidTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.billModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.BillCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.BillDateDateEdit = new DevExpress.XtraEditors.DateEdit();
			this.NotesTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.BillTypeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.ItemForBillGuid = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForBillCode = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForBillDate = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForNotes = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForBillType = new DevExpress.XtraLayout.LayoutControlItem();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.Add = new DevExpress.XtraEditors.SimpleButton();
			this.Delete = new DevExpress.XtraEditors.SimpleButton();
			this.Save = new DevExpress.XtraEditors.SimpleButton();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
			this.dataLayoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BillGuidTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billModelBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BillCodeTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BillDateDateEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BillDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NotesTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BillTypeCheckEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForBillGuid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForBillCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForBillDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForNotes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForBillType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			this.SuspendLayout();
			// 
			// dataLayoutControl1
			// 
			this.dataLayoutControl1.Controls.Add(this.BillGuidTextEdit);
			this.dataLayoutControl1.Controls.Add(this.BillCodeTextEdit);
			this.dataLayoutControl1.Controls.Add(this.BillDateDateEdit);
			this.dataLayoutControl1.Controls.Add(this.NotesTextEdit);
			this.dataLayoutControl1.Controls.Add(this.BillTypeCheckEdit);
			this.dataLayoutControl1.DataSource = this.billModelBindingSource;
			this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
			this.dataLayoutControl1.Name = "dataLayoutControl1";
			this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1270, 75, 650, 400);
			this.dataLayoutControl1.Root = this.Root;
			this.dataLayoutControl1.Size = new System.Drawing.Size(1205, 210);
			this.dataLayoutControl1.TabIndex = 0;
			this.dataLayoutControl1.Text = "dataLayoutControl1";
			// 
			// BillGuidTextEdit
			// 
			this.BillGuidTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.billModelBindingSource, "BillGuid", true));
			this.BillGuidTextEdit.Location = new System.Drawing.Point(114, 12);
			this.BillGuidTextEdit.Name = "BillGuidTextEdit";
			this.BillGuidTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
			this.BillGuidTextEdit.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BillGuidTextEdit.Properties.Appearance.Options.UseFont = true;
			this.BillGuidTextEdit.Size = new System.Drawing.Size(1079, 28);
			this.BillGuidTextEdit.StyleController = this.dataLayoutControl1;
			this.BillGuidTextEdit.TabIndex = 4;
			// 
			// billModelBindingSource
			// 
			this.billModelBindingSource.DataSource = typeof(ItemStockRepoPattern.Model.BillModel);
			// 
			// BillCodeTextEdit
			// 
			this.BillCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.billModelBindingSource, "BillCode", true));
			this.BillCodeTextEdit.Location = new System.Drawing.Point(114, 44);
			this.BillCodeTextEdit.Name = "BillCodeTextEdit";
			this.BillCodeTextEdit.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BillCodeTextEdit.Properties.Appearance.Options.UseFont = true;
			this.BillCodeTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.BillCodeTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.BillCodeTextEdit.Properties.MaskSettings.Set("mask", "N0");
			this.BillCodeTextEdit.Size = new System.Drawing.Size(1079, 28);
			this.BillCodeTextEdit.StyleController = this.dataLayoutControl1;
			this.BillCodeTextEdit.TabIndex = 5;
			// 
			// BillDateDateEdit
			// 
			this.BillDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.billModelBindingSource, "BillDate", true));
			this.BillDateDateEdit.EditValue = null;
			this.BillDateDateEdit.Location = new System.Drawing.Point(114, 76);
			this.BillDateDateEdit.Name = "BillDateDateEdit";
			this.BillDateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BillDateDateEdit.Properties.Appearance.Options.UseFont = true;
			this.BillDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.BillDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.BillDateDateEdit.Size = new System.Drawing.Size(1079, 28);
			this.BillDateDateEdit.StyleController = this.dataLayoutControl1;
			this.BillDateDateEdit.TabIndex = 6;
			// 
			// NotesTextEdit
			// 
			this.NotesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.billModelBindingSource, "Notes", true));
			this.NotesTextEdit.Location = new System.Drawing.Point(114, 108);
			this.NotesTextEdit.Name = "NotesTextEdit";
			this.NotesTextEdit.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NotesTextEdit.Properties.Appearance.Options.UseFont = true;
			this.NotesTextEdit.Size = new System.Drawing.Size(1079, 28);
			this.NotesTextEdit.StyleController = this.dataLayoutControl1;
			this.NotesTextEdit.TabIndex = 7;
			// 
			// BillTypeCheckEdit
			// 
			this.BillTypeCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.billModelBindingSource, "BillType", true));
			this.BillTypeCheckEdit.Location = new System.Drawing.Point(12, 140);
			this.BillTypeCheckEdit.Name = "BillTypeCheckEdit";
			this.BillTypeCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BillTypeCheckEdit.Properties.Appearance.Options.UseFont = true;
			this.BillTypeCheckEdit.Properties.Caption = "نوع الفاتورة";
			this.BillTypeCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.BillTypeCheckEdit.Size = new System.Drawing.Size(1181, 25);
			this.BillTypeCheckEdit.StyleController = this.dataLayoutControl1;
			this.BillTypeCheckEdit.TabIndex = 8;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1205, 210);
			this.Root.TextVisible = false;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.AllowDrawBackground = false;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForBillGuid,
            this.ItemForBillCode,
            this.ItemForBillDate,
            this.ItemForNotes,
            this.ItemForBillType});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "autoGeneratedGroup0";
			this.layoutControlGroup1.Size = new System.Drawing.Size(1185, 190);
			// 
			// ItemForBillGuid
			// 
			this.ItemForBillGuid.AppearanceItemCaption.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemForBillGuid.AppearanceItemCaption.Options.UseFont = true;
			this.ItemForBillGuid.Control = this.BillGuidTextEdit;
			this.ItemForBillGuid.Location = new System.Drawing.Point(0, 0);
			this.ItemForBillGuid.Name = "ItemForBillGuid";
			this.ItemForBillGuid.Size = new System.Drawing.Size(1185, 32);
			this.ItemForBillGuid.TextSize = new System.Drawing.Size(90, 21);
			// 
			// ItemForBillCode
			// 
			this.ItemForBillCode.AppearanceItemCaption.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemForBillCode.AppearanceItemCaption.Options.UseFont = true;
			this.ItemForBillCode.Control = this.BillCodeTextEdit;
			this.ItemForBillCode.Location = new System.Drawing.Point(0, 32);
			this.ItemForBillCode.Name = "ItemForBillCode";
			this.ItemForBillCode.Size = new System.Drawing.Size(1185, 32);
			this.ItemForBillCode.TextLocation = DevExpress.Utils.Locations.Left;
			this.ItemForBillCode.TextSize = new System.Drawing.Size(90, 21);
			// 
			// ItemForBillDate
			// 
			this.ItemForBillDate.AppearanceItemCaption.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemForBillDate.AppearanceItemCaption.Options.UseFont = true;
			this.ItemForBillDate.Control = this.BillDateDateEdit;
			this.ItemForBillDate.Location = new System.Drawing.Point(0, 64);
			this.ItemForBillDate.Name = "ItemForBillDate";
			this.ItemForBillDate.Size = new System.Drawing.Size(1185, 32);
			this.ItemForBillDate.TextLocation = DevExpress.Utils.Locations.Left;
			this.ItemForBillDate.TextSize = new System.Drawing.Size(90, 21);
			// 
			// ItemForNotes
			// 
			this.ItemForNotes.AppearanceItemCaption.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemForNotes.AppearanceItemCaption.Options.UseFont = true;
			this.ItemForNotes.Control = this.NotesTextEdit;
			this.ItemForNotes.Location = new System.Drawing.Point(0, 96);
			this.ItemForNotes.Name = "ItemForNotes";
			this.ItemForNotes.Size = new System.Drawing.Size(1185, 32);
			this.ItemForNotes.TextLocation = DevExpress.Utils.Locations.Left;
			this.ItemForNotes.TextSize = new System.Drawing.Size(90, 21);
			// 
			// ItemForBillType
			// 
			this.ItemForBillType.Control = this.BillTypeCheckEdit;
			this.ItemForBillType.Location = new System.Drawing.Point(0, 128);
			this.ItemForBillType.Name = "ItemForBillType";
			this.ItemForBillType.Size = new System.Drawing.Size(1185, 62);
			this.ItemForBillType.TextSize = new System.Drawing.Size(0, 0);
			this.ItemForBillType.TextVisible = false;
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.layoutControl1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 210);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1205, 503);
			this.panelControl1.TabIndex = 1;
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.Add);
			this.layoutControl1.Controls.Add(this.Delete);
			this.layoutControl1.Controls.Add(this.Save);
			this.layoutControl1.Controls.Add(this.gridControl1);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(2, 2);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup2;
			this.layoutControl1.Size = new System.Drawing.Size(1201, 499);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// Add
			// 
			this.Add.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Add.Appearance.Options.UseFont = true;
			this.Add.Location = new System.Drawing.Point(12, 72);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(1177, 26);
			this.Add.StyleController = this.layoutControl1;
			this.Add.TabIndex = 7;
			this.Add.Text = "Add";
			// 
			// Delete
			// 
			this.Delete.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Delete.Appearance.Options.UseFont = true;
			this.Delete.Location = new System.Drawing.Point(12, 42);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(1177, 26);
			this.Delete.StyleController = this.layoutControl1;
			this.Delete.TabIndex = 6;
			this.Delete.Text = "Delete";
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// Save
			// 
			this.Save.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Save.Appearance.Options.UseFont = true;
			this.Save.Location = new System.Drawing.Point(12, 12);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(1177, 26);
			this.Save.StyleController = this.layoutControl1;
			this.Save.TabIndex = 5;
			this.Save.Text = "Save";
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(12, 102);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1177, 385);
			this.gridControl1.TabIndex = 4;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup2.GroupBordersVisible = false;
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem3});
			this.layoutControlGroup2.Name = "layoutControlGroup2";
			this.layoutControlGroup2.Size = new System.Drawing.Size(1201, 499);
			this.layoutControlGroup2.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gridControl1;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 90);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1181, 389);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.Add;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 60);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(1181, 30);
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.Save;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(1181, 30);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.Delete;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 30);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(1181, 30);
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextVisible = false;
			// 
			// Frm_Bill
			// 
			this.Appearance.Options.UseFont = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1205, 713);
			this.Controls.Add(this.panelControl1);
			this.Controls.Add(this.dataLayoutControl1);
			this.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Frm_Bill";
			this.Text = "Frm_Bill";
			this.Load += new System.EventHandler(this.Frm_Bill_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
			this.dataLayoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.BillGuidTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billModelBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BillCodeTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BillDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BillDateDateEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NotesTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BillTypeCheckEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForBillGuid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForBillCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForBillDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForNotes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForBillType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraEditors.TextEdit BillGuidTextEdit;
		private System.Windows.Forms.BindingSource billModelBindingSource;
		private DevExpress.XtraEditors.TextEdit BillCodeTextEdit;
		private DevExpress.XtraEditors.DateEdit BillDateDateEdit;
		private DevExpress.XtraEditors.TextEdit NotesTextEdit;
		private DevExpress.XtraEditors.CheckEdit BillTypeCheckEdit;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem ItemForBillGuid;
		private DevExpress.XtraLayout.LayoutControlItem ItemForBillCode;
		private DevExpress.XtraLayout.LayoutControlItem ItemForBillDate;
		private DevExpress.XtraLayout.LayoutControlItem ItemForNotes;
		private DevExpress.XtraLayout.LayoutControlItem ItemForBillType;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraEditors.SimpleButton Add;
		private DevExpress.XtraEditors.SimpleButton Delete;
		private DevExpress.XtraEditors.SimpleButton Save;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
	}
}