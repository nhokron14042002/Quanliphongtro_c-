using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Security.Cryptography;
using QLPhongTro;

namespace QLPhongTro.ChildForm
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

       


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LuuTru.Con = new SqlConnection("server =.; uid = sa; pwd = 0387002171; database = QlPhongTro3");
                LuuTru.Con.Open();
                SqlCommand com = new SqlCommand("select * from _User where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", LuuTru.Con);
                SqlDataReader drd = com.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(drd);
                if (table.Rows.Count > 0)
                {
                    LuuTru.Kt = !LuuTru.Kt;
                    MessageBox.Show("Xin Chào: " + txtUsername.Text, "Thông báo!");
                    
                    Close();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo!");
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                MessageBox.Show("Không thể kết nối server hoặc dữ liệu nhập không đúng!!!", "Thông báo!");
            }

           
        }
    }
}
