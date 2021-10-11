
namespace medical_management
{
    partial class frmLothuoc
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
            this.lblLothuoc = new System.Windows.Forms.Label();
            this.dgvLothuoc = new System.Windows.Forms.DataGridView();
            this.Malo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysanxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngayhethan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLothuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLothuoc
            // 
            this.lblLothuoc.AutoSize = true;
            this.lblLothuoc.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLothuoc.Location = new System.Drawing.Point(294, 23);
            this.lblLothuoc.Name = "lblLothuoc";
            this.lblLothuoc.Size = new System.Drawing.Size(161, 23);
            this.lblLothuoc.TabIndex = 0;
            this.lblLothuoc.Text = "Danh sách Lô thuốc";
            // 
            // dgvLothuoc
            // 
            this.dgvLothuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLothuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLothuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLothuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Malo,
            this.Mathuoc,
            this.Soluong,
            this.Gianhap,
            this.Ngaysanxuat,
            this.Ngayhethan});
            this.dgvLothuoc.Location = new System.Drawing.Point(12, 91);
            this.dgvLothuoc.Name = "dgvLothuoc";
            this.dgvLothuoc.Size = new System.Drawing.Size(776, 329);
            this.dgvLothuoc.TabIndex = 1;
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
            // Gianhap
            // 
            this.Gianhap.DataPropertyName = "Gianhap";
            this.Gianhap.HeaderText = "Giá nhập";
            this.Gianhap.Name = "Gianhap";
            // 
            // Ngaysanxuat
            // 
            this.Ngaysanxuat.DataPropertyName = "Ngaysanxuat";
            this.Ngaysanxuat.HeaderText = "Ngày sản xuất";
            this.Ngaysanxuat.Name = "Ngaysanxuat";
            // 
            // Ngayhethan
            // 
            this.Ngayhethan.DataPropertyName = "Ngayhethan";
            this.Ngayhethan.HeaderText = "Ngày hết hạn";
            this.Ngayhethan.Name = "Ngayhethan";
            // 
            // frmLothuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::medical_management.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLothuoc);
            this.Controls.Add(this.lblLothuoc);
            this.Name = "frmLothuoc";
            this.Text = "frmLothuoc";
            this.Load += new System.EventHandler(this.frmLothuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLothuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLothuoc;
        private System.Windows.Forms.DataGridView dgvLothuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysanxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngayhethan;
    }
}