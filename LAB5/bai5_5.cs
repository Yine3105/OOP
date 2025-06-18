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
    public partial class bai5_5 : Form
    {
        public bai5_5()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bài52ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bai5_2 frm = new bai5_2();
            frm.ShowDialog();
        }

        private void bải53ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bai5_3 frm = new bai5_3();
            frm.ShowDialog();
        }

        private void bài54ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bai5_4 frm = new bai5_4();
            frm.ShowDialog();
        }
    }
}
