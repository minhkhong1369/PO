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
   
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
       //public static string userlogin;
        public frmLogin()
        {
            InitializeComponent();
          
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Trim()=="" || txtPassword.Text.Trim()=="")
            {
                MessageBox.Show("Vui lòng nhập thông tin tài khoản!");
                return;
            }
            try
            {
                //Create SqlConnection
                Class.clsLogin cls = new Class.clsLogin();
                cls.Username = txtUsername.Text;
                cls.Password = txtPassword.Text;
                DataTable dt = cls.tbLogin_Get();
                            
                int count = dt.Rows.Count;
                //If count is equal to 1, than show frmMain form
                    if (count == 1)
                    {
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                      
                        //frmMain frm = (frmMain)Application.OpenForms["frmMain"];
                        //frm.fnc_DisableLoginButton();
                        this.Close();
                        //frmMain frm = new frmMain();
                        //frm.Show();
                        //frm.BtnLogin.Enabled = false;
                        Class.App.UserLogin = txtUsername.Text;
                        //UserLogin.userlogin = txtUsername.Text;
                                                
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Class.App.UserLogin==null)
                    Application.Exit();
        }
       
        
    }
}