﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_management
{
    public partial class frmHTPPharmacy : Form
    {
        public frmHTPPharmacy()
        {
            InitializeComponent();
        }

        private void mItemReLogin_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
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
    }
}
