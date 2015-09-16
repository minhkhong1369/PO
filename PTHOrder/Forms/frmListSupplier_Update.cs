﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PTHOrder.Forms
{
    public partial class frmListSupplier_Update : DevExpress.XtraEditors.XtraForm
    {
        public frmListSupplier_Update()
        {
            InitializeComponent();
            statusForm = true;
            this.Text = "Thêm mới nhà cung cấp";
        }
        bool statusForm= true;
        public frmListSupplier_Update(string code)
        {
            InitializeComponent();
            statusForm = false;
            Class.clsListSupplier cls = new Class.clsListSupplier();
            cls.SupplierCode = code;
            DataTable dt = cls.tbSupplier_Get();
            if (dt.Rows.Count > 0) {
                txtSupplierCode.Text = dt.Rows[0]["SupplierCode"].ToString();
                txtSupplierName.Text = dt.Rows[0]["SupplierName"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
                txtTelephone.Text = dt.Rows[0]["Telephone"].ToString();
                txtMail.Text = dt.Rows[0]["Mail"].ToString();
                txtGroup.Text = dt.Rows[0]["Group"].ToString();
                txtContact.Text = dt.Rows[0]["Contact"].ToString();
                txtNote.Text = dt.Rows[0]["Note"].ToString();
            }
            this.Text = "Cập nhật nhà cung cấp:  "+ dt.Rows[0]["SupplierName"].ToString();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            //Ran buoc du lieu form
            if (txtSupplierCode.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhà cung cấp");
                txtSupplierCode.Focus();
                return;
            }
            if (txtSupplierName.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp");
                txtSupplierName.Focus();
                return;
            }
            if (statusForm)
            {      
                
                Class.clsListSupplier cls = new Class.clsListSupplier();
                cls.SupplierCode = txtSupplierCode.Text;
                cls.SupplierName = txtSupplierName.Text;
                cls.Address = txtAddress.Text;
                cls.Telephone = txtTelephone.Text;
                cls.Mail = txtMail.Text;
                cls.Group = txtGroup.Text;
                cls.Contact = txtContact.Text;
                cls.Note = txtNote.Text;
                if (cls.Insert())
                {
                    MessageBox.Show("Thêm thành công");
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    return;
                }
            }
            else
            {
                Class.clsListSupplier cls = new Class.clsListSupplier();
                cls.SupplierCode = txtSupplierCode.Text;
                cls.SupplierName = txtSupplierName.Text;
                cls.Address = txtAddress.Text;
                cls.Telephone = txtTelephone.Text;
                cls.Mail = txtMail.Text;
                cls.Group = txtGroup.Text;
                cls.Contact = txtContact.Text;
                cls.Note = txtNote.Text;
                if (cls.Update())
                {
                    MessageBox.Show("Sửa thành công");
                   // this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                    return;
                }
            }

            Addnew();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

                //Ran buoc du lieu form
                if (txtSupplierCode.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã nhà cung cấp");
                    txtSupplierCode.Focus();
                    return;
                }
                if (txtSupplierName.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên nhà cung cấp");
                    txtSupplierName.Focus();
                    return;
                }

            if (statusForm)
            {
                
               
               
                Class.clsListSupplier cls = new Class.clsListSupplier();
                cls.SupplierCode = txtSupplierCode.Text;
                cls.SupplierName = txtSupplierName.Text;
                cls.Address = txtAddress.Text;
                cls.Telephone = txtTelephone.Text;
                cls.Mail = txtMail.Text;
                cls.Group = txtGroup.Text;
                cls.Contact = txtContact.Text;
                cls.Note = txtNote.Text;
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
                Class.clsListSupplier cls = new Class.clsListSupplier();
                cls.SupplierCode = txtSupplierCode.Text;
                cls.SupplierName = txtSupplierName.Text;
                cls.Address = txtAddress.Text;
                cls.Telephone = txtTelephone.Text;
                cls.Mail = txtMail.Text;
                cls.Group = txtGroup.Text;
                cls.Contact = txtContact.Text;
                cls.Note = txtNote.Text;
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

        void Addnew()
        {
            this.Text = "Thêm mới nhà cung cấp";
            this.txtSupplierCode.Text = "";
            this.txtSupplierName.Text = "";
            this.txtAddress.Text = "";
            this.txtTelephone.Text = "";
            this.txtMail.Text = "";
            this.txtGroup.Text = "";
            this.txtContact.Text = "";
            this.txtNote.Text = "";
            this.txtSupplierCode.Focus();
            statusForm = true;
        }

         
        
        

         
    }
}