namespace PTHOrder.Forms
{
    partial class frmListOrder_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListOrder_Update));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtOrderCode = new DevExpress.XtraEditors.TextEdit();
            this.txtFollowers = new DevExpress.XtraEditors.TextEdit();
            this.txtPlaceOfDelivery = new DevExpress.XtraEditors.TextEdit();
            this.txtPaymentConditions = new DevExpress.XtraEditors.TextEdit();
            this.txtVAT = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.btnSaveNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.dateSuggestDate = new DevExpress.XtraEditors.DateEdit();
            this.dateDeliveryDate = new DevExpress.XtraEditors.DateEdit();
            this.cboSupplier = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSupplierCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridItem = new DevExpress.XtraGrid.GridControl();
            this.gridItemDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescribe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonetize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierSuggest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDetailCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFollowers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaceOfDelivery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentConditions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVAT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSuggestDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSuggestDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDeliveryDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Đơn Đặt Hàng:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(46, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Ngày Đề Nghị:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(43, 62);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Người Theo Dõi";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(26, 88);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(94, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Tên Nhà Cung Cấp:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(63, 114);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Ngày Giao:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(45, 140);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Địa Điểm Giao:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(7, 170);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(109, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Điều Kiện Thanh Toán:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(66, 196);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(50, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Thuế VAT:";
            // 
            // txtOrderCode
            // 
            this.txtOrderCode.Location = new System.Drawing.Point(140, 4);
            this.txtOrderCode.Name = "txtOrderCode";
            this.txtOrderCode.Size = new System.Drawing.Size(129, 20);
            this.txtOrderCode.TabIndex = 1;
            // 
            // txtFollowers
            // 
            this.txtFollowers.Location = new System.Drawing.Point(140, 55);
            this.txtFollowers.Name = "txtFollowers";
            this.txtFollowers.Size = new System.Drawing.Size(234, 20);
            this.txtFollowers.TabIndex = 3;
            // 
            // txtPlaceOfDelivery
            // 
            this.txtPlaceOfDelivery.Location = new System.Drawing.Point(140, 133);
            this.txtPlaceOfDelivery.Name = "txtPlaceOfDelivery";
            this.txtPlaceOfDelivery.Size = new System.Drawing.Size(234, 20);
            this.txtPlaceOfDelivery.TabIndex = 6;
            // 
            // txtPaymentConditions
            // 
            this.txtPaymentConditions.Location = new System.Drawing.Point(140, 163);
            this.txtPaymentConditions.Name = "txtPaymentConditions";
            this.txtPaymentConditions.Size = new System.Drawing.Size(234, 20);
            this.txtPaymentConditions.TabIndex = 7;
            // 
            // txtVAT
            // 
            this.txtVAT.EditValue = ((short)(10));
            this.txtVAT.Location = new System.Drawing.Point(140, 189);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(28, 20);
            this.txtVAT.TabIndex = 8;
            this.txtVAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVAT_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.ImageIndex = 1;
            this.btnSave.ImageList = this.imageCollection1;
            this.btnSave.Location = new System.Drawing.Point(165, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 38);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Lưu && Đóng";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "Action_Save_New_32x32.png");
            this.imageCollection1.Images.SetKeyName(1, "Action_Save_Close_32x32.png");
            this.imageCollection1.Images.SetKeyName(2, "Action_Exit_32x32.png");
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.ImageIndex = 0;
            this.btnSaveNew.ImageList = this.imageCollection1;
            this.btnSaveNew.Location = new System.Drawing.Point(271, 392);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(107, 38);
            this.btnSaveNew.TabIndex = 10;
            this.btnSaveNew.Text = "Lưu && Thêm";
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.ImageIndex = 2;
            this.btnExit.ImageList = this.imageCollection1;
            this.btnExit.Location = new System.Drawing.Point(378, 392);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 38);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Đóng";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dateSuggestDate
            // 
            this.dateSuggestDate.EditValue = null;
            this.dateSuggestDate.Location = new System.Drawing.Point(140, 30);
            this.dateSuggestDate.Name = "dateSuggestDate";
            this.dateSuggestDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSuggestDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateSuggestDate.Size = new System.Drawing.Size(100, 20);
            this.dateSuggestDate.TabIndex = 2;
            // 
            // dateDeliveryDate
            // 
            this.dateDeliveryDate.EditValue = null;
            this.dateDeliveryDate.Location = new System.Drawing.Point(140, 107);
            this.dateDeliveryDate.Name = "dateDeliveryDate";
            this.dateDeliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDeliveryDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateDeliveryDate.Size = new System.Drawing.Size(100, 20);
            this.dateDeliveryDate.TabIndex = 5;
            // 
            // cboSupplier
            // 
            this.cboSupplier.EnterMoveNextControl = true;
            this.cboSupplier.Location = new System.Drawing.Point(140, 81);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "Them", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.cboSupplier.Properties.NullText = "[Vui lòng chọn nhà cung cấp]";
            this.cboSupplier.Properties.ShowFooter = false;
            this.cboSupplier.Properties.View = this.gridLookUpEdit1View;
            this.cboSupplier.Size = new System.Drawing.Size(234, 20);
            this.cboSupplier.TabIndex = 12;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSupplierCode,
            this.colSupplierName});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colSupplierCode
            // 
            this.colSupplierCode.Caption = "Mã NCC";
            this.colSupplierCode.FieldName = "SupplierCode";
            this.colSupplierCode.Name = "colSupplierCode";
            this.colSupplierCode.Visible = true;
            this.colSupplierCode.VisibleIndex = 0;
            this.colSupplierCode.Width = 240;
            // 
            // colSupplierName
            // 
            this.colSupplierName.Caption = "Tên Nhà Cung Cấp";
            this.colSupplierName.FieldName = "SupplierName";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.Visible = true;
            this.colSupplierName.VisibleIndex = 1;
            this.colSupplierName.Width = 854;
            // 
            // gridItem
            // 
            this.gridItem.Location = new System.Drawing.Point(26, 228);
            this.gridItem.MainView = this.gridItemDetail;
            this.gridItem.Name = "gridItem";
            this.gridItem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemCalcEdit1});
            this.gridItem.Size = new System.Drawing.Size(614, 158);
            this.gridItem.TabIndex = 13;
            this.gridItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridItemDetail});
            // 
            // gridItemDetail
            // 
            this.gridItemDetail.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridItemDetail.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridItemDetail.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            this.gridItemDetail.Appearance.TopNewRow.Options.UseFont = true;
            this.gridItemDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescribe,
            this.colNumber,
            this.colUnit,
            this.colPrice,
            this.colMonetize,
            this.colOrderCode,
            this.colSupplierSuggest,
            this.colOrderDetailCode});
            this.gridItemDetail.GridControl = this.gridItem;
            this.gridItemDetail.IndicatorWidth = 45;
            this.gridItemDetail.Name = "gridItemDetail";
            this.gridItemDetail.OptionsCustomization.AllowFilter = false;
            this.gridItemDetail.OptionsCustomization.AllowSort = false;
            this.gridItemDetail.OptionsView.ColumnAutoWidth = false;
            this.gridItemDetail.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridItemDetail.OptionsView.ShowGroupPanel = false;
            this.gridItemDetail.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridItemDetail_CellValueChanged);
            this.gridItemDetail.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridItemDetail_ValidateRow);
            this.gridItemDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridItemDetail_KeyDown);
            // 
            // colDescribe
            // 
            this.colDescribe.Caption = "Mô tả";
            this.colDescribe.FieldName = "Describe";
            this.colDescribe.Name = "colDescribe";
            this.colDescribe.Visible = true;
            this.colDescribe.VisibleIndex = 0;
            this.colDescribe.Width = 138;
            // 
            // colNumber
            // 
            this.colNumber.Caption = "Số lượng";
            this.colNumber.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 1;
            this.colNumber.Width = 57;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            this.repositoryItemCalcEdit1.NullText = "0";
            this.repositoryItemCalcEdit1.NullValuePrompt = "0";
            // 
            // colUnit
            // 
            this.colUnit.Caption = "Đơn vị";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 2;
            this.colUnit.Width = 61;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Giá";
            this.colPrice.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            this.colPrice.Width = 68;
            // 
            // colMonetize
            // 
            this.colMonetize.Caption = "Thành tiền";
            this.colMonetize.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colMonetize.FieldName = "Monetize";
            this.colMonetize.Name = "colMonetize";
            this.colMonetize.OptionsColumn.AllowEdit = false;
            this.colMonetize.Visible = true;
            this.colMonetize.VisibleIndex = 4;
            this.colMonetize.Width = 85;
            // 
            // colOrderCode
            // 
            this.colOrderCode.Caption = "Số DH";
            this.colOrderCode.FieldName = "OrderCode";
            this.colOrderCode.Name = "colOrderCode";
            // 
            // colSupplierSuggest
            // 
            this.colSupplierSuggest.Caption = "Nhà Cung cấp đề cử";
            this.colSupplierSuggest.FieldName = "SupplierSuggest";
            this.colSupplierSuggest.Name = "colSupplierSuggest";
            this.colSupplierSuggest.Visible = true;
            this.colSupplierSuggest.VisibleIndex = 5;
            this.colSupplierSuggest.Width = 149;
            // 
            // colOrderDetailCode
            // 
            this.colOrderDetailCode.Caption = "OrderDetailCode";
            this.colOrderDetailCode.FieldName = "OrderDetailCode";
            this.colOrderDetailCode.Name = "colOrderDetailCode";
            this.colOrderDetailCode.Width = 117;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.ValidateOnEnterKey = true;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(170, 192);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(11, 13);
            this.labelControl9.TabIndex = 14;
            this.labelControl9.Text = "%";
            // 
            // frmListOrder_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 453);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.gridItem);
            this.Controls.Add(this.cboSupplier);
            this.Controls.Add(this.dateDeliveryDate);
            this.Controls.Add(this.dateSuggestDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.txtPaymentConditions);
            this.Controls.Add(this.txtPlaceOfDelivery);
            this.Controls.Add(this.txtFollowers);
            this.Controls.Add(this.txtOrderCode);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmListOrder_Update";
            this.Text = "frmListOrder_Update";
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFollowers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaceOfDelivery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentConditions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVAT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSuggestDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSuggestDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDeliveryDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtOrderCode;
        private DevExpress.XtraEditors.TextEdit txtFollowers;
        private DevExpress.XtraEditors.TextEdit txtPlaceOfDelivery;
        private DevExpress.XtraEditors.TextEdit txtPaymentConditions;
        private DevExpress.XtraEditors.TextEdit txtVAT;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnSaveNew;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.DateEdit dateSuggestDate;
        private DevExpress.XtraEditors.DateEdit dateDeliveryDate;
        private DevExpress.XtraEditors.GridLookUpEdit cboSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private DevExpress.XtraGrid.GridControl gridItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridItemDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colDescribe;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colMonetize;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierSuggest;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDetailCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}