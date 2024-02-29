using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Form_register : Form
    {
        public Form_register()
        {
            InitializeComponent();
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            if (cb_type.SelectedIndex == -1)
            {
                MessageBox.Show("请输入类型！");
            }
            else if (text_password.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码！");
                text_password.Focus(); //焦点停留在文本框
            }
            else if (text_password.Text.Trim() != text_confirmPassword.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不一致！");
                text_confirmPassword.Focus(); //焦点停留在文本框
            }
            else if (text_phone.Text.Trim() == "")
            {
                MessageBox.Show("请输入电话号码！");
                text_phone.Focus(); //焦点停留在文本框
            }
            else if (!rbtn_sex1.Checked&&!rbtn_sex2.Checked)
            {
                MessageBox.Show("请选择性别！");
                text_password.Focus(); //焦点停留在文本框
            }
            else
            {
                int sex = rbtn_sex1.Checked == true ? 1 : 2;
                MySqlConnection conn = new MySqlConnection("server=localhost;database=lsm;User ID=root;Password=123456;port=3306");
                conn.Open();
                string str = String.Format("insert into reader (typeID,password,phone,sex,borrowingNum,hasBorrowedNum,violationNum) values({0},'{1}','{2}','{3}',0,0,0)",cb_type.SelectedIndex+1, text_password.Text, text_phone.Text,sex);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                 int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    string getId = "SELECT LAST_INSERT_ID()";
                    MySqlCommand getIdCmd = new MySqlCommand(getId, conn);
                    int id = Convert.ToInt32(getIdCmd.ExecuteScalar());
                    string response = String.Format("注册成功！你的用户ID是：{0}，请记住！",id);
                    MessageBox.Show(response);
                    Form_login Form = new Form_login();
                    Form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("注册失败！");
                }
                conn.Close();
            }
        }

        private void Form_register_Load(object sender, EventArgs e)
        { 
                                                             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbtn_sex1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_sex2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void text_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_confirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nud_age_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
