
namespace medical_management
{
    partial class frmBatch
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
            this.lblLothuoc.Location = new System.Drawing.Point(430, 47);
            this.lblLothuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLothuoc.Name = "lblLothuoc";
            this.lblLothuoc.Size = new System.Drawing.Size(206, 29);
            this.lblLothuoc.TabIndex = 0;
            this.lblLothuoc.Text = "Danh sách Lô thuốc";
            // 
            // dgvLothuoc
            // 
            this.dgvLothuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLothuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLothuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvLothuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLothuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Malo,
            this.Mathuoc,
            this.Soluong,
            this.Gianhap,
            this.Ngaysanxuat,
            this.Ngayhethan});
            this.dgvLothuoc.Location = new System.Drawing.Point(16, 112);
            this.dgvLothuoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLothuoc.Name = "dgvLothuoc";
            this.dgvLothuoc.RowHeadersWidth = 51;
            this.dgvLothuoc.Size = new System.Drawing.Size(1035, 405);
            this.dgvLothuoc.TabIndex = 1;
            this.dgvLothuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLothuoc_CellContentClick);
            // 
            // Malo
            // 
            this.Malo.DataPropertyName = "Malo";
            this.Malo.HeaderText = "Mã lô";
            this.Malo.MinimumWidth = 6;
            this.Malo.Name = "Malo";
            // 
            // Mathuoc
            // 
            this.Mathuoc.DataPropertyName = "Mathuoc";
            this.Mathuoc.HeaderText = "Mã thuốc";
            this.Mathuoc.MinimumWidth = 6;
            this.Mathuoc.Name = "Mathuoc";
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
            // frmLothuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvLothuoc);
            this.Controls.Add(this.lblLothuoc);
            this.Margin = new System.Windows.Forms.Padding(4);
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