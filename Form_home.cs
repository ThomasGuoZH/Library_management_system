using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Form_home : Form
    {
        public Form_home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form_home_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            Form_login frm = new Form_login();
            frm.Show();
        }

        private void register_Click(object sender, EventArgs e)
        {
            Form_register frm = new Form_register();
            frm.Show();
        }
       
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
