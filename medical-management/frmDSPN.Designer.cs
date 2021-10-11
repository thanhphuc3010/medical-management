
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPN)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDMPN
            // 
            this.lblDMPN.AutoSize = true;
            this.lblDMPN.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMPN.Location = new System.Drawing.Point(277, 23);
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
            this.dgvDSPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sophieunhap,
            this.Ngaynhap,
            this.Tongtien,
            this.Conthieu,
            this.Trangthai,
            this.TenNCC,
            this.Dienthoai});
            this.dgvDSPN.Location = new System.Drawing.Point(12, 83);
            this.dgvDSPN.Name = "dgvDSPN";
            this.dgvDSPN.Size = new System.Drawing.Size(776, 355);
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
            // frmDSPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDSPN);
            this.Controls.Add(this.lblDMPN);
            this.Name = "frmDSPN";
            this.Text = "frmDMPN";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPN)).EndInit();
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
    }
}