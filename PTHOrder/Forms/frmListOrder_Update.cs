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
            LoadListSupplier();
            LoadOrderDetails();
            dateSuggestDate.DateTime = DateTime.Now;
            dateDeliveryDate.DateTime = DateTime.Now;
        }
         bool statusForm= true;
        public frmListOrder_Update(string code)
        {
            InitializeComponent();
            LoadListSupplier();
            statusForm = false;
            Class.clsListOrder cls = new Class.clsListOrder();
            cls.OrderCode = code;
            DataTable dt = cls.tbOrder_Get();
            if (dt.Rows.Count > 0) {
                txtOrderCode.Enabled = false;
                txtOrderCode.Text = dt.Rows[0]["OrderCode"].ToString();                
                dateSuggestDate.DateTime = (DateTime)dt.Rows[0]["DateSuggest"];
                txtFollowers.Text = dt.Rows[0]["Followers"].ToString();               
                dateDeliveryDate.DateTime = (DateTime)dt.Rows[0]["DeliveryDate"];
                txtPlaceOfDelivery.Text = dt.Rows[0]["PlaceOfDelivery"].ToString();
                txtPaymentConditions.Text = dt.Rows[0]["PaymentConditions"].ToString();
                cboSupplier.EditValue = dt.Rows[0]["SupplierCode"].ToString();
                txtVAT.Text = dt.Rows[0]["VAT"].ToString();

                LoadOrderDetails(dt.Rows[0]["OrderCode"].ToString());//load du lieu vao luoi chi tiet ddh dua vao OrderCode
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
            //cboSupplier.EditValue = dt.Rows[0]["SupplierCode"];
        }
        DataTable dtOrderDetail = new DataTable();
        DataTable dtOrderDetailTemp = new DataTable();//bang tam de luu du lieu can xoa tu bang OrderDetails khi chinh sua
        void LoadOrderDetails()
        {
            Class.clsListOrder cls = new Class.clsListOrder();
            cls.OrderCode = "";
            dtOrderDetail = cls.tbOrderDetails_GetByCode();            
            gridItem.DataSource = dtOrderDetail;
            dtOrderDetail.Clear();

        }
        void LoadOrderDetails(string Ordercode)
        {
            Class.clsListOrder cls = new Class.clsListOrder();
            cls.OrderCode = Ordercode;
            dtOrderDetail = cls.tbOrderDetails_GetByCode();
            gridItem.DataSource = dtOrderDetail;

            cls.OrderCode = "";
            dtOrderDetailTemp = cls.tbOrderDetails_GetByCode(); 
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Ran buoc du lieu form
            if (txtOrderCode.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã đơn đặt hàng");
                txtOrderCode.Focus();
                return;
            }
            if (cboSupplier.EditValue == null)
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp");
                cboSupplier.Focus();
                return;
            }
            if (statusForm)
            {
                Class.clsListOrder cls = new Class.clsListOrder();
                cls.OrderCode = txtOrderCode.Text;
                cls.DateSuggest = dateSuggestDate.DateTime;
                cls.Followers = txtFollowers.Text;
                cls.SupplierCode = cboSupplier.EditValue.ToString();
                cls.DeliveryDate = dateDeliveryDate.DateTime;
                cls.PlaceOfDelivery = txtPlaceOfDelivery.Text;
                cls.PaymentConditions = txtPaymentConditions.Text;
                if (txtVAT.EditValue == null)
                {
                    cls.VAT = 0;
                }
                else
                {
                    cls.VAT = int.Parse(txtVAT.EditValue.ToString());
                }
                if (cls.Insert(dtOrderDetail))
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
                cls.SupplierCode = cboSupplier.EditValue.ToString();
                cls.DeliveryDate = dateDeliveryDate.DateTime;
                cls.PlaceOfDelivery = txtPlaceOfDelivery.Text;
                cls.PaymentConditions = txtPaymentConditions.Text;
                cls.VAT = int.Parse(txtVAT.EditValue.ToString());
                if (cls.Update(dtOrderDetail,dtOrderDetailTemp))
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

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            //Ran buoc du lieu form
            if (txtOrderCode.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã đơn đặt hàng");
                txtOrderCode.Focus();
                return;
            }
            if (cboSupplier.EditValue == null)
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp");
                cboSupplier.Focus();
                return;
            }
            if (statusForm)
            {
                Class.clsListOrder cls = new Class.clsListOrder();
                cls.OrderCode = txtOrderCode.Text;
                cls.DateSuggest = dateSuggestDate.DateTime;
                cls.Followers = txtFollowers.Text;
                cls.SupplierCode = cboSupplier.EditValue.ToString();
                cls.DeliveryDate = dateDeliveryDate.DateTime;
                cls.PlaceOfDelivery = txtPlaceOfDelivery.Text;
                cls.PaymentConditions = txtPaymentConditions.Text;
                if (txtVAT.EditValue == null)
                {
                    cls.VAT = 0;
                }
                else
                {
                    cls.VAT = int.Parse(txtVAT.EditValue.ToString());
                }
                if (cls.Insert(dtOrderDetail))
                {
                    MessageBox.Show("Thêm thành công");
                  //  this.Close();
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
                cls.SupplierCode = cboSupplier.EditValue.ToString();
                cls.DeliveryDate = dateDeliveryDate.DateTime;
                cls.PlaceOfDelivery = txtPlaceOfDelivery.Text;
                cls.PaymentConditions = txtPaymentConditions.Text;
                cls.VAT = int.Parse(txtVAT.EditValue.ToString());
                if (cls.Update(dtOrderDetail,dtOrderDetailTemp))
                {
                    MessageBox.Show("Sửa thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }

            }
            Addnew();
        }

        private void gridItemDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (gridItemDetail.FocusedRowHandle > -1)
            {
                if (e.KeyValue == 46)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xoá hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            DataRow dr = dtOrderDetailTemp.NewRow();//tao dong bang tam
                            dr["OrderDetailCode"] = dtOrderDetail.Rows[gridItemDetail.FocusedRowHandle]["OrderDetailCode"].ToString();//
                            dtOrderDetailTemp.Rows.Add(dr); //chen dong tu ban OrderDetail sang ban tam

                            dtOrderDetail.Rows.RemoveAt(gridItemDetail.FocusedRowHandle);//xoa dong tai vi tri tro chuot tren luoi
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

     

        private void gridItemDetail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colNumber")
                {
                    string number = gridItemDetail.GetRowCellValue(e.RowHandle, colNumber).ToString();
                    string price = gridItemDetail.GetRowCellValue(e.RowHandle, colPrice).ToString();
                    double monetize;
                    monetize = Double.Parse(number) * Double.Parse(price);
                    gridItemDetail.SetRowCellValue(e.RowHandle, colMonetize, monetize);
                }
                if (e.Column.Name == "colPrice")
                {
                    string number = gridItemDetail.GetRowCellValue(e.RowHandle, colNumber).ToString();
                    string price = gridItemDetail.GetRowCellValue(e.RowHandle, colPrice).ToString();
                    double monetize;
                    monetize = Double.Parse(number) * Double.Parse(price);
                    gridItemDetail.SetRowCellValue(e.RowHandle, colMonetize, monetize);
                }

            }
            catch { }
        }

        private void gridItemDetail_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (e.RowHandle < 0)
            {
                if (gridItemDetail.GetRowCellValue(e.RowHandle, colNumber).ToString() == "")
                {
                    e.ErrorText = "Bạn chưa nhập Số Lượng";
                    e.Valid = false;
                }
                if (gridItemDetail.GetRowCellValue(e.RowHandle, colPrice).ToString() == "")
                {
                    e.ErrorText = "Bạn chưa nhập Giá";
                    e.Valid = false;
                }
            }
        }

        private void txtVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("VAT là kí tự số ", "Thông Báo ");
            }
        }
       void Addnew()
        {
            this.Text = "Thêm mới đơn đặt hàng";
            this.txtOrderCode.Text = "";
            dateSuggestDate.DateTime = DateTime.Now;
            this.txtFollowers.Text="";
            this.cboSupplier.EditValue.ToString();
            dateDeliveryDate.DateTime =DateTime.Now;
            this.txtPlaceOfDelivery.Text="";
            this.txtPaymentConditions.Text="";
           // this.txtVAT.EditValue="";
            this.txtOrderCode.Focus();
            dtOrderDetail.Clear();
            statusForm = true;
        }
       
       
    }
}