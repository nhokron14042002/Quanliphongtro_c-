using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongTro.ChildForm
{
    public partial class frmRePass : Form
    {

        private Database db = new Database();
       
        public frmRePass()
        {
            InitializeComponent();
           
        }


       




        private void btn_Login_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            //btn xóa
            db = new Database();
            var username = txtUsername.Text.Trim();
            var newpassword = txtNewPassword.Text.Trim();
            var repassword = txtRePassword.Text.Trim();

            if ((String.IsNullOrEmpty(newpassword) && String.IsNullOrEmpty(repassword) && String.IsNullOrEmpty(username)))
            {
                MessageBox.Show("Vui lòng  nhập username or password ", "Chú ý !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (newpassword == repassword) {


                var lstPra = new List<CustomParameter>() {

                new CustomParameter()
                {
                    key = "@newpassword",
                    value= newpassword

                },

                 new CustomParameter()
                {
                    key = "@username",
                    value= username

                },

                new CustomParameter()
                {
                    key = "@repassword",
                    value= repassword

                }

                };
                var rs = db.ExeCute("[repass]", lstPra);

                if (rs == 1)
                {

                    MessageBox.Show("Đã thay đổi mật khẩu !!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // reset lại các giá trị component sau khi thêm
                    txtNewPassword.Text = null;
                    txtRePassword.Text = null;
                  
                }



            }
                
            }
        

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
