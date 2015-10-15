using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

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
               
            
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cls.Delete();
                        MessageBox.Show("Xóa thành công!");
                        tbSupplier_GetList();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            btnAdd_ItemClick(null, null);

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            btnEdit_ItemClick(null, null);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            btnDelete_ItemClick(null,null);
        }

        private void gridItemDetail_DoubleClick(object sender, EventArgs e)
        {
            btn_Update_Click(null,null);
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridItem.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridItem.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridItem.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridItem.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridItem.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridItem.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

      

       
        }
   

      
     
}

    