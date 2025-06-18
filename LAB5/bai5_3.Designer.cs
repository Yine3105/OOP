namespace LAB5_TRUONGTHIBAONHI_65132499
{
    partial class bai5_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.cmbNhanHieu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTinhGiaBan = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgData = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(440, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin điện thoại";
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(447, 158);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(359, 31);
            this.txtMaSo.TabIndex = 1;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(447, 334);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(359, 31);
            this.txtGiaNhap.TabIndex = 2;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(447, 421);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(359, 31);
            this.txtGiaBan.TabIndex = 3;
            // 
            // cmbNhanHieu
            // 
            this.cmbNhanHieu.FormattingEnabled = true;
            this.cmbNhanHieu.Location = new System.Drawing.Point(447, 252);
            this.cmbNhanHieu.Name = "cmbNhanHieu";
            this.cmbNhanHieu.Size = new System.Drawing.Size(359, 33);
            this.cmbNhanHieu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(263, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(263, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhãn hiệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(263, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giá nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(263, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá bán";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(208, 490);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(185, 61);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(415, 490);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(185, 61);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTinhGiaBan
            // 
            this.btnTinhGiaBan.Location = new System.Drawing.Point(621, 490);
            this.btnTinhGiaBan.Name = "btnTinhGiaBan";
            this.btnTinhGiaBan.Size = new System.Drawing.Size(185, 61);
            this.btnTinhGiaBan.TabIndex = 11;
            this.btnTinhGiaBan.Text = "Tính giá bán";
            this.btnTinhGiaBan.UseVisualStyleBackColor = true;
            this.btnTinhGiaBan.Click += new System.EventHandler(this.btnTinhGiaBan_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(823, 490);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(185, 61);
            this.btnSort.TabIndex = 12;
            this.btnSort.Text = "Sắp xếp";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(884, 152);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(325, 300);
            this.picAnh.TabIndex = 13;
            this.picAnh.TabStop = false;
            this.picAnh.Click += new System.EventHandler(this.picAnh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(964, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 37);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hình ảnh";
            // 
            // dtgData
            // 
            this.dtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgData.Location = new System.Drawing.Point(208, 599);
            this.dtgData.Name = "dtgData";
            this.dtgData.RowHeadersWidth = 82;
            this.dtgData.RowTemplate.Height = 33;
            this.dtgData.Size = new System.Drawing.Size(1001, 358);
            this.dtgData.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1024, 490);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(185, 61);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bai5_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 1001);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtgData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnTinhGiaBan);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNhanHieu);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtMaSo);
            this.Controls.Add(this.label1);
            this.Name = "bai5_3";
            this.Text = "bai5_3";
            this.Load += new System.EventHandler(this.bai5_3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.ComboBox cmbNhanHieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnTinhGiaBan;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgData;
        private System.Windows.Forms.Button btnClose;
    }
}