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
                MessageBox.Show("���������ͣ�");
            }
            if (text_id.Text.Trim()=="")
            {
                MessageBox.Show("������ID��");
                text_id.Focus(); //����ͣ�����ı���
            }
            else if(text_password.Text.Trim()=="")
            {
                MessageBox.Show("���������룡");
                text_password.Focus(); //����ͣ�����ı���
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
                        MessageBox.Show("����Ա��½�ɹ���");
                        this.Hide();  //�������ش��岻�ܹرգ�ֻ������
                        Form_admin frm = new Form_admin(); //ʵ������Ŀ������
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("�Բ��������û������Ƿ�ѡ����ȷ����ID�������Ƿ���д��ȷ��");
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
                        MessageBox.Show("�û���½�ɹ���");
                        this.Hide();  //�������ش��岻�ܹرգ�ֻ������
                        Form_user frm = new Form_user(); //ʵ������Ŀ������
                        frm.readerID = text_id.Text;
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("�Բ��������û������Ƿ�ѡ����ȷ����ID�������Ƿ���д��ȷ��");
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