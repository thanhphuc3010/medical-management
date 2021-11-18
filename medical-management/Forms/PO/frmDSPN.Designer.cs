
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
            this.Manhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluonglo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvPNCT = new System.Windows.Forms.DataGridView();
            this.Malo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPNCT)).BeginInit();
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
            this.dgvDSPN.AllowUserToAddRows = false;
            this.dgvDSPN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSPN.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDSPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Manhap,
            this.Ngaynhap,
            this.MaNV,
            this.MaNCC,
            this.Soluonglo,
            this.Tongtien});
            this.dgvDSPN.Location = new System.Drawing.Point(12, 57);
            this.dgvDSPN.Name = "dgvDSPN";
            this.dgvDSPN.ReadOnly = true;
            this.dgvDSPN.RowHeadersVisible = false;
            this.dgvDSPN.RowHeadersWidth = 51;
            this.dgvDSPN.Size = new System.Drawing.Size(915, 272);
            this.dgvDSPN.TabIndex = 1;
            this.dgvDSPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPN_CellClick);
            this.dgvDSPN.Sorted += new System.EventHandler(this.dgvDSPN_Sorted);
            // 
            // Manhap
            // 
            this.Manhap.DataPropertyName = "Manhap";
            this.Manhap.HeaderText = "Mã phiếu nhập";
            this.Manhap.Name = "Manhap";
            // 
            // Ngaynhap
            // 
            this.Ngaynhap.DataPropertyName = "Ngaynhap";
            this.Ngaynhap.HeaderText = "Ngày nhập";
            this.Ngaynhap.Name = "Ngaynhap";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân viên";
            this.MaNV.Name = "MaNV";
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.Name = "MaNCC";
            // 
            // Soluonglo
            // 
            this.Soluonglo.DataPropertyName = "Soluonglo";
            this.Soluonglo.HeaderText = "Số lượng lô";
            this.Soluonglo.Name = "Soluonglo";
            // 
            // Tongtien
            // 
            this.Tongtien.DataPropertyName = "Tongtien";
            this.Tongtien.HeaderText = "Tổng tiền";
            this.Tongtien.Name = "Tongtien";
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.Donvi,
            this.Gianhap,
            this.Thanhtien});
            this.dgvPNCT.Location = new System.Drawing.Point(12, 348);
            this.dgvPNCT.Name = "dgvPNCT";
            this.dgvPNCT.Size = new System.Drawing.Size(915, 141);
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
            // Donvi
            // 
            this.Donvi.DataPropertyName = "Donvi";
            this.Donvi.HeaderText = "Đơn vị";
            this.Donvi.Name = "Donvi";
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
            // frmDSPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 513);
            this.Controls.Add(this.dgvPNCT);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvDSPN);
            this.Controls.Add(this.lblDMPN);
            this.Name = "frmDSPN";
            this.Text = "frmDMPN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDSPN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPNCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDMPN;
        private System.Windows.Forms.DataGridView dgvDSPN;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvPNCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluonglo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongtien;
    }
}