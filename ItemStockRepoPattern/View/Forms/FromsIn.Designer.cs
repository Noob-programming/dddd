namespace ItemStockRepoPattern.View.Forms
{
	partial class FromsIn
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
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromsIn));
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
			this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			this.ItemGuidTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.itemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ItemNameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.ItemPriceTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.ItemPriceSingleTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.ItemPriceManyTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.ParentGuidButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
			this.ISgroupCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.ItemCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.ItemForItemGuid = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForItemName = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForItemPrice = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForItemPriceSingle = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForItemPriceMany = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForParentGuid = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForISgroup = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForItemCode = new DevExpress.XtraLayout.LayoutControlItem();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
			this.dataLayoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ItemGuidTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemModelBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemNameTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemPriceTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemPriceSingleTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemPriceManyTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ParentGuidButtonEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ISgroupCheckEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemCodeTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForItemGuid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForItemName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForItemPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForItemPriceSingle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForItemPriceMany)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForParentGuid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForISgroup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForItemCode)).BeginInit();
			this.SuspendLayout();
			// 
			// dataLayoutControl1
			// 
			this.dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.True;
			this.dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.True;
			this.dataLayoutControl1.Controls.Add(this.ItemGuidTextEdit);
			this.dataLayoutControl1.Controls.Add(this.ItemNameTextEdit);
			this.dataLayoutControl1.Controls.Add(this.ItemPriceTextEdit);
			this.dataLayoutControl1.Controls.Add(this.ItemPriceSingleTextEdit);
			this.dataLayoutControl1.Controls.Add(this.ItemPriceManyTextEdit);
			this.dataLayoutControl1.Controls.Add(this.ParentGuidButtonEdit);
			this.dataLayoutControl1.Controls.Add(this.ISgroupCheckEdit);
			this.dataLayoutControl1.Controls.Add(this.ItemCodeTextEdit);
			this.dataLayoutControl1.DataSource = this.itemModelBindingSource;
			this.dataLayoutControl1.Location = new System.Drawing.Point(12, 12);
			this.dataLayoutControl1.Name = "dataLayoutControl1";
			this.dataLayoutControl1.Root = this.Root;
			this.dataLayoutControl1.Size = new System.Drawing.Size(850, 256);
			this.dataLayoutControl1.TabIndex = 0;
			this.dataLayoutControl1.Text = "dataLayoutControl1";
			// 
			// ItemGuidTextEdit
			// 
			this.ItemGuidTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemModelBindingSource, "ItemGuid", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.ItemGuidTextEdit.Location = new System.Drawing.Point(101, 12);
			this.ItemGuidTextEdit.Name = "ItemGuidTextEdit";
			this.ItemGuidTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
			this.ItemGuidTextEdit.Size = new System.Drawing.Size(737, 20);
			this.ItemGuidTextEdit.StyleController = this.dataLayoutControl1;
			this.ItemGuidTextEdit.TabIndex = 4;
			// 
			// itemModelBindingSource
			// 
			this.itemModelBindingSource.DataSource = typeof(ItemStockRepoPattern.Model.ItemModel);
			// 
			// ItemNameTextEdit
			// 
			this.ItemNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemModelBindingSource, "ItemName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.ItemNameTextEdit.Location = new System.Drawing.Point(101, 36);
			this.ItemNameTextEdit.Name = "ItemNameTextEdit";
			this.ItemNameTextEdit.Size = new System.Drawing.Size(737, 20);
			this.ItemNameTextEdit.StyleController = this.dataLayoutControl1;
			this.ItemNameTextEdit.TabIndex = 5;
			// 
			// ItemPriceTextEdit
			// 
			this.ItemPriceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemModelBindingSource, "ItemPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.ItemPriceTextEdit.Location = new System.Drawing.Point(101, 60);
			this.ItemPriceTextEdit.Name = "ItemPriceTextEdit";
			this.ItemPriceTextEdit.Properties.Appearance.Options.UseTextOptions = true;
			this.ItemPriceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.ItemPriceTextEdit.Properties.Mask.EditMask = "G";
			this.ItemPriceTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.ItemPriceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.ItemPriceTextEdit.Size = new System.Drawing.Size(737, 20);
			this.ItemPriceTextEdit.StyleController = this.dataLayoutControl1;
			this.ItemPriceTextEdit.TabIndex = 6;
			// 
			// ItemPriceSingleTextEdit
			// 
			this.ItemPriceSingleTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemModelBindingSource, "ItemPriceSingle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.ItemPriceSingleTextEdit.Location = new System.Drawing.Point(101, 84);
			this.ItemPriceSingleTextEdit.Name = "ItemPriceSingleTextEdit";
			this.ItemPriceSingleTextEdit.Properties.Appearance.Options.UseTextOptions = true;
			this.ItemPriceSingleTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.ItemPriceSingleTextEdit.Properties.Mask.EditMask = "G";
			this.ItemPriceSingleTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.ItemPriceSingleTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.ItemPriceSingleTextEdit.Size = new System.Drawing.Size(737, 20);
			this.ItemPriceSingleTextEdit.StyleController = this.dataLayoutControl1;
			this.ItemPriceSingleTextEdit.TabIndex = 7;
			// 
			// ItemPriceManyTextEdit
			// 
			this.ItemPriceManyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemModelBindingSource, "ItemPriceMany", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.ItemPriceManyTextEdit.Location = new System.Drawing.Point(101, 108);
			this.ItemPriceManyTextEdit.Name = "ItemPriceManyTextEdit";
			this.ItemPriceManyTextEdit.Properties.Appearance.Options.UseTextOptions = true;
			this.ItemPriceManyTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.ItemPriceManyTextEdit.Properties.Mask.EditMask = "G";
			this.ItemPriceManyTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.ItemPriceManyTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.ItemPriceManyTextEdit.Size = new System.Drawing.Size(737, 20);
			this.ItemPriceManyTextEdit.StyleController = this.dataLayoutControl1;
			this.ItemPriceManyTextEdit.TabIndex = 8;
			// 
			// ParentGuidButtonEdit
			// 
			this.ParentGuidButtonEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemModelBindingSource, "ParentGuid", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.ParentGuidButtonEdit.Location = new System.Drawing.Point(101, 132);
			this.ParentGuidButtonEdit.Name = "ParentGuidButtonEdit";
			editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
			this.ParentGuidButtonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.ParentGuidButtonEdit.Size = new System.Drawing.Size(737, 40);
			this.ParentGuidButtonEdit.StyleController = this.dataLayoutControl1;
			this.ParentGuidButtonEdit.TabIndex = 9;
			this.ParentGuidButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ParentGuidButtonEdit_ButtonClick);
			// 
			// ISgroupCheckEdit
			// 
			this.ISgroupCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemModelBindingSource, "ISgroup", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.ISgroupCheckEdit.Location = new System.Drawing.Point(12, 176);
			this.ISgroupCheckEdit.Name = "ISgroupCheckEdit";
			this.ISgroupCheckEdit.Properties.Caption = "صنف";
			this.ISgroupCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.ISgroupCheckEdit.Size = new System.Drawing.Size(826, 20);
			this.ISgroupCheckEdit.StyleController = this.dataLayoutControl1;
			this.ISgroupCheckEdit.TabIndex = 10;
			// 
			// ItemCodeTextEdit
			// 
			this.ItemCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemModelBindingSource, "ItemCode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.ItemCodeTextEdit.Location = new System.Drawing.Point(101, 200);
			this.ItemCodeTextEdit.Name = "ItemCodeTextEdit";
			this.ItemCodeTextEdit.Properties.Appearance.Options.UseTextOptions = true;
			this.ItemCodeTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.ItemCodeTextEdit.Properties.Mask.EditMask = "N0";
			this.ItemCodeTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.ItemCodeTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.ItemCodeTextEdit.Size = new System.Drawing.Size(737, 20);
			this.ItemCodeTextEdit.StyleController = this.dataLayoutControl1;
			this.ItemCodeTextEdit.TabIndex = 11;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
			this.layoutControlGroup1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(850, 256);
			this.Root.TextVisible = false;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.AllowDrawBackground = false;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
			this.ItemForItemGuid,
			this.ItemForItemName,
			this.ItemForItemPrice,
			this.ItemForItemPriceSingle,
			this.ItemForItemPriceMany,
			this.ItemForParentGuid,
			this.ItemForISgroup,
			this.ItemForItemCode});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "autoGeneratedGroup0";
			this.layoutControlGroup1.Size = new System.Drawing.Size(830, 236);
			// 
			// ItemForItemGuid
			// 
			this.ItemForItemGuid.Control = this.ItemGuidTextEdit;
			this.ItemForItemGuid.Location = new System.Drawing.Point(0, 0);
			this.ItemForItemGuid.Name = "ItemForItemGuid";
			this.ItemForItemGuid.Size = new System.Drawing.Size(830, 24);
			this.ItemForItemGuid.TextSize = new System.Drawing.Size(77, 13);
			// 
			// ItemForItemName
			// 
			this.ItemForItemName.Control = this.ItemNameTextEdit;
			this.ItemForItemName.Location = new System.Drawing.Point(0, 24);
			this.ItemForItemName.Name = "ItemForItemName";
			this.ItemForItemName.Size = new System.Drawing.Size(830, 24);
			this.ItemForItemName.TextSize = new System.Drawing.Size(77, 13);
			// 
			// ItemForItemPrice
			// 
			this.ItemForItemPrice.Control = this.ItemPriceTextEdit;
			this.ItemForItemPrice.Location = new System.Drawing.Point(0, 48);
			this.ItemForItemPrice.Name = "ItemForItemPrice";
			this.ItemForItemPrice.Size = new System.Drawing.Size(830, 24);
			this.ItemForItemPrice.TextSize = new System.Drawing.Size(77, 13);
			// 
			// ItemForItemPriceSingle
			// 
			this.ItemForItemPriceSingle.Control = this.ItemPriceSingleTextEdit;
			this.ItemForItemPriceSingle.Location = new System.Drawing.Point(0, 72);
			this.ItemForItemPriceSingle.Name = "ItemForItemPriceSingle";
			this.ItemForItemPriceSingle.Size = new System.Drawing.Size(830, 24);
			this.ItemForItemPriceSingle.TextSize = new System.Drawing.Size(77, 13);
			// 
			// ItemForItemPriceMany
			// 
			this.ItemForItemPriceMany.Control = this.ItemPriceManyTextEdit;
			this.ItemForItemPriceMany.Location = new System.Drawing.Point(0, 96);
			this.ItemForItemPriceMany.Name = "ItemForItemPriceMany";
			this.ItemForItemPriceMany.Size = new System.Drawing.Size(830, 24);
			this.ItemForItemPriceMany.TextSize = new System.Drawing.Size(77, 13);
			// 
			// ItemForParentGuid
			// 
			this.ItemForParentGuid.Control = this.ParentGuidButtonEdit;
			this.ItemForParentGuid.Location = new System.Drawing.Point(0, 120);
			this.ItemForParentGuid.Name = "ItemForParentGuid";
			this.ItemForParentGuid.Size = new System.Drawing.Size(830, 44);
			this.ItemForParentGuid.TextSize = new System.Drawing.Size(77, 13);
			// 
			// ItemForISgroup
			// 
			this.ItemForISgroup.Control = this.ISgroupCheckEdit;
			this.ItemForISgroup.Location = new System.Drawing.Point(0, 164);
			this.ItemForISgroup.Name = "ItemForISgroup";
			this.ItemForISgroup.Size = new System.Drawing.Size(830, 24);
			this.ItemForISgroup.TextSize = new System.Drawing.Size(0, 0);
			this.ItemForISgroup.TextVisible = false;
			// 
			// ItemForItemCode
			// 
			this.ItemForItemCode.Control = this.ItemCodeTextEdit;
			this.ItemForItemCode.Location = new System.Drawing.Point(0, 188);
			this.ItemForItemCode.Name = "ItemForItemCode";
			this.ItemForItemCode.Size = new System.Drawing.Size(830, 48);
			this.ItemForItemCode.TextSize = new System.Drawing.Size(77, 13);
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(24, 315);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(337, 65);
			this.simpleButton1.TabIndex = 1;
			this.simpleButton1.Text = "simpleButton1";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// FromsIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(907, 440);
			this.Controls.Add(this.simpleButton1);
			this.Controls.Add(this.dataLayoutControl1);
			this.Name = "FromsIn";
			this.Text = "FromsIn";
			this.Load += new System.EventHandler(this.FromsIn_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
			this.dataLayoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ItemGuidTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemModelBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemNameTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemPriceTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemPriceSingleTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemPriceManyTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ParentGuidButtonEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ISgroupCheckEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemCodeTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForItemGuid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForItemName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForItemPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForItemPriceSingle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForItemPriceMany)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForParentGuid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForISgroup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForItemCode)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraEditors.TextEdit ItemGuidTextEdit;
		private System.Windows.Forms.BindingSource itemModelBindingSource;
		private DevExpress.XtraEditors.TextEdit ItemNameTextEdit;
		private DevExpress.XtraEditors.TextEdit ItemPriceTextEdit;
		private DevExpress.XtraEditors.TextEdit ItemPriceSingleTextEdit;
		private DevExpress.XtraEditors.TextEdit ItemPriceManyTextEdit;
		private DevExpress.XtraEditors.ButtonEdit ParentGuidButtonEdit;
		private DevExpress.XtraEditors.CheckEdit ISgroupCheckEdit;
		private DevExpress.XtraEditors.TextEdit ItemCodeTextEdit;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem ItemForItemGuid;
		private DevExpress.XtraLayout.LayoutControlItem ItemForItemName;
		private DevExpress.XtraLayout.LayoutControlItem ItemForItemPrice;
		private DevExpress.XtraLayout.LayoutControlItem ItemForItemPriceSingle;
		private DevExpress.XtraLayout.LayoutControlItem ItemForItemPriceMany;
		private DevExpress.XtraLayout.LayoutControlItem ItemForParentGuid;
		private DevExpress.XtraLayout.LayoutControlItem ItemForISgroup;
		private DevExpress.XtraLayout.LayoutControlItem ItemForItemCode;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
	}
}