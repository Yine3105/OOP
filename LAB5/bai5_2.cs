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
    public partial class bai5_2 : Form
    {
        public bai5_2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }
        private void bai5_2_Load(object sender, EventArgs e)
        {
            rdbPTB1.Checked = true;
            txtsoC.Enabled = false;
        }
        private void rdbPTB1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPTB1.Checked)
            {
                txtsoC.Enabled = false;
                rdbPTB2.Checked = false;
            }
            else
            {
                txtsoC.Enabled = true;
                rdbPTB2.Checked = false;
            }
        }

        private void rdbPTB2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_ThucHien_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtsoA.Text);
            float b = float.Parse(txtsoB.Text);
            if (rdbPTB1.Checked)
            {
                PTB1 ptb1 = new PTB1(a, b);
                txtKetQua.Text = ptb1.Giai().ToString();
            }
            else
            {
                float c = float.Parse(txtsoC.Text);
                PTB2 ptb2 = new PTB2(a, b, c);
                txtKetQua.Text = ptb2.Giai().ToString();
            }
        }
    }
}
