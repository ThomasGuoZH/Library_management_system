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

namespace LMS
{
    public partial class bring_back : UserControl
    {
        public String readerID;
        public bring_back(String readerID)
        {
            InitializeComponent();
            this.readerID = readerID;
        }
        protected void DataBlind_bringback()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
            conn.Open();
            string str = String.Format("select ISBNCode,borrowDate,dueDeadline,dueDate from borrowrecord where readerID='{0}'",readerID);
            MySqlDataAdapter da1 = new MySqlDataAdapter(str, conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            books.Items.Clear();
            string str1 = String.Format("select typeID from reader where readerID='{0}'", readerID);
            MySqlDataAdapter da2 = new MySqlDataAdapter(str1, conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            int typeID = Convert.ToInt32(dt2.Rows[0]["typeID"]);
            int maxdays = 0;
            if (typeID == 1 || typeID == 2)
            {
                maxdays = 60;
            }
            else if (typeID == 3)
            {
                maxdays = 30;
            }
            foreach (DataRow dr in dt1.Rows)
            {
                if (dr["dueDate"] == DBNull.Value)
                {
                    string ISBNCode = Convert.ToString(dr["ISBNCode"]);
                    string str2 = String.Format("select name from book where ISBNCode='{0}'", ISBNCode);
                    MySqlDataAdapter da = new MySqlDataAdapter(str2, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    string name = Convert.ToString(dt.Rows[0]["name"]);
                    ListViewItem item = new ListViewItem(name);
                    item.SubItems.Add(ISBNCode);
                    DateTime borrowDate = Convert.ToDateTime(dr["borrowDate"]);
                    DateTime dueDeadline = Convert.ToDateTime(dr["dueDeadline"]);
                    item.SubItems.Add(borrowDate.ToString());
                    item.SubItems.Add(dueDeadline.ToString());
                    TimeSpan difference = dueDeadline - borrowDate;
                    if (difference.Days > maxdays)
                    {
                        item.SubItems.Add("no");
                    }
                    else
                    {
                        item.SubItems.Add("no");
                    }
                    books.Items.Add(item);
                }
                else continue;
            }
            conn.Close();
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            DataBlind_bringback();
        }

        private void books_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (books.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("是否确定归还？", "归还确认", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ListViewItem selectedItem = books.SelectedItems[0];
                    string ISBNCode = selectedItem.SubItems[1].Text;
                    DateTime dueTime = DateTime.Now;
                    string isoverdue= selectedItem.SubItems[4].Text;
                    MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
                    conn.Open();
                    string str2 = String.Format("select curStore from book where ISBNCode='{0}'", ISBNCode);
                    MySqlDataAdapter da = new MySqlDataAdapter(str2, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    int curNum = Convert.ToInt16(dt.Rows[0]["curStore"]);
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 第一个 SQL 语句
                            string str3 = "update book set curStore=@curStore where ISBNCode=@ISBNCode";
                            using (MySqlCommand cmd1 = new MySqlCommand(str3, conn, transaction))
                            {
                                // 使用参数添加值
                                cmd1.Parameters.AddWithValue("@curStore", curNum + 1);
                                cmd1.Parameters.AddWithValue("@ISBNCode", ISBNCode);
                                cmd1.ExecuteNonQuery();
                            }

                            // 第二个 SQL 语句
                            string str4 = "update borrowrecord set isoverdue=@isoverdue, dueDate=@dueDate where ISBNCode=@ISBNCode and readerID=@readerID";
                            using (MySqlCommand cmd2 = new MySqlCommand(str4, conn, transaction))
                            {
                                // 使用参数添加值
                                cmd2.Parameters.AddWithValue("@isoverdue", isoverdue);
                                cmd2.Parameters.AddWithValue("@dueDate", dueTime.ToString("yyyy-MM-dd"));
                                cmd2.Parameters.AddWithValue("@ISBNCode", ISBNCode);
                                cmd2.Parameters.AddWithValue("@readerID", readerID);
                                cmd2.ExecuteNonQuery();
                            }

                            // 提交事务
                            transaction.Commit();
                            Console.WriteLine("事务已提交");
                        }
                        catch (Exception ex)
                        {
                            // 出现异常时回滚事务
                            Console.WriteLine("事务回滚: " + ex.Message);
                            transaction.Rollback();
                        }
                    }

                    conn.Close();
                    books.Items.Clear();
                    MessageBox.Show("归还成功！");
                    DataBlind_bringback();
                }
            }
            else
            {
                MessageBox.Show("请选择要归还的图书");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (books.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("是否确定续借30日？", "续借确认", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ListViewItem selectedItem = books.SelectedItems[0];
                    string ISBNCode = selectedItem.SubItems[1].Text;
                    DateTime deadline=Convert.ToDateTime(selectedItem.SubItems[3].Text);
                    deadline = deadline.AddDays(30);
                    MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
                    conn.Open();
                    string str = String.Format("update borrowrecord set dueDeadline='{0}' where ISBNCode={1} and readerID='{2}'", deadline.ToString("yyyy-MM-dd"), ISBNCode, readerID);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("续借成功！");
                        DataBlind_bringback();
                        selectedItem.SubItems[4].Text = "no";
                    }
                    else
                    {
                        MessageBox.Show("续借失败！");
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要续借的图书");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataBlind_bringback();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
