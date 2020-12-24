namespace WindowsFormsApplication3 {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rpgFun = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.cboProductType = new DevExpress.XtraBars.BarEditItem();
            this.beiElectrolyteNo = new DevExpress.XtraBars.BarEditItem();
            this.beiMinBefore = new DevExpress.XtraBars.BarEditItem();
            this.beiMaxBefore = new DevExpress.XtraBars.BarEditItem();
            this.beiMinScope = new DevExpress.XtraBars.BarEditItem();
            this.beiMaxScope = new DevExpress.XtraBars.BarEditItem();
            this.beiBarCodeLen = new DevExpress.XtraBars.BarEditItem();
            this.beiPrefixData = new DevExpress.XtraBars.BarEditItem();
            this.beiPrefixLen = new DevExpress.XtraBars.BarEditItem();
            this.beiInjectionNeedle = new DevExpress.XtraBars.BarEditItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiModify = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTopping = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMoveUp = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMoveDown = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSetTheButton = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rpgFun
            // 
            this.rpgFun.Name = "rpgFun";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.cboProductType,
            this.beiElectrolyteNo,
            this.beiMinBefore,
            this.beiMaxBefore,
            this.beiMinScope,
            this.beiMaxScope,
            this.beiBarCodeLen,
            this.beiPrefixData,
            this.beiPrefixLen,
            this.beiInjectionNeedle,
            this.bbiRefresh,
            this.bbiModify,
            this.bbiSave,
            this.bbiCancel,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.bbiTopping,
            this.bbiMoveUp,
            this.bbiMoveDown,
            this.bbiSetTheButton});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(969, 122);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 110;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 111;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "产品型号";
            this.barButtonItem3.Id = 114;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "系统设置";
            this.barButtonItem4.Id = 115;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 116;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // cboProductType
            // 
            this.cboProductType.Caption = "   产品型号：";
            this.cboProductType.Edit = null;
            this.cboProductType.EditHeight = 30;
            this.cboProductType.EditWidth = 120;
            this.cboProductType.Id = 120;
            this.cboProductType.Name = "cboProductType";
            // 
            // beiElectrolyteNo
            // 
            this.beiElectrolyteNo.Caption = "电解液批次：";
            this.beiElectrolyteNo.Edit = null;
            this.beiElectrolyteNo.EditHeight = 30;
            this.beiElectrolyteNo.EditWidth = 120;
            this.beiElectrolyteNo.Id = 121;
            this.beiElectrolyteNo.Name = "beiElectrolyteNo";
            // 
            // beiMinBefore
            // 
            this.beiMinBefore.Caption = "最小值：";
            this.beiMinBefore.Edit = null;
            this.beiMinBefore.EditHeight = 30;
            this.beiMinBefore.EditWidth = 60;
            this.beiMinBefore.Id = 122;
            this.beiMinBefore.Name = "beiMinBefore";
            // 
            // beiMaxBefore
            // 
            this.beiMaxBefore.Caption = "最大值：";
            this.beiMaxBefore.Edit = null;
            this.beiMaxBefore.EditHeight = 30;
            this.beiMaxBefore.EditWidth = 60;
            this.beiMaxBefore.Id = 123;
            this.beiMaxBefore.Name = "beiMaxBefore";
            // 
            // beiMinScope
            // 
            this.beiMinScope.Caption = "最小值";
            this.beiMinScope.Edit = null;
            this.beiMinScope.EditHeight = 30;
            this.beiMinScope.EditWidth = 60;
            this.beiMinScope.Id = 124;
            this.beiMinScope.Name = "beiMinScope";
            // 
            // beiMaxScope
            // 
            this.beiMaxScope.Caption = "最大值";
            this.beiMaxScope.Edit = null;
            this.beiMaxScope.EditHeight = 30;
            this.beiMaxScope.EditWidth = 60;
            this.beiMaxScope.Id = 125;
            this.beiMaxScope.Name = "beiMaxScope";
            // 
            // beiBarCodeLen
            // 
            this.beiBarCodeLen.Caption = "最大长度";
            this.beiBarCodeLen.Edit = null;
            this.beiBarCodeLen.EditHeight = 30;
            this.beiBarCodeLen.EditWidth = 60;
            this.beiBarCodeLen.Id = 126;
            this.beiBarCodeLen.Name = "beiBarCodeLen";
            // 
            // beiPrefixData
            // 
            this.beiPrefixData.Caption = "前缀位数";
            this.beiPrefixData.Edit = null;
            this.beiPrefixData.EditHeight = 30;
            this.beiPrefixData.EditWidth = 60;
            this.beiPrefixData.Id = 127;
            this.beiPrefixData.Name = "beiPrefixData";
            // 
            // beiPrefixLen
            // 
            this.beiPrefixLen.Caption = "前缀位数";
            this.beiPrefixLen.Edit = null;
            this.beiPrefixLen.EditHeight = 30;
            this.beiPrefixLen.EditWidth = 60;
            this.beiPrefixLen.Id = 128;
            this.beiPrefixLen.Name = "beiPrefixLen";
            // 
            // beiInjectionNeedle
            // 
            this.beiInjectionNeedle.Caption = "针头数量";
            this.beiInjectionNeedle.Edit = null;
            this.beiInjectionNeedle.EditHeight = 30;
            this.beiInjectionNeedle.EditWidth = 60;
            this.beiInjectionNeedle.Id = 129;
            this.beiInjectionNeedle.Name = "beiInjectionNeedle";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "刷新";
            this.bbiRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiRefresh.Glyph")));
            this.bbiRefresh.Id = 141;
            this.bbiRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiRefresh.LargeGlyph")));
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.Tag = "0";
            // 
            // bbiModify
            // 
            this.bbiModify.Caption = "修改";
            this.bbiModify.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiModify.Glyph")));
            this.bbiModify.Id = 143;
            this.bbiModify.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiModify.LargeGlyph")));
            this.bbiModify.Name = "bbiModify";
            this.bbiModify.Tag = "1";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "保存";
            this.bbiSave.Enabled = false;
            this.bbiSave.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiSave.Glyph")));
            this.bbiSave.Id = 145;
            this.bbiSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSave.LargeGlyph")));
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.Tag = "2";
            // 
            // bbiCancel
            // 
            this.bbiCancel.Caption = "取消";
            this.bbiCancel.Enabled = false;
            this.bbiCancel.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiCancel.Glyph")));
            this.bbiCancel.Id = 146;
            this.bbiCancel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiCancel.LargeGlyph")));
            this.bbiCancel.Name = "bbiCancel";
            this.bbiCancel.Tag = "3";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "新增行";
            this.barButtonItem7.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.Glyph")));
            this.barButtonItem7.Id = 148;
            this.barButtonItem7.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.LargeGlyph")));
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barButtonItem7.Tag = "5";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "插入行";
            this.barButtonItem8.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.Glyph")));
            this.barButtonItem8.Id = 149;
            this.barButtonItem8.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.LargeGlyph")));
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem8.Tag = "6";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "删除行";
            this.barButtonItem9.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.Glyph")));
            this.barButtonItem9.Id = 150;
            this.barButtonItem9.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.LargeGlyph")));
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barButtonItem9.Tag = "7";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "导出";
            this.barButtonItem10.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.Glyph")));
            this.barButtonItem10.Id = 151;
            this.barButtonItem10.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.LargeGlyph")));
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.Tag = "4";
            // 
            // bbiTopping
            // 
            this.bbiTopping.Caption = "置顶";
            this.bbiTopping.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiTopping.Glyph")));
            this.bbiTopping.Id = 152;
            this.bbiTopping.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiTopping.LargeGlyph")));
            this.bbiTopping.Name = "bbiTopping";
            this.bbiTopping.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTopping_ItemClick);
            // 
            // bbiMoveUp
            // 
            this.bbiMoveUp.Caption = "上移";
            this.bbiMoveUp.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiMoveUp.Glyph")));
            this.bbiMoveUp.Id = 153;
            this.bbiMoveUp.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiMoveUp.LargeGlyph")));
            this.bbiMoveUp.Name = "bbiMoveUp";
            this.bbiMoveUp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMoveUp_ItemClick);
            // 
            // bbiMoveDown
            // 
            this.bbiMoveDown.Caption = "下移";
            this.bbiMoveDown.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiMoveDown.Glyph")));
            this.bbiMoveDown.Id = 154;
            this.bbiMoveDown.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiMoveDown.LargeGlyph")));
            this.bbiMoveDown.Name = "bbiMoveDown";
            this.bbiMoveDown.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMoveDown_ItemClick);
            // 
            // bbiSetTheButton
            // 
            this.bbiSetTheButton.Caption = "置底";
            this.bbiSetTheButton.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiSetTheButton.Glyph")));
            this.bbiSetTheButton.Id = 155;
            this.bbiSetTheButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSetTheButton.LargeGlyph")));
            this.bbiSetTheButton.Name = "bbiSetTheButton";
            this.bbiSetTheButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSetTheButton_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "基础资料";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiTopping, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiMoveUp);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiMoveDown);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSetTheButton);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 122);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(969, 457);
            this.gridControl1.TabIndex = 1;
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
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "姓名";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "年龄";
            this.gridColumn3.FieldName = "Age";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "性别";
            this.gridColumn4.FieldName = "Sex";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "出生日期";
            this.gridColumn5.FieldName = "BirthDate";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "地址";
            this.gridColumn6.FieldName = "Address";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "序号";
            this.gridColumn7.FieldName = "Seq";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 579);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgFun;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarEditItem cboProductType;
        private DevExpress.XtraBars.BarEditItem beiElectrolyteNo;
        private DevExpress.XtraBars.BarEditItem beiMinBefore;
        private DevExpress.XtraBars.BarEditItem beiMaxBefore;
        private DevExpress.XtraBars.BarEditItem beiMinScope;
        private DevExpress.XtraBars.BarEditItem beiMaxScope;
        private DevExpress.XtraBars.BarEditItem beiBarCodeLen;
        private DevExpress.XtraBars.BarEditItem beiPrefixData;
        private DevExpress.XtraBars.BarEditItem beiPrefixLen;
        private DevExpress.XtraBars.BarEditItem beiInjectionNeedle;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.BarButtonItem bbiModify;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiCancel;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem bbiTopping;
        private DevExpress.XtraBars.BarButtonItem bbiMoveUp;
        private DevExpress.XtraBars.BarButtonItem bbiMoveDown;
        private DevExpress.XtraBars.BarButtonItem bbiSetTheButton;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}

