
namespace medical_management
{
    partial class frmPhieunhap
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
            this.lblPhieunhap = new System.Windows.Forms.Label();
            this.lblThongtinchung = new System.Windows.Forms.Label();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblNhanviennhap = new System.Windows.Forms.Label();
            this.lblNgaynhap = new System.Windows.Forms.Label();
            this.lblManhap = new System.Windows.Forms.Label();
            this.lblHsd = new System.Windows.Forms.Label();
            this.lblMathuoc = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblDongia = new System.Windows.Forms.Label();
            this.txtManhap = new System.Windows.Forms.TextBox();
            this.txtNhanviennhap = new System.Windows.Forms.TextBox();
            this.txtNgaynhap = new System.Windows.Forms.TextBox();
            this.txtMathuoc = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtHsd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblTongcong = new System.Windows.Forms.Label();
            this.lblTongtienthanhtoan = new System.Windows.Forms.Label();
            this.lblChietkhau = new System.Windows.Forms.Label();
            this.lblThue = new System.Windows.Forms.Label();
            this.txtChietkhau = new System.Windows.Forms.TextBox();
            this.txtTongtienthanhtoan = new System.Windows.Forms.TextBox();
            this.txtTongcong = new System.Windows.Forms.TextBox();
            this.txtThue = new System.Windows.Forms.TextBox();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.dgvPhieunhaphang = new System.Windows.Forms.DataGridView();
            this.lblChitietphieunhap = new System.Windows.Forms.Label();
            this.btnGhinhan = new System.Windows.Forms.Button();
            this.lblDonvitinh = new System.Windows.Forms.Label();
            this.txtDonvitinh = new System.Windows.Forms.TextBox();
            this.lblTenthuoc = new System.Windows.Forms.Label();
            this.btnTenthuoc = new System.Windows.Forms.TextBox();
            this.lblNCC = new System.Windows.Forms.Label();
            this.btnSelectSupplier = new System.Windows.Forms.Button();
            this.Malo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvThanhtoan = new System.Windows.Forms.DataGridView();
            this.Phuongthucthanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaythanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieunhaphang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhtoan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPhieunhap
            // 
            this.lblPhieunhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhieunhap.AutoSize = true;
            this.lblPhieunhap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieunhap.Location = new System.Drawing.Point(435, 9);
            this.lblPhieunhap.Name = "lblPhieunhap";
            this.lblPhieunhap.Size = new System.Drawing.Size(139, 19);
            this.lblPhieunhap.TabIndex = 0;
            this.lblPhieunhap.Text = "PHIẾU NHẬP HÀNG";
            this.lblPhieunhap.Click += new System.EventHandler(this.lblPhieunhap_Click);
            // 
            // lblThongtinchung
            // 
            this.lblThongtinchung.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblThongtinchung.AutoSize = true;
            this.lblThongtinchung.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtinchung.Location = new System.Drawing.Point(27, 42);
            this.lblThongtinchung.Name = "lblThongtinchung";
            this.lblThongtinchung.Size = new System.Drawing.Size(120, 19);
            this.lblThongtinchung.TabIndex = 1;
            this.lblThongtinchung.Text = "Thông tin chung";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(339, 76);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(93, 13);
            this.lblMaNCC.TabIndex = 4;
            this.lblMaNCC.Text = "Mã Nhà cung cấp";
            // 
            // lblNhanviennhap
            // 
            this.lblNhanviennhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNhanviennhap.AutoSize = true;
            this.lblNhanviennhap.Location = new System.Drawing.Point(39, 128);
            this.lblNhanviennhap.Name = "lblNhanviennhap";
            this.lblNhanviennhap.Size = new System.Drawing.Size(83, 13);
            this.lblNhanviennhap.TabIndex = 5;
            this.lblNhanviennhap.Text = "Nhân viên nhập";
            // 
            // lblNgaynhap
            // 
            this.lblNgaynhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNgaynhap.AutoSize = true;
            this.lblNgaynhap.Location = new System.Drawing.Point(39, 102);
            this.lblNgaynhap.Name = "lblNgaynhap";
            this.lblNgaynhap.Size = new System.Drawing.Size(59, 13);
            this.lblNgaynhap.TabIndex = 6;
            this.lblNgaynhap.Text = "Ngày nhập";
            // 
            // lblManhap
            // 
            this.lblManhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblManhap.AutoSize = true;
            this.lblManhap.Location = new System.Drawing.Point(39, 76);
            this.lblManhap.Name = "lblManhap";
            this.lblManhap.Size = new System.Drawing.Size(49, 13);
            this.lblManhap.TabIndex = 7;
            this.lblManhap.Text = "Mã nhập";
            // 
            // lblHsd
            // 
            this.lblHsd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHsd.AutoSize = true;
            this.lblHsd.Location = new System.Drawing.Point(695, 203);
            this.lblHsd.Name = "lblHsd";
            this.lblHsd.Size = new System.Drawing.Size(68, 13);
            this.lblHsd.TabIndex = 9;
            this.lblHsd.Text = "Hạn sử dụng";
            // 
            // lblMathuoc
            // 
            this.lblMathuoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMathuoc.AutoSize = true;
            this.lblMathuoc.Location = new System.Drawing.Point(695, 73);
            this.lblMathuoc.Name = "lblMathuoc";
            this.lblMathuoc.Size = new System.Drawing.Size(52, 13);
            this.lblMathuoc.TabIndex = 11;
            this.lblMathuoc.Text = "Mã thuốc";
            // 
            // lblSoluong
            // 
            this.lblSoluong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(695, 177);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(49, 13);
            this.lblSoluong.TabIndex = 13;
            this.lblSoluong.Text = "Số lượng";
            // 
            // lblDongia
            // 
            this.lblDongia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDongia.AutoSize = true;
            this.lblDongia.Location = new System.Drawing.Point(695, 151);
            this.lblDongia.Name = "lblDongia";
            this.lblDongia.Size = new System.Drawing.Size(44, 13);
            this.lblDongia.TabIndex = 14;
            this.lblDongia.Text = "Đơn giá";
            // 
            // txtManhap
            // 
            this.txtManhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtManhap.Location = new System.Drawing.Point(126, 73);
            this.txtManhap.Name = "txtManhap";
            this.txtManhap.Size = new System.Drawing.Size(156, 20);
            this.txtManhap.TabIndex = 15;
            // 
            // txtNhanviennhap
            // 
            this.txtNhanviennhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNhanviennhap.Location = new System.Drawing.Point(128, 125);
            this.txtNhanviennhap.Name = "txtNhanviennhap";
            this.txtNhanviennhap.Size = new System.Drawing.Size(156, 20);
            this.txtNhanviennhap.TabIndex = 17;
            // 
            // txtNgaynhap
            // 
            this.txtNgaynhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNgaynhap.Location = new System.Drawing.Point(126, 99);
            this.txtNgaynhap.Name = "txtNgaynhap";
            this.txtNgaynhap.Size = new System.Drawing.Size(156, 20);
            this.txtNgaynhap.TabIndex = 18;
            // 
            // txtMathuoc
            // 
            this.txtMathuoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMathuoc.Location = new System.Drawing.Point(785, 70);
            this.txtMathuoc.Name = "txtMathuoc";
            this.txtMathuoc.Size = new System.Drawing.Size(156, 20);
            this.txtMathuoc.TabIndex = 20;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSoluong.Location = new System.Drawing.Point(785, 174);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(156, 20);
            this.txtSoluong.TabIndex = 22;
            // 
            // txtDongia
            // 
            this.txtDongia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDongia.Location = new System.Drawing.Point(785, 148);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(156, 20);
            this.txtDongia.TabIndex = 23;
            // 
            // txtHsd
            // 
            this.txtHsd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtHsd.Location = new System.Drawing.Point(785, 200);
            this.txtHsd.Name = "txtHsd";
            this.txtHsd.Size = new System.Drawing.Size(156, 20);
            this.txtHsd.TabIndex = 25;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(790, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(54, 30);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Location = new System.Drawing.Point(907, 251);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(60, 30);
            this.btnDel.TabIndex = 30;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(850, 251);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(51, 29);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblTongcong
            // 
            this.lblTongcong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTongcong.AutoSize = true;
            this.lblTongcong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongcong.Location = new System.Drawing.Point(26, 23);
            this.lblTongcong.Name = "lblTongcong";
            this.lblTongcong.Size = new System.Drawing.Size(73, 16);
            this.lblTongcong.TabIndex = 32;
            this.lblTongcong.Text = "Tổng cộng";
            // 
            // lblTongtienthanhtoan
            // 
            this.lblTongtienthanhtoan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTongtienthanhtoan.AutoSize = true;
            this.lblTongtienthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongtienthanhtoan.Location = new System.Drawing.Point(26, 98);
            this.lblTongtienthanhtoan.Name = "lblTongtienthanhtoan";
            this.lblTongtienthanhtoan.Size = new System.Drawing.Size(128, 16);
            this.lblTongtienthanhtoan.TabIndex = 33;
            this.lblTongtienthanhtoan.Text = "Tổng tiền thanh toán";
            // 
            // lblChietkhau
            // 
            this.lblChietkhau.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblChietkhau.AutoSize = true;
            this.lblChietkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChietkhau.Location = new System.Drawing.Point(26, 75);
            this.lblChietkhau.Name = "lblChietkhau";
            this.lblChietkhau.Size = new System.Drawing.Size(70, 16);
            this.lblChietkhau.TabIndex = 34;
            this.lblChietkhau.Text = "Chiết khấu";
            // 
            // lblThue
            // 
            this.lblThue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblThue.AutoSize = true;
            this.lblThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThue.Location = new System.Drawing.Point(26, 49);
            this.lblThue.Name = "lblThue";
            this.lblThue.Size = new System.Drawing.Size(39, 16);
            this.lblThue.TabIndex = 35;
            this.lblThue.Text = "Thuế";
            // 
            // txtChietkhau
            // 
            this.txtChietkhau.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtChietkhau.Location = new System.Drawing.Point(170, 72);
            this.txtChietkhau.Name = "txtChietkhau";
            this.txtChietkhau.Size = new System.Drawing.Size(118, 20);
            this.txtChietkhau.TabIndex = 43;
            // 
            // txtTongtienthanhtoan
            // 
            this.txtTongtienthanhtoan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTongtienthanhtoan.Location = new System.Drawing.Point(170, 98);
            this.txtTongtienthanhtoan.Name = "txtTongtienthanhtoan";
            this.txtTongtienthanhtoan.Size = new System.Drawing.Size(118, 20);
            this.txtTongtienthanhtoan.TabIndex = 42;
            // 
            // txtTongcong
            // 
            this.txtTongcong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTongcong.Location = new System.Drawing.Point(170, 20);
            this.txtTongcong.Name = "txtTongcong";
            this.txtTongcong.Size = new System.Drawing.Size(118, 20);
            this.txtTongcong.TabIndex = 39;
            // 
            // txtThue
            // 
            this.txtThue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtThue.Location = new System.Drawing.Point(170, 46);
            this.txtThue.Name = "txtThue";
            this.txtThue.Size = new System.Drawing.Size(118, 20);
            this.txtThue.TabIndex = 38;
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThanhtoan.Location = new System.Drawing.Point(331, 130);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(97, 37);
            this.btnThanhtoan.TabIndex = 46;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            // 
            // dgvPhieunhaphang
            // 
            this.dgvPhieunhaphang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhieunhaphang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieunhaphang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhieunhaphang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieunhaphang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Malo,
            this.Mathuoc,
            this.Soluong,
            this.Donvitinh,
            this.Dongia,
            this.Thanhtien});
            this.dgvPhieunhaphang.Location = new System.Drawing.Point(19, 293);
            this.dgvPhieunhaphang.Name = "dgvPhieunhaphang";
            this.dgvPhieunhaphang.Size = new System.Drawing.Size(948, 215);
            this.dgvPhieunhaphang.TabIndex = 48;
            this.dgvPhieunhaphang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieunhaphang_CellContentClick);
            // 
            // lblChitietphieunhap
            // 
            this.lblChitietphieunhap.AutoSize = true;
            this.lblChitietphieunhap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChitietphieunhap.Location = new System.Drawing.Point(15, 259);
            this.lblChitietphieunhap.Name = "lblChitietphieunhap";
            this.lblChitietphieunhap.Size = new System.Drawing.Size(139, 19);
            this.lblChitietphieunhap.TabIndex = 49;
            this.lblChitietphieunhap.Text = "Chi tiết phiếu nhập";
            // 
            // btnGhinhan
            // 
            this.btnGhinhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGhinhan.Location = new System.Drawing.Point(215, 130);
            this.btnGhinhan.Name = "btnGhinhan";
            this.btnGhinhan.Size = new System.Drawing.Size(97, 37);
            this.btnGhinhan.TabIndex = 51;
            this.btnGhinhan.Text = "Ghi nhận";
            this.btnGhinhan.UseVisualStyleBackColor = true;
            // 
            // lblDonvitinh
            // 
            this.lblDonvitinh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDonvitinh.AutoSize = true;
            this.lblDonvitinh.Location = new System.Drawing.Point(695, 125);
            this.lblDonvitinh.Name = "lblDonvitinh";
            this.lblDonvitinh.Size = new System.Drawing.Size(60, 13);
            this.lblDonvitinh.TabIndex = 8;
            this.lblDonvitinh.Text = "Đơn vị tính";
            // 
            // txtDonvitinh
            // 
            this.txtDonvitinh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDonvitinh.Location = new System.Drawing.Point(785, 122);
            this.txtDonvitinh.Name = "txtDonvitinh";
            this.txtDonvitinh.Size = new System.Drawing.Size(156, 20);
            this.txtDonvitinh.TabIndex = 24;
            // 
            // lblTenthuoc
            // 
            this.lblTenthuoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTenthuoc.AutoSize = true;
            this.lblTenthuoc.Location = new System.Drawing.Point(695, 99);
            this.lblTenthuoc.Name = "lblTenthuoc";
            this.lblTenthuoc.Size = new System.Drawing.Size(56, 13);
            this.lblTenthuoc.TabIndex = 10;
            this.lblTenthuoc.Text = "Tên thuốc";
            // 
            // btnTenthuoc
            // 
            this.btnTenthuoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTenthuoc.Location = new System.Drawing.Point(785, 96);
            this.btnTenthuoc.Name = "btnTenthuoc";
            this.btnTenthuoc.Size = new System.Drawing.Size(156, 20);
            this.btnTenthuoc.TabIndex = 19;
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.BackColor = System.Drawing.Color.Transparent;
            this.lblNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCC.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNCC.Location = new System.Drawing.Point(450, 77);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(134, 16);
            this.lblNCC.TabIndex = 53;
            this.lblNCC.Text = "Tên Nhà cung cấp";
            this.lblNCC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSelectSupplier
            // 
            this.btnSelectSupplier.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectSupplier.Image = global::medical_management.Properties.Resources.plus_circle_outline;
            this.btnSelectSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectSupplier.Location = new System.Drawing.Point(483, 63);
            this.btnSelectSupplier.Name = "btnSelectSupplier";
            this.btnSelectSupplier.Size = new System.Drawing.Size(149, 38);
            this.btnSelectSupplier.TabIndex = 54;
            this.btnSelectSupplier.Text = "Nhà cung cấp";
            this.btnSelectSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSelectSupplier.UseVisualStyleBackColor = false;
            // 
            // Malo
            // 
            this.Malo.DataPropertyName = "Malo";
            this.Malo.HeaderText = "Mã lô";
            this.Malo.Name = "Malo";
            // 
            // Mathuoc
            // 
            this.Mathuoc.DataPropertyName = "Mathuoc";
            this.Mathuoc.HeaderText = "Mã thuốc";
            this.Mathuoc.Name = "Mathuoc";
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.Name = "Soluong";
            // 
            // Donvitinh
            // 
            this.Donvitinh.DataPropertyName = "Donvitinh";
            this.Donvitinh.HeaderText = "Đơn vị tính";
            this.Donvitinh.Name = "Donvitinh";
            // 
            // Dongia
            // 
            this.Dongia.DataPropertyName = "Dongia";
            this.Dongia.HeaderText = "Đơn giá";
            this.Dongia.Name = "Dongia";
            // 
            // Thanhtien
            // 
            this.Thanhtien.DataPropertyName = "Thanhtien";
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.Name = "Thanhtien";
            // 
            // dgvThanhtoan
            // 
            this.dgvThanhtoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvThanhtoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanhtoan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvThanhtoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhtoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Phuongthucthanhtoan,
            this.Ngaythanhtoan,
            this.Thanhtoan,
            this.Ghichu});
            this.dgvThanhtoan.Location = new System.Drawing.Point(19, 514);
            this.dgvThanhtoan.Name = "dgvThanhtoan";
            this.dgvThanhtoan.Size = new System.Drawing.Size(480, 185);
            this.dgvThanhtoan.TabIndex = 55;
            // 
            // Phuongthucthanhtoan
            // 
            this.Phuongthucthanhtoan.DataPropertyName = "Phuongthucthanhtoan";
            this.Phuongthucthanhtoan.HeaderText = "Phương thức thanh toán";
            this.Phuongthucthanhtoan.Name = "Phuongthucthanhtoan";
            // 
            // Ngaythanhtoan
            // 
            this.Ngaythanhtoan.DataPropertyName = "Ngaythanhtoan";
            this.Ngaythanhtoan.HeaderText = "Ngày thanh toán";
            this.Ngaythanhtoan.Name = "Ngaythanhtoan";
            // 
            // Thanhtoan
            // 
            this.Thanhtoan.DataPropertyName = "Thanhtoan";
            this.Thanhtoan.HeaderText = "Thanh toán";
            this.Thanhtoan.Name = "Thanhtoan";
            // 
            // Ghichu
            // 
            this.Ghichu.DataPropertyName = "Ghichu";
            this.Ghichu.HeaderText = "Ghi chú";
            this.Ghichu.Name = "Ghichu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtTongcong);
            this.panel1.Controls.Add(this.lblTongcong);
            this.panel1.Controls.Add(this.lblTongtienthanhtoan);
            this.panel1.Controls.Add(this.lblChietkhau);
            this.panel1.Controls.Add(this.btnGhinhan);
            this.panel1.Controls.Add(this.lblThue);
            this.panel1.Controls.Add(this.txtThue);
            this.panel1.Controls.Add(this.txtTongtienthanhtoan);
            this.panel1.Controls.Add(this.btnThanhtoan);
            this.panel1.Controls.Add(this.txtChietkhau);
            this.panel1.Location = new System.Drawing.Point(519, 514);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 185);
            this.panel1.TabIndex = 56;
            // 
            // frmPhieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::medical_management.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(989, 713);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvThanhtoan);
            this.Controls.Add(this.btnSelectSupplier);
            this.Controls.Add(this.lblNCC);
            this.Controls.Add(this.lblChitietphieunhap);
            this.Controls.Add(this.dgvPhieunhaphang);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtHsd);
            this.Controls.Add(this.txtDonvitinh);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtMathuoc);
            this.Controls.Add(this.btnTenthuoc);
            this.Controls.Add(this.txtNgaynhap);
            this.Controls.Add(this.txtNhanviennhap);
            this.Controls.Add(this.txtManhap);
            this.Controls.Add(this.lblDongia);
            this.Controls.Add(this.lblSoluong);
            this.Controls.Add(this.lblMathuoc);
            this.Controls.Add(this.lblTenthuoc);
            this.Controls.Add(this.lblHsd);
            this.Controls.Add(this.lblDonvitinh);
            this.Controls.Add(this.lblManhap);
            this.Controls.Add(this.lblNgaynhap);
            this.Controls.Add(this.lblNhanviennhap);
            this.Controls.Add(this.lblMaNCC);
            this.Controls.Add(this.lblThongtinchung);
            this.Controls.Add(this.lblPhieunhap);
            this.Name = "frmPhieunhap";
            this.Text = "Lưu phiếu nhập";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieunhaphang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhtoan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhieunhap;
        private System.Windows.Forms.Label lblThongtinchung;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.Label lblNhanviennhap;
        private System.Windows.Forms.Label lblNgaynhap;
        private System.Windows.Forms.Label lblManhap;
        private System.Windows.Forms.Label lblHsd;
        private System.Windows.Forms.Label lblMathuoc;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblDongia;
        private System.Windows.Forms.TextBox txtManhap;
        private System.Windows.Forms.TextBox txtNhanviennhap;
        private System.Windows.Forms.TextBox txtNgaynhap;
        private System.Windows.Forms.TextBox txtMathuoc;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtHsd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblTongcong;
        private System.Windows.Forms.Label lblTongtienthanhtoan;
        private System.Windows.Forms.Label lblChietkhau;
        private System.Windows.Forms.Label lblThue;
        private System.Windows.Forms.TextBox txtChietkhau;
        private System.Windows.Forms.TextBox txtTongtienthanhtoan;
        private System.Windows.Forms.TextBox txtTongcong;
        private System.Windows.Forms.TextBox txtThue;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.DataGridView dgvPhieunhaphang;
        private System.Windows.Forms.Label lblChitietphieunhap;
        private System.Windows.Forms.Button btnGhinhan;
        private System.Windows.Forms.Label lblDonvitinh;
        private System.Windows.Forms.TextBox txtDonvitinh;
        private System.Windows.Forms.Label lblTenthuoc;
        private System.Windows.Forms.TextBox btnTenthuoc;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.Button btnSelectSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.DataGridView dgvThanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phuongthucthanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaythanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
        private System.Windows.Forms.Panel panel1;
    }
}