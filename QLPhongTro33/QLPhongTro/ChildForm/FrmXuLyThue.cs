using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongTro.ChildForm
{
    public partial class FrmXuLyThue : Form
    {




        private Database db;


        // thêm mới và cập nhật đều xử lí chung trong form xử lí form này
        // trong kiểu bool nếu true là trường hợp thêm mới nếu false là trường hợp cập nhật
        public FrmXuLyThue()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void grbContent_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Dispose(); // đóng form
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose(); // đóng form
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cbbPhong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn phòng thuế ", "Ràng buộc dữ liệu !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            var idPhong = cbbPhong.SelectedValue.ToString();

            if (cbbKhach.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Khách Hàng hoặc thêm mới!! ", "Ràng buộc dữ liệu !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            var idKhachHang = cbbKhach.SelectedValue.ToString();

            int datCoc = 0;
            try
            {
                datCoc = int.Parse(txtTienCoc.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập tiền đặt cọc!! ", "Ràng buộc dữ liệu !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            // DateTime ngayThue, ngayTra;
            var ngaythue = mtbNgayThue.Text.ToString();
            var ngayTra = mtbNgayTra.Text.ToString();


            try
            {

                /* ngayThue = DateTime.ParseExact(mtbNgayThue.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                 ngayTra = DateTime.ParseExact(mtbNgayTra.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);


                 if (ngayTra < ngayThue)
                 {

                     MessageBox.Show("Ngày thuê không được nhỏ hơn hoặc bằng ngày trả.", "WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     return;
                 }*/

            }
            catch (Exception)
            {
                MessageBox.Show("Ngày thuê hoặc ngày trả không hợp lệ.");
                return;

            }




            var lstPra = new List<CustomParameter>
            {

                new CustomParameter
                {
                    key= "@idPhong",
                    value= idPhong

                },

                new CustomParameter
                {
                    key= "@idKhachHang",
                    value= idKhachHang

                },

                new CustomParameter
                {
                    key= "@datCoc",
                    value= datCoc.ToString()

                },


                new CustomParameter
                {
                    key= "@ngayThue",
                    value= ngaythue.ToString()

                },

                 new CustomParameter
                {
                    key= "@ngayTra",
                    value= ngayTra.ToString()

                }


            };

            var rs = db.ExeCute("ThuePhong", lstPra);
            if (rs == 1)
            {

                MessageBox.Show("Thuê phòng thành công!!", "Successfully!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }


        }

        private void FrmXuLyThue_Load(object sender, EventArgs e)
        {
            db = new Database();
            loadDSPhong();
            loadDSKhachHang();
            mtbNgayThue.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
            mtbNgayTra.Text = DateTime.Now.AddMonths(1).ToString("yyyy/MM/dd HH:mm");



        }


        private void loadDSPhong()
        {
            var dt = db.SelectData("[LoadAllDSPhong]");
            // var dt = db.SelectData("[loadDSPhong]");

            cbbPhong.DataSource = dt; // đổ dữ liệu cho combobox
            cbbPhong.DisplayMember = "TenPhong";// thuộc tính hiển thị
            cbbPhong.ValueMember = "ID"; // thuộc tính giá trị
            cbbPhong.SelectedIndex = -1;




        }


        private void loadDSKhachHang()
        {
            var dt = db.SelectData("[loadDSKhachHang]");

            cbbKhach.DataSource = dt; // đổ dữ liệu cho combobox
            cbbKhach.DisplayMember = "Hoten";// thuộc tính hiển thị

            cbbKhach.ValueMember = "ID"; // thuộc tính giá trị
            cbbKhach.SelectedIndex = -1;

        }
        private void cbbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var f = new FrmAddKhach();
            f.ShowDialog();
        }
    }
}
