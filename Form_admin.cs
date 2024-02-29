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
    public partial class Form_admin : Form
    {
        public UserControl uf1;
        public UserControl uf2;
        public UserControl uf3;
        public Form_admin()
        {
            InitializeComponent();
            uf1 = new readers_management();
            uf1.Show();
            panel1.Controls.Add(uf1);
            uf2 = new books_management();
            uf3 = new records_management();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uf1.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(uf1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)                                    
        {
            uf2.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(uf2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uf3.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(uf3);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
