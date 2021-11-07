
namespace medical_management
{
    partial class frmDSHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDMHD = new System.Windows.Forms.Label();
            this.dgvDSHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conthieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoadonchitiet = new System.Windows.Forms.DataGridView();
            this.Mathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInvoiceSummary = new System.Windows.Forms.DataGridView();
            this.isChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Trangthaihoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReceivable = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.lblInvoiceCount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadonchitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceSummary)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDMHD
            // 
            this.lblDMHD.AutoSize = true;
            this.lblDMHD.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMHD.Location = new System.Drawing.Point(18, 9);
            this.lblDMHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDMHD.Name = "lblDMHD";
            this.lblDMHD.Size = new System.Drawing.Size(228, 33);
            this.lblDMHD.TabIndex = 0;
            this.lblDMHD.Text = "Danh sách hóa đơn";
            // 
            // dgvDSHD
            // 
            this.dgvDSHD.AllowUserToAddRows = false;
            this.dgvDSHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHD.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvDSHD.ColumnHeadersHeight = 30;
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.NgayHD,
            this.Tongtien,
            this.Conthieu,
            this.Trangthai,
            this.TenKH,
            this.Sdt,
            this.TenNV});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSHD.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgvDSHD.Location = new System.Drawing.Point(284, 69);
            this.dgvDSHD.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.ReadOnly = true;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvDSHD.RowHeadersVisible = false;
            this.dgvDSHD.RowHeadersWidth = 51;
            this.dgvDSHD.RowTemplate.Height = 28;
            this.dgvDSHD.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSHD.Size = new System.Drawing.Size(1010, 296);
            this.dgvDSHD.TabIndex = 4;
            this.dgvDSHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHD_CellClick);
            this.dgvDSHD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHD_CellDoubleClick);
            this.dgvDSHD.Sorted += new System.EventHandler(this.dgvDSHD_Sorted);
            // 
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaHD.DataPropertyName = "MaHD";
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.MaHD.DefaultCellStyle = dataGridViewCellStyle20;
            this.MaHD.HeaderText = "Số hóa đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            this.MaHD.Width = 114;
            // 
            // NgayHD
            // 
            this.NgayHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NgayHD.DataPropertyName = "NgayHD";
            this.NgayHD.HeaderText = "Ngày hóa đơn";
            this.NgayHD.MinimumWidth = 6;
            this.NgayHD.Name = "NgayHD";
            this.NgayHD.ReadOnly = true;
            this.NgayHD.Width = 130;
            // 
            // Tongtien
            // 
            this.Tongtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tongtien.DataPropertyName = "Tongtien";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.Format = "N0";
            dataGridViewCellStyle21.NullValue = null;
            dataGridViewCellStyle21.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.Tongtien.DefaultCellStyle = dataGridViewCellStyle21;
            this.Tongtien.HeaderText = "Tổng tiền";
            this.Tongtien.MinimumWidth = 6;
            this.Tongtien.Name = "Tongtien";
            this.Tongtien.ReadOnly = true;
            this.Tongtien.Width = 99;
            // 
            // Conthieu
            // 
            this.Conthieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Conthieu.DataPropertyName = "Conthieu";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N0";
            dataGridViewCellStyle22.NullValue = null;
            dataGridViewCellStyle22.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.Conthieu.DefaultCellStyle = dataGridViewCellStyle22;
            this.Conthieu.HeaderText = "Còn thiếu";
            this.Conthieu.MinimumWidth = 6;
            this.Conthieu.Name = "Conthieu";
            this.Conthieu.ReadOnly = true;
            this.Conthieu.Width = 101;
            // 
            // Trangthai
            // 
            this.Trangthai.DataPropertyName = "Trangthaihoadon";
            dataGridViewCellStyle23.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.Trangthai.DefaultCellStyle = dataGridViewCellStyle23;
            this.Trangthai.HeaderText = "Trạng thái";
            this.Trangthai.MinimumWidth = 6;
            this.Trangthai.Name = "Trangthai";
            this.Trangthai.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            dataGridViewCellStyle24.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.TenKH.DefaultCellStyle = dataGridViewCellStyle24;
            this.TenKH.HeaderText = "Tên Khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            dataGridViewCellStyle25.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.Sdt.DefaultCellStyle = dataGridViewCellStyle25;
            this.Sdt.HeaderText = "Điện thoại";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            dataGridViewCellStyle26.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.TenNV.DefaultCellStyle = dataGridViewCellStyle26;
            this.TenNV.HeaderText = "Người bán";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // dgvHoadonchitiet
            // 
            this.dgvHoadonchitiet.AllowUserToAddRows = false;
            this.dgvHoadonchitiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoadonchitiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoadonchitiet.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoadonchitiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvHoadonchitiet.ColumnHeadersHeight = 30;
            this.dgvHoadonchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHoadonchitiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mathuoc,
            this.Tenthuoc,
            this.Donvi,
            this.Dongia,
            this.Soluong,
            this.Thanhtien});
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoadonchitiet.DefaultCellStyle = dataGridViewCellStyle34;
            this.dgvHoadonchitiet.Location = new System.Drawing.Point(284, 373);
            this.dgvHoadonchitiet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvHoadonchitiet.Name = "dgvHoadonchitiet";
            this.dgvHoadonchitiet.ReadOnly = true;
            this.dgvHoadonchitiet.RowHeadersWidth = 51;
            this.dgvHoadonchitiet.RowTemplate.Height = 28;
            this.dgvHoadonchitiet.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoadonchitiet.Size = new System.Drawing.Size(1010, 338);
            this.dgvHoadonchitiet.TabIndex = 3;
            // 
            // Mathuoc
            // 
            this.Mathuoc.DataPropertyName = "Mathuoc";
            this.Mathuoc.FillWeight = 71.23801F;
            this.Mathuoc.HeaderText = "Mã thuốc";
            this.Mathuoc.MinimumWidth = 6;
            this.Mathuoc.Name = "Mathuoc";
            this.Mathuoc.ReadOnly = true;
            // 
            // Tenthuoc
            // 
            this.Tenthuoc.DataPropertyName = "Tenthuoc";
            this.Tenthuoc.FillWeight = 248.0518F;
            this.Tenthuoc.HeaderText = "Tên thuốc";
            this.Tenthuoc.MinimumWidth = 6;
            this.Tenthuoc.Name = "Tenthuoc";
            this.Tenthuoc.ReadOnly = true;
            // 
            // Donvi
            // 
            this.Donvi.DataPropertyName = "Donvi";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Donvi.DefaultCellStyle = dataGridViewCellStyle30;
            this.Donvi.FillWeight = 48.12834F;
            this.Donvi.HeaderText = "ĐVT";
            this.Donvi.MinimumWidth = 10;
            this.Donvi.Name = "Donvi";
            this.Donvi.ReadOnly = true;
            this.Donvi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Dongia
            // 
            this.Dongia.DataPropertyName = "Dongia";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle31.Format = "N2";
            dataGridViewCellStyle31.NullValue = null;
            this.Dongia.DefaultCellStyle = dataGridViewCellStyle31;
            this.Dongia.FillWeight = 66.82219F;
            this.Dongia.HeaderText = "Đơn giá";
            this.Dongia.MinimumWidth = 6;
            this.Dongia.Name = "Dongia";
            this.Dongia.ReadOnly = true;
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.Format = "N2";
            dataGridViewCellStyle32.NullValue = null;
            this.Soluong.DefaultCellStyle = dataGridViewCellStyle32;
            this.Soluong.FillWeight = 66.43012F;
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            this.Soluong.ReadOnly = true;
            // 
            // Thanhtien
            // 
            this.Thanhtien.DataPropertyName = "Thanhtien";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle33.Format = "N2";
            dataGridViewCellStyle33.NullValue = null;
            this.Thanhtien.DefaultCellStyle = dataGridViewCellStyle33;
            this.Thanhtien.FillWeight = 99.32957F;
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.MinimumWidth = 6;
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.ReadOnly = true;
            // 
            // dgvInvoiceSummary
            // 
            this.dgvInvoiceSummary.AllowUserToAddRows = false;
            this.dgvInvoiceSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceSummary.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvInvoiceSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isChecked,
            this.Trangthaihoadon,
            this.dataGridViewTextBoxColumn5});
            this.dgvInvoiceSummary.Location = new System.Drawing.Point(8, 69);
            this.dgvInvoiceSummary.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvInvoiceSummary.Name = "dgvInvoiceSummary";
            this.dgvInvoiceSummary.RowHeadersVisible = false;
            this.dgvInvoiceSummary.RowHeadersWidth = 51;
            this.dgvInvoiceSummary.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoiceSummary.Size = new System.Drawing.Size(262, 254);
            this.dgvInvoiceSummary.TabIndex = 2;
            this.dgvInvoiceSummary.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInvoiceSummary_CellMouseUp);
            this.dgvInvoiceSummary.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceSummary_CellValueChanged);
            // 
            // isChecked
            // 
            this.isChecked.FillWeight = 81.70993F;
            this.isChecked.HeaderText = "";
            this.isChecked.MinimumWidth = 6;
            this.isChecked.Name = "isChecked";
            this.isChecked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isChecked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Trangthaihoadon
            // 
            this.Trangthaihoadon.DataPropertyName = "Trangthaihoadon";
            this.Trangthaihoadon.FillWeight = 159.6229F;
            this.Trangthaihoadon.HeaderText = "Trạng thái";
            this.Trangthaihoadon.MinimumWidth = 6;
            this.Trangthaihoadon.Name = "Trangthaihoadon";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Soluong";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.Format = "N0";
            dataGridViewCellStyle36.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle36;
            this.dataGridViewTextBoxColumn5.FillWeight = 144.3871F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblReceivable);
            this.panel1.Controls.Add(this.lblTotalPayment);
            this.panel1.Controls.Add(this.lblInvoiceCount);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.dtpToDate);
            this.panel1.Controls.Add(this.dtpFromDate);
            this.panel1.Location = new System.Drawing.Point(8, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 179);
            this.panel1.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(13, 137);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(76, 18);
            this.label.TabIndex = 52;
            this.label.Text = "Còn thiếu:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "Đã trả:";
            // 
            // lblReceivable
            // 
            this.lblReceivable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReceivable.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivable.Location = new System.Drawing.Point(93, 137);
            this.lblReceivable.Name = "lblReceivable";
            this.lblReceivable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReceivable.Size = new System.Drawing.Size(145, 18);
            this.lblReceivable.TabIndex = 54;
            this.lblReceivable.Text = "500.000";
            this.lblReceivable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalPayment.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayment.Location = new System.Drawing.Point(93, 107);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalPayment.Size = new System.Drawing.Size(145, 18);
            this.lblTotalPayment.TabIndex = 55;
            this.lblTotalPayment.Text = "1.500.000";
            this.lblTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInvoiceCount
            // 
            this.lblInvoiceCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvoiceCount.AutoSize = true;
            this.lblInvoiceCount.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceCount.ForeColor = System.Drawing.Color.Navy;
            this.lblInvoiceCount.Location = new System.Drawing.Point(221, 41);
            this.lblInvoiceCount.Name = "lblInvoiceCount";
            this.lblInvoiceCount.Size = new System.Drawing.Size(29, 20);
            this.lblInvoiceCount.TabIndex = 56;
            this.lblInvoiceCount.Text = "20";
            this.lblInvoiceCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(93, 77);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotal.Size = new System.Drawing.Size(145, 18);
            this.lblTotal.TabIndex = 56;
            this.lblTotal.Text = "2.500.000";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 57;
            this.label2.Text = "Tổng tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "Số hóa đơn: ";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(225, 1);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(30, 23);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "button1";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(121, 1);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(87, 22);
            this.dtpToDate.TabIndex = 48;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(8, 1);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(87, 22);
            this.dtpFromDate.TabIndex = 3;
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.BackColor = System.Drawing.Color.Transparent;
            this.btnAddInvoice.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInvoice.Image = global::medical_management.Properties.Resources.plus_circle_outline;
            this.btnAddInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddInvoice.Location = new System.Drawing.Point(284, 12);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(118, 43);
            this.btnAddInvoice.TabIndex = 1;
            this.btnAddInvoice.Text = "Thêm mới";
            this.btnAddInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddInvoice.UseVisualStyleBackColor = false;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // frmDSHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 724);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvInvoiceSummary);
            this.Controls.Add(this.dgvHoadonchitiet);
            this.Controls.Add(this.dgvDSHD);
            this.Controls.Add(this.lblDMHD);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDSHD";
            this.Text = "frmDMHD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDSHD_Load);
            this.Shown += new System.EventHandler(this.frmDSHD_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadonchitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceSummary)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDMHD;
        private System.Windows.Forms.DataGridView dgvDSHD;
        private System.Windows.Forms.DataGridView dgvHoadonchitiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.DataGridView dgvInvoiceSummary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReceivable;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthaihoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label lblInvoiceCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conthieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
    }
}