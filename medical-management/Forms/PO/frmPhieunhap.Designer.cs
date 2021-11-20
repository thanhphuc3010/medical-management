
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieunhap));
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
            this.lblTongtienthanhtoan = new System.Windows.Forms.Label();
            this.txtTongtienthanhtoan = new System.Windows.Forms.TextBox();
            this.dgvPhieunhapchitiet = new System.Windows.Forms.DataGridView();
            this.Mathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Malothuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cmnuPODetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPhieunhap
            // 
            this.lblPhieunhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhieunhap.AutoSize = true;
            this.lblPhieunhap.BackColor = System.Drawing.Color.Transparent;
            this.lblPhieunhap.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieunhap.Location = new System.Drawing.Point(413, 9);
            this.lblPhieunhap.Name = "lblPhieunhap";
            this.lblPhieunhap.Size = new System.Drawing.Size(205, 29);
            this.lblPhieunhap.TabIndex = 0;
            this.lblPhieunhap.Text = "PHIẾU NHẬP HÀNG";
            // 
            // lblThongtinchung
            // 
            this.lblThongtinchung.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblThongtinchung.AutoSize = true;
            this.lblThongtinchung.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblThongtinchung.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtinchung.Location = new System.Drawing.Point(8, 39);
            this.lblThongtinchung.Name = "lblThongtinchung";
            this.lblThongtinchung.Size = new System.Drawing.Size(120, 19);
            this.lblThongtinchung.TabIndex = 1;
            this.lblThongtinchung.Text = "Thông tin chung";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.BackColor = System.Drawing.Color.Transparent;
            this.lblMaNCC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNCC.Location = new System.Drawing.Point(330, 102);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(98, 15);
            this.lblMaNCC.TabIndex = 4;
            this.lblMaNCC.Text = "Mã Nhà cung cấp";
            // 
            // lblNhanviennhap
            // 
            this.lblNhanviennhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNhanviennhap.AutoSize = true;
            this.lblNhanviennhap.BackColor = System.Drawing.Color.Transparent;
            this.lblNhanviennhap.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanviennhap.Location = new System.Drawing.Point(39, 128);
            this.lblNhanviennhap.Name = "lblNhanviennhap";
            this.lblNhanviennhap.Size = new System.Drawing.Size(92, 15);
            this.lblNhanviennhap.TabIndex = 5;
            this.lblNhanviennhap.Text = "Nhân viên nhập";
            // 
            // lblNgaynhap
            // 
            this.lblNgaynhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNgaynhap.AutoSize = true;
            this.lblNgaynhap.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaynhap.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaynhap.Location = new System.Drawing.Point(39, 104);
            this.lblNgaynhap.Name = "lblNgaynhap";
            this.lblNgaynhap.Size = new System.Drawing.Size(64, 15);
            this.lblNgaynhap.TabIndex = 6;
            this.lblNgaynhap.Text = "Ngày nhập";
            // 
            // lblManhap
            // 
            this.lblManhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblManhap.AutoSize = true;
            this.lblManhap.BackColor = System.Drawing.Color.Transparent;
            this.lblManhap.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManhap.Location = new System.Drawing.Point(39, 77);
            this.lblManhap.Name = "lblManhap";
            this.lblManhap.Size = new System.Drawing.Size(54, 15);
            this.lblManhap.TabIndex = 7;
            this.lblManhap.Text = "Mã nhập";
            // 
            // lblNgayhethan
            // 
            this.lblNgayhethan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNgayhethan.AutoSize = true;
            this.lblNgayhethan.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayhethan.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayhethan.Location = new System.Drawing.Point(676, 239);
            this.lblNgayhethan.Name = "lblNgayhethan";
            this.lblNgayhethan.Size = new System.Drawing.Size(79, 15);
            this.lblNgayhethan.TabIndex = 9;
            this.lblNgayhethan.Text = "Ngày hết hạn";
            // 
            // lblMathuoc
            // 
            this.lblMathuoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMathuoc.AutoSize = true;
            this.lblMathuoc.BackColor = System.Drawing.Color.Transparent;
            this.lblMathuoc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMathuoc.Location = new System.Drawing.Point(676, 81);
            this.lblMathuoc.Name = "lblMathuoc";
            this.lblMathuoc.Size = new System.Drawing.Size(58, 15);
            this.lblMathuoc.TabIndex = 11;
            this.lblMathuoc.Text = "Mã thuốc";
            // 
            // lblSoluong
            // 
            this.lblSoluong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoluong.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluong.Location = new System.Drawing.Point(676, 185);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(58, 15);
            this.lblSoluong.TabIndex = 13;
            this.lblSoluong.Text = "Số lượng ";
            // 
            // lblGianhap
            // 
            this.lblGianhap.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGianhap.AutoSize = true;
            this.lblGianhap.BackColor = System.Drawing.Color.Transparent;
            this.lblGianhap.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGianhap.Location = new System.Drawing.Point(676, 159);
            this.lblGianhap.Name = "lblGianhap";
            this.lblGianhap.Size = new System.Drawing.Size(54, 15);
            this.lblGianhap.TabIndex = 14;
            this.lblGianhap.Text = "Giá nhập";
            // 
            // txtManhap
            // 
            this.txtManhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtManhap.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtManhap.Location = new System.Drawing.Point(133, 74);
            this.txtManhap.Name = "txtManhap";
            this.txtManhap.Size = new System.Drawing.Size(156, 20);
            this.txtManhap.TabIndex = 15;
            // 
            // txtNhanviennhap
            // 
            this.txtNhanviennhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNhanviennhap.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNhanviennhap.Location = new System.Drawing.Point(133, 126);
            this.txtNhanviennhap.Name = "txtNhanviennhap";
            this.txtNhanviennhap.Size = new System.Drawing.Size(156, 20);
            this.txtNhanviennhap.TabIndex = 17;
            // 
            // txtMathuoc
            // 
            this.txtMathuoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMathuoc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMathuoc.Location = new System.Drawing.Point(766, 78);
            this.txtMathuoc.Name = "txtMathuoc";
            this.txtMathuoc.Size = new System.Drawing.Size(125, 20);
            this.txtMathuoc.TabIndex = 20;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSoluong.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSoluong.Location = new System.Drawing.Point(766, 182);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(156, 20);
            this.txtSoluong.TabIndex = 22;
            this.txtSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoluong_KeyPress);
            // 
            // txtGianhap
            // 
            this.txtGianhap.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtGianhap.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtGianhap.Location = new System.Drawing.Point(766, 156);
            this.txtGianhap.Name = "txtGianhap";
            this.txtGianhap.Size = new System.Drawing.Size(156, 20);
            this.txtGianhap.TabIndex = 23;
            this.txtGianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGianhap_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Navy;
            this.btnAdd.Image = global::medical_management.Properties.Resources.ic_cart;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(932, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Navy;
            this.btnCancel.Image = global::medical_management.Properties.Resources.ic_close;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(932, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 30);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Navy;
            this.btnUpdate.Image = global::medical_management.Properties.Resources.ic_edit;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(932, 145);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 29);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblTongtienthanhtoan
            // 
            this.lblTongtienthanhtoan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTongtienthanhtoan.AutoSize = true;
            this.lblTongtienthanhtoan.BackColor = System.Drawing.Color.Transparent;
            this.lblTongtienthanhtoan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongtienthanhtoan.ForeColor = System.Drawing.Color.Red;
            this.lblTongtienthanhtoan.Location = new System.Drawing.Point(650, 456);
            this.lblTongtienthanhtoan.Name = "lblTongtienthanhtoan";
            this.lblTongtienthanhtoan.Size = new System.Drawing.Size(153, 19);
            this.lblTongtienthanhtoan.TabIndex = 33;
            this.lblTongtienthanhtoan.Text = "Tổng tiền thanh toán";
            // 
            // txtTongtienthanhtoan
            // 
            this.txtTongtienthanhtoan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTongtienthanhtoan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTongtienthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongtienthanhtoan.ForeColor = System.Drawing.Color.Red;
            this.txtTongtienthanhtoan.Location = new System.Drawing.Point(821, 456);
            this.txtTongtienthanhtoan.Name = "txtTongtienthanhtoan";
            this.txtTongtienthanhtoan.Size = new System.Drawing.Size(149, 21);
            this.txtTongtienthanhtoan.TabIndex = 42;
            this.txtTongtienthanhtoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.Malothuoc,
            this.Donvi,
            this.Soluong,
            this.Gianhap,
            this.Thanhtien,
            this.Ngaysanxuat,
            this.Ngayhethan});
            this.dgvPhieunhapchitiet.Location = new System.Drawing.Point(12, 270);
            this.dgvPhieunhapchitiet.Name = "dgvPhieunhapchitiet";
            this.dgvPhieunhapchitiet.RowHeadersWidth = 51;
            this.dgvPhieunhapchitiet.Size = new System.Drawing.Size(980, 170);
            this.dgvPhieunhapchitiet.TabIndex = 48;
            this.dgvPhieunhapchitiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieunhapchitiet_CellContentClick);
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
            // Malothuoc
            // 
            this.Malothuoc.DataPropertyName = "Malo";
            this.Malothuoc.HeaderText = "Mã lô";
            this.Malothuoc.Name = "Malothuoc";
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
            this.lblChitietphieunhap.Location = new System.Drawing.Point(12, 238);
            this.lblChitietphieunhap.Name = "lblChitietphieunhap";
            this.lblChitietphieunhap.Size = new System.Drawing.Size(139, 19);
            this.lblChitietphieunhap.TabIndex = 49;
            this.lblChitietphieunhap.Text = "Chi tiết phiếu nhập";
            // 
            // btnGhinhan
            // 
            this.btnGhinhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGhinhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGhinhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhinhan.ForeColor = System.Drawing.Color.Navy;
            this.btnGhinhan.Location = new System.Drawing.Point(873, 511);
            this.btnGhinhan.Name = "btnGhinhan";
            this.btnGhinhan.Size = new System.Drawing.Size(97, 37);
            this.btnGhinhan.TabIndex = 51;
            this.btnGhinhan.Text = "Ghi nhận";
            this.btnGhinhan.UseVisualStyleBackColor = false;
            this.btnGhinhan.Click += new System.EventHandler(this.btnGhinhan_Click);
            // 
            // lblDonvi
            // 
            this.lblDonvi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDonvi.AutoSize = true;
            this.lblDonvi.BackColor = System.Drawing.Color.Transparent;
            this.lblDonvi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonvi.Location = new System.Drawing.Point(676, 133);
            this.lblDonvi.Name = "lblDonvi";
            this.lblDonvi.Size = new System.Drawing.Size(45, 15);
            this.lblDonvi.TabIndex = 8;
            this.lblDonvi.Text = "Đơn vị ";
            // 
            // txtDonvi
            // 
            this.txtDonvi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDonvi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDonvi.Location = new System.Drawing.Point(766, 130);
            this.txtDonvi.Name = "txtDonvi";
            this.txtDonvi.Size = new System.Drawing.Size(156, 20);
            this.txtDonvi.TabIndex = 24;
            // 
            // lblTenthuoc
            // 
            this.lblTenthuoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTenthuoc.AutoSize = true;
            this.lblTenthuoc.BackColor = System.Drawing.Color.Transparent;
            this.lblTenthuoc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenthuoc.Location = new System.Drawing.Point(676, 107);
            this.lblTenthuoc.Name = "lblTenthuoc";
            this.lblTenthuoc.Size = new System.Drawing.Size(60, 15);
            this.lblTenthuoc.TabIndex = 10;
            this.lblTenthuoc.Text = "Tên thuốc";
            // 
            // txtTenthuoc
            // 
            this.txtTenthuoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTenthuoc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTenthuoc.Location = new System.Drawing.Point(766, 104);
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
            this.dtpNgaynhap.CalendarMonthBackground = System.Drawing.SystemColors.ButtonFace;
            this.dtpNgaynhap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaynhap.Location = new System.Drawing.Point(133, 102);
            this.dtpNgaynhap.Name = "dtpNgaynhap";
            this.dtpNgaynhap.Size = new System.Drawing.Size(156, 20);
            this.dtpNgaynhap.TabIndex = 58;
            // 
            // txtMalo
            // 
            this.txtMalo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMalo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMalo.Location = new System.Drawing.Point(418, 70);
            this.txtMalo.Name = "txtMalo";
            this.txtMalo.Size = new System.Drawing.Size(156, 20);
            this.txtMalo.TabIndex = 60;
            // 
            // lblMalo
            // 
            this.lblMalo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMalo.AutoSize = true;
            this.lblMalo.BackColor = System.Drawing.Color.Transparent;
            this.lblMalo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMalo.Location = new System.Drawing.Point(329, 73);
            this.lblMalo.Name = "lblMalo";
            this.lblMalo.Size = new System.Drawing.Size(37, 15);
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
            this.lblNgaysanxuat.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaysanxuat.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaysanxuat.Location = new System.Drawing.Point(676, 213);
            this.lblNgaysanxuat.Name = "lblNgaysanxuat";
            this.lblNgaysanxuat.Size = new System.Drawing.Size(82, 15);
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
            this.cmnuPODetail.Size = new System.Drawing.Size(99, 68);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(95, 6);
            // 
            // editItem
            // 
            this.editItem.Image = global::medical_management.Properties.Resources.ic_edit;
            this.editItem.Name = "editItem";
            this.editItem.Size = new System.Drawing.Size(98, 26);
            this.editItem.Text = "Sửa";
            this.editItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(95, 6);
            // 
            // deleteItem
            // 
            this.deleteItem.Image = global::medical_management.Properties.Resources.ic_close;
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(98, 26);
            this.deleteItem.Text = "Xóa";
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // frmPhieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::medical_management.Properties.Resources._635203f6dfa214fc4db3;
            this.ClientSize = new System.Drawing.Size(1021, 610);
            this.Controls.Add(this.btnGhinhan);
            this.Controls.Add(this.lblTongtienthanhtoan);
            this.Controls.Add(this.dtpNgaysanxuat);
            this.Controls.Add(this.txtTongtienthanhtoan);
            this.Controls.Add(this.lblNgaysanxuat);
            this.Controls.Add(this.dtpNgayhethan);
            this.Controls.Add(this.txtMalo);
            this.Controls.Add(this.lblMalo);
            this.Controls.Add(this.dtpNgaynhap);
            this.Controls.Add(this.btnSelectMedical);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhieunhap";
            this.Text = "Phiếu nhập hàng";
            this.Load += new System.EventHandler(this.frmPhieunhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieunhapchitiet)).EndInit();
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
        private System.Windows.Forms.Label lblTongtienthanhtoan;
        private System.Windows.Forms.TextBox txtTongtienthanhtoan;
        private System.Windows.Forms.DataGridView dgvPhieunhapchitiet;
        private System.Windows.Forms.Label lblChitietphieunhap;
        private System.Windows.Forms.Button btnGhinhan;
        private System.Windows.Forms.Label lblDonvi;
        private System.Windows.Forms.TextBox txtDonvi;
        private System.Windows.Forms.Label lblTenthuoc;
        private System.Windows.Forms.TextBox txtTenthuoc;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.Button btnSelectSupplier;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Malothuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysanxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngayhethan;
    }
}