namespace Testsource
{
	partial class test
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
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.BillGuidTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.ItemForBillGuid = new DevExpress.XtraLayout.LayoutControlItem();
			this.BillCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.ItemForBillCode = new DevExpress.XtraLayout.LayoutControlItem();
			this.BillDateDateEdit = new DevExpress.XtraEditors.DateEdit();
			this.ItemForBillDate = new DevExpress.XtraLayout.LayoutControlItem();
			this.NotesTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.ItemForNotes = new DevExpress.XtraLayout.LayoutControlItem();
			this.BillTypeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.ItemForBillType = new DevExpress.XtraLayout.LayoutControlItem();
			this.billItem1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
			this.dataLayoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BillGuidTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForBillGuid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BillCodeTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForBillCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BillDateDateEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BillDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForBillDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NotesTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForNotes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BillTypeCheckEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForBillType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billItem1BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataLayoutControl1
			// 
			this.dataLayoutControl1.Controls.Add(this.BillGuidTextEdit);
			this.dataLayoutControl1.Controls.Add(this.BillCodeTextEdit);
			this.dataLayoutControl1.Controls.Add(this.BillDateDateEdit);
			this.dataLayoutControl1.Controls.Add(this.NotesTextEdit);
			this.dataLayoutControl1.Controls.Add(this.BillTypeCheckEdit);
			this.dataLayoutControl1.DataSource = this.billItem1BindingSource;
			this.dataLayoutControl1.Location = new System.Drawing.Point(184, 53);
			this.dataLayoutControl1.Name = "dataLayoutControl1";
			this.dataLayoutControl1.Root = this.Root;
			this.dataLayoutControl1.Size = new System.Drawing.Size(487, 257);
			this.dataLayoutControl1.TabIndex = 0;
			this.dataLayoutControl1.Text = "dataLayoutControl1";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(487, 257);
			this.Root.TextVisible = false;
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(184, 332);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(494, 90);
			this.simpleButton1.TabIndex = 1;
			this.simpleButton1.Text = "simpleButton1";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
			this.layoutControlGroup1.Size = new System.Drawing.Size(467, 237);
			// 
			// BillGuidTextEdit
			// 
			this.BillGuidTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.billItem1BindingSource, "BillGuid", true));
			this.BillGuidTextEdit.Location = new System.Drawing.Point(80, 12);
			this.BillGuidTextEdit.Name = "BillGuidTextEdit";
			this.BillGuidTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
			this.BillGuidTextEdit.Size = new System.Drawing.Size(395, 20);
			this.BillGuidTextEdit.StyleController = this.dataLayoutControl1;
			this.BillGuidTextEdit.TabIndex = 4;
			// 
			// ItemForBillGuid
			// 
			this.ItemForBillGuid.Control = this.BillGuidTextEdit;
			this.ItemForBillGuid.Location = new System.Drawing.Point(0, 0);
			this.ItemForBillGuid.Name = "ItemForBillGuid";
			this.ItemForBillGuid.Size = new System.Drawing.Size(467, 24);
			this.ItemForBillGuid.TextSize = new System.Drawing.Size(56, 13);
			// 
			// BillCodeTextEdit
			// 
			this.BillCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.billItem1BindingSource, "BillCode", true));
			this.BillCodeTextEdit.Location = new System.Drawing.Point(80, 36);
			this.BillCodeTextEdit.Name = "BillCodeTextEdit";
			this.BillCodeTextEdit.Properties.Appearance.Options.UseTextOptions = true;
			this.BillCodeTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.BillCodeTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.BillCodeTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.BillCodeTextEdit.Properties.MaskSettings.Set("mask", "N0");
			this.BillCodeTextEdit.Size = new System.Drawing.Size(395, 20);
			this.BillCodeTextEdit.StyleController = this.dataLayoutControl1;
			this.BillCodeTextEdit.TabIndex = 5;
			// 
			// ItemForBillCode
			// 
			this.ItemForBillCode.Control = this.BillCodeTextEdit;
			this.ItemForBillCode.Location = new System.Drawing.Point(0, 24);
			this.ItemForBillCode.Name = "ItemForBillCode";
			this.ItemForBillCode.Size = new System.Drawing.Size(467, 24);
			this.ItemForBillCode.TextSize = new System.Drawing.Size(56, 13);
			// 
			// BillDateDateEdit
			// 
			this.BillDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.billItem1BindingSource, "BillDate", true));
			this.BillDateDateEdit.EditValue = null;
			this.BillDateDateEdit.Location = new System.Drawing.Point(80, 60);
			this.BillDateDateEdit.Name = "BillDateDateEdit";
			this.BillDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.BillDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.BillDateDateEdit.Size = new System.Drawing.Size(395, 20);
			this.BillDateDateEdit.StyleController = this.dataLayoutControl1;
			this.BillDateDateEdit.TabIndex = 6;
			// 
			// ItemForBillDate
			// 
			this.ItemForBillDate.Control = this.BillDateDateEdit;
			this.ItemForBillDate.Location = new System.Drawing.Point(0, 48);
			this.ItemForBillDate.Name = "ItemForBillDate";
			this.ItemForBillDate.Size = new System.Drawing.Size(467, 24);
			this.ItemForBillDate.TextSize = new System.Drawing.Size(56, 13);
			// 
			// NotesTextEdit
			// 
			this.NotesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.billItem1BindingSource, "Notes", true));
			this.NotesTextEdit.Location = new System.Drawing.Point(80, 84);
			this.NotesTextEdit.Name = "NotesTextEdit";
			this.NotesTextEdit.Size = new System.Drawing.Size(395, 20);
			this.NotesTextEdit.StyleController = this.dataLayoutControl1;
			this.NotesTextEdit.TabIndex = 7;
			// 
			// ItemForNotes
			// 
			this.ItemForNotes.Control = this.NotesTextEdit;
			this.ItemForNotes.Location = new System.Drawing.Point(0, 72);
			this.ItemForNotes.Name = "ItemForNotes";
			this.ItemForNotes.Size = new System.Drawing.Size(467, 24);
			this.ItemForNotes.TextSize = new System.Drawing.Size(56, 13);
			// 
			// BillTypeCheckEdit
			// 
			this.BillTypeCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.billItem1BindingSource, "BillType", true));
			this.BillTypeCheckEdit.Location = new System.Drawing.Point(12, 108);
			this.BillTypeCheckEdit.Name = "BillTypeCheckEdit";
			this.BillTypeCheckEdit.Properties.Caption = "نوع الفاتورة";
			this.BillTypeCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.BillTypeCheckEdit.Size = new System.Drawing.Size(463, 20);
			this.BillTypeCheckEdit.StyleController = this.dataLayoutControl1;
			this.BillTypeCheckEdit.TabIndex = 8;
			// 
			// ItemForBillType
			// 
			this.ItemForBillType.Control = this.BillTypeCheckEdit;
			this.ItemForBillType.Location = new System.Drawing.Point(0, 96);
			this.ItemForBillType.Name = "ItemForBillType";
			this.ItemForBillType.Size = new System.Drawing.Size(467, 141);
			this.ItemForBillType.TextSize = new System.Drawing.Size(0, 0);
			this.ItemForBillType.TextVisible = false;
			// 
			// billItem1BindingSource
			// 
			this.billItem1BindingSource.DataSource = typeof(Testsource.BillItem1);
			// 
			// test
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(841, 499);
			this.Controls.Add(this.simpleButton1);
			this.Controls.Add(this.dataLayoutControl1);
			this.Name = "test";
			this.Text = "test";
			this.Load += new System.EventHandler(this.test_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
			this.dataLayoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BillGuidTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForBillGuid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BillCodeTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForBillCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BillDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BillDateDateEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForBillDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NotesTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForNotes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BillTypeCheckEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForBillType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billItem1BindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private System.Windows.Forms.BindingSource billItem1BindingSource;
		private DevExpress.XtraEditors.TextEdit BillGuidTextEdit;
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
	}
}