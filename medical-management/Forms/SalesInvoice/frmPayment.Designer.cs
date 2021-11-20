
namespace medical_management
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.txtPaymentNote = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.btnSavePayment = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(31, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phương thức TT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(31, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nội dung TT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(31, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chưa thanh toán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(31, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số tiền TT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày thanh toán";
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "Tiền mặt",
            "Thẻ"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(168, 98);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(137, 23);
            this.cbPaymentMethod.TabIndex = 2;
            // 
            // txtPaymentNote
            // 
            this.txtPaymentNote.Location = new System.Drawing.Point(168, 140);
            this.txtPaymentNote.Name = "txtPaymentNote";
            this.txtPaymentNote.Size = new System.Drawing.Size(551, 21);
            this.txtPaymentNote.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblTotal.Location = new System.Drawing.Point(168, 179);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(19, 20);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "0";
            this.lblTotal.DoubleClick += new System.EventHandler(this.lblTotal_DoubleClick);
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(168, 216);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(233, 21);
            this.txtPayment.TabIndex = 1;
            this.txtPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayment_KeyPress);
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.CustomFormat = "dd/MM/yyyy";
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaymentDate.Location = new System.Drawing.Point(519, 178);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(200, 21);
            this.dtpPaymentDate.TabIndex = 3;
            // 
            // btnSavePayment
            // 
            this.btnSavePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSavePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSavePayment.Location = new System.Drawing.Point(519, 285);
            this.btnSavePayment.Name = "btnSavePayment";
            this.btnSavePayment.Size = new System.Drawing.Size(90, 35);
            this.btnSavePayment.TabIndex = 4;
            this.btnSavePayment.Text = "Ghi nhận";
            this.btnSavePayment.UseVisualStyleBackColor = false;
            this.btnSavePayment.Click += new System.EventHandler(this.btnSavePayment_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.ForeColor = System.Drawing.Color.Red;
            this.btnCancle.Location = new System.Drawing.Point(629, 285);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(90, 35);
            this.btnCancle.TabIndex = 4;
            this.btnCancle.Text = "Hủy";
            this.btnCancle.UseVisualStyleBackColor = false;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCustomer.Location = new System.Drawing.Point(168, 60);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(109, 15);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Tên khách hàng";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::medical_management.Properties.Resources._97cea7e15201dc807d266908c4d911b1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 342);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSavePayment);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.cbPaymentMethod);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.txtPaymentNote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.TextBox txtPaymentNote;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Button btnSavePayment;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label lblCustomer;
    }
}