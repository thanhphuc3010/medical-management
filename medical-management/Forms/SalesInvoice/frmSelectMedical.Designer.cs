
namespace medical_management
{
    partial class frmSelectMedical
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Mathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hamluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donggoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhphan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysanxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hansudung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.Mathuoc,
            this.MaNSX,
            this.Tenthuoc,
            this.Donvi,
            this.Hamluong,
            this.Soluong,
            this.Donggoi,
            this.Thanhphan,
            this.Dongia,
            this.Gianhap,
            this.Ngaysanxuat,
            this.Hansudung,
            this.Ghichu});
            this.dgvThuoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThuoc.Location = new System.Drawing.Point(0, 64);
            this.dgvThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.RowHeadersVisible = false;
            this.dgvThuoc.RowHeadersWidth = 20;
            this.dgvThuoc.RowTemplate.Height = 30;
            this.dgvThuoc.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThuoc.Size = new System.Drawing.Size(800, 386);
            this.dgvThuoc.TabIndex = 11;
            this.dgvThuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellContentClick);
            this.dgvThuoc.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachhang_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tìm kiếm:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 22);
            this.textBox1.TabIndex = 30;
            // 
            // Selected
            // 
            this.Selected.FillWeight = 37.43316F;
            this.Selected.HeaderText = "";
            this.Selected.MinimumWidth = 6;
            this.Selected.Name = "Selected";
            // 
            // Mathuoc
            // 
            this.Mathuoc.DataPropertyName = "Mathuoc";
            this.Mathuoc.FillWeight = 110.4278F;
            this.Mathuoc.HeaderText = "Mã thuốc";
            this.Mathuoc.MinimumWidth = 6;
            this.Mathuoc.Name = "Mathuoc";
            // 
            // MaNSX
            // 
            this.MaNSX.DataPropertyName = "MaNSX";
            this.MaNSX.FillWeight = 110.4278F;
            this.MaNSX.HeaderText = "Mã Nhà sản xuất";
            this.MaNSX.MinimumWidth = 6;
            this.MaNSX.Name = "MaNSX";
            // 
            // Tenthuoc
            // 
            this.Tenthuoc.DataPropertyName = "Tenthuoc";
            this.Tenthuoc.FillWeight = 110.4278F;
            this.Tenthuoc.HeaderText = "Tên thuốc";
            this.Tenthuoc.MinimumWidth = 6;
            this.Tenthuoc.Name = "Tenthuoc";
            // 
            // Donvi
            // 
            this.Donvi.DataPropertyName = "Donvi";
            this.Donvi.FillWeight = 110.4278F;
            this.Donvi.HeaderText = "Đơn vị";
            this.Donvi.MinimumWidth = 6;
            this.Donvi.Name = "Donvi";
            // 
            // Hamluong
            // 
            this.Hamluong.DataPropertyName = "Hamluong";
            this.Hamluong.HeaderText = "Hàm Lượng";
            this.Hamluong.MinimumWidth = 6;
            this.Hamluong.Name = "Hamluong";
            this.Hamluong.Visible = false;
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Soluong.DefaultCellStyle = dataGridViewCellStyle1;
            this.Soluong.FillWeight = 110.4278F;
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            // 
            // Donggoi
            // 
            this.Donggoi.DataPropertyName = "Donggoi";
            this.Donggoi.HeaderText = "Đóng gói";
            this.Donggoi.MinimumWidth = 6;
            this.Donggoi.Name = "Donggoi";
            this.Donggoi.Visible = false;
            // 
            // Thanhphan
            // 
            this.Thanhphan.DataPropertyName = "Thanhphan";
            this.Thanhphan.HeaderText = "Thành phần";
            this.Thanhphan.MinimumWidth = 6;
            this.Thanhphan.Name = "Thanhphan";
            this.Thanhphan.Visible = false;
            // 
            // Dongia
            // 
            this.Dongia.DataPropertyName = "Dongia";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Dongia.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dongia.FillWeight = 110.4278F;
            this.Dongia.HeaderText = "Đơn giá";
            this.Dongia.MinimumWidth = 6;
            this.Dongia.Name = "Dongia";
            // 
            // Gianhap
            // 
            this.Gianhap.DataPropertyName = "Gianhap";
            this.Gianhap.HeaderText = "Giá nhập";
            this.Gianhap.MinimumWidth = 6;
            this.Gianhap.Name = "Gianhap";
            this.Gianhap.Visible = false;
            // 
            // Ngaysanxuat
            // 
            this.Ngaysanxuat.DataPropertyName = "Ngaysanxuat";
            this.Ngaysanxuat.HeaderText = "Ngày sản xuất";
            this.Ngaysanxuat.MinimumWidth = 6;
            this.Ngaysanxuat.Name = "Ngaysanxuat";
            this.Ngaysanxuat.Visible = false;
            // 
            // Hansudung
            // 
            this.Hansudung.DataPropertyName = "Hansudung";
            this.Hansudung.HeaderText = "Hạn sử dụng";
            this.Hansudung.MinimumWidth = 6;
            this.Hansudung.Name = "Hansudung";
            this.Hansudung.Visible = false;
            // 
            // Ghichu
            // 
            this.Ghichu.DataPropertyName = "Ghichu";
            this.Ghichu.HeaderText = "Ghi chú";
            this.Ghichu.MinimumWidth = 6;
            this.Ghichu.Name = "Ghichu";
            this.Ghichu.Visible = false;
            // 
            // frmSelectMedical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvThuoc);
            this.Name = "frmSelectMedical";
            this.Text = "frmSelectMedical";
            this.Load += new System.EventHandler(this.frmSelectMedical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hamluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donggoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhphan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysanxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hansudung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
    }
}