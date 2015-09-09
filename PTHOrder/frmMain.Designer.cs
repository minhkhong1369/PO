namespace PTHOrder
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.defaultStyle = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePass = new DevExpress.XtraBars.BarButtonItem();
            this.btnListSupplier = new DevExpress.XtraBars.BarButtonItem();
            this.btnListOrder = new DevExpress.XtraBars.BarButtonItem();
            this.imageLarge = new DevExpress.Utils.ImageCollection();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLarge)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnLogIn,
            this.btnChangePass,
            this.btnListSupplier,
            this.btnListOrder});
            this.ribbonControl1.LargeImages = this.imageLarge;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(765, 142);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Caption = "Đăng Nhập";
            this.btnLogIn.Id = 1;
            this.btnLogIn.LargeImageIndex = 0;
            this.btnLogIn.LargeWidth = 80;
            this.btnLogIn.Name = "btnLogIn";
            // 
            // btnChangePass
            // 
            this.btnChangePass.Caption = "Đổi Mật Khẩu";
            this.btnChangePass.Id = 2;
            this.btnChangePass.LargeImageIndex = 1;
            this.btnChangePass.LargeWidth = 80;
            this.btnChangePass.Name = "btnChangePass";
            // 
            // btnListSupplier
            // 
            this.btnListSupplier.AllowAllUp = true;
            this.btnListSupplier.Caption = "Danh Sách Nhà Cung Cấp";
            this.btnListSupplier.Id = 7;
            this.btnListSupplier.LargeImageIndex = 2;
            this.btnListSupplier.LargeWidth = 90;
            this.btnListSupplier.Name = "btnListSupplier";
            this.btnListSupplier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnListSupplier_ItemClick);
            // 
            // btnListOrder
            // 
            this.btnListOrder.Caption = "Danh Sách Đơn Đặt Hàng";
            this.btnListOrder.Id = 8;
            this.btnListOrder.LargeImageIndex = 3;
            this.btnListOrder.LargeWidth = 90;
            this.btnListOrder.Name = "btnListOrder";
            this.btnListOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnListOrder_ItemClick);
            // 
            // imageLarge
            // 
            this.imageLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.imageLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageLarge.ImageStream")));
            this.imageLarge.Images.SetKeyName(0, "BO_Security_Permission_32x32.png");
            this.imageLarge.Images.SetKeyName(1, "Action_ResetPassword_32x32.png");
            this.imageLarge.Images.SetKeyName(2, "Action_Open_Object_32x32.png");
            this.imageLarge.Images.SetKeyName(3, "BO_Order_Item_32x32.png");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogIn);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnChangePass, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Danh Mục";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnListSupplier);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnListOrder, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 501);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLarge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultStyle;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnLogIn;
        private DevExpress.XtraBars.BarButtonItem btnChangePass;
        private DevExpress.Utils.ImageCollection imageLarge;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnListSupplier;
        private DevExpress.XtraBars.BarButtonItem btnListOrder;


    }
}