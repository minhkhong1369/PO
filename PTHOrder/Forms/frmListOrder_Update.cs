using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PTHOrder.Class;

namespace PTHOrder.Forms
{
    public partial class frmListOrder_Update : DevExpress.XtraEditors.XtraForm
    {
        public frmListOrder_Update()
        {
            InitializeComponent();
            statusForm = true;
            this.Text = "Thêm mới đơn đặt hàng";
        }
         bool statusForm= true;
        public frmListOrder_Update(string code)
        {
            InitializeComponent();
            statusForm = false;
            Class.clsListOrder cls = new Class.clsListOrder();
            cls.OrderCode = code;
            DataTable dt = cls.tbOrder_Get();
            if (dt.Rows.Count > 0) {
                txtOrderCode.Text = dt.Rows[0]["OrderCode"].ToString();
                dateSuggestDate.DateTime = (DateTime)dt.Rows[0]["DateSuggest"];
                txtFollowers.Text = dt.Rows[0]["Followers"].ToString();               
                dateDeliveryDate.DateTime = (DateTime)dt.Rows[0]["DeliveryDate"];
                txtPlaceOfDelivery.Text = dt.Rows[0]["PlaceOfDelivery"].ToString();
                txtPaymentConditions.Text = dt.Rows[0]["PaymentConditions"].ToString();
                txtVAT.Text = dt.Rows[0]["VAT"].ToString();
            }
            this.Text = "Cập nhật đơn đặt hàng:  " + dt.Rows[0]["OrderCode"].ToString();
        }
        void LoadListSupplier()
        {
            Class.clsListSupplier cls = new Class.clsListSupplier();
            DataTable dt = cls.tbSupplier_GetList();
            cboSupplier.Properties.DataSource = dt;
            cboSupplier.Properties.DisplayMember = "SupplierName";
            cboSupplier.Properties.ValueMember = "SupplierCode";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            if (statusForm)
            {
                Class.clsListOrder cls = new Class.clsListOrder();
                cls.OrderCode = txtOrderCode.Text;
                cls.DateSuggest = dateSuggestDate.DateTime;
                cls.Followers = txtFollowers.Text;
                
                cls.DeliveryDate = dateDeliveryDate.DateTime;
                cls.PlaceOfDelivery = txtPlaceOfDelivery.Text;
                cls.PaymentConditions = txtPaymentConditions.Text;
                cls.VAT = int.Parse(txtVAT.EditValue.ToString());
                if (cls.Insert())
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                Class.clsListOrder cls = new Class.clsListOrder();
                cls.OrderCode = txtOrderCode.Text;
                cls.DateSuggest = dateSuggestDate.DateTime;
                cls.Followers = txtFollowers.Text;                
                cls.DeliveryDate = dateDeliveryDate.DateTime;
                cls.PlaceOfDelivery = txtPlaceOfDelivery.Text;
                cls.PaymentConditions = txtPaymentConditions.Text;
                cls.VAT = int.Parse(txtVAT.EditValue.ToString());
                if (cls.Update())
                {
                    MessageBox.Show("Sửa thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }

            }
        }

        private void frmListOrder_Update_Load(object sender, EventArgs e)
        {
            LoadListSupplier();
        }

       
       
    }
}