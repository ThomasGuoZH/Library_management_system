using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMS
{
    public partial class readers_management : UserControl
    {
        public readers_management()
        {
            InitializeComponent();
        }

        protected void DataBlind_readers()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
            conn.Open();
            string str = "select readerID,typeID,sex,phone,borrowingNum,hasBorrowedNum,violationNum,situation,remark from reader";
            MySqlDataAdapter da = new MySqlDataAdapter(str,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            readers.Items.Clear();
            foreach(DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["readerID"].ToString());
                if (dr["typeID"].ToString() == "1")
                {
                    item.SubItems.Add("教师");
                }
                else if (dr["typeID"].ToString() == "2")
                {
                    item.SubItems.Add("职工");
                }
                else
                {
                    item.SubItems.Add("学生");
                }
                item.SubItems.Add(dr["phone"].ToString());
                if (dr["sex"].ToString() == "1")
                {
                    item.SubItems.Add("男");
                }
                else if (dr["sex"].ToString() == "2")
                {
                    item.SubItems.Add("女");
                }
                item.SubItems.Add(dr["borrowingNum"].ToString());
                item.SubItems.Add(dr["hasBorrowedNum"].ToString());              
                item.SubItems.Add(dr["situation"].ToString());
                item.SubItems.Add(dr["remark"].ToString());
                item.SubItems.Add(dr["violationNum"].ToString());
                readers.Items.Add(item);    
            }
        }

        private void readers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (readers.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = readers.SelectedItems[0];
                td_phone.Text = selectedItem.SubItems[2].Text; 
                td_situation.Text = selectedItem.SubItems[6].Text;
                td_remark.Text = selectedItem.SubItems[7].Text;
            }
        }

        private void readers_management_Load(object sender, EventArgs e)
        {
            DataBlind_readers();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (readers.SelectedItems.Count > 0)
            {
                /*ListViewItem selectedItem = readers.SelectedItems[0];
                string readerID = selectedItem.SubItems[0].Text;
                string typeID = selectedItem.SubItems[1].Text;
                string phone = selectedItem.SubItems[2].Text;
                string sex = selectedItem.SubItems[3].Text;
                if (sex == "女")
                {
                    sex = "2";
                }
                else
                {
                    sex = "1";
                }
                string borrowingNum = selectedItem.SubItems[4].Text;
                string hasborrowedNum = selectedItem.SubItems[5].Text;
                string violationNum = selectedItem.SubItems[6].Text;
                string situation = selectedItem.SubItems[7].Text;
                string remark = selectedItem.SubItems[8].Text;*/
                ListViewItem selectedItem = readers.SelectedItems[0];
                string readerID = selectedItem.SubItems[0].Text;
                MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
                conn.Open();
                string str = String.Format("update reader set phone='{0}',situation='{1}',remark={2} where readerID={3}", td_phone.Text,td_situation.Text,td_remark.Text,readerID);
                MySqlCommand cmd = new MySqlCommand(str, conn);                     
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0) 
                {
                    MessageBox.Show("用户信息修改成功！");
                    DataBlind_readers();
                }
                else
                {
                    MessageBox.Show("读者信息修改失败！");
                }
            }
            else
            {
                MessageBox.Show("请选择要修改的信息");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (readers.SelectedItems.Count > 0) {
                ListViewItem selectedItem = readers.SelectedItems[0];
                string readerID = selectedItem.SubItems[0].Text;
                MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
                conn.Open();
                string str = String.Format("delete from reader where readerID={0}",readerID);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    MessageBox.Show("用户信息删除成功！");
                    DataBlind_readers();
                }
                else
                {
                    MessageBox.Show("读者信息删除失败！");
                } 
            }
            else
            {
                MessageBox.Show("请选择要删除的信息");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
            conn.Open();
            String readerID = tb_id.Text;
            string str = String.Format("select readerID,typeID,sex,phone,borrowingNum,hasBorrowedNum,violationNum,situation,remark from reader where readerID='{0}'",readerID);
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            readers.Items.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["readerID"].ToString());
                    if (dr["typeID"].ToString() == "1")
                    {
                        item.SubItems.Add("教师");
                    }
                    else if (dr["typeID"].ToString() == "2")
                    {
                        item.SubItems.Add("职工");
                    }
                    else
                    {
                        item.SubItems.Add("学生");
                    }
                    item.SubItems.Add(dr["phone"].ToString());
                    if (dr["sex"].ToString() == "1")
                    {
                        item.SubItems.Add("男");
                    }
                    else if (dr["sex"].ToString() == "2")
                    {
                        item.SubItems.Add("女");
                    }
                    item.SubItems.Add(dr["borrowingNum"].ToString());
                    item.SubItems.Add(dr["hasBorrowedNum"].ToString());
                    item.SubItems.Add(dr["situation"].ToString());
                    item.SubItems.Add(dr["remark"].ToString());
                    item.SubItems.Add(dr["violationNum"].ToString());
                    readers.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("你要查询的用户不存在");
                DataBlind_readers();
            }
        }
            

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataBlind_readers();
        }
    }
}
