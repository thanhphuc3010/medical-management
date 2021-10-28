
namespace medical_management
{
    partial class frmDSPN
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
            this.lblDMPN = new System.Windows.Forms.Label();
            this.dgvDSPN = new System.Windows.Forms.DataGridView();
            this.Sophieunhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conthieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvPNCT = new System.Windows.Forms.DataGridView();
            this.Malo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblConthieu = new System.Windows.Forms.Label();
            this.lblDatra = new System.Windows.Forms.Label();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.lblInvoiceCount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.lblLoan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPNCT)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDMPN
            // 
            this.lblDMPN.AutoSize = true;
            this.lblDMPN.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMPN.Location = new System.Drawing.Point(23, 9);
            this.lblDMPN.Name = "lblDMPN";
            this.lblDMPN.Size = new System.Drawing.Size(202, 26);
            this.lblDMPN.TabIndex = 0;
            this.lblDMPN.Text = "Danh sách Phiếu nhập";
            // 
            // dgvDSPN
            // 
            this.dgvDSPN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSPN.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sophieunhap,
            this.Ngaynhap,
            this.Tongtien,
            this.Conthieu,
            this.Trangthai,
            this.TenNCC,
            this.Dienthoai});
            this.dgvDSPN.Location = new System.Drawing.Point(253, 57);
            this.dgvDSPN.Name = "dgvDSPN";
            this.dgvDSPN.Size = new System.Drawing.Size(674, 252);
            this.dgvDSPN.TabIndex = 1;
            // 
            // Sophieunhap
            // 
            this.Sophieunhap.DataPropertyName = "Sophieunhap";
            this.Sophieunhap.HeaderText = "Số Phiếu nhập";
            this.Sophieunhap.Name = "Sophieunhap";
            // 
            // Ngaynhap
            // 
            this.Ngaynhap.DataPropertyName = "Ngaynhap";
            this.Ngaynhap.HeaderText = "Ngày nhập";
            this.Ngaynhap.Name = "Ngaynhap";
            // 
            // Tongtien
            // 
            this.Tongtien.DataPropertyName = "Tongtien";
            this.Tongtien.HeaderText = "Tổng tiền";
            this.Tongtien.Name = "Tongtien";
            // 
            // Conthieu
            // 
            this.Conthieu.DataPropertyName = "Conthieu";
            this.Conthieu.HeaderText = "Còn thiếu";
            this.Conthieu.Name = "Conthieu";
            // 
            // Trangthai
            // 
            this.Trangthai.DataPropertyName = "Trangthai";
            this.Trangthai.HeaderText = "Trạng thái";
            this.Trangthai.Name = "Trangthai";
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên nhà cung cấp";
            this.TenNCC.Name = "TenNCC";
            // 
            // Dienthoai
            // 
            this.Dienthoai.DataPropertyName = "Dienthoai";
            this.Dienthoai.HeaderText = "Điện thoại";
            this.Dienthoai.Name = "Dienthoai";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::medical_management.Properties.Resources.plus_circle_outline;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(253, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // dgvPNCT
            // 
            this.dgvPNCT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPNCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPNCT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPNCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPNCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Malo,
            this.Mathuoc,
            this.Soluong,
            this.Donvitinh,
            this.Dongia,
            this.Thanhtien});
            this.dgvPNCT.Location = new System.Drawing.Point(253, 315);
            this.dgvPNCT.Name = "dgvPNCT";
            this.dgvPNCT.Size = new System.Drawing.Size(674, 186);
            this.dgvPNCT.TabIndex = 3;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLoan);
            this.panel1.Controls.Add(this.lblTotalPayment);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblInvoiceCount);
            this.panel1.Controls.Add(this.lblTongtien);
            this.panel1.Controls.Add(this.lblDatra);
            this.panel1.Controls.Add(this.lblConthieu);
            this.panel1.Controls.Add(this.lblCount);
            this.panel1.Controls.Add(this.dtpToDate);
            this.panel1.Controls.Add(this.dtpFromDate);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 195);
            this.panel1.TabIndex = 4;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(5, 14);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(78, 20);
            this.dtpFromDate.TabIndex = 5;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(123, 14);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(78, 20);
            this.dtpToDate.TabIndex = 6;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(3, 56);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(76, 13);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "Số phiếu nhập";
            // 
            // lblConthieu
            // 
            this.lblConthieu.AutoSize = true;
            this.lblConthieu.Location = new System.Drawing.Point(7, 163);
            this.lblConthieu.Name = "lblConthieu";
            this.lblConthieu.Size = new System.Drawing.Size(52, 13);
            this.lblConthieu.TabIndex = 7;
            this.lblConthieu.Text = "Còn thiếu";
            // 
            // lblDatra
            // 
            this.lblDatra.AutoSize = true;
            this.lblDatra.Location = new System.Drawing.Point(7, 134);
            this.lblDatra.Name = "lblDatra";
            this.lblDatra.Size = new System.Drawing.Size(42, 13);
            this.lblDatra.TabIndex = 8;
            this.lblDatra.Text = "Đã trả :";
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Location = new System.Drawing.Point(7, 108);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(58, 13);
            this.lblTongtien.TabIndex = 9;
            this.lblTongtien.Text = "Tổng tiền :";
            // 
            // lblInvoiceCount
            // 
            this.lblInvoiceCount.AutoSize = true;
            this.lblInvoiceCount.Location = new System.Drawing.Point(146, 56);
            this.lblInvoiceCount.Name = "lblInvoiceCount";
            this.lblInvoiceCount.Size = new System.Drawing.Size(10, 13);
            this.lblInvoiceCount.TabIndex = 10;
            this.lblInvoiceCount.Text = ".";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(146, 98);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(10, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = ".";
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Location = new System.Drawing.Point(146, 134);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(10, 13);
            this.lblTotalPayment.TabIndex = 12;
            this.lblTotalPayment.Text = ".";
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Location = new System.Drawing.Point(146, 163);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(10, 13);
            this.lblLoan.TabIndex = 13;
            this.lblLoan.Text = ".";
            // 
            // frmDSPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPNCT);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvDSPN);
            this.Controls.Add(this.lblDMPN);
            this.Name = "frmDSPN";
            this.Text = "frmDMPN";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPNCT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDMPN;
        private System.Windows.Forms.DataGridView dgvDSPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sophieunhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conthieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dienthoai;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvPNCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.Label lblDatra;
        private System.Windows.Forms.Label lblConthieu;
        private System.Windows.Forms.Label lblInvoiceCount;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblLoan;
    }
}