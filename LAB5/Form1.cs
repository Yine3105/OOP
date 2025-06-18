using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5_TRUONGTHIBAONHI_65132499
{
    public partial class ĐăngNhập : Form
    {
        public ĐăngNhập()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(txtTenTN.Text == "123" && txtMK.Text == "abc")
            {
                Close();
            }
            else
            {
                MessageBox.Show("Nhap sai roi ma\n Nhap lai khong mom?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void txtTenTN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
