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
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.billModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.Save = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.Delete = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.Add = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
			this.dataLayoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billModelBindingSource)).BeginInit();
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
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
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
			this.dataLayoutControl1.Size = new System.Drawing.Size(1205, 172);
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
			this.Root.Size = new System.Drawing.Size(1205, 172);
			this.Root.TextVisible = false;
			// 
			// billModelBindingSource
			// 
			this.billModelBindingSource.DataSource = typeof(ItemStockRepoPattern.Model.BillModel);
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
			this.layoutControlGroup1.Size = new System.Drawing.Size(1185, 152);
			// 
			// BillGuidTextEdit
			// 
			this.BillGuidTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.billModelBindingSource, "BillGuid", true));
			this.BillGuidTextEdit.Location = new System.Drawing.Point(80, 12);
			this.BillGuidTextEdit.Name = "BillGuidTextEdit";
			this.BillGuidTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
			this.BillGuidTextEdit.Size = new System.Drawing.Size(1113, 20);
			this.BillGuidTextEdit.StyleController = this.dataLayoutControl1;
			this.BillGuidTextEdit.TabIndex = 4;
			// 
			// ItemForBillGuid
			// 
			this.ItemForBillGuid.Control = this.BillGuidTextEdit;
			this.ItemForBillGuid.Location = new System.Drawing.Point(0, 0);
			this.ItemForBillGuid.Name = "ItemForBillGuid";
			this.ItemForBillGuid.Size = new System.Drawing.Size(1185, 24);
			this.ItemForBillGuid.TextSize = new System.Drawing.Size(56, 13);
			// 
			// BillCodeTextEdit
			// 
			this.BillCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.billModelBindingSource, "BillCode", true));
			this.BillCodeTextEdit.Location = new System.Drawing.Point(80, 36);
			this.BillCodeTextEdit.Name = "BillCodeTextEdit";
			this.BillCodeTextEdit.Properties.Appearance.Options.UseTextOptions = true;
			this.BillCodeTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.BillCodeTextEdit.Properties.Mask.EditMask = "N0";
			this.BillCodeTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.BillCodeTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.BillCodeTextEdit.Size = new System.Drawing.Size(1113, 20);
			this.BillCodeTextEdit.StyleController = this.dataLayoutControl1;
			this.BillCodeTextEdit.TabIndex = 5;
			// 
			// ItemForBillCode
			// 
			this.ItemForBillCode.Control = this.BillCodeTextEdit;
			this.ItemForBillCode.Location = new System.Drawing.Point(0, 24);
			this.ItemForBillCode.Name = "ItemForBillCode";
			this.ItemForBillCode.Size = new System.Drawing.Size(1185, 24);
			this.ItemForBillCode.TextSize = new System.Drawing.Size(56, 13);
			// 
			// BillDateDateEdit
			// 
			this.BillDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.billModelBindingSource, "BillDate", true));
			this.BillDateDateEdit.EditValue = null;
			this.BillDateDateEdit.Location = new System.Drawing.Point(80, 60);
			this.BillDateDateEdit.Name = "BillDateDateEdit";
			this.BillDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.BillDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.BillDateDateEdit.Size = new System.Drawing.Size(1113, 20);
			this.BillDateDateEdit.StyleController = this.dataLayoutControl1;
			this.BillDateDateEdit.TabIndex = 6;
			// 
			// ItemForBillDate
			// 
			this.ItemForBillDate.Control = this.BillDateDateEdit;
			this.ItemForBillDate.Location = new System.Drawing.Point(0, 48);
			this.ItemForBillDate.Name = "ItemForBillDate";
			this.ItemForBillDate.Size = new System.Drawing.Size(1185, 24);
			this.ItemForBillDate.TextSize = new System.Drawing.Size(56, 13);
			// 
			// NotesTextEdit
			// 
			this.NotesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.billModelBindingSource, "Notes", true));
			this.NotesTextEdit.Location = new System.Drawing.Point(80, 84);
			this.NotesTextEdit.Name = "NotesTextEdit";
			this.NotesTextEdit.Size = new System.Drawing.Size(1113, 20);
			this.NotesTextEdit.StyleController = this.dataLayoutControl1;
			this.NotesTextEdit.TabIndex = 7;
			// 
			// ItemForNotes
			// 
			this.ItemForNotes.Control = this.NotesTextEdit;
			this.ItemForNotes.Location = new System.Drawing.Point(0, 72);
			this.ItemForNotes.Name = "ItemForNotes";
			this.ItemForNotes.Size = new System.Drawing.Size(1185, 24);
			this.ItemForNotes.TextSize = new System.Drawing.Size(56, 13);
			// 
			// BillTypeCheckEdit
			// 
			this.BillTypeCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.billModelBindingSource, "BillType", true));
			this.BillTypeCheckEdit.Location = new System.Drawing.Point(12, 108);
			this.BillTypeCheckEdit.Name = "BillTypeCheckEdit";
			this.BillTypeCheckEdit.Properties.Caption = "نوع الفاتورة";
			this.BillTypeCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.BillTypeCheckEdit.Size = new System.Drawing.Size(1181, 20);
			this.BillTypeCheckEdit.StyleController = this.dataLayoutControl1;
			this.BillTypeCheckEdit.TabIndex = 8;
			// 
			// ItemForBillType
			// 
			this.ItemForBillType.Control = this.BillTypeCheckEdit;
			this.ItemForBillType.Location = new System.Drawing.Point(0, 96);
			this.ItemForBillType.Name = "ItemForBillType";
			this.ItemForBillType.Size = new System.Drawing.Size(1185, 56);
			this.ItemForBillType.TextSize = new System.Drawing.Size(0, 0);
			this.ItemForBillType.TextVisible = false;
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.layoutControl1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 172);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1205, 541);
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
			this.layoutControl1.Size = new System.Drawing.Size(1201, 537);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
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
			this.layoutControlGroup2.Size = new System.Drawing.Size(1201, 537);
			this.layoutControlGroup2.TextVisible = false;
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(12, 90);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1177, 435);
			this.gridControl1.TabIndex = 4;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gridControl1;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 78);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1181, 439);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// Save
			// 
			this.Save.Location = new System.Drawing.Point(12, 12);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(1177, 22);
			this.Save.StyleController = this.layoutControl1;
			this.Save.TabIndex = 5;
			this.Save.Text = "Save";
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.Save;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(1181, 26);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// Delete
			// 
			this.Delete.Location = new System.Drawing.Point(12, 38);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(1177, 22);
			this.Delete.StyleController = this.layoutControl1;
			this.Delete.TabIndex = 6;
			this.Delete.Text = "Delete";
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.Delete;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(1181, 26);
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextVisible = false;
			// 
			// Add
			// 
			this.Add.Location = new System.Drawing.Point(12, 64);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(1177, 22);
			this.Add.StyleController = this.layoutControl1;
			this.Add.TabIndex = 7;
			this.Add.Text = "Add";
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.Add;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 52);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(1181, 26);
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
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
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billModelBindingSource)).EndInit();
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
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
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