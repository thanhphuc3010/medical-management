
namespace medical_management
{
    partial class frmNhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanvien));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.lblNhanvien = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblChucvu = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblChungchihanhnghe = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtGioitinh = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSodienthoai = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtChungchihanhnghe = new System.Windows.Forms.TextBox();
            this.txtNgaysinh = new System.Windows.Forms.TextBox();
            this.txtChucvu = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chungchihanhnghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.Location = new System.Drawing.Point(27, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSave.Location = new System.Drawing.Point(198, 207);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(51, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDel.Location = new System.Drawing.Point(141, 207);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(51, 40);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEdit.Location = new System.Drawing.Point(84, 207);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(51, 40);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDau
            // 
            this.btnDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDau.Location = new System.Drawing.Point(12, 470);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(75, 28);
            this.btnDau.TabIndex = 5;
            this.btnDau.Text = "Đầu";
            this.btnDau.UseVisualStyleBackColor = false;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCuoi.Location = new System.Drawing.Point(255, 470);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(75, 28);
            this.btnCuoi.TabIndex = 6;
            this.btnCuoi.Text = "Cuối";
            this.btnCuoi.UseVisualStyleBackColor = false;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // btnSau
            // 
            this.btnSau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSau.Location = new System.Drawing.Point(174, 470);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(75, 28);
            this.btnSau.TabIndex = 7;
            this.btnSau.Text = "Sau";
            this.btnSau.UseVisualStyleBackColor = false;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTruoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTruoc.Location = new System.Drawing.Point(93, 470);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(75, 28);
            this.btnTruoc.TabIndex = 8;
            this.btnTruoc.Text = "Trước";
            this.btnTruoc.UseVisualStyleBackColor = false;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // lblNhanvien
            // 
            this.lblNhanvien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNhanvien.AutoSize = true;
            this.lblNhanvien.BackColor = System.Drawing.Color.Transparent;
            this.lblNhanvien.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanvien.Location = new System.Drawing.Point(430, 30);
            this.lblNhanvien.Name = "lblNhanvien";
            this.lblNhanvien.Size = new System.Drawing.Size(210, 29);
            this.lblNhanvien.TabIndex = 9;
            this.lblNhanvien.Text = "Thông tin nhân viên";
            // 
            // lblDiachi
            // 
            this.lblDiachi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.BackColor = System.Drawing.Color.Transparent;
            this.lblDiachi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.Location = new System.Drawing.Point(689, 89);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(42, 15);
            this.lblDiachi.TabIndex = 10;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblSdt
            // 
            this.lblSdt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSdt.AutoSize = true;
            this.lblSdt.BackColor = System.Drawing.Color.Transparent;
            this.lblSdt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdt.Location = new System.Drawing.Point(689, 119);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(78, 15);
            this.lblSdt.TabIndex = 11;
            this.lblSdt.Text = "Số điện thoại";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(689, 145);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.BackColor = System.Drawing.Color.Transparent;
            this.lblGioitinh.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioitinh.Location = new System.Drawing.Point(353, 145);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(54, 15);
            this.lblGioitinh.TabIndex = 13;
            this.lblGioitinh.Text = "Giới tính";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaysinh.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaysinh.Location = new System.Drawing.Point(353, 119);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(59, 15);
            this.lblNgaysinh.TabIndex = 14;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblChucvu
            // 
            this.lblChucvu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChucvu.AutoSize = true;
            this.lblChucvu.BackColor = System.Drawing.Color.Transparent;
            this.lblChucvu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucvu.Location = new System.Drawing.Point(37, 145);
            this.lblChucvu.Name = "lblChucvu";
            this.lblChucvu.Size = new System.Drawing.Size(50, 15);
            this.lblChucvu.TabIndex = 15;
            this.lblChucvu.Text = "Chức vụ";
            // 
            // lblTenNV
            // 
            this.lblTenNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.BackColor = System.Drawing.Color.Transparent;
            this.lblTenNV.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(37, 121);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(84, 15);
            this.lblTenNV.TabIndex = 16;
            this.lblTenNV.Text = "Tên Nhân viên";
            // 
            // lblMaNV
            // 
            this.lblMaNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.BackColor = System.Drawing.Color.Transparent;
            this.lblMaNV.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(37, 93);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(82, 15);
            this.lblMaNV.TabIndex = 17;
            this.lblMaNV.Text = "Mã Nhân viên";
            // 
            // lblChungchihanhnghe
            // 
            this.lblChungchihanhnghe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChungchihanhnghe.AutoSize = true;
            this.lblChungchihanhnghe.BackColor = System.Drawing.Color.Transparent;
            this.lblChungchihanhnghe.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChungchihanhnghe.Location = new System.Drawing.Point(353, 90);
            this.lblChungchihanhnghe.Name = "lblChungchihanhnghe";
            this.lblChungchihanhnghe.Size = new System.Drawing.Size(120, 15);
            this.lblChungchihanhnghe.TabIndex = 18;
            this.lblChungchihanhnghe.Text = "Chứng chỉ hành nghề";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaNV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMaNV.Location = new System.Drawing.Point(162, 90);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(145, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGioitinh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtGioitinh.Location = new System.Drawing.Point(492, 142);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(145, 20);
            this.txtGioitinh.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtEmail.Location = new System.Drawing.Point(794, 138);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSodienthoai.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSodienthoai.Location = new System.Drawing.Point(794, 112);
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Size = new System.Drawing.Size(146, 20);
            this.txtSodienthoai.TabIndex = 22;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiachi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDiachi.Location = new System.Drawing.Point(794, 86);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(146, 20);
            this.txtDiachi.TabIndex = 23;
            // 
            // txtChungchihanhnghe
            // 
            this.txtChungchihanhnghe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtChungchihanhnghe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtChungchihanhnghe.Location = new System.Drawing.Point(492, 90);
            this.txtChungchihanhnghe.Name = "txtChungchihanhnghe";
            this.txtChungchihanhnghe.Size = new System.Drawing.Size(146, 20);
            this.txtChungchihanhnghe.TabIndex = 24;
            // 
            // txtNgaysinh
            // 
            this.txtNgaysinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNgaysinh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNgaysinh.Location = new System.Drawing.Point(492, 116);
            this.txtNgaysinh.Name = "txtNgaysinh";
            this.txtNgaysinh.Size = new System.Drawing.Size(145, 20);
            this.txtNgaysinh.TabIndex = 4;
            // 
            // txtChucvu
            // 
            this.txtChucvu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtChucvu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtChucvu.Location = new System.Drawing.Point(162, 142);
            this.txtChucvu.Name = "txtChucvu";
            this.txtChucvu.Size = new System.Drawing.Size(145, 20);
            this.txtChucvu.TabIndex = 3;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenNV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTenNV.Location = new System.Drawing.Point(162, 116);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(145, 20);
            this.txtTenNV.TabIndex = 2;
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanvien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.Chucvu,
            this.Ngaysinh,
            this.Gioitinh,
            this.Chungchihanhnghe,
            this.Diachi,
            this.Sdt,
            this.Email});
            this.dgvNhanvien.Location = new System.Drawing.Point(12, 263);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.Size = new System.Drawing.Size(949, 189);
            this.dgvNhanvien.TabIndex = 28;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân viên";
            this.MaNV.Name = "MaNV";
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân viên";
            this.TenNV.Name = "TenNV";
            // 
            // Chucvu
            // 
            this.Chucvu.DataPropertyName = "Chucvu";
            this.Chucvu.HeaderText = "Chức vụ";
            this.Chucvu.Name = "Chucvu";
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "Ngày sinh";
            this.Ngaysinh.Name = "Ngaysinh";
            // 
            // Gioitinh
            // 
            this.Gioitinh.DataPropertyName = "Gioitinh";
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.Name = "Gioitinh";
            // 
            // Chungchihanhnghe
            // 
            this.Chungchihanhnghe.DataPropertyName = "Chungchihanhnghe";
            this.Chungchihanhnghe.HeaderText = "Chứng chỉ hành nghề";
            this.Chungchihanhnghe.Name = "Chungchihanhnghe";
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
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExit.Location = new System.Drawing.Point(872, 470);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 28);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Kết thúc";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::medical_management.Properties.Resources._635203f6dfa214fc4db3;
            this.ClientSize = new System.Drawing.Size(973, 510);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvNhanvien);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtChucvu);
            this.Controls.Add(this.txtNgaysinh);
            this.Controls.Add(this.txtChungchihanhnghe);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtSodienthoai);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtGioitinh);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lblChungchihanhnghe);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.lblChucvu);
            this.Controls.Add(this.lblNgaysinh);
            this.Controls.Add(this.lblGioitinh);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSdt);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.lblNhanvien);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnCuoi);
            this.Controls.Add(this.btnDau);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhanvien";
            this.Text = "Danh mục Nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Label lblNhanvien;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblChucvu;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblChungchihanhnghe;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtGioitinh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSodienthoai;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtChungchihanhnghe;
        private System.Windows.Forms.TextBox txtNgaysinh;
        private System.Windows.Forms.TextBox txtChucvu;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chungchihanhnghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}