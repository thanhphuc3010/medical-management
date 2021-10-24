
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDMHD = new System.Windows.Forms.Label();
            this.dgvDSHD = new System.Windows.Forms.DataGridView();
            this.dgvHoadonchitiet = new System.Windows.Forms.DataGridView();
            this.Mathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInvoiceSummary = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReceivable = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.isChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Trangthaihoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInvoiceCount = new System.Windows.Forms.Label();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conthieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.NgayHD,
            this.Tongtien,
            this.Conthieu,
            this.Trangthai,
            this.TenKH,
            this.Sdt,
            this.TenNV});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSHD.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDSHD.Location = new System.Drawing.Point(284, 69);
            this.dgvDSHD.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDSHD.RowHeadersVisible = false;
            this.dgvDSHD.RowHeadersWidth = 51;
            this.dgvDSHD.RowTemplate.Height = 28;
            this.dgvDSHD.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSHD.Size = new System.Drawing.Size(1010, 296);
            this.dgvDSHD.TabIndex = 4;
            this.dgvDSHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHD_CellClick);
            // 
            // dgvHoadonchitiet
            // 
            this.dgvHoadonchitiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoadonchitiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoadonchitiet.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoadonchitiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHoadonchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadonchitiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mathuoc,
            this.Tenthuoc,
            this.Donvi,
            this.Dongia,
            this.Soluong,
            this.Thanhtien});
            this.dgvHoadonchitiet.Location = new System.Drawing.Point(284, 373);
            this.dgvHoadonchitiet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvHoadonchitiet.Name = "dgvHoadonchitiet";
            this.dgvHoadonchitiet.RowHeadersWidth = 51;
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
            // 
            // Tenthuoc
            // 
            this.Tenthuoc.DataPropertyName = "Tenthuoc";
            this.Tenthuoc.FillWeight = 248.0518F;
            this.Tenthuoc.HeaderText = "Tên thuốc";
            this.Tenthuoc.MinimumWidth = 6;
            this.Tenthuoc.Name = "Tenthuoc";
            // 
            // Donvi
            // 
            this.Donvi.DataPropertyName = "Donvi";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Donvi.DefaultCellStyle = dataGridViewCellStyle9;
            this.Donvi.FillWeight = 48.12834F;
            this.Donvi.HeaderText = "ĐVT";
            this.Donvi.MinimumWidth = 10;
            this.Donvi.Name = "Donvi";
            this.Donvi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Dongia
            // 
            this.Dongia.DataPropertyName = "Dongia";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.Dongia.DefaultCellStyle = dataGridViewCellStyle10;
            this.Dongia.FillWeight = 66.82219F;
            this.Dongia.HeaderText = "Đơn giá";
            this.Dongia.MinimumWidth = 6;
            this.Dongia.Name = "Dongia";
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.Soluong.DefaultCellStyle = dataGridViewCellStyle11;
            this.Soluong.FillWeight = 66.43012F;
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            // 
            // Thanhtien
            // 
            this.Thanhtien.DataPropertyName = "Thanhtien";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.Thanhtien.DefaultCellStyle = dataGridViewCellStyle12;
            this.Thanhtien.FillWeight = 99.32957F;
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.MinimumWidth = 6;
            this.Thanhtien.Name = "Thanhtien";
            // 
            // dgvInvoiceSummary
            // 
            this.dgvInvoiceSummary.AllowUserToAddRows = false;
            this.dgvInvoiceSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceSummary.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
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
            this.lblReceivable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReceivable.AutoSize = true;
            this.lblReceivable.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivable.Location = new System.Drawing.Point(151, 137);
            this.lblReceivable.Name = "lblReceivable";
            this.lblReceivable.Size = new System.Drawing.Size(60, 18);
            this.lblReceivable.TabIndex = 54;
            this.lblReceivable.Text = "500.000";
            this.lblReceivable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayment.Location = new System.Drawing.Point(139, 107);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(72, 18);
            this.lblTotalPayment.TabIndex = 55;
            this.lblTotalPayment.Text = "1.500.000";
            this.lblTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(139, 77);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 18);
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
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "N0";
            dataGridViewCellStyle14.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn5.FillWeight = 144.3871F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
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
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaHD.DataPropertyName = "MaHD";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.MaHD.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.Tongtien.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.Conthieu.DefaultCellStyle = dataGridViewCellStyle4;
            this.Conthieu.HeaderText = "Còn thiếu";
            this.Conthieu.MinimumWidth = 6;
            this.Conthieu.Name = "Conthieu";
            this.Conthieu.ReadOnly = true;
            this.Conthieu.Width = 101;
            // 
            // Trangthai
            // 
            this.Trangthai.DataPropertyName = "Trangthaihoadon";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.Trangthai.DefaultCellStyle = dataGridViewCellStyle5;
            this.Trangthai.HeaderText = "Trạng thái";
            this.Trangthai.MinimumWidth = 6;
            this.Trangthai.Name = "Trangthai";
            this.Trangthai.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên Khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "Điện thoại";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Người bán";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
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