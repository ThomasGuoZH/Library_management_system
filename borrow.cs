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

namespace LMS
{
    public partial class borrow : UserControl
    {
        public String readerID;
        public borrow(String readerID)
        {
            InitializeComponent();
            this.readerID = readerID;
        }

        protected void DataBlind_borrow()
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

        private void borrow_Load(object sender, EventArgs e)
        {
            DataBlind_borrow();
        }

        private void books_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
            conn.Open();
            String name = textBox1.Text;
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
                DataBlind_borrow();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (books.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("是否确定借阅？", "借阅确认", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ListViewItem selectedItem = books.SelectedItems[0];
                    MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
                    conn.Open();
                    String ISBNCode = selectedItem.SubItems[1].Text;
                    DateTime currentTime = DateTime.Now;
                    int curNum = Convert.ToInt32(selectedItem.SubItems[5].Text);
                    string str1 = String.Format("select typeID from reader where readerID='{0}'", readerID);
                    MySqlDataAdapter da = new MySqlDataAdapter(str1, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    int typeID = Convert.ToInt32(dt.Rows[0]["typeID"]);
                    int maxdays = 0;
                    if (typeID == 1 || typeID == 2)
                    {
                        maxdays = 60;
                    }
                    else if (typeID == 3)
                    {
                        maxdays = 30;
                    }
                    DateTime deadline = currentTime.AddDays(maxdays);
                    DateTime newTime = currentTime.AddDays(30);
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 第一个 SQL 语句
                            string str2 = "insert into borrowrecord (readerID,ISBNCode,borrowDate,dueDeadline) values (@readerID, @ISBNCode, @borrowDate, @dueDeadline)";
                            using (MySqlCommand cmd1 = new MySqlCommand(str2, conn, transaction))
                            {
                                // 使用参数添加值
                                cmd1.Parameters.AddWithValue("@readerID", this.readerID);
                                cmd1.Parameters.AddWithValue("@ISBNCode", ISBNCode);
                                cmd1.Parameters.AddWithValue("@borrowDate", currentTime.ToString("yyyy-MM-dd"));
                                cmd1.Parameters.AddWithValue("@dueDeadline", deadline.ToString("yyyy-MM-dd"));
                                cmd1.ExecuteNonQuery();
                            }

                            // 第二个 SQL 语句
                            string str3 = "update book set curStore=@curStore where ISBNCode=@ISBNCode";
                            using (MySqlCommand cmd2 = new MySqlCommand(str3, conn, transaction))
                            {
                                // 使用参数添加值
                                cmd2.Parameters.AddWithValue("@curStore", curNum - 1);
                                cmd2.Parameters.AddWithValue("@ISBNCode", ISBNCode);
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
                    MessageBox.Show("借阅成功！");
                    DataBlind_borrow();
                }  
            }
            else
            {
                MessageBox.Show("请选择要借阅的书籍");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataBlind_borrow();
        }
    }
}
