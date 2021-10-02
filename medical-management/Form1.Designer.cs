namespace medical_management
{
    partial class Form1
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
            this.dgvMedical = new System.Windows.Forms.DataGridView();
            this.btnDemo = new System.Windows.Forms.Button();
            this.lblDemo = new System.Windows.Forms.Label();
            this.txtDemo = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedical)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedical
            // 
            this.dgvMedical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedical.Location = new System.Drawing.Point(49, 161);
            this.dgvMedical.Name = "dgvMedical";
            this.dgvMedical.RowHeadersWidth = 51;
            this.dgvMedical.RowTemplate.Height = 24;
            this.dgvMedical.Size = new System.Drawing.Size(957, 319);
            this.dgvMedical.TabIndex = 0;
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(494, 69);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(75, 23);
            this.btnDemo.TabIndex = 1;
            this.btnDemo.Text = "button1";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // lblDemo
            // 
            this.lblDemo.AutoSize = true;
            this.lblDemo.Location = new System.Drawing.Point(356, 89);
            this.lblDemo.Name = "lblDemo";
            this.lblDemo.Size = new System.Drawing.Size(46, 17);
            this.lblDemo.TabIndex = 2;
            this.lblDemo.Text = "label1";
            // 
            // txtDemo
            // 
            this.txtDemo.Location = new System.Drawing.Point(648, 89);
            this.txtDemo.Name = "txtDemo";
            this.txtDemo.Size = new System.Drawing.Size(336, 22);
            this.txtDemo.TabIndex = 3;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Control;
            this.btnShow.Location = new System.Drawing.Point(494, 119);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtDemo);
            this.Controls.Add(this.lblDemo);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.dgvMedical);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedical;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.Label lblDemo;
        private System.Windows.Forms.TextBox txtDemo;
        private System.Windows.Forms.Button btnShow;
    }
}

