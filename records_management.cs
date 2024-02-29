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
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMS
{
    public partial class records_management : UserControl
    {
        public records_management()
        {
            InitializeComponent();
        }

        protected void DataBlind_records()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
            conn.Open();
            string str = "select readerID,ISBNCode,borrowDate,dueDate,isOverdue,isDamaged,isfined from borrowrecord";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            records.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["readerID"].ToString());
                item.SubItems.Add(dr["ISBNCode"].ToString());
                item.SubItems.Add(dr["borrowDate"].ToString());
                item.SubItems.Add(dr["dueDate"].ToString());
                item.SubItems.Add(dr["isOverdue"].ToString());
                item.SubItems.Add(dr["isDamaged"].ToString());
                item.SubItems.Add(dr["isfined"].ToString());
                records.Items.Add(item);
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
            conn.Open();
            string ISBNCode = txt_ISBN.Text;
            string str = String.Format("select readerID,ISBNCode,borrowDate,dueDate,isOverdue,isDamaged,isfined from borrowrecord where ISBNCode like '%{0}%'", ISBNCode);
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            records.Items.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["readerID"].ToString());
                    item.SubItems.Add(dr["ISBNCode"].ToString());
                    item.SubItems.Add(dr["borrowDate"].ToString());
                    item.SubItems.Add(dr["dueDate"].ToString());
                    item.SubItems.Add(dr["isOverdue"].ToString());
                    item.SubItems.Add(dr["isDamaged"].ToString());
                    item.SubItems.Add(dr["isfined"].ToString());
                    records.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("你要查询的ISBN码不存在");
                DataBlind_records();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void records_management_Load(object sender, EventArgs e)
        {
            DataBlind_records();
        }

        private void records_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (records.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = records.SelectedItems[0];
                txt_damage.Text = selectedItem.SubItems[6].Text;
                txt_fined.Text = selectedItem.SubItems[5].Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataBlind_records();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (records.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = records.SelectedItems[0];
                string readerID = selectedItem.SubItems[0].Text;
                string ISBNCode = selectedItem.SubItems[1].Text;
                MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
                conn.Open();
                string str = String.Format("delete from borrowrecord where readerID={0} and ISBNCode='{1}'", readerID,ISBNCode);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    MessageBox.Show("记录删除成功！");
                    DataBlind_records();
                }
                else
                {
                    MessageBox.Show("记录删除失败！");
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的记录");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
            conn.Open();
            string readerID = txt_id.Text;
            string str = String.Format("select readerID,ISBNCode,borrowDate,dueDate,isOverdue,isDamaged,isfined from borrowrecord where readerID like '%{0}%'", readerID);
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            records.Items.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["readerID"].ToString());
                    item.SubItems.Add(dr["ISBNCode"].ToString());
                    item.SubItems.Add(dr["borrowDate"].ToString());
                    item.SubItems.Add(dr["dueDate"].ToString());
                    item.SubItems.Add(dr["isOverdue"].ToString());
                    item.SubItems.Add(dr["isDamaged"].ToString());
                    item.SubItems.Add(dr["isfined"].ToString());
                    records.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("你要查询的ID不存在");
                DataBlind_records();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (records.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = records.SelectedItems[0];
                string readerID = selectedItem.SubItems[0].Text;
                string ISBNCode = selectedItem.SubItems[1].Text;
                MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
                conn.Open();
                string str = String.Format("update borrowrecord set isfined='{0}',isdamaged='{1}' where ISBNCode={2} and readerID='{3}'", txt_fined.Text, txt_damage.Text, ISBNCode,readerID);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    MessageBox.Show("记录修改成功！");
                    DataBlind_records();
                }
                else
                {
                    MessageBox.Show("记录修改失败！");
                }
            }
            else
            {
                MessageBox.Show("请选择要修改的记录");
            }
        }
    }
}
