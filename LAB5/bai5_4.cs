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
    public partial class bai5_4 : Form
    {
        List<Access> validCodes = new List<Access>();
        string currentCode = "";
        public bai5_4()
        {
            InitializeComponent();
            InitializeAccessCodes();
        }
        void InitializeAccessCodes()
        {
            validCodes.Add(new Access("2643", "Technician"));
            validCodes.Add(new Access("6372", "Scientist"));
            validCodes.Add(new Access("9652", "Employee"));
            validCodes.Add(new Access("9843", "Employee"));
            validCodes.Add(new Access("1947", "Boss"));
        }
        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void bai5_4_Load(object sender, EventArgs e)
        {
            txtSecurityCode.UseSystemPasswordChar = true;
        }
        private void Digit_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            currentCode += btn.Text;
            txtSecurityCode.Text = new string('*', currentCode.Length);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (currentCode.Length > 0)
                currentCode = currentCode.Substring(0, currentCode.Length - 1);
            txtSecurityCode.Text = new string('*', currentCode.Length);
        }
        string ValidateCode(string code)
        {
            foreach (var item in validCodes)
            {
                if (item.Code == code)
                    return item.Role;
            }
            return "";
        }

        private void btnsharp_Click(object sender, EventArgs e)
        {
            string role = ValidateCode(currentCode);
            if (role != "")
            {
                lbaccess.Items.Add(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt") + "   " + role);
            }
            else
            {
                MessageBox.Show("Access Denied!", "Error");
            }
            txtSecurityCode.Text = "";
        }
    }
}