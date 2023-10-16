namespace NewStock.Forms
{
	partial class Frm_ItemForms
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
			this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
			this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.Group = new DevExpress.XtraEditors.CheckEdit();
			this.txtPriceMany = new DevExpress.XtraEditors.TextEdit();
			this.txtPriceSingle = new DevExpress.XtraEditors.TextEdit();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.txtPrice = new DevExpress.XtraEditors.TextEdit();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.txtName = new DevExpress.XtraEditors.TextEdit();
			this.txtCode = new DevExpress.XtraEditors.TextEdit();
			this.txtGuid = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtparentguid = new DevExpress.XtraEditors.LookUpEdit();
			this.tB_ItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.billsDB1 = new NewStock.BillsDB();
			this.tB_ItemTableAdapter1 = new NewStock.BillsDBTableAdapters.TB_ItemTableAdapter();
			this.tBItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
			this.panelControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			this.panelControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Group.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPriceMany.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPriceSingle.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGuid.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtparentguid.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tB_ItemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDB1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBItemBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.panelControl2);
			this.panelControl1.Controls.Add(this.panelControl3);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Margin = new System.Windows.Forms.Padding(5);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(886, 538);
			this.panelControl1.TabIndex = 0;
			// 
			// panelControl3
			// 
			this.panelControl3.Controls.Add(this.simpleButton3);
			this.panelControl3.Controls.Add(this.simpleButton2);
			this.panelControl3.Controls.Add(this.simpleButton1);
			this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelControl3.Location = new System.Drawing.Point(2, 2);
			this.panelControl3.Name = "panelControl3";
			this.panelControl3.Size = new System.Drawing.Size(195, 534);
			this.panelControl3.TabIndex = 1;
			// 
			// simpleButton3
			// 
			this.simpleButton3.Location = new System.Drawing.Point(10, 129);
			this.simpleButton3.Name = "simpleButton3";
			this.simpleButton3.Size = new System.Drawing.Size(155, 56);
			this.simpleButton3.TabIndex = 0;
			this.simpleButton3.Text = "Delete";
			this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
			// 
			// simpleButton2
			// 
			this.simpleButton2.Location = new System.Drawing.Point(10, 67);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(155, 56);
			this.simpleButton2.TabIndex = 0;
			this.simpleButton2.Text = "Add";
			this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(10, 5);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(155, 56);
			this.simpleButton1.TabIndex = 0;
			this.simpleButton1.Text = "Save";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// panelControl2
			// 
			this.panelControl2.Controls.Add(this.txtparentguid);
			this.panelControl2.Controls.Add(this.Group);
			this.panelControl2.Controls.Add(this.txtPriceMany);
			this.panelControl2.Controls.Add(this.txtPriceSingle);
			this.panelControl2.Controls.Add(this.labelControl7);
			this.panelControl2.Controls.Add(this.txtPrice);
			this.panelControl2.Controls.Add(this.labelControl4);
			this.panelControl2.Controls.Add(this.labelControl5);
			this.panelControl2.Controls.Add(this.labelControl6);
			this.panelControl2.Controls.Add(this.txtName);
			this.panelControl2.Controls.Add(this.txtCode);
			this.panelControl2.Controls.Add(this.txtGuid);
			this.panelControl2.Controls.Add(this.labelControl3);
			this.panelControl2.Controls.Add(this.labelControl2);
			this.panelControl2.Controls.Add(this.labelControl1);
			this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl2.Location = new System.Drawing.Point(197, 2);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(687, 534);
			this.panelControl2.TabIndex = 0;
			// 
			// Group
			// 
			this.Group.Location = new System.Drawing.Point(37, 343);
			this.Group.Name = "Group";
			this.Group.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Group.Properties.Appearance.Options.UseFont = true;
			this.Group.Properties.Caption = "Group";
			this.Group.Size = new System.Drawing.Size(158, 25);
			this.Group.TabIndex = 8;
			// 
			// txtPriceMany
			// 
			this.txtPriceMany.Location = new System.Drawing.Point(37, 261);
			this.txtPriceMany.Name = "txtPriceMany";
			this.txtPriceMany.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPriceMany.Properties.Appearance.Options.UseFont = true;
			this.txtPriceMany.Size = new System.Drawing.Size(243, 28);
			this.txtPriceMany.TabIndex = 5;
			// 
			// txtPriceSingle
			// 
			this.txtPriceSingle.Location = new System.Drawing.Point(37, 215);
			this.txtPriceSingle.Name = "txtPriceSingle";
			this.txtPriceSingle.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPriceSingle.Properties.Appearance.Options.UseFont = true;
			this.txtPriceSingle.Size = new System.Drawing.Size(243, 28);
			this.txtPriceSingle.TabIndex = 6;
			// 
			// labelControl7
			// 
			this.labelControl7.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl7.Appearance.Options.UseFont = true;
			this.labelControl7.Location = new System.Drawing.Point(297, 312);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(110, 21);
			this.labelControl7.TabIndex = 2;
			this.labelControl7.Text = "parent Guid";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(37, 170);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrice.Properties.Appearance.Options.UseFont = true;
			this.txtPrice.Size = new System.Drawing.Size(243, 28);
			this.txtPrice.TabIndex = 7;
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Location = new System.Drawing.Point(297, 264);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(150, 21);
			this.labelControl4.TabIndex = 2;
			this.labelControl4.Text = "item Price Many";
			// 
			// labelControl5
			// 
			this.labelControl5.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl5.Appearance.Options.UseFont = true;
			this.labelControl5.Location = new System.Drawing.Point(297, 218);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(170, 21);
			this.labelControl5.TabIndex = 3;
			this.labelControl5.Text = "item Price Single";
			// 
			// labelControl6
			// 
			this.labelControl6.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl6.Appearance.Options.UseFont = true;
			this.labelControl6.Location = new System.Drawing.Point(297, 173);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(100, 21);
			this.labelControl6.TabIndex = 4;
			this.labelControl6.Text = "item Price";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(37, 126);
			this.txtName.Name = "txtName";
			this.txtName.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Properties.Appearance.Options.UseFont = true;
			this.txtName.Size = new System.Drawing.Size(243, 28);
			this.txtName.TabIndex = 1;
			// 
			// txtCode
			// 
			this.txtCode.Location = new System.Drawing.Point(37, 80);
			this.txtCode.Name = "txtCode";
			this.txtCode.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCode.Properties.Appearance.Options.UseFont = true;
			this.txtCode.Size = new System.Drawing.Size(243, 28);
			this.txtCode.TabIndex = 1;
			// 
			// txtGuid
			// 
			this.txtGuid.Location = new System.Drawing.Point(37, 35);
			this.txtGuid.Name = "txtGuid";
			this.txtGuid.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGuid.Properties.Appearance.Options.UseFont = true;
			this.txtGuid.Size = new System.Drawing.Size(243, 28);
			this.txtGuid.TabIndex = 1;
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(297, 129);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(90, 21);
			this.labelControl3.TabIndex = 0;
			this.labelControl3.Text = "item Name";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(297, 83);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(90, 21);
			this.labelControl2.TabIndex = 0;
			this.labelControl2.Text = "item code";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(297, 38);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(90, 21);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "item Guid";
			// 
			// txtparentguid
			// 
			this.txtparentguid.Location = new System.Drawing.Point(37, 308);
			this.txtparentguid.Name = "txtparentguid";
			this.txtparentguid.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtparentguid.Properties.Appearance.Options.UseFont = true;
			this.txtparentguid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtparentguid.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("itemGuid", "item guid", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("itemName", "item name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("parentGuid", "parent guid", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.txtparentguid.Properties.DataSource = this.tBItemBindingSource;
			this.txtparentguid.Properties.DisplayMember = "itemName";
			this.txtparentguid.Properties.NullText = "";
			this.txtparentguid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.txtparentguid.Properties.ValueMember = "itemGuid";
			this.txtparentguid.Size = new System.Drawing.Size(243, 28);
			this.txtparentguid.TabIndex = 9;
			// 
			// tB_ItemBindingSource
			// 
			this.tB_ItemBindingSource.DataMember = "TB_Item";
			this.tB_ItemBindingSource.DataSource = this.billsDB1;
			this.tB_ItemBindingSource.Sort = "itemcode ASC";
			// 
			// billsDB1
			// 
			this.billsDB1.DataSetName = "BillsDB";
			this.billsDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tB_ItemTableAdapter1
			// 
			this.tB_ItemTableAdapter1.ClearBeforeFill = true;
			// 
			// tBItemBindingSource
			// 
			this.tBItemBindingSource.DataMember = "TB_Item";
			this.tBItemBindingSource.DataSource = this.billsDB1;
			// 
			// Frm_ItemForms
			// 
			this.Appearance.Options.UseFont = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(886, 538);
			this.Controls.Add(this.panelControl1);
			this.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Frm_ItemForms";
			this.Text = "Frm_ItemForms";
			this.Load += new System.EventHandler(this.Frm_ItemForms_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
			this.panelControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			this.panelControl2.ResumeLayout(false);
			this.panelControl2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Group.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPriceMany.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPriceSingle.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGuid.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtparentguid.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tB_ItemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDB1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBItemBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.PanelControl panelControl3;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.PanelControl panelControl2;
		private DevExpress.XtraEditors.SimpleButton simpleButton3;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraEditors.CheckEdit Group;
		private DevExpress.XtraEditors.TextEdit txtPriceMany;
		private DevExpress.XtraEditors.TextEdit txtPriceSingle;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.TextEdit txtPrice;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.TextEdit txtName;
		private DevExpress.XtraEditors.TextEdit txtCode;
		private DevExpress.XtraEditors.TextEdit txtGuid;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LookUpEdit txtparentguid;
		private System.Windows.Forms.BindingSource tB_ItemBindingSource;
		private BillsDB billsDB1;
		private BillsDBTableAdapters.TB_ItemTableAdapter tB_ItemTableAdapter1;
		private System.Windows.Forms.BindingSource tBItemBindingSource;
	}
}