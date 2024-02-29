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
    public partial class Form_user : Form
    {
        public UserControl uf1;
        public UserControl uf2;
        public UserControl uf3;
        public String readerID;
        public Form_user()
        {
            InitializeComponent();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            uf1 = new borrow(readerID);
            uf1.Show();
            panel1.Controls.Add(uf1);
            uf2 = new bring_back(readerID);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uf1.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(uf1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uf2.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(uf2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
