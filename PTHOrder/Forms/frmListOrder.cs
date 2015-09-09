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
    public partial class frmListOrder : DevExpress.XtraEditors.XtraForm
    {
        public frmListOrder()
        {
            InitializeComponent();
        }

      
        //load Grid view
        void tbOrder_GetList()
        {
            Class.clsListOrder cls = new Class.clsListOrder();
            DataTable dt = cls.tbOrder_GetList();
            gridItem.DataSource = dt;

        }
        private void frmListOrder_Load(object sender, EventArgs e)
        {
            tbOrder_GetList();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.frmListOrder_Update frm = new frmListOrder_Update();
            frm.ShowDialog();
            tbOrder_GetList();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridItemDetail.FocusedRowHandle > 0)
            {
                string code = gridItemDetail.GetFocusedRowCellValue(colOrderCode).ToString();
                Forms.frmListOrder_Update frm = new frmListOrder_Update(code);
                frm.ShowDialog();
                tbOrder_GetList();
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridItemDetail.FocusedRowHandle > 0)
            {
                string code = gridItemDetail.GetFocusedRowCellValue(colOrderCode).ToString();
                Class.clsListOrder cls = new Class.clsListOrder();
                cls.OrderCode = code;
                if (cls.Delete())
                {
                    MessageBox.Show("Xóa thành công");
                    tbOrder_GetList();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }

            }
        }
    }
}