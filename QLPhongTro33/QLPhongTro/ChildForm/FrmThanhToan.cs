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
    public partial class FrmThanhToan : Form
    {

        private String IDThuePhong;
        private Database db;
        public FrmThanhToan(String IDThuePhong)
        {
            this.IDThuePhong = IDThuePhong;
            db = new Database();
            InitializeComponent();
        }
        DataRow dr;

        private void LoadHopDongThuePhong()
        {

            List<CustomParameter> ListPra = new List<CustomParameter> {
                new CustomParameter
                {

                    key= "@ID",
                   value= IDThuePhong

                }

            };
            dr = db.SelectData("LoadThongTinHopDongThueTro", ListPra).Rows[0];
            lblKhachHang.Text = dr["Hoten"].ToString();
            lblGiaPhong.Text = string.Format("{0:N0}", int.Parse(dr["GiaPhong"].ToString()));
            txtThanhToan.Text = dr["DaThanhToan"].ToString();
            lblConLai.Text = dr["ConLai"].ToString();



        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtTienCoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmThanhToan_Load(object sender, EventArgs e)
        {
            LoadHopDongThuePhong();
        }

        private void txtThanhToan_KeyUp(object sender, KeyEventArgs e)
        {
            lblConLai.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["GiaPhong"].ToString()) - int.Parse(txtThanhToan.Text));
        }

        private void txtThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            List<CustomParameter> ListPra = new List<CustomParameter> {
                new CustomParameter
                {

                    key= "@ID",
                   value= IDThuePhong

                },

                  new CustomParameter
                {

                    key= "@SoTien",
                   value= txtThanhToan.Text

                }

            };



            var kq = db.ExeCute("ThanhToan", ListPra);



            if (kq == 1)
            {

                MessageBox.Show("Thanh toán thành công !!!!", "SUCCESSFULLY!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            else
            {

                MessageBox.Show("Thanh toán thất bại !!!!", "FAILED!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void grbContent_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pblBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlRight_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

