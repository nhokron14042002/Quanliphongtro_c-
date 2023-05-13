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
    public partial class FrmAddKhach : Form
    {

        private Database db;
        public FrmAddKhach()
        {
            InitializeComponent();
        }


        private void grbContent_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            db = new Database();
            var ho = txtHo.Text.Trim();
            var tenDem = txtTenDem.Text.Trim();
            var ten = txtTen.Text.Trim();
            var dienthoai = txtDienThoai.Text.Trim();
            var cmnd = txtCMND.Text.Trim();
            var qq = txtQueQuan.Text.Trim();
            var hktt = txtHKTT.Text.Trim();
            // ràng buộc dl 
            if (String.IsNullOrEmpty(ho) || String.IsNullOrEmpty(tenDem) || String.IsNullOrEmpty(ten)
                || String.IsNullOrEmpty(dienthoai) || String.IsNullOrEmpty(cmnd) || String.IsNullOrEmpty(hktt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ds tham số thêm khách hàng 

            var listP = new List<CustomParameter>

            {

                new CustomParameter
                {
                    key= "@ho",
                    value = ho
                },
                new CustomParameter
                {
                    key= "@hoDem",
                    value = tenDem

                },
                new CustomParameter
                {
                    key= "@ten",
                    value = ten
                },
                new CustomParameter
                {
                    key= "@dienThoai",
                    value = dienthoai
                },
                 new CustomParameter
                {
                    key= "@cmnd",
                    value = cmnd
                },
                  new CustomParameter
                {
                    key= "@queQuan",
                    value = qq
                }, new CustomParameter
                {
                    key= "@hktt",
                    value = hktt
                }


            };

            var rs = db.ExeCute("themKH", listP);
            if (rs == 1)
            {

                MessageBox.Show("Thêm khách hàng thành công", "Successfull!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
