
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
            this.components = new System.ComponentModel.Container();
            this.lblPhieunhap = new System.Windows.Forms.Label();
            this.lblThongtinchung = new System.Windows.Forms.Label();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblNhanviennhap = new System.Windows.Forms.Label();
            this.lblNgaynhap = new System.Windows.Forms.Label();
            this.lblManhap = new System.Windows.Forms.Label();
            this.lblNgayhethan = new System.Windows.Forms.Label();
            this.lblMathuoc = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblGianhap = new System.Windows.Forms.Label();
            this.txtManhap = new System.Windows.Forms.TextBox();
            this.txtNhanviennhap = new System.Windows.Forms.TextBox();
            this.txtMathuoc = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtGianhap = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTongcong = new System.Windows.Forms.Label();
            this.lblTongtienthanhtoan = new System.Windows.Forms.Label();
            this.lblChietkhau = new System.Windows.Forms.Label();
            this.lblThue = new System.Windows.Forms.Label();
            this.txtChietkhau = new System.Windows.Forms.TextBox();
            this.txtTongtienthanhtoan = new System.Windows.Forms.TextBox();
            this.txtTongcong = new System.Windows.Forms.TextBox();
            this.txtThue = new System.Windows.Forms.TextBox();
            this.dgvPhieunhapchitiet = new System.Windows.Forms.DataGridView();
            this.Mathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblChitietphieunhap = new System.Windows.Forms.Label();
            this.btnGhinhan = new System.Windows.Forms.Button();
            this.lblDonvi = new System.Windows.Forms.Label();
            this.txtDonvi = new System.Windows.Forms.TextBox();
            this.lblTenthuoc = new System.Windows.Forms.Label();
            this.txtTenthuoc = new System.Windows.Forms.TextBox();
            this.lblNCC = new System.Windows.Forms.Label();
            this.btnSelectSupplier = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectMedical = new System.Windows.Forms.Button();
            this.dtpNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.txtMalo = new System.Windows.Forms.TextBox();
            this.lblMalo = new System.Windows.Forms.Label();
            this.dtpNgayhethan = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaysanxuat = new System.Windows.Forms.DateTimePicker();
            this.lblNgaysanxuat = new System.Windows.Forms.Label();
            this.cmnuPODetail = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieunhapchitiet)).BeginInit();
            this.panel1.SuspendLayout();
            this.cmnuPODetail.SuspendLayout();
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
            this.lblMaNCC.Location = new System.Drawing.Point(330, 102);
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
            // lblNgayhethan
            // 
            this.lblNgayhethan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNgayhethan.AutoSize = true;
            this.lblNgayhethan.Location = new System.Drawing.Point(676, 238);
            this.lblNgayhethan.Name = "lblNgayhethan";
            this.lblNgayhethan.Size = new System.Drawing.Size(71, 13);
            this.lblNgayhethan.TabIndex = 9;
            this.lblNgayhethan.Text = "Ngày hết hạn";
            // 
            // lblMathuoc
            // 
            this.lblMathuoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMathuoc.AutoSize = true;
            this.lblMathuoc.Location = new System.Drawing.Point(676, 80);
            this.lblMathuoc.Name = "lblMathuoc";
            this.lblMathuoc.Size = new System.Drawing.Size(52, 13);
            this.lblMathuoc.TabIndex = 11;
            this.lblMathuoc.Text = "Mã thuốc";
            // 
            // lblSoluong
            // 
            this.lblSoluong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(676, 184);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(52, 13);
            this.lblSoluong.TabIndex = 13;
            this.lblSoluong.Text = "Số lượng ";
            // 
            // lblGianhap
            // 
            this.lblGianhap.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGianhap.AutoSize = true;
            this.lblGianhap.Location = new System.Drawing.Point(676, 158);
            this.lblGianhap.Name = "lblGianhap";
            this.lblGianhap.Size = new System.Drawing.Size(50, 13);
            this.lblGianhap.TabIndex = 14;
            this.lblGianhap.Text = "Giá nhập";
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
            // txtMathuoc
            // 
            this.txtMathuoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMathuoc.Location = new System.Drawing.Point(766, 77);
            this.txtMathuoc.Name = "txtMathuoc";
            this.txtMathuoc.Size = new System.Drawing.Size(125, 20);
            this.txtMathuoc.TabIndex = 20;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSoluong.Location = new System.Drawing.Point(766, 181);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(156, 20);
            this.txtSoluong.TabIndex = 22;
            this.txtSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoluong_KeyPress);
            // 
            // txtGianhap
            // 
            this.txtGianhap.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtGianhap.Location = new System.Drawing.Point(766, 155);
            this.txtGianhap.Name = "txtGianhap";
            this.txtGianhap.Size = new System.Drawing.Size(156, 20);
            this.txtGianhap.TabIndex = 23;
            this.txtGianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGianhap_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Image = global::medical_management.Properties.Resources.ic_cart;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(945, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 30);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = global::medical_management.Properties.Resources.ic_close;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(945, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 30);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(945, 142);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(64, 29);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblTongcong
            // 
            this.lblTongcong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTongcong.AutoSize = true;
            this.lblTongcong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongcong.Location = new System.Drawing.Point(65, 26);
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
            this.lblTongtienthanhtoan.Location = new System.Drawing.Point(65, 101);
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
            this.lblChietkhau.Location = new System.Drawing.Point(65, 78);
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
            this.lblThue.Location = new System.Drawing.Point(65, 52);
            this.lblThue.Name = "lblThue";
            this.lblThue.Size = new System.Drawing.Size(39, 16);
            this.lblThue.TabIndex = 35;
            this.lblThue.Text = "Thuế";
            // 
            // txtChietkhau
            // 
            this.txtChietkhau.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtChietkhau.Location = new System.Drawing.Point(236, 75);
            this.txtChietkhau.Name = "txtChietkhau";
            this.txtChietkhau.Size = new System.Drawing.Size(149, 20);
            this.txtChietkhau.TabIndex = 43;
            this.txtChietkhau.Text = "0";
            this.txtChietkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtChietkhau.TextChanged += new System.EventHandler(this.txtChietkhau_TextChanged);
            // 
            // txtTongtienthanhtoan
            // 
            this.txtTongtienthanhtoan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTongtienthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongtienthanhtoan.ForeColor = System.Drawing.Color.Red;
            this.txtTongtienthanhtoan.Location = new System.Drawing.Point(236, 101);
            this.txtTongtienthanhtoan.Name = "txtTongtienthanhtoan";
            this.txtTongtienthanhtoan.Size = new System.Drawing.Size(149, 21);
            this.txtTongtienthanhtoan.TabIndex = 42;
            this.txtTongtienthanhtoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTongcong
            // 
            this.txtTongcong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTongcong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongcong.ForeColor = System.Drawing.Color.DarkRed;
            this.txtTongcong.Location = new System.Drawing.Point(236, 23);
            this.txtTongcong.Name = "txtTongcong";
            this.txtTongcong.Size = new System.Drawing.Size(149, 21);
            this.txtTongcong.TabIndex = 39;
            this.txtTongcong.Text = "0";
            this.txtTongcong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtThue
            // 
            this.txtThue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtThue.Location = new System.Drawing.Point(236, 49);
            this.txtThue.Name = "txtThue";
            this.txtThue.Size = new System.Drawing.Size(149, 20);
            this.txtThue.TabIndex = 38;
            this.txtThue.Text = "0";
            this.txtThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtThue.TextChanged += new System.EventHandler(this.txtThue_TextChanged);
            this.txtThue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThue_KeyPress);
            // 
            // dgvPhieunhapchitiet
            // 
            this.dgvPhieunhapchitiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhieunhapchitiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieunhapchitiet.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhieunhapchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieunhapchitiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mathuoc,
            this.Donvi,
            this.Soluong,
            this.Gianhap,
            this.Thanhtien});
            this.dgvPhieunhapchitiet.Location = new System.Drawing.Point(12, 293);
            this.dgvPhieunhapchitiet.Name = "dgvPhieunhapchitiet";
            this.dgvPhieunhapchitiet.Size = new System.Drawing.Size(980, 215);
            this.dgvPhieunhapchitiet.TabIndex = 48;
            this.dgvPhieunhapchitiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieunhaphang_CellContentClick);
            this.dgvPhieunhapchitiet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPhieunhapchitiet_MouseClick);
            // 
            // Mathuoc
            // 
            this.Mathuoc.DataPropertyName = "Mathuoc";
            this.Mathuoc.HeaderText = "Mã thuốc";
            this.Mathuoc.Name = "Mathuoc";
            // 
            // Donvi
            // 
            this.Donvi.DataPropertyName = "Donvi";
            this.Donvi.HeaderText = "Đơn vị ";
            this.Donvi.Name = "Donvi";
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.Name = "Soluong";
            // 
            // Gianhap
            // 
            this.Gianhap.DataPropertyName = "Gianhap";
            this.Gianhap.HeaderText = "Giá nhập";
            this.Gianhap.Name = "Gianhap";
            // 
            // Thanhtien
            // 
            this.Thanhtien.DataPropertyName = "Thanhtien";
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.Name = "Thanhtien";
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
            this.btnGhinhan.Location = new System.Drawing.Point(321, 134);
            this.btnGhinhan.Name = "btnGhinhan";
            this.btnGhinhan.Size = new System.Drawing.Size(97, 37);
            this.btnGhinhan.TabIndex = 51;
            this.btnGhinhan.Text = "Ghi nhận";
            this.btnGhinhan.UseVisualStyleBackColor = true;
            this.btnGhinhan.Click += new System.EventHandler(this.btnGhinhan_Click);
            // 
            // lblDonvi
            // 
            this.lblDonvi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDonvi.AutoSize = true;
            this.lblDonvi.Location = new System.Drawing.Point(676, 132);
            this.lblDonvi.Name = "lblDonvi";
            this.lblDonvi.Size = new System.Drawing.Size(41, 13);
            this.lblDonvi.TabIndex = 8;
            this.lblDonvi.Text = "Đơn vị ";
            // 
            // txtDonvi
            // 
            this.txtDonvi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDonvi.Location = new System.Drawing.Point(766, 129);
            this.txtDonvi.Name = "txtDonvi";
            this.txtDonvi.Size = new System.Drawing.Size(156, 20);
            this.txtDonvi.TabIndex = 24;
            // 
            // lblTenthuoc
            // 
            this.lblTenthuoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTenthuoc.AutoSize = true;
            this.lblTenthuoc.Location = new System.Drawing.Point(676, 106);
            this.lblTenthuoc.Name = "lblTenthuoc";
            this.lblTenthuoc.Size = new System.Drawing.Size(56, 13);
            this.lblTenthuoc.TabIndex = 10;
            this.lblTenthuoc.Text = "Tên thuốc";
            // 
            // txtTenthuoc
            // 
            this.txtTenthuoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTenthuoc.Location = new System.Drawing.Point(766, 103);
            this.txtTenthuoc.Name = "txtTenthuoc";
            this.txtTenthuoc.Size = new System.Drawing.Size(156, 20);
            this.txtTenthuoc.TabIndex = 19;
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.BackColor = System.Drawing.Color.Transparent;
            this.lblNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCC.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNCC.Location = new System.Drawing.Point(425, 103);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(134, 16);
            this.lblNCC.TabIndex = 53;
            this.lblNCC.Text = "Tên Nhà cung cấp";
            this.lblNCC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSelectSupplier
            // 
            this.btnSelectSupplier.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectSupplier.BackgroundImage = global::medical_management.Properties.Resources.plus_circle_outline;
            this.btnSelectSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSupplier.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSelectSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectSupplier.Location = new System.Drawing.Point(554, 92);
            this.btnSelectSupplier.Name = "btnSelectSupplier";
            this.btnSelectSupplier.Size = new System.Drawing.Size(39, 38);
            this.btnSelectSupplier.TabIndex = 54;
            this.btnSelectSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSelectSupplier.UseVisualStyleBackColor = false;
            this.btnSelectSupplier.Click += new System.EventHandler(this.btnSelectSupplier_Click);
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
            this.panel1.Controls.Add(this.txtChietkhau);
            this.panel1.Location = new System.Drawing.Point(519, 514);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 185);
            this.panel1.TabIndex = 56;
            // 
            // btnSelectMedical
            // 
            this.btnSelectMedical.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectMedical.BackgroundImage = global::medical_management.Properties.Resources.plus_circle_outline;
            this.btnSelectMedical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectMedical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectMedical.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSelectMedical.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectMedical.Location = new System.Drawing.Point(865, 62);
            this.btnSelectMedical.Name = "btnSelectMedical";
            this.btnSelectMedical.Size = new System.Drawing.Size(39, 38);
            this.btnSelectMedical.TabIndex = 57;
            this.btnSelectMedical.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSelectMedical.UseVisualStyleBackColor = false;
            this.btnSelectMedical.Click += new System.EventHandler(this.btnSelectMedical_Click);
            // 
            // dtpNgaynhap
            // 
            this.dtpNgaynhap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaynhap.Location = new System.Drawing.Point(126, 102);
            this.dtpNgaynhap.Name = "dtpNgaynhap";
            this.dtpNgaynhap.Size = new System.Drawing.Size(156, 20);
            this.dtpNgaynhap.TabIndex = 58;
            // 
            // txtMalo
            // 
            this.txtMalo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMalo.Location = new System.Drawing.Point(418, 69);
            this.txtMalo.Name = "txtMalo";
            this.txtMalo.Size = new System.Drawing.Size(156, 20);
            this.txtMalo.TabIndex = 60;
            // 
            // lblMalo
            // 
            this.lblMalo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMalo.AutoSize = true;
            this.lblMalo.Location = new System.Drawing.Point(329, 72);
            this.lblMalo.Name = "lblMalo";
            this.lblMalo.Size = new System.Drawing.Size(33, 13);
            this.lblMalo.TabIndex = 59;
            this.lblMalo.Text = "Mã lô";
            // 
            // dtpNgayhethan
            // 
            this.dtpNgayhethan.CustomFormat = "dd/MM/yyy";
            this.dtpNgayhethan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayhethan.Location = new System.Drawing.Point(766, 235);
            this.dtpNgayhethan.Name = "dtpNgayhethan";
            this.dtpNgayhethan.Size = new System.Drawing.Size(156, 20);
            this.dtpNgayhethan.TabIndex = 61;
            // 
            // dtpNgaysanxuat
            // 
            this.dtpNgaysanxuat.CustomFormat = "dd/MM/yyy";
            this.dtpNgaysanxuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaysanxuat.Location = new System.Drawing.Point(766, 209);
            this.dtpNgaysanxuat.Name = "dtpNgaysanxuat";
            this.dtpNgaysanxuat.Size = new System.Drawing.Size(156, 20);
            this.dtpNgaysanxuat.TabIndex = 63;
            // 
            // lblNgaysanxuat
            // 
            this.lblNgaysanxuat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNgaysanxuat.AutoSize = true;
            this.lblNgaysanxuat.Location = new System.Drawing.Point(676, 212);
            this.lblNgaysanxuat.Name = "lblNgaysanxuat";
            this.lblNgaysanxuat.Size = new System.Drawing.Size(75, 13);
            this.lblNgaysanxuat.TabIndex = 62;
            this.lblNgaysanxuat.Text = "Ngày sản xuất";
            // 
            // cmnuPODetail
            // 
            this.cmnuPODetail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.editItem,
            this.toolStripSeparator2,
            this.deleteItem});
            this.cmnuPODetail.Name = "cmnuPODetail";
            this.cmnuPODetail.Size = new System.Drawing.Size(95, 60);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(91, 6);
            // 
            // editItem
            // 
            this.editItem.Image = global::medical_management.Properties.Resources.ic_edit;
            this.editItem.Name = "editItem";
            this.editItem.Size = new System.Drawing.Size(94, 22);
            this.editItem.Text = "Sửa";
            this.editItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(91, 6);
            // 
            // deleteItem
            // 
            this.deleteItem.Image = global::medical_management.Properties.Resources.ic_close;
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(94, 22);
            this.deleteItem.Text = "Xóa";
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // frmPhieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::medical_management.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1021, 713);
            this.Controls.Add(this.dtpNgaysanxuat);
            this.Controls.Add(this.lblNgaysanxuat);
            this.Controls.Add(this.dtpNgayhethan);
            this.Controls.Add(this.txtMalo);
            this.Controls.Add(this.lblMalo);
            this.Controls.Add(this.dtpNgaynhap);
            this.Controls.Add(this.btnSelectMedical);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSelectSupplier);
            this.Controls.Add(this.lblNCC);
            this.Controls.Add(this.lblChitietphieunhap);
            this.Controls.Add(this.dgvPhieunhapchitiet);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDonvi);
            this.Controls.Add(this.txtGianhap);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtMathuoc);
            this.Controls.Add(this.txtTenthuoc);
            this.Controls.Add(this.txtNhanviennhap);
            this.Controls.Add(this.txtManhap);
            this.Controls.Add(this.lblGianhap);
            this.Controls.Add(this.lblSoluong);
            this.Controls.Add(this.lblMathuoc);
            this.Controls.Add(this.lblTenthuoc);
            this.Controls.Add(this.lblNgayhethan);
            this.Controls.Add(this.lblDonvi);
            this.Controls.Add(this.lblManhap);
            this.Controls.Add(this.lblNgaynhap);
            this.Controls.Add(this.lblNhanviennhap);
            this.Controls.Add(this.lblMaNCC);
            this.Controls.Add(this.lblThongtinchung);
            this.Controls.Add(this.lblPhieunhap);
            this.Name = "frmPhieunhap";
            this.Text = "frmPhieunhaphang";
            this.Load += new System.EventHandler(this.frmPhieunhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieunhapchitiet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmnuPODetail.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblNgayhethan;
        private System.Windows.Forms.Label lblMathuoc;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblGianhap;
        private System.Windows.Forms.TextBox txtManhap;
        private System.Windows.Forms.TextBox txtNhanviennhap;
        private System.Windows.Forms.TextBox txtMathuoc;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtGianhap;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTongcong;
        private System.Windows.Forms.Label lblTongtienthanhtoan;
        private System.Windows.Forms.Label lblChietkhau;
        private System.Windows.Forms.Label lblThue;
        private System.Windows.Forms.TextBox txtChietkhau;
        private System.Windows.Forms.TextBox txtTongtienthanhtoan;
        private System.Windows.Forms.TextBox txtTongcong;
        private System.Windows.Forms.TextBox txtThue;
        private System.Windows.Forms.DataGridView dgvPhieunhapchitiet;
        private System.Windows.Forms.Label lblChitietphieunhap;
        private System.Windows.Forms.Button btnGhinhan;
        private System.Windows.Forms.Label lblDonvi;
        private System.Windows.Forms.TextBox txtDonvi;
        private System.Windows.Forms.Label lblTenthuoc;
        private System.Windows.Forms.TextBox txtTenthuoc;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.Button btnSelectSupplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelectMedical;
        private System.Windows.Forms.DateTimePicker dtpNgaynhap;
        private System.Windows.Forms.TextBox txtMalo;
        private System.Windows.Forms.Label lblMalo;
        private System.Windows.Forms.DateTimePicker dtpNgayhethan;
        private System.Windows.Forms.DateTimePicker dtpNgaysanxuat;
        private System.Windows.Forms.Label lblNgaysanxuat;
        private System.Windows.Forms.ContextMenuStrip cmnuPODetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deleteItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
    }
}