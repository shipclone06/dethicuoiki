using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dethicuoiki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string u = "shipclone06";
            string p = "0x98_60";
            if (txtuser.Text == u && txtpass.Text == p)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
                this.Close();
            }
            

            if (txtuser.TextLength == 0)
            {
                errorProvider1.SetError(txtuser, "vui lòng ghi thông tin");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtpass.TextLength == 0)
            {
                errorProvider2.SetError(txtpass, "vui lòng ghi thông tin");
            }
            else
            {
                errorProvider2.Clear();
            }
            lblinfo.Text = "Sai rồi kìa, vui lòng nhập lại tên hoặc mật khẩu";

        }

        private void lblinfo_Click(object sender, EventArgs e)
        {
            lblinfo.Text = "";
        }
    }
}
