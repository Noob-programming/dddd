namespace ItemStockRepoPattern.View.Forms
{
	partial class Frm_ShoppingCart
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
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.txtSalesOrderGuid = new DevExpress.XtraEditors.TextEdit();
			this.labels = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.LookItemGuid = new DevExpress.XtraEditors.LookUpEdit();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.txtShoppingID = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.txtPrice = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.txtTotal = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
			this.LookBillGuid = new DevExpress.XtraEditors.LookUpEdit();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
			this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSalesOrderGuid.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.labels)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LookItemGuid.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtShoppingID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LookBillGuid.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.layoutControl1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1210, 754);
			this.panelControl1.TabIndex = 0;
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.gridControl1);
			this.layoutControl1.Controls.Add(this.simpleButton3);
			this.layoutControl1.Controls.Add(this.simpleButton2);
			this.layoutControl1.Controls.Add(this.simpleButton1);
			this.layoutControl1.Controls.Add(this.LookBillGuid);
			this.layoutControl1.Controls.Add(this.txtTotal);
			this.layoutControl1.Controls.Add(this.txtPrice);
			this.layoutControl1.Controls.Add(this.txtQuantity);
			this.layoutControl1.Controls.Add(this.txtShoppingID);
			this.layoutControl1.Controls.Add(this.LookItemGuid);
			this.layoutControl1.Controls.Add(this.txtSalesOrderGuid);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(2, 2);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(1206, 750);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.labels,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem9,
            this.layoutControlItem8,
            this.layoutControlItem10});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1206, 750);
			this.Root.TextVisible = false;
			// 
			// txtSalesOrderGuid
			// 
			this.txtSalesOrderGuid.Location = new System.Drawing.Point(164, 12);
			this.txtSalesOrderGuid.Name = "txtSalesOrderGuid";
			this.txtSalesOrderGuid.Size = new System.Drawing.Size(1030, 20);
			this.txtSalesOrderGuid.StyleController = this.layoutControl1;
			this.txtSalesOrderGuid.TabIndex = 4;
			// 
			// labels
			// 
			this.labels.AppearanceItemCaption.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labels.AppearanceItemCaption.Options.UseFont = true;
			this.labels.AppearanceItemCaption.Options.UseTextOptions = true;
			this.labels.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.labels.Control = this.txtSalesOrderGuid;
			this.labels.Location = new System.Drawing.Point(0, 0);
			this.labels.Name = "labels";
			this.labels.Size = new System.Drawing.Size(1186, 25);
			this.labels.Text = "SalesOrderGuid";
			this.labels.TextSize = new System.Drawing.Size(140, 21);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 243);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(1186, 20);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// LookItemGuid
			// 
			this.LookItemGuid.Location = new System.Drawing.Point(164, 37);
			this.LookItemGuid.Name = "LookItemGuid";
			this.LookItemGuid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.LookItemGuid.Properties.NullText = "";
			this.LookItemGuid.Size = new System.Drawing.Size(1030, 20);
			this.LookItemGuid.StyleController = this.layoutControl1;
			this.LookItemGuid.TabIndex = 5;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
			this.layoutControlItem2.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.layoutControlItem2.Control = this.LookItemGuid;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 25);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(1186, 25);
			this.layoutControlItem2.Text = "item Guid";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(140, 21);
			// 
			// txtShoppingID
			// 
			this.txtShoppingID.Location = new System.Drawing.Point(164, 87);
			this.txtShoppingID.Name = "txtShoppingID";
			this.txtShoppingID.Size = new System.Drawing.Size(1030, 20);
			this.txtShoppingID.StyleController = this.layoutControl1;
			this.txtShoppingID.TabIndex = 6;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
			this.layoutControlItem4.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.layoutControlItem4.Control = this.txtShoppingID;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 75);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(1186, 25);
			this.layoutControlItem4.Text = "Shopping ID";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(140, 21);
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(164, 112);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(1030, 20);
			this.txtQuantity.StyleController = this.layoutControl1;
			this.txtQuantity.TabIndex = 7;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
			this.layoutControlItem5.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.layoutControlItem5.Control = this.txtQuantity;
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 100);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(1186, 25);
			this.layoutControlItem5.Text = "Quantity";
			this.layoutControlItem5.TextSize = new System.Drawing.Size(140, 21);
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(164, 137);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(1030, 20);
			this.txtPrice.StyleController = this.layoutControl1;
			this.txtPrice.TabIndex = 8;
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
			this.layoutControlItem6.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.layoutControlItem6.Control = this.txtPrice;
			this.layoutControlItem6.Enabled = false;
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 125);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(1186, 25);
			this.layoutControlItem6.Text = "Prices";
			this.layoutControlItem6.TextSize = new System.Drawing.Size(140, 21);
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(164, 162);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(1030, 20);
			this.txtTotal.StyleController = this.layoutControl1;
			this.txtTotal.TabIndex = 9;
			// 
			// layoutControlItem7
			// 
			this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = true;
			this.layoutControlItem7.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.layoutControlItem7.Control = this.txtTotal;
			this.layoutControlItem7.Enabled = false;
			this.layoutControlItem7.Location = new System.Drawing.Point(0, 150);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Size = new System.Drawing.Size(1186, 25);
			this.layoutControlItem7.Text = "Total";
			this.layoutControlItem7.TextSize = new System.Drawing.Size(140, 21);
			// 
			// LookBillGuid
			// 
			this.LookBillGuid.Location = new System.Drawing.Point(164, 62);
			this.LookBillGuid.Name = "LookBillGuid";
			this.LookBillGuid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.LookBillGuid.Properties.NullText = "";
			this.LookBillGuid.Size = new System.Drawing.Size(1030, 20);
			this.LookBillGuid.StyleController = this.layoutControl1;
			this.LookBillGuid.TabIndex = 10;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem3.Control = this.LookBillGuid;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 50);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(1186, 25);
			this.layoutControlItem3.Text = "Bill Guid";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(140, 21);
			// 
			// simpleButton1
			// 
			this.simpleButton1.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButton1.Appearance.Options.UseFont = true;
			this.simpleButton1.Appearance.Options.UseTextOptions = true;
			this.simpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.simpleButton1.Location = new System.Drawing.Point(12, 187);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(589, 30);
			this.simpleButton1.StyleController = this.layoutControl1;
			this.simpleButton1.TabIndex = 11;
			this.simpleButton1.Text = "Add";
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.simpleButton1;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 175);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(593, 34);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// simpleButton2
			// 
			this.simpleButton2.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButton2.Appearance.Options.UseFont = true;
			this.simpleButton2.Appearance.Options.UseTextOptions = true;
			this.simpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.simpleButton2.Location = new System.Drawing.Point(605, 187);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(589, 30);
			this.simpleButton2.StyleController = this.layoutControl1;
			this.simpleButton2.TabIndex = 12;
			this.simpleButton2.Text = "Save";
			// 
			// layoutControlItem8
			// 
			this.layoutControlItem8.Control = this.simpleButton2;
			this.layoutControlItem8.Location = new System.Drawing.Point(593, 175);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Size = new System.Drawing.Size(593, 34);
			this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem8.TextVisible = false;
			// 
			// simpleButton3
			// 
			this.simpleButton3.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButton3.Appearance.Options.UseFont = true;
			this.simpleButton3.Appearance.Options.UseTextOptions = true;
			this.simpleButton3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.simpleButton3.Location = new System.Drawing.Point(12, 221);
			this.simpleButton3.Name = "simpleButton3";
			this.simpleButton3.Size = new System.Drawing.Size(1182, 30);
			this.simpleButton3.StyleController = this.layoutControl1;
			this.simpleButton3.TabIndex = 13;
			this.simpleButton3.Text = "Delete";
			// 
			// layoutControlItem9
			// 
			this.layoutControlItem9.Control = this.simpleButton3;
			this.layoutControlItem9.Location = new System.Drawing.Point(0, 209);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Size = new System.Drawing.Size(1186, 34);
			this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem9.TextVisible = false;
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(12, 275);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1182, 463);
			this.gridControl1.TabIndex = 14;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			// 
			// layoutControlItem10
			// 
			this.layoutControlItem10.Control = this.gridControl1;
			this.layoutControlItem10.Location = new System.Drawing.Point(0, 263);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Size = new System.Drawing.Size(1186, 467);
			this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem10.TextVisible = false;
			// 
			// Frm_ShoppingCart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1210, 754);
			this.Controls.Add(this.panelControl1);
			this.Name = "Frm_ShoppingCart";
			this.Text = "Frm_ShoppingCart";
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSalesOrderGuid.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.labels)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LookItemGuid.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtShoppingID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LookBillGuid.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraEditors.LookUpEdit LookItemGuid;
		private DevExpress.XtraEditors.TextEdit txtSalesOrderGuid;
		private DevExpress.XtraLayout.LayoutControlItem labels;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraEditors.LookUpEdit LookBillGuid;
		private DevExpress.XtraEditors.TextEdit txtTotal;
		private DevExpress.XtraEditors.TextEdit txtPrice;
		private DevExpress.XtraEditors.TextEdit txtQuantity;
		private DevExpress.XtraEditors.TextEdit txtShoppingID;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.SimpleButton simpleButton3;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
	}
}