using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PTHOrder.Forms
{
    public partial class frmListSupplier : DevExpress.XtraEditors.XtraForm
    {
        public frmListSupplier()
        {
            InitializeComponent();
        }
        //load Grid view
        void tbSupplier_GetList()
        {
            Class.clsListSupplier cls = new Class.clsListSupplier();
            DataTable dt = cls.tbSupplier_GetList();
            gridItem.DataSource = dt;

        }

        private void frmListSupplier_Load(object sender, EventArgs e)
        {
            tbSupplier_GetList();
        }
         //Xử lý nút thêm
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.frmListSupplier_Update frm = new frmListSupplier_Update();
            frm.ShowDialog();
            tbSupplier_GetList();
        }
        //Xử lý nút xóa
        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridItemDetail.FocusedRowHandle > -1)
            {
                string code = gridItemDetail.GetFocusedRowCellValue(colSupplierCode).ToString();
                Class.clsListSupplier cls = new Class.clsListSupplier();
                cls.SupplierCode = code;
                if (cls.Delete())
                {
                    MessageBox.Show("Xóa thành công");
                    tbSupplier_GetList();
                }
                else {
                    MessageBox.Show("Xóa thất bại");
                }

            }

        }
        //Xử lý nút sửa
        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             if (gridItemDetail.FocusedRowHandle > -1)
            {
                string code = gridItemDetail.GetFocusedRowCellValue(colSupplierCode).ToString();
                Forms.frmListSupplier_Update frm = new frmListSupplier_Update(code);
                frm.ShowDialog();
                tbSupplier_GetList();
            }
           
        }

     
       

        }

  }