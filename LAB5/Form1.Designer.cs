namespace LAB5_TRUONGTHIBAONHI_65132499
{
    partial class ĐăngNhập
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
            this.txtTenTN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btnĐăngNhập = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTenTN
            // 
            this.txtTenTN.Location = new System.Drawing.Point(441, 234);
            this.txtTenTN.Multiline = true;
            this.txtTenTN.Name = "txtTenTN";
            this.txtTenTN.Size = new System.Drawing.Size(419, 64);
            this.txtTenTN.TabIndex = 0;
            this.txtTenTN.TextChanged += new System.EventHandler(this.txtTenTN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(432, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng nhập hệ thống";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(135, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên truy cập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(135, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(441, 337);
            this.txtMK.Multiline = true;
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(419, 64);
            this.txtMK.TabIndex = 4;
            this.txtMK.TextChanged += new System.EventHandler(this.txtMK_TextChanged);
            // 
            // btnĐăngNhập
            // 
            this.btnĐăngNhập.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnĐăngNhập.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnĐăngNhập.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnĐăngNhập.Location = new System.Drawing.Point(515, 462);
            this.btnĐăngNhập.Name = "btnĐăngNhập";
            this.btnĐăngNhập.Size = new System.Drawing.Size(289, 64);
            this.btnĐăngNhập.TabIndex = 5;
            this.btnĐăngNhập.Text = "Đăng nhập";
            this.btnĐăngNhập.UseVisualStyleBackColor = false;
            this.btnĐăngNhập.Click += new System.EventHandler(this.btn_Click);
            // 
            // ĐăngNhập
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 712);
            this.Controls.Add(this.btnĐăngNhập);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenTN);
            this.Name = "ĐăngNhập";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btnĐăngNhập;
    }
}

