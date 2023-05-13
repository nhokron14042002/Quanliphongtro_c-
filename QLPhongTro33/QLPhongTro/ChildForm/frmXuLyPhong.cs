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
    public partial class frmXuLyPhong : Form
    {

        private string idPhong;


        private Database db;
        public frmXuLyPhong(String idPhong)

        // thêm mới và cập nhật đều xử lí chung trong form xử lí form này
        // trong kiểu bool nếu true là trường hợp thêm mới nếu false là trường hợp cập nhật
        {
            this.idPhong = idPhong;



            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadLoaiPhong()
        {
            var dt = db.SelectData("loadDSLoaiPhong");
            cbbLoaiPhong.DataSource = dt; // đổ dữ liệu cho combobox
            cbbLoaiPhong.DisplayMember = "tenLoaiPhong";// thuộc tính hiển thị
            cbbLoaiPhong.ValueMember = "ID"; // thuộc tính giá trị



        }

        private void frmXuLyPhong_Load(object sender, EventArgs e)
        {
            db = new Database();

            loadLoaiPhong();
            if (String.IsNullOrEmpty(idPhong))//trường hợp thêm mới phòng không có id phòng <=> null
            {
                lblTitle.Text = "Thêm phòng mới";
            }
            else
            {

                lblTitle.Text = "Cập nhật thông tin phòng";
                // vì phòng được xác định qua id nên chúng ta cần truyền tham số là giá trị của id phòng vào 
                var lstPra = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idPhong",
                        value = idPhong

                    }

                };
                var phong = db.SelectData("[selectPhong]", lstPra).Rows[0];// sử dụng selectdata trong class database để lấy dữ liệu phòng


                // kết quả trả về là một datatable chỉ gồm một hàng chính là hàng có chỉ số hàng bằng 0

                // set dữ liệu lấy được cho các compoment trên form xử lí form frmXuliPhong
                cbbLoaiPhong.SelectedValue = phong["IDLoaiPhong"].ToString();// set id loai phòng cho compobox
                txtTenPhong.Text = phong["TenPhong"].ToString();// set giá trị tên phòng cho tex box txttenphong
                if (phong["trangthai"].ToString() == "1")// set trạng thái hoạt động cho ckbhoatdong
                {

                    ckbHoatDong.Checked = true;
                }
                else
                {
                    ckbHoatDong.Checked = false;
                }


            }

        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Dispose(); // đóng form
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {


            if (cbbLoaiPhong.SelectedIndex < 0)// kiểm tra loại phòng đã được chọn hay chưa
            {
                MessageBox.Show("Vui lòng chọn loại phòng. ", "Chú ý !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;


            }

            var idLoaiPhong = cbbLoaiPhong.SelectedValue.ToString();
            var tenPhong = txtTenPhong.Text.Trim();
            var trangThai = ckbHoatDong.Checked ? 1 : 0;


            if (string.IsNullOrEmpty(tenPhong))// kiểm tra loại phòng đã được chọn hay chưa
            {
                MessageBox.Show("Vui lòng nhập tên phòng. ", "Chú ý !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPhong.Select();
                return;


            }
            if (String.IsNullOrEmpty(idPhong))// th thêm mới phòng 
            {

                var lstPra = new List<CustomParameter>() {

                new CustomParameter()
                {
                    key = "@idLoaiPhong",
                    value= idLoaiPhong

                },

                new CustomParameter()
                {
                    key = "@tenPhong",
                    value= tenPhong

                },

                new CustomParameter()
                {
                    key = "@trangThai",
                    value= trangThai.ToString()

                }

                };
                var rs = db.ExeCute("[themMoiPhong]", lstPra);

                if (rs == 1)
                {

                    MessageBox.Show("Thêm mới thành công !!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // reset lại các giá trị component sau khi thêm
                    txtTenPhong.Text = null;
                    cbbLoaiPhong.SelectedIndex = 0;
                }

            }
            else // trường hợp cập nhật phòng đã tồn tại id
            {

                // xử lí trường hợp cập nhật khi click vào button cập nhật 
                // bên proc có 4 tham số truyền vào nên phải truyền vào 4 tham số 
                var lstPara = new List<CustomParameter>() {


                new CustomParameter()
                {
                    key = "@idPhong",
                    value= idPhong
                },

                new CustomParameter()
                {
                    key = "@tenPhong",
                    value= txtTenPhong.Text
                },


                new CustomParameter()
                {
                    key = "@idLoaiPhong",
                    value= cbbLoaiPhong.SelectedValue.ToString()
                },


                new CustomParameter()
                {
                    key = "@trangThai",
                    value= trangThai.ToString()
                }

                };

                var kq = db.ExeCute("updatePhong", lstPara);
                if (kq == 1)
                {
                    MessageBox.Show("Cập nhật thông tin phòng thành công", "Successfully!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công", "Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    this.Dispose();
                }

            }
        }

        private void cbbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grbContent_Enter(object sender, EventArgs e)
        {

        }

        private void txtTenPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pblBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
