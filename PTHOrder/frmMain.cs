﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PTHOrder
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
       // Forms.frmLogin frmlogin = new Forms.frmLogin();
        public frmMain()
        {
            InitializeComponent();
           
        }
        // Kiem tra form da mo len hay chua
        public static bool IsFocusForm(Type type, Form frmParent)
        {
            int i = 0;
            if (frmParent == null) return false;
            foreach (Form frm in frmParent.MdiChildren)
            {
                if (frm.GetType() == type)
                {
                    if (frm.MinimizeBox)
                    {
                        frm.Focus();
                        frm.WindowState = FormWindowState.Maximized;
                    }
                    frm.Focus();
                    return true;
                }
                else
                {
                    i++;
                }

            }
            if (i != 0)
                return false;
            return false;
        }
    
        private void btnListSupplier_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           //kiem tra neu form chua mo thi mo form
            if (!IsFocusForm(typeof(Forms.frmListSupplier), this))
            {
                Forms.frmListSupplier frm = new Forms.frmListSupplier();
                 frm.MdiParent = this;
                 frm.Show();
            }           
        }

        private void btnListOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!IsFocusForm(typeof(Forms.frmListOrder), this))
            {
                Forms.frmListOrder frm = new Forms.frmListOrder();
                frm.MdiParent = this;
                frm.Show();
            } 
        }

        private void btnLogIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.frmLogin frmlogin = new Forms.frmLogin();
            frmlogin.ShowDialog();
            if (Class.App.UserLogin != null)
                btnLogIn.Enabled = false;
            
        }
        //tao ham goi botton login cho form khac
        public void fnc_DisableLoginButton()
        {
            btnLogIn.Enabled = false;
        }
        //tao ham goi botton login cho form khac c2: goi doi tuong dev
        public DevExpress.XtraBars.BarButtonItem BtnLogin
        {
            get { return btnLogIn; }
            set { btnLogIn = value; }
        }

        private void btnLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Class.App.UserLogin = null;
            btnLogIn_ItemClick(null, null);
        }

        private void btnChangePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.frmChangepassword frm = new Forms.frmChangepassword();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnLogIn_ItemClick(null, null);
        }

       
    }
}