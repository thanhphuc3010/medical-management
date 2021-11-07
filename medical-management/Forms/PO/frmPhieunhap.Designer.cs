
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
            this.Ngaysanxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngayhethan = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblPhieunhap.Location = new System.Drawing.Point(580, 11);
            this.lblPhieunhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhieunhap.Name = "lblPhieunhap";
            this.lblPhieunhap.Size = new System.Drawing.Size(172, 24);
            this.lblPhieunhap.TabIndex = 0;
            this.lblPhieunhap.Text = "PHIẾU NHẬP HÀNG";
            // 
            // lblThongtinchung
            // 
            this.lblThongtinchung.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblThongtinchung.AutoSize = true;
            this.lblThongtinchung.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtinchung.Location = new System.Drawing.Point(36, 52);
            this.lblThongtinchung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongtinchung.Name = "lblThongtinchung";
            this.lblThongtinchung.Size = new System.Drawing.Size(145, 24);
            this.lblThongtinchung.TabIndex = 1;
            this.lblThongtinchung.Text = "Thông tin chung";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(440, 126);
            this.lblMaNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(119, 17);
            this.lblMaNCC.TabIndex = 4;
            this.lblMaNCC.Text = "Mã Nhà cung cấp";
            // 
            // lblNhanviennhap
            // 
            this.lblNhanviennhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNhanviennhap.AutoSize = true;
            this.lblNhanviennhap.Location = new System.Drawing.Point(52, 158);
            this.lblNhanviennhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhanviennhap.Name = "lblNhanviennhap";
            this.lblNhanviennhap.Size = new System.Drawing.Size(108, 17);
            this.lblNhanviennhap.TabIndex = 5;
            this.lblNhanviennhap.Text = "Nhân viên nhập";
            // 
            // lblNgaynhap
            // 
            this.lblNgaynhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNgaynhap.AutoSize = true;
            this.lblNgaynhap.Location = new System.Drawing.Point(52, 126);
            this.lblNgaynhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaynhap.Name = "lblNgaynhap";
            this.lblNgaynhap.Size = new System.Drawing.Size(77, 17);
            this.lblNgaynhap.TabIndex = 6;
            this.lblNgaynhap.Text = "Ngày nhập";
            // 
            // lblManhap
            // 
            this.lblManhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblManhap.AutoSize = true;
            this.lblManhap.Location = new System.Drawing.Point(52, 94);
            this.lblManhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManhap.Name = "lblManhap";
            this.lblManhap.Size = new System.Drawing.Size(63, 17);
            this.lblManhap.TabIndex = 7;
            this.lblManhap.Text = "Mã nhập";
            // 
            // lblNgayhethan
            // 
            this.lblNgayhethan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNgayhethan.AutoSize = true;
            this.lblNgayhethan.Location = new System.Drawing.Point(901, 293);
            this.lblNgayhethan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayhethan.Name = "lblNgayhethan";
            this.lblNgayhethan.Size = new System.Drawing.Size(93, 17);
            this.lblNgayhethan.TabIndex = 9;
            this.lblNgayhethan.Text = "Ngày hết hạn";
            // 
            // lblMathuoc
            // 
            this.lblMathuoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMathuoc.AutoSize = true;
            this.lblMathuoc.Location = new System.Drawing.Point(901, 98);
            this.lblMathuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMathuoc.Name = "lblMathuoc";
            this.lblMathuoc.Size = new System.Drawing.Size(66, 17);
            this.lblMathuoc.TabIndex = 11;
            this.lblMathuoc.Text = "Mã thuốc";
            // 
            // lblSoluong
            // 
            this.lblSoluong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(901, 226);
            this.lblSoluong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(68, 17);
            this.lblSoluong.TabIndex = 13;
            this.lblSoluong.Text = "Số lượng ";
            // 
            // lblGianhap
            // 
            this.lblGianhap.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGianhap.AutoSize = true;
            this.lblGianhap.Location = new System.Drawing.Point(901, 194);
            this.lblGianhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGianhap.Name = "lblGianhap";
            this.lblGianhap.Size = new System.Drawing.Size(66, 17);
            this.lblGianhap.TabIndex = 14;
            this.lblGianhap.Text = "Giá nhập";
            // 
            // txtManhap
            // 
            this.txtManhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtManhap.Location = new System.Drawing.Point(168, 90);
            this.txtManhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtManhap.Name = "txtManhap";
            this.txtManhap.Size = new System.Drawing.Size(207, 22);
            this.txtManhap.TabIndex = 15;
            // 
            // txtNhanviennhap
            // 
            this.txtNhanviennhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNhanviennhap.Location = new System.Drawing.Point(171, 154);
            this.txtNhanviennhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhanviennhap.Name = "txtNhanviennhap";
            this.txtNhanviennhap.Size = new System.Drawing.Size(207, 22);
            this.txtNhanviennhap.TabIndex = 17;
            // 
            // txtMathuoc
            // 
            this.txtMathuoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMathuoc.Location = new System.Drawing.Point(1021, 95);
            this.txtMathuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtMathuoc.Name = "txtMathuoc";
            this.txtMathuoc.Size = new System.Drawing.Size(165, 22);
            this.txtMathuoc.TabIndex = 20;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSoluong.Location = new System.Drawing.Point(1021, 223);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(207, 22);
            this.txtSoluong.TabIndex = 22;
            this.txtSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoluong_KeyPress);
            // 
            // txtGianhap
            // 
            this.txtGianhap.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtGianhap.Location = new System.Drawing.Point(1021, 191);
            this.txtGianhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtGianhap.Name = "txtGianhap";
            this.txtGianhap.Size = new System.Drawing.Size(207, 22);
            this.txtGianhap.TabIndex = 23;
            this.txtGianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGianhap_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Image = global::medical_management.Properties.Resources.ic_cart;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(1260, 126);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 37);
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
            this.btnCancel.Location = new System.Drawing.Point(1260, 226);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 37);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(1260, 175);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 36);
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
            this.lblTongcong.Location = new System.Drawing.Point(87, 32);
            this.lblTongcong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongcong.Name = "lblTongcong";
            this.lblTongcong.Size = new System.Drawing.Size(87, 20);
            this.lblTongcong.TabIndex = 32;
            this.lblTongcong.Text = "Tổng cộng";
            // 
            // lblTongtienthanhtoan
            // 
            this.lblTongtienthanhtoan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTongtienthanhtoan.AutoSize = true;
            this.lblTongtienthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongtienthanhtoan.Location = new System.Drawing.Point(87, 124);
            this.lblTongtienthanhtoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongtienthanhtoan.Name = "lblTongtienthanhtoan";
            this.lblTongtienthanhtoan.Size = new System.Drawing.Size(161, 20);
            this.lblTongtienthanhtoan.TabIndex = 33;
            this.lblTongtienthanhtoan.Text = "Tổng tiền thanh toán";
            // 
            // lblChietkhau
            // 
            this.lblChietkhau.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblChietkhau.AutoSize = true;
            this.lblChietkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChietkhau.Location = new System.Drawing.Point(87, 96);
            this.lblChietkhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChietkhau.Name = "lblChietkhau";
            this.lblChietkhau.Size = new System.Drawing.Size(88, 20);
            this.lblChietkhau.TabIndex = 34;
            this.lblChietkhau.Text = "Chiết khấu";
            // 
            // lblThue
            // 
            this.lblThue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblThue.AutoSize = true;
            this.lblThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThue.Location = new System.Drawing.Point(87, 64);
            this.lblThue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThue.Name = "lblThue";
            this.lblThue.Size = new System.Drawing.Size(46, 20);
            this.lblThue.TabIndex = 35;
            this.lblThue.Text = "Thuế";
            // 
            // txtChietkhau
            // 
            this.txtChietkhau.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtChietkhau.Location = new System.Drawing.Point(315, 92);
            this.txtChietkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtChietkhau.Name = "txtChietkhau";
            this.txtChietkhau.Size = new System.Drawing.Size(197, 22);
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
            this.txtTongtienthanhtoan.Location = new System.Drawing.Point(315, 124);
            this.txtTongtienthanhtoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongtienthanhtoan.Name = "txtTongtienthanhtoan";
            this.txtTongtienthanhtoan.Size = new System.Drawing.Size(197, 24);
            this.txtTongtienthanhtoan.TabIndex = 42;
            this.txtTongtienthanhtoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTongcong
            // 
            this.txtTongcong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTongcong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongcong.ForeColor = System.Drawing.Color.DarkRed;
            this.txtTongcong.Location = new System.Drawing.Point(315, 28);
            this.txtTongcong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongcong.Name = "txtTongcong";
            this.txtTongcong.Size = new System.Drawing.Size(197, 24);
            this.txtTongcong.TabIndex = 39;
            this.txtTongcong.Text = "0";
            this.txtTongcong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtThue
            // 
            this.txtThue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtThue.Location = new System.Drawing.Point(315, 60);
            this.txtThue.Margin = new System.Windows.Forms.Padding(4);
            this.txtThue.Name = "txtThue";
            this.txtThue.Size = new System.Drawing.Size(197, 22);
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
            this.Thanhtien,
            this.Ngaysanxuat,
            this.Ngayhethan});
            this.dgvPhieunhapchitiet.Location = new System.Drawing.Point(16, 361);
            this.dgvPhieunhapchitiet.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhieunhapchitiet.Name = "dgvPhieunhapchitiet";
            this.dgvPhieunhapchitiet.RowHeadersWidth = 51;
            this.dgvPhieunhapchitiet.Size = new System.Drawing.Size(1307, 265);
            this.dgvPhieunhapchitiet.TabIndex = 48;
            this.dgvPhieunhapchitiet.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPhieunhapchitiet_CellMouseDown);
            this.dgvPhieunhapchitiet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPhieunhapchitiet_MouseClick);
            // 
            // Mathuoc
            // 
            this.Mathuoc.DataPropertyName = "Mathuoc";
            this.Mathuoc.HeaderText = "Mã thuốc";
            this.Mathuoc.MinimumWidth = 6;
            this.Mathuoc.Name = "Mathuoc";
            // 
            // Donvi
            // 
            this.Donvi.DataPropertyName = "Donvi";
            this.Donvi.HeaderText = "Đơn vị ";
            this.Donvi.MinimumWidth = 6;
            this.Donvi.Name = "Donvi";
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
            this.Gianhap.MinimumWidth = 6;
            this.Gianhap.Name = "Gianhap";
            // 
            // Thanhtien
            // 
            this.Thanhtien.DataPropertyName = "Thanhtien";
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.MinimumWidth = 6;
            this.Thanhtien.Name = "Thanhtien";
            // 
            // Ngaysanxuat
            // 
            this.Ngaysanxuat.DataPropertyName = "Ngaysanxuat";
            this.Ngaysanxuat.HeaderText = "Ngày sản xuất";
            this.Ngaysanxuat.MinimumWidth = 6;
            this.Ngaysanxuat.Name = "Ngaysanxuat";
            // 
            // Ngayhethan
            // 
            this.Ngayhethan.DataPropertyName = "Ngayhethan";
            this.Ngayhethan.HeaderText = "Ngày hết hạn";
            this.Ngayhethan.MinimumWidth = 6;
            this.Ngayhethan.Name = "Ngayhethan";
            // 
            // lblChitietphieunhap
            // 
            this.lblChitietphieunhap.AutoSize = true;
            this.lblChitietphieunhap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChitietphieunhap.Location = new System.Drawing.Point(20, 319);
            this.lblChitietphieunhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChitietphieunhap.Name = "lblChitietphieunhap";
            this.lblChitietphieunhap.Size = new System.Drawing.Size(172, 24);
            this.lblChitietphieunhap.TabIndex = 49;
            this.lblChitietphieunhap.Text = "Chi tiết phiếu nhập";
            // 
            // btnGhinhan
            // 
            this.btnGhinhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGhinhan.Location = new System.Drawing.Point(428, 165);
            this.btnGhinhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnGhinhan.Name = "btnGhinhan";
            this.btnGhinhan.Size = new System.Drawing.Size(129, 46);
            this.btnGhinhan.TabIndex = 51;
            this.btnGhinhan.Text = "Ghi nhận";
            this.btnGhinhan.UseVisualStyleBackColor = true;
            this.btnGhinhan.Click += new System.EventHandler(this.btnGhinhan_Click);
            // 
            // lblDonvi
            // 
            this.lblDonvi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDonvi.AutoSize = true;
            this.lblDonvi.Location = new System.Drawing.Point(901, 162);
            this.lblDonvi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonvi.Name = "lblDonvi";
            this.lblDonvi.Size = new System.Drawing.Size(52, 17);
            this.lblDonvi.TabIndex = 8;
            this.lblDonvi.Text = "Đơn vị ";
            // 
            // txtDonvi
            // 
            this.txtDonvi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDonvi.Location = new System.Drawing.Point(1021, 159);
            this.txtDonvi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonvi.Name = "txtDonvi";
            this.txtDonvi.Size = new System.Drawing.Size(207, 22);
            this.txtDonvi.TabIndex = 24;
            // 
            // lblTenthuoc
            // 
            this.lblTenthuoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTenthuoc.AutoSize = true;
            this.lblTenthuoc.Location = new System.Drawing.Point(901, 130);
            this.lblTenthuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenthuoc.Name = "lblTenthuoc";
            this.lblTenthuoc.Size = new System.Drawing.Size(72, 17);
            this.lblTenthuoc.TabIndex = 10;
            this.lblTenthuoc.Text = "Tên thuốc";
            // 
            // txtTenthuoc
            // 
            this.txtTenthuoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTenthuoc.Location = new System.Drawing.Point(1021, 127);
            this.txtTenthuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenthuoc.Name = "txtTenthuoc";
            this.txtTenthuoc.Size = new System.Drawing.Size(207, 22);
            this.txtTenthuoc.TabIndex = 19;
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.BackColor = System.Drawing.Color.Transparent;
            this.lblNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCC.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNCC.Location = new System.Drawing.Point(567, 127);
            this.lblNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(161, 20);
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
            this.btnSelectSupplier.Location = new System.Drawing.Point(739, 113);
            this.btnSelectSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectSupplier.Name = "btnSelectSupplier";
            this.btnSelectSupplier.Size = new System.Drawing.Size(52, 47);
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
            this.panel1.Location = new System.Drawing.Point(692, 633);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 228);
            this.panel1.TabIndex = 56;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSelectMedical
            // 
            this.btnSelectMedical.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectMedical.BackgroundImage = global::medical_management.Properties.Resources.plus_circle_outline;
            this.btnSelectMedical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectMedical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectMedical.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSelectMedical.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectMedical.Location = new System.Drawing.Point(1153, 76);
            this.btnSelectMedical.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectMedical.Name = "btnSelectMedical";
            this.btnSelectMedical.Size = new System.Drawing.Size(52, 47);
            this.btnSelectMedical.TabIndex = 57;
            this.btnSelectMedical.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSelectMedical.UseVisualStyleBackColor = false;
            this.btnSelectMedical.Click += new System.EventHandler(this.btnSelectMedical_Click);
            // 
            // dtpNgaynhap
            // 
            this.dtpNgaynhap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaynhap.Location = new System.Drawing.Point(168, 126);
            this.dtpNgaynhap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaynhap.Name = "dtpNgaynhap";
            this.dtpNgaynhap.Size = new System.Drawing.Size(207, 22);
            this.dtpNgaynhap.TabIndex = 58;
            // 
            // txtMalo
            // 
            this.txtMalo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMalo.Location = new System.Drawing.Point(557, 85);
            this.txtMalo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMalo.Name = "txtMalo";
            this.txtMalo.Size = new System.Drawing.Size(207, 22);
            this.txtMalo.TabIndex = 60;
            // 
            // lblMalo
            // 
            this.lblMalo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMalo.AutoSize = true;
            this.lblMalo.Location = new System.Drawing.Point(439, 89);
            this.lblMalo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMalo.Name = "lblMalo";
            this.lblMalo.Size = new System.Drawing.Size(42, 17);
            this.lblMalo.TabIndex = 59;
            this.lblMalo.Text = "Mã lô";
            // 
            // dtpNgayhethan
            // 
            this.dtpNgayhethan.CustomFormat = "dd/MM/yyy";
            this.dtpNgayhethan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayhethan.Location = new System.Drawing.Point(1021, 289);
            this.dtpNgayhethan.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayhethan.Name = "dtpNgayhethan";
            this.dtpNgayhethan.Size = new System.Drawing.Size(207, 22);
            this.dtpNgayhethan.TabIndex = 61;
            // 
            // dtpNgaysanxuat
            // 
            this.dtpNgaysanxuat.CustomFormat = "dd/MM/yyy";
            this.dtpNgaysanxuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaysanxuat.Location = new System.Drawing.Point(1021, 257);
            this.dtpNgaysanxuat.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaysanxuat.Name = "dtpNgaysanxuat";
            this.dtpNgaysanxuat.Size = new System.Drawing.Size(207, 22);
            this.dtpNgaysanxuat.TabIndex = 63;
            // 
            // lblNgaysanxuat
            // 
            this.lblNgaysanxuat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNgaysanxuat.AutoSize = true;
            this.lblNgaysanxuat.Location = new System.Drawing.Point(901, 261);
            this.lblNgaysanxuat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaysanxuat.Name = "lblNgaysanxuat";
            this.lblNgaysanxuat.Size = new System.Drawing.Size(98, 17);
            this.lblNgaysanxuat.TabIndex = 62;
            this.lblNgaysanxuat.Text = "Ngày sản xuất";
            // 
            // cmnuPODetail
            // 
            this.cmnuPODetail.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnuPODetail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.editItem,
            this.toolStripSeparator2,
            this.deleteItem});
            this.cmnuPODetail.Name = "cmnuPODetail";
            this.cmnuPODetail.Size = new System.Drawing.Size(109, 68);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(105, 6);
            // 
            // editItem
            // 
            this.editItem.Image = global::medical_management.Properties.Resources.ic_edit;
            this.editItem.Name = "editItem";
            this.editItem.Size = new System.Drawing.Size(108, 26);
            this.editItem.Text = "Sửa";
            this.editItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(105, 6);
            // 
            // deleteItem
            // 
            this.deleteItem.Image = global::medical_management.Properties.Resources.ic_close;
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(108, 26);
            this.deleteItem.Text = "Xóa";
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // frmPhieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::medical_management.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1361, 878);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysanxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngayhethan;
    }
}