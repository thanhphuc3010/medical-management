﻿
namespace medical_management
{
    partial class frmThuoc
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblThuoc = new System.Windows.Forms.Label();
            this.lblMathuoc = new System.Windows.Forms.Label();
            this.lblManhasanxuat = new System.Windows.Forms.Label();
            this.lblTenthuoc = new System.Windows.Forms.Label();
            this.lblHamluong = new System.Windows.Forms.Label();
            this.lblDonvi = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblDonggoi = new System.Windows.Forms.Label();
            this.lblThanhphan = new System.Windows.Forms.Label();
            this.lblGhichu = new System.Windows.Forms.Label();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.Mathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nhomthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhphan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hamluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donggoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMathuoc = new System.Windows.Forms.TextBox();
            this.txtMaNSX = new System.Windows.Forms.TextBox();
            this.txtTenthuoc = new System.Windows.Forms.TextBox();
            this.txtDonvi = new System.Windows.Forms.TextBox();
            this.txtHamluong = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtDonggoi = new System.Windows.Forms.TextBox();
            this.txtThanhphan = new System.Windows.Forms.TextBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.btnDau = new System.Windows.Forms.Button();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.txtGianhap = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.lblGianhap = new System.Windows.Forms.Label();
            this.lblDongia = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtNhomthuoc = new System.Windows.Forms.TextBox();
            this.lblNhomthuoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comFName = new System.Windows.Forms.ComboBox();
            this.comFValue = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(167, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(47, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(114, 256);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(47, 34);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(61, 256);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(47, 34);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(220, 256);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(47, 34);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblThuoc
            // 
            this.lblThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblThuoc.AutoSize = true;
            this.lblThuoc.BackColor = System.Drawing.Color.Transparent;
            this.lblThuoc.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuoc.Location = new System.Drawing.Point(428, 28);
            this.lblThuoc.Name = "lblThuoc";
            this.lblThuoc.Size = new System.Drawing.Size(169, 29);
            this.lblThuoc.TabIndex = 5;
            this.lblThuoc.Text = "Thông tin thuốc";
            // 
            // lblMathuoc
            // 
            this.lblMathuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMathuoc.AutoSize = true;
            this.lblMathuoc.BackColor = System.Drawing.Color.Transparent;
            this.lblMathuoc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMathuoc.Location = new System.Drawing.Point(28, 97);
            this.lblMathuoc.Name = "lblMathuoc";
            this.lblMathuoc.Size = new System.Drawing.Size(59, 15);
            this.lblMathuoc.TabIndex = 6;
            this.lblMathuoc.Text = "Mã Thuốc";
            // 
            // lblManhasanxuat
            // 
            this.lblManhasanxuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblManhasanxuat.AutoSize = true;
            this.lblManhasanxuat.BackColor = System.Drawing.Color.Transparent;
            this.lblManhasanxuat.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManhasanxuat.Location = new System.Drawing.Point(28, 119);
            this.lblManhasanxuat.Name = "lblManhasanxuat";
            this.lblManhasanxuat.Size = new System.Drawing.Size(97, 15);
            this.lblManhasanxuat.TabIndex = 7;
            this.lblManhasanxuat.Text = "Mã Nhà sản xuất";
            // 
            // lblTenthuoc
            // 
            this.lblTenthuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenthuoc.AutoSize = true;
            this.lblTenthuoc.BackColor = System.Drawing.Color.Transparent;
            this.lblTenthuoc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenthuoc.Location = new System.Drawing.Point(28, 167);
            this.lblTenthuoc.Name = "lblTenthuoc";
            this.lblTenthuoc.Size = new System.Drawing.Size(60, 15);
            this.lblTenthuoc.TabIndex = 8;
            this.lblTenthuoc.Text = "Tên thuốc";
            // 
            // lblHamluong
            // 
            this.lblHamluong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHamluong.AutoSize = true;
            this.lblHamluong.BackColor = System.Drawing.Color.Transparent;
            this.lblHamluong.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHamluong.Location = new System.Drawing.Point(386, 121);
            this.lblHamluong.Name = "lblHamluong";
            this.lblHamluong.Size = new System.Drawing.Size(67, 15);
            this.lblHamluong.TabIndex = 9;
            this.lblHamluong.Text = "Hàm lượng";
            // 
            // lblDonvi
            // 
            this.lblDonvi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDonvi.AutoSize = true;
            this.lblDonvi.BackColor = System.Drawing.Color.Transparent;
            this.lblDonvi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonvi.Location = new System.Drawing.Point(386, 95);
            this.lblDonvi.Name = "lblDonvi";
            this.lblDonvi.Size = new System.Drawing.Size(42, 15);
            this.lblDonvi.TabIndex = 10;
            this.lblDonvi.Text = "Đơn vị";
            // 
            // lblSoluong
            // 
            this.lblSoluong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoluong.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluong.Location = new System.Drawing.Point(729, 94);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(55, 15);
            this.lblSoluong.TabIndex = 11;
            this.lblSoluong.Text = "Số lượng";
            // 
            // lblDonggoi
            // 
            this.lblDonggoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDonggoi.AutoSize = true;
            this.lblDonggoi.BackColor = System.Drawing.Color.Transparent;
            this.lblDonggoi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonggoi.Location = new System.Drawing.Point(387, 147);
            this.lblDonggoi.Name = "lblDonggoi";
            this.lblDonggoi.Size = new System.Drawing.Size(54, 15);
            this.lblDonggoi.TabIndex = 12;
            this.lblDonggoi.Text = "Đóng gói";
            // 
            // lblThanhphan
            // 
            this.lblThanhphan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblThanhphan.AutoSize = true;
            this.lblThanhphan.BackColor = System.Drawing.Color.Transparent;
            this.lblThanhphan.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhphan.Location = new System.Drawing.Point(387, 173);
            this.lblThanhphan.Name = "lblThanhphan";
            this.lblThanhphan.Size = new System.Drawing.Size(70, 15);
            this.lblThanhphan.TabIndex = 13;
            this.lblThanhphan.Text = "Thành phần";
            // 
            // lblGhichu
            // 
            this.lblGhichu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGhichu.AutoSize = true;
            this.lblGhichu.BackColor = System.Drawing.Color.Transparent;
            this.lblGhichu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhichu.Location = new System.Drawing.Point(729, 177);
            this.lblGhichu.Name = "lblGhichu";
            this.lblGhichu.Size = new System.Drawing.Size(47, 15);
            this.lblGhichu.TabIndex = 16;
            this.lblGhichu.Text = "Ghi chú";
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mathuoc,
            this.Nhomthuoc,
            this.MaNSX,
            this.Tenthuoc,
            this.Donvi,
            this.Thanhphan,
            this.Hamluong,
            this.Donggoi,
            this.Soluong,
            this.Gianhap,
            this.Dongia,
            this.Ghichu});
            this.dgvThuoc.Location = new System.Drawing.Point(12, 304);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.RowHeadersWidth = 20;
            this.dgvThuoc.Size = new System.Drawing.Size(1000, 182);
            this.dgvThuoc.TabIndex = 10;
            // 
            // Mathuoc
            // 
            this.Mathuoc.DataPropertyName = "Mathuoc";
            this.Mathuoc.HeaderText = "Mã thuốc";
            this.Mathuoc.MinimumWidth = 6;
            this.Mathuoc.Name = "Mathuoc";
            // 
            // Nhomthuoc
            // 
            this.Nhomthuoc.DataPropertyName = "Nhomthuoc";
            this.Nhomthuoc.HeaderText = "Nhóm thuốc";
            this.Nhomthuoc.Name = "Nhomthuoc";
            // 
            // MaNSX
            // 
            this.MaNSX.DataPropertyName = "MaNSX";
            this.MaNSX.HeaderText = "Mã Nhà sản xuất";
            this.MaNSX.MinimumWidth = 6;
            this.MaNSX.Name = "MaNSX";
            // 
            // Tenthuoc
            // 
            this.Tenthuoc.DataPropertyName = "Tenthuoc";
            this.Tenthuoc.HeaderText = "Tên thuốc";
            this.Tenthuoc.MinimumWidth = 6;
            this.Tenthuoc.Name = "Tenthuoc";
            // 
            // Donvi
            // 
            this.Donvi.DataPropertyName = "Donvi";
            this.Donvi.HeaderText = "Đơn vị";
            this.Donvi.MinimumWidth = 6;
            this.Donvi.Name = "Donvi";
            // 
            // Thanhphan
            // 
            this.Thanhphan.DataPropertyName = "Thanhphan";
            this.Thanhphan.HeaderText = "Thành phần";
            this.Thanhphan.MinimumWidth = 6;
            this.Thanhphan.Name = "Thanhphan";
            // 
            // Hamluong
            // 
            this.Hamluong.DataPropertyName = "Hamluong";
            this.Hamluong.HeaderText = "Hàm Lượng";
            this.Hamluong.MinimumWidth = 6;
            this.Hamluong.Name = "Hamluong";
            // 
            // Donggoi
            // 
            this.Donggoi.DataPropertyName = "Donggoi";
            this.Donggoi.HeaderText = "Đóng gói";
            this.Donggoi.MinimumWidth = 6;
            this.Donggoi.Name = "Donggoi";
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            // 
            // Gianhap
            // 
            this.Gianhap.DataPropertyName = "Gianhap";
            this.Gianhap.HeaderText = "Giá nhập";
            this.Gianhap.Name = "Gianhap";
            // 
            // Dongia
            // 
            this.Dongia.DataPropertyName = "Dongia";
            this.Dongia.HeaderText = "Đơn giá";
            this.Dongia.Name = "Dongia";
            // 
            // Ghichu
            // 
            this.Ghichu.DataPropertyName = "Ghichu";
            this.Ghichu.HeaderText = "Ghi chú";
            this.Ghichu.MinimumWidth = 6;
            this.Ghichu.Name = "Ghichu";
            // 
            // txtMathuoc
            // 
            this.txtMathuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMathuoc.Location = new System.Drawing.Point(136, 92);
            this.txtMathuoc.Name = "txtMathuoc";
            this.txtMathuoc.Size = new System.Drawing.Size(188, 20);
            this.txtMathuoc.TabIndex = 18;
            // 
            // txtMaNSX
            // 
            this.txtMaNSX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaNSX.Location = new System.Drawing.Point(136, 118);
            this.txtMaNSX.Name = "txtMaNSX";
            this.txtMaNSX.Size = new System.Drawing.Size(188, 20);
            this.txtMaNSX.TabIndex = 19;
            // 
            // txtTenthuoc
            // 
            this.txtTenthuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenthuoc.Location = new System.Drawing.Point(136, 166);
            this.txtTenthuoc.Name = "txtTenthuoc";
            this.txtTenthuoc.Size = new System.Drawing.Size(188, 20);
            this.txtTenthuoc.TabIndex = 20;
            // 
            // txtDonvi
            // 
            this.txtDonvi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDonvi.Location = new System.Drawing.Point(481, 92);
            this.txtDonvi.Name = "txtDonvi";
            this.txtDonvi.Size = new System.Drawing.Size(188, 20);
            this.txtDonvi.TabIndex = 21;
            // 
            // txtHamluong
            // 
            this.txtHamluong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHamluong.Location = new System.Drawing.Point(481, 118);
            this.txtHamluong.Name = "txtHamluong";
            this.txtHamluong.Size = new System.Drawing.Size(188, 20);
            this.txtHamluong.TabIndex = 22;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoluong.Location = new System.Drawing.Point(812, 92);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(188, 20);
            this.txtSoluong.TabIndex = 23;
            // 
            // txtDonggoi
            // 
            this.txtDonggoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDonggoi.Location = new System.Drawing.Point(481, 144);
            this.txtDonggoi.Name = "txtDonggoi";
            this.txtDonggoi.Size = new System.Drawing.Size(188, 20);
            this.txtDonggoi.TabIndex = 24;
            // 
            // txtThanhphan
            // 
            this.txtThanhphan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtThanhphan.Location = new System.Drawing.Point(481, 170);
            this.txtThanhphan.Name = "txtThanhphan";
            this.txtThanhphan.Size = new System.Drawing.Size(188, 20);
            this.txtThanhphan.TabIndex = 25;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGhichu.Location = new System.Drawing.Point(812, 170);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(188, 20);
            this.txtGhichu.TabIndex = 28;
            // 
            // btnDau
            // 
            this.btnDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDau.Location = new System.Drawing.Point(9, 492);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(68, 34);
            this.btnDau.TabIndex = 29;
            this.btnDau.Text = "Đầu";
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCuoi.Location = new System.Drawing.Point(231, 492);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(68, 34);
            this.btnCuoi.TabIndex = 30;
            this.btnCuoi.Text = "Cuối";
            this.btnCuoi.UseVisualStyleBackColor = true;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // btnSau
            // 
            this.btnSau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSau.Location = new System.Drawing.Point(157, 492);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(68, 34);
            this.btnSau.TabIndex = 31;
            this.btnSau.Text = "Sau";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTruoc.Location = new System.Drawing.Point(83, 492);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(68, 34);
            this.btnTruoc.TabIndex = 32;
            this.btnTruoc.Text = "Trước";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // txtGianhap
            // 
            this.txtGianhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGianhap.HideSelection = false;
            this.txtGianhap.Location = new System.Drawing.Point(812, 144);
            this.txtGianhap.Name = "txtGianhap";
            this.txtGianhap.Size = new System.Drawing.Size(188, 20);
            this.txtGianhap.TabIndex = 38;
            // 
            // txtDongia
            // 
            this.txtDongia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDongia.Location = new System.Drawing.Point(812, 118);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(188, 20);
            this.txtDongia.TabIndex = 37;
            // 
            // lblGianhap
            // 
            this.lblGianhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGianhap.AutoSize = true;
            this.lblGianhap.BackColor = System.Drawing.Color.Transparent;
            this.lblGianhap.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGianhap.Location = new System.Drawing.Point(729, 151);
            this.lblGianhap.Name = "lblGianhap";
            this.lblGianhap.Size = new System.Drawing.Size(54, 15);
            this.lblGianhap.TabIndex = 36;
            this.lblGianhap.Text = "Giá nhập";
            // 
            // lblDongia
            // 
            this.lblDongia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDongia.AutoSize = true;
            this.lblDongia.BackColor = System.Drawing.Color.Transparent;
            this.lblDongia.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDongia.Location = new System.Drawing.Point(729, 121);
            this.lblDongia.Name = "lblDongia";
            this.lblDongia.Size = new System.Drawing.Size(48, 15);
            this.lblDongia.TabIndex = 35;
            this.lblDongia.Text = "Đơn giá";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(931, 492);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 34);
            this.btnExit.TabIndex = 39;
            this.btnExit.Text = "Kết thúc";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtNhomthuoc
            // 
            this.txtNhomthuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNhomthuoc.Location = new System.Drawing.Point(136, 144);
            this.txtNhomthuoc.Name = "txtNhomthuoc";
            this.txtNhomthuoc.Size = new System.Drawing.Size(188, 20);
            this.txtNhomthuoc.TabIndex = 41;
            // 
            // lblNhomthuoc
            // 
            this.lblNhomthuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNhomthuoc.AutoSize = true;
            this.lblNhomthuoc.BackColor = System.Drawing.Color.Transparent;
            this.lblNhomthuoc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhomthuoc.Location = new System.Drawing.Point(28, 145);
            this.lblNhomthuoc.Name = "lblNhomthuoc";
            this.lblNhomthuoc.Size = new System.Drawing.Size(75, 15);
            this.lblNhomthuoc.TabIndex = 40;
            this.lblNhomthuoc.Text = "Nhóm thuốc";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(728, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tên trường        =          Giá trị";
            // 
            // comFName
            // 
            this.comFName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comFName.FormattingEnabled = true;
            this.comFName.Items.AddRange(new object[] {
            "Nhóm thuốc",
            "Mã Nhà sản xuất"});
            this.comFName.Location = new System.Drawing.Point(710, 231);
            this.comFName.Name = "comFName";
            this.comFName.Size = new System.Drawing.Size(121, 21);
            this.comFName.TabIndex = 43;
            this.comFName.SelectedIndexChanged += new System.EventHandler(this.comFName_SelectedIndexChanged);
            // 
            // comFValue
            // 
            this.comFValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comFValue.FormattingEnabled = true;
            this.comFValue.Location = new System.Drawing.Point(864, 231);
            this.comFValue.Name = "comFValue";
            this.comFValue.Size = new System.Drawing.Size(121, 21);
            this.comFValue.TabIndex = 44;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Location = new System.Drawing.Point(732, 258);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(78, 31);
            this.btnFilter.TabIndex = 45;
            this.btnFilter.Text = "Lọc dữ liệu";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(891, 258);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(71, 31);
            this.btnRefresh.TabIndex = 46;
            this.btnRefresh.Text = "Nạp lại";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // frmThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::medical_management.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1028, 538);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.comFValue);
            this.Controls.Add(this.comFName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhomthuoc);
            this.Controls.Add(this.lblNhomthuoc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtGianhap);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.lblGianhap);
            this.Controls.Add(this.lblDongia);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnCuoi);
            this.Controls.Add(this.btnDau);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.txtThanhphan);
            this.Controls.Add(this.txtDonggoi);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtHamluong);
            this.Controls.Add(this.txtDonvi);
            this.Controls.Add(this.txtTenthuoc);
            this.Controls.Add(this.txtMaNSX);
            this.Controls.Add(this.txtMathuoc);
            this.Controls.Add(this.dgvThuoc);
            this.Controls.Add(this.lblGhichu);
            this.Controls.Add(this.lblThanhphan);
            this.Controls.Add(this.lblDonggoi);
            this.Controls.Add(this.lblSoluong);
            this.Controls.Add(this.lblDonvi);
            this.Controls.Add(this.lblHamluong);
            this.Controls.Add(this.lblTenthuoc);
            this.Controls.Add(this.lblManhasanxuat);
            this.Controls.Add(this.lblMathuoc);
            this.Controls.Add(this.lblThuoc);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThuoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblThuoc;
        private System.Windows.Forms.Label lblMathuoc;
        private System.Windows.Forms.Label lblManhasanxuat;
        private System.Windows.Forms.Label lblTenthuoc;
        private System.Windows.Forms.Label lblHamluong;
        private System.Windows.Forms.Label lblDonvi;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblDonggoi;
        private System.Windows.Forms.Label lblThanhphan;
        private System.Windows.Forms.Label lblGhichu;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.TextBox txtMathuoc;
        private System.Windows.Forms.TextBox txtMaNSX;
        private System.Windows.Forms.TextBox txtTenthuoc;
        private System.Windows.Forms.TextBox txtDonvi;
        private System.Windows.Forms.TextBox txtHamluong;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtDonggoi;
        private System.Windows.Forms.TextBox txtThanhphan;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.TextBox txtGianhap;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label lblGianhap;
        private System.Windows.Forms.Label lblDongia;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtNhomthuoc;
        private System.Windows.Forms.Label lblNhomthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nhomthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhphan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hamluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donggoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comFName;
        private System.Windows.Forms.ComboBox comFValue;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnRefresh;
    }
}