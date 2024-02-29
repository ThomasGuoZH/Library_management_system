using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMS
{
    public partial class books_management : UserControl
    {
        protected void DataBlind_books()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
            conn.Open();
            string str = "select ISBNCode,name,price,author,totalStore,curStore from book";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            books.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["name"].ToString());             
                item.SubItems.Add(dr["ISBNCode"].ToString());                
                item.SubItems.Add(dr["price"].ToString());
                item.SubItems.Add(dr["author"].ToString());
                item.SubItems.Add(dr["totalStore"].ToString());
                item.SubItems.Add(dr["curStore"].ToString());
                books.Items.Add(item);
            }
        }
        public books_management()
        {
            InitializeComponent();
        }

        private void books_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (books.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = books.SelectedItems[0];
                txt_total.Text = selectedItem.SubItems[4].Text;
                txt_left.Text = selectedItem.SubItems[5].Text;
            }
        }

        private void books_management_Load(object sender, EventArgs e)
        {
            DataBlind_books();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (books.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = books.SelectedItems[0];
                string ISBNCode = selectedItem.SubItems[1].Text;
                MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
                conn.Open();
                string str = String.Format("delete from book where ISBNCode={0}", ISBNCode);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    MessageBox.Show("图书信息删除成功！");
                    DataBlind_books();
                }
                else
                {
                    MessageBox.Show("图书信息删除失败！");
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的信息");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
            conn.Open();
            String name = txt_name.Text;
            string str = String.Format("select ISBNCode,name,price,author,totalStore,curStore from book where name like '%{0}%'", name);
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            books.Items.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["name"].ToString());
                    item.SubItems.Add(dr["ISBNCode"].ToString());
                    item.SubItems.Add(dr["price"].ToString());
                    item.SubItems.Add(dr["author"].ToString());
                    item.SubItems.Add(dr["totalStore"].ToString());
                    item.SubItems.Add(dr["curStore"].ToString());
                    books.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("你要查询的图书不存在");
                DataBlind_books();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataBlind_books();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (books.SelectedItems.Count > 0)
            { 
                ListViewItem selectedItem = books.SelectedItems[0];
                string ISBNCode = selectedItem.SubItems[1].Text;
                MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
                conn.Open();
                string str = String.Format("update book set totalStore='{0}',curStore='{1}' where ISBNCode={2}", txt_total.Text, txt_left.Text, ISBNCode);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    MessageBox.Show("图书信息修改成功！");
                    DataBlind_books();
                }
                else
                {
                    MessageBox.Show("图书信息修改失败！");
                }
            }
            else
            {
                MessageBox.Show("请选择要修改的信息");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
            conn.Open();
            string str = String.Format("INSERT INTO book (name, ISBNCode, totalStore, curStore, price, author) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", textBox1.Text, textBox2.Text, textBox3.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            MySqlCommand cmd = new MySqlCommand(str, conn);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if (i > 0)
            {
                MessageBox.Show("图书插入成功");
                DataBlind_books();
            }
            else
            {
                MessageBox.Show("图书添加失败");
            }
        }
    }
}
