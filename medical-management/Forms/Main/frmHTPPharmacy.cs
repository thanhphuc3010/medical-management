﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using medical_management.BUS;
using medical_management.DTO;

namespace medical_management
{
    public partial class frmHTPPharmacy : Form
    {
        public bool isLogin = false;
        public string staffId;
        private Staff staff;
        public frmHTPPharmacy()
        {
            InitializeComponent();
        }

        private void frmHTPPharmacy_Load(object sender, EventArgs e)
        {
            showLoginForm();
            if (isLogin)
            {
                staff = StaffBUS.getStaffById(staffId);
                tssStaffName.Text = staff.Id + " - " + staff.Name;
                ttsDatetime.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
        }

        private void showLoginForm()
        {
            frmLogin f = new frmLogin();
            f.ShowDialog(this);
        }

        private void mItemReLogin_Click(object sender, EventArgs e)
        {
            // DEMO GIT & GITHUB
            // Change source from github website
        }

        private void mItemThuoc_Click(object sender, EventArgs e)
        {
            frmThuoc f = new frmThuoc();
            f.Show();


        }

        private void mItemKH_Click(object sender, EventArgs e)
        {
            frmKhachhang f = new frmKhachhang();
            f.Show();
        }

        private void mItemNCC_Click(object sender, EventArgs e)
        {
            frmNhacungcap f = new frmNhacungcap();
            f.Show();
        }

        private void mItemNSX_Click(object sender, EventArgs e)
        {
            frmNhasanxuat f = new frmNhasanxuat();
            f.Show();
        }

        private void mItemNV_Click(object sender, EventArgs e)
        {
            frmNhanvien f = new frmNhanvien();
            f.Show();
        }

        private void mItemInvoice_Click(object sender, EventArgs e)
        {
            frmDSHD f = new frmDSHD();
            f.MdiParent = this;
            f.Show();
        }

        private void frmHTPPharmacy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
