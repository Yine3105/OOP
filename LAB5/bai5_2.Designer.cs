namespace LAB5_TRUONGTHIBAONHI_65132499
{
    partial class bai5_2
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
            this.txtsoA = new System.Windows.Forms.TextBox();
            this.txtsoB = new System.Windows.Forms.TextBox();
            this.txtsoC = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbPTB2 = new System.Windows.Forms.RadioButton();
            this.rdbPTB1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ThucHien = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtsoA
            // 
            this.txtsoA.Location = new System.Drawing.Point(786, 188);
            this.txtsoA.Name = "txtsoA";
            this.txtsoA.Size = new System.Drawing.Size(272, 31);
            this.txtsoA.TabIndex = 0;
            // 
            // txtsoB
            // 
            this.txtsoB.Location = new System.Drawing.Point(786, 276);
            this.txtsoB.Name = "txtsoB";
            this.txtsoB.Size = new System.Drawing.Size(272, 31);
            this.txtsoB.TabIndex = 1;
            // 
            // txtsoC
            // 
            this.txtsoC.Location = new System.Drawing.Point(786, 367);
            this.txtsoC.Name = "txtsoC";
            this.txtsoC.Size = new System.Drawing.Size(272, 31);
            this.txtsoC.TabIndex = 2;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(334, 522);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(723, 31);
            this.txtKetQua.TabIndex = 3;
            this.txtKetQua.TextChanged += new System.EventHandler(this.txtKetQua_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPTB2);
            this.groupBox1.Controls.Add(this.rdbPTB1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(126, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 210);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Phương Trình";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbPTB2
            // 
            this.rdbPTB2.AutoSize = true;
            this.rdbPTB2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rdbPTB2.Location = new System.Drawing.Point(32, 135);
            this.rdbPTB2.Name = "rdbPTB2";
            this.rdbPTB2.Size = new System.Drawing.Size(333, 46);
            this.rdbPTB2.TabIndex = 3;
            this.rdbPTB2.TabStop = true;
            this.rdbPTB2.Text = "ax^2 + bx + c = 0";
            this.rdbPTB2.UseVisualStyleBackColor = true;
            this.rdbPTB2.CheckedChanged += new System.EventHandler(this.rdbPTB2_CheckedChanged);
            // 
            // rdbPTB1
            // 
            this.rdbPTB1.AutoSize = true;
            this.rdbPTB1.ForeColor = System.Drawing.Color.Olive;
            this.rdbPTB1.Location = new System.Drawing.Point(32, 60);
            this.rdbPTB1.Name = "rdbPTB1";
            this.rdbPTB1.Size = new System.Drawing.Size(215, 46);
            this.rdbPTB1.TabIndex = 2;
            this.rdbPTB1.TabStop = true;
            this.rdbPTB1.Text = "ax + b = 0";
            this.rdbPTB1.UseVisualStyleBackColor = true;
            this.rdbPTB1.CheckedChanged += new System.EventHandler(this.rdbPTB1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(593, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hệ số a";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(593, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hệ số b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(595, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hệ số c";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(119, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kết quả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(492, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(406, 55);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giải phương trình";
            // 
            // btn_ThucHien
            // 
            this.btn_ThucHien.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_ThucHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThucHien.Location = new System.Drawing.Point(334, 617);
            this.btn_ThucHien.Name = "btn_ThucHien";
            this.btn_ThucHien.Size = new System.Drawing.Size(202, 60);
            this.btn_ThucHien.TabIndex = 10;
            this.btn_ThucHien.Text = "Thực hiện";
            this.btn_ThucHien.UseVisualStyleBackColor = false;
            this.btn_ThucHien.Click += new System.EventHandler(this.btn_ThucHien_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Dong.Location = new System.Drawing.Point(856, 617);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(202, 60);
            this.btn_Dong.TabIndex = 11;
            this.btn_Dong.Text = "Đóng\r\n";
            this.btn_Dong.UseVisualStyleBackColor = false;
            this.btn_Dong.Click += new System.EventHandler(this.button2_Click);
            // 
            // bai5_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 779);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_ThucHien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtsoC);
            this.Controls.Add(this.txtsoB);
            this.Controls.Add(this.txtsoA);
            this.Name = "bai5_2";
            this.Text = "bai5_2";
            this.Load += new System.EventHandler(this.bai5_2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsoA;
        private System.Windows.Forms.TextBox txtsoB;
        private System.Windows.Forms.TextBox txtsoC;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ThucHien;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.RadioButton rdbPTB2;
        private System.Windows.Forms.RadioButton rdbPTB1;
    }
}