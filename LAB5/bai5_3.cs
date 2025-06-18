using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5_TRUONGTHIBAONHI_65132499
{
    public partial class bai5_3 : Form
    {
        List<DienThoai> ls;
        string path = "";
        public bai5_3()
        {
            InitializeComponent();
        }
        void Readfile()
        {
            ls = new List<DienThoai>();
            FileStream f = new FileStream(@"d:\Lập trình hướng đối tượng\LAB4_TRUONGTHIBAONHI_65132499\input.txt", FileMode.Open);
            StreamReader sr = new StreamReader(f);
            string line;//lưu từng dòng dữ liệu đọc ra từ file
            while ((line = sr.ReadLine()) != null)
            {
                string ma = line;
                string hieu = sr.ReadLine();
                float gia = float.Parse(sr.ReadLine());
                string duong = sr.ReadLine();
                DienThoai dt = new DienThoai(ma, hieu, gia, duong);
                ls.Add(dt);
            }
            f.Close();//đóng file
        }

        private void bai5_3_Load(object sender, EventArgs e)
        {
            Readfile();
            //đưa dữ liệu từ list vào datagrid
            dtgData.DataSource = ls;
        }

        private void picAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image file|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                path = dlg.FileName;//đường dẫn tới file
                picAnh.Image = Image.FromFile(path);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ma = txtMaSo.Text;
            string hieu = cmbNhanHieu.Text;
            float gia = float.Parse(txtGiaNhap.Text);
            DienThoai dt = new DienThoai(ma, hieu, gia, path);
            ls.Add(dt);
            //cập nhật lại datagrid
            dtgData.DataSource = null;
            dtgData.DataSource = ls;
            //xóa textbox
            txtMaSo.Clear();
            txtGiaNhap.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //tìm vị trí của đối tượng
            int p = ls.FindIndex(d => d.MaSo == txtMaSo.Text);
            if (p >= 0)//tìm thấy
                ls.RemoveAt(p);
            else
                MessageBox.Show("Dien thoai nay khong co trong danh sach!", "Thông báo");
            //cập nhật lại datagrid
            dtgData.DataSource = null;
            dtgData.DataSource = ls;
            //xóa textbox
            txtMaSo.Clear();
        }

        private void btnTinhGiaBan_Click(object sender, EventArgs e)
        {
            //tìm  đối tượng
            DienThoai p = ls.Find(d => d.MaSo == txtMaSo.Text);
            if (p != null)//tìm thấy
                txtGiaBan.Text = p.TinhGB().ToString(); //hiển thị giá bán lên textbox
            else
                MessageBox.Show("Dien thoai nay khong co trong danh sach!", "Thông báo");
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            ls.Sort();//lấy điều kiện sắp xếp trong CompareTo() của Icompareable
            //cập nhật lại datagrid
            dtgData.DataSource = null;
            dtgData.DataSource = ls;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
