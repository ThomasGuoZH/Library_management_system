using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace LMS
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (cb_type.SelectedIndex == -1)
            {
                MessageBox.Show("请输入类型！");
            }
            if (text_id.Text.Trim()=="")
            {
                MessageBox.Show("请输入ID！");
                text_id.Focus(); //焦点停留在文本框
            }
            else if(text_password.Text.Trim()=="")
            {
                MessageBox.Show("请输入密码！");
                text_password.Focus(); //焦点停留在文本框
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
                conn.Open();
                if (cb_type.SelectedIndex == 0)
                {
                    string str = String.Format("select * from administrator where adminID='{0}' and password='{1}'", text_id.Text, text_password.Text);
                    MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    conn.Close();
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("管理员登陆成功！");
                        this.Hide();  //程序隐藏窗体不能关闭，只能隐藏
                        Form_admin frm = new Form_admin(); //实例化项目主窗口
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("对不起，请检查用户类型是否选择正确或者ID和密码是否填写正确！");
                    }
                }
                else
                {
                    string str = String.Format("select * from reader where readerID={0} and password='{1}' and typeID={2}", text_id.Text, text_password.Text, cb_type.SelectedIndex);
                    MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    conn.Close();
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("用户登陆成功！");
                        this.Hide();  //程序隐藏窗体不能关闭，只能隐藏
                        Form_user frm = new Form_user(); //实例化项目主窗口
                        frm.readerID = text_id.Text;
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("对不起，请检查用户类型是否选择正确或者ID和密码是否填写正确！");
                    }
                }
            }
        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}