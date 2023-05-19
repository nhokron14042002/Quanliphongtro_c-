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
    public partial class   FrmDangThue
 : Form
    {

        private Database db;
        private int rowIndex = -1;// biến lưu trữ chỉ số phòng được chọn 
        private String idPhong; // khai báo id phòng làm biến toàn cục để khi click vào dòng nào cx có thể lấy được idphong đồng thời 
        // đồng thời có thể sử dụng trong sự kiện click của các button xóa 

        public FrmDangThue()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmXuLyPhong(null).ShowDialog();// truyền tham số null để xác định trường hợp thêm mới phòng (vì không có id)
            loadDSPhong();

        }



        private void frmPhong_Load(object sender, EventArgs e)
        {
            loadDSPhong();
            #region gui
            // đặt lên tên cột

            dgvPhong.Columns["tenLoaiPhong"].HeaderText = "Loại Phòng";
            dgvPhong.Columns["tenPhong"].HeaderText = "Phòng";
            dgvPhong.Columns["dongia"].HeaderText = "Đơn giá";
            dgvPhong.Columns["trangthai"].HeaderText = "Trạng thái";

            // set kich thước các cột

            dgvPhong.Columns["id"].Width = 50;
            dgvPhong.Columns["tenLoaiPhong"].Width = 200;
            dgvPhong.Columns["dongia"].Width = 200;
            dgvPhong.Columns["tenPhong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;// cột tên phòng tự động co dãn theo form 
            dgvPhong.Columns["trangthai"].Width = 200;


            //căn chỉnh vị trí cốt
            dgvPhong.Columns["dongia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;// căn phải cột giá trị cột đơn giá

            // định dạng phần nghìn cho cột đơn giá phòng

            dgvPhong.Columns["dongia"].DefaultCellStyle.Format = "N0";

            #endregion
        }

        private void loadDSPhong()
        {
            db = new Database();
            var timKiem = txtTìmKiem.Text.Trim();
            var lstPra = new List<CustomParameter>() {



             new CustomParameter()
             {

                 key ="@timkiem",
                 value = timKiem
             }

            };

            var dt = db.SelectData("PhongDangThue", lstPra);

            dgvPhong.DataSource = dt;
        }

        private void dgvPhong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // LẤY ID PHÒNG ĐƯỢC CHỌN 
            var idPhong = dgvPhong.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            new frmXuLyPhong(idPhong).ShowDialog();// truyền idphong được chọn qua form để xác định trường hợp cập nhật phòng theo id

            loadDSPhong();

        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {   // LẤY ID PHÒNG ĐƯỢC CHỌN 
            // idPhong = dgvPhong.Rows[e.RowIndex].Cells["ID"].Value.ToString();


            rowIndex = e.RowIndex;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // kiểm tra rowindex có <0 hay không 
            // <0 tất là chưa chọn được phòng nào để xóa vì chỉ số dòng chỉ bắt đầu từ 0
            if (rowIndex < 0)
            {

                MessageBox.Show("Vui lòng chọn phòng cần xóa!!", "Chú ý !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // nếu có phòng chọn để xóa thì hiện câu hỏi xác nhận xóa
            if (MessageBox.Show("Bạn có chắc muốn xóa phòng " + dgvPhong.Rows[rowIndex].Cells["tenphong"].Value.ToString() + " hay không ??", "Xác nhận xóa phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK) ;
            {
                // truyền id vào proc detelePhong
                var lstPara = new List<CustomParameter>
                {
                  new CustomParameter
                  {
                    key = "@idPhong",
                    value=  dgvPhong.Rows[rowIndex].Cells["ID"].Value.ToString()
                  }



                };

                var kq = db.ExeCute("deletePhong", lstPara);

                // hiển thị thông báo xóa thành công 

                if (kq == 1)
                {

                    MessageBox.Show("Xóa phòng thành công !", "Successfully!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // sau khi xóa thành công thì load lại ds phòng 
                    loadDSPhong();
                }

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click_1(object sender, EventArgs e)
        {

        }
    }
}
