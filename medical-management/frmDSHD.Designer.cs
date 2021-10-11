
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
            this.lblDMHD = new System.Windows.Forms.Label();
            this.dgvDMHD = new System.Windows.Forms.DataGridView();
            this.Sohoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngayhoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conthieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMHD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDMHD
            // 
            this.lblDMHD.AutoSize = true;
            this.lblDMHD.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMHD.Location = new System.Drawing.Point(305, 26);
            this.lblDMHD.Name = "lblDMHD";
            this.lblDMHD.Size = new System.Drawing.Size(179, 26);
            this.lblDMHD.TabIndex = 0;
            this.lblDMHD.Text = "Danh mục Hóa đơn";
            this.lblDMHD.Click += new System.EventHandler(this.lblDMHD_Click);
            // 
            // dgvDMHD
            // 
            this.dgvDMHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDMHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDMHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDMHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sohoadon,
            this.Ngayhoadon,
            this.Tongtien,
            this.Conthieu,
            this.Trangthai,
            this.TenKH,
            this.Dienthoai,
            this.Tennhanvien});
            this.dgvDMHD.Location = new System.Drawing.Point(12, 88);
            this.dgvDMHD.Name = "dgvDMHD";
            this.dgvDMHD.Size = new System.Drawing.Size(776, 321);
            this.dgvDMHD.TabIndex = 1;
            // 
            // Sohoadon
            // 
            this.Sohoadon.DataPropertyName = "Sohoadon";
            this.Sohoadon.HeaderText = "Số hóa đơn";
            this.Sohoadon.Name = "Sohoadon";
            // 
            // Ngayhoadon
            // 
            this.Ngayhoadon.DataPropertyName = "Ngayhoadon";
            this.Ngayhoadon.HeaderText = "Ngày hóa đơn";
            this.Ngayhoadon.Name = "Ngayhoadon";
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
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên Khách hàng";
            this.TenKH.Name = "TenKH";
            // 
            // Dienthoai
            // 
            this.Dienthoai.DataPropertyName = "Dienthoai";
            this.Dienthoai.HeaderText = "Điện thoại";
            this.Dienthoai.Name = "Dienthoai";
            // 
            // Tennhanvien
            // 
            this.Tennhanvien.DataPropertyName = "Tennhanvien";
            this.Tennhanvien.HeaderText = "Tên nhân viên";
            this.Tennhanvien.Name = "Tennhanvien";
            // 
            // frmDMHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDMHD);
            this.Controls.Add(this.lblDMHD);
            this.Name = "frmDMHD";
            this.Text = "frmDMHD";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDMHD;
        private System.Windows.Forms.DataGridView dgvDMHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sohoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngayhoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conthieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tennhanvien;
    }
}