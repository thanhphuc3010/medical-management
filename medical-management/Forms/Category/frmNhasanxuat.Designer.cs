﻿
namespace medical_management
{
    partial class frmNhasanxuat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.lblNXS = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblTenNSX = new System.Windows.Forms.Label();
            this.lblMaNSX = new System.Windows.Forms.Label();
            this.txtMaNSX = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTenNSX = new System.Windows.Forms.TextBox();
            this.dgvNhasanxuat = new System.Windows.Forms.DataGridView();
            this.MaNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhasanxuat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 174);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 43);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDau
            // 
            this.btnDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDau.Location = new System.Drawing.Point(2, 434);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(74, 29);
            this.btnDau.TabIndex = 1;
            this.btnDau.Text = "Đầu";
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(242, 174);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(51, 43);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(185, 174);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(51, 43);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(128, 174);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(51, 43);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(71, 174);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(51, 43);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCuoi.Location = new System.Drawing.Point(242, 434);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(74, 29);
            this.btnCuoi.TabIndex = 6;
            this.btnCuoi.Text = "Cuối";
            this.btnCuoi.UseVisualStyleBackColor = true;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // btnSau
            // 
            this.btnSau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSau.Location = new System.Drawing.Point(162, 434);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(74, 29);
            this.btnSau.TabIndex = 7;
            this.btnSau.Text = "Sau";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTruoc.Location = new System.Drawing.Point(82, 434);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(74, 29);
            this.btnTruoc.TabIndex = 8;
            this.btnTruoc.Text = "Trước";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // lblNXS
            // 
            this.lblNXS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNXS.AutoSize = true;
            this.lblNXS.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNXS.Location = new System.Drawing.Point(326, 22);
            this.lblNXS.Name = "lblNXS";
            this.lblNXS.Size = new System.Drawing.Size(124, 26);
            this.lblNXS.TabIndex = 9;
            this.lblNXS.Text = "Nhà sản xuất";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(458, 101);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblSdt
            // 
            this.lblSdt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSdt.AutoSize = true;
            this.lblSdt.Location = new System.Drawing.Point(458, 75);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(70, 13);
            this.lblSdt.TabIndex = 11;
            this.lblSdt.Text = "Số điện thoại";
            // 
            // lblDiachi
            // 
            this.lblDiachi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(60, 127);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(40, 13);
            this.lblDiachi.TabIndex = 12;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblTenNSX
            // 
            this.lblTenNSX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenNSX.AutoSize = true;
            this.lblTenNSX.Location = new System.Drawing.Point(60, 101);
            this.lblTenNSX.Name = "lblTenNSX";
            this.lblTenNSX.Size = new System.Drawing.Size(92, 13);
            this.lblTenNSX.TabIndex = 13;
            this.lblTenNSX.Text = "Tên Nhà sản xuất";
            // 
            // lblMaNSX
            // 
            this.lblMaNSX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaNSX.AutoSize = true;
            this.lblMaNSX.Location = new System.Drawing.Point(60, 75);
            this.lblMaNSX.Name = "lblMaNSX";
            this.lblMaNSX.Size = new System.Drawing.Size(88, 13);
            this.lblMaNSX.TabIndex = 14;
            this.lblMaNSX.Text = "Mã Nhà sản xuất";
            // 
            // txtMaNSX
            // 
            this.txtMaNSX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaNSX.Location = new System.Drawing.Point(185, 72);
            this.txtMaNSX.Name = "txtMaNSX";
            this.txtMaNSX.Size = new System.Drawing.Size(157, 20);
            this.txtMaNSX.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(563, 98);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(157, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // txtSdt
            // 
            this.txtSdt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSdt.Location = new System.Drawing.Point(563, 72);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(157, 20);
            this.txtSdt.TabIndex = 17;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiachi.Location = new System.Drawing.Point(185, 124);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(157, 20);
            this.txtDiachi.TabIndex = 18;
            // 
            // txtTenNSX
            // 
            this.txtTenNSX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenNSX.Location = new System.Drawing.Point(185, 98);
            this.txtTenNSX.Name = "txtTenNSX";
            this.txtTenNSX.Size = new System.Drawing.Size(157, 20);
            this.txtTenNSX.TabIndex = 19;
            // 
            // dgvNhasanxuat
            // 
            this.dgvNhasanxuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhasanxuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhasanxuat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNhasanxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhasanxuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNSX,
            this.TenNSX,
            this.Diachi,
            this.Sdt,
            this.Email});
            this.dgvNhasanxuat.Location = new System.Drawing.Point(5, 236);
            this.dgvNhasanxuat.Name = "dgvNhasanxuat";
            this.dgvNhasanxuat.Size = new System.Drawing.Size(778, 179);
            this.dgvNhasanxuat.TabIndex = 20;
            // 
            // MaNSX
            // 
            this.MaNSX.DataPropertyName = "MaNSX";
            this.MaNSX.HeaderText = "Mã Nhà sản xuất";
            this.MaNSX.Name = "MaNSX";
            // 
            // TenNSX
            // 
            this.TenNSX.DataPropertyName = "TenNSX";
            this.TenNSX.HeaderText = "Tên Nhà sản xuất";
            this.TenNSX.Name = "TenNSX";
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.Name = "Diachi";
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "Số điện thoại";
            this.Sdt.Name = "Sdt";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(709, 434);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 29);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Kết thúc";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmNhasanxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::medical_management.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(795, 475);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvNhasanxuat);
            this.Controls.Add(this.txtTenNSX);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMaNSX);
            this.Controls.Add(this.lblMaNSX);
            this.Controls.Add(this.lblTenNSX);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.lblSdt);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNXS);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnCuoi);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDau);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmNhasanxuat";
            this.Text = "frmNhasanxuat";
            this.Load += new System.EventHandler(this.frmNhasanxuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhasanxuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Label lblNXS;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblTenNSX;
        private System.Windows.Forms.Label lblMaNSX;
        private System.Windows.Forms.TextBox txtMaNSX;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTenNSX;
        private System.Windows.Forms.DataGridView dgvNhasanxuat;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}