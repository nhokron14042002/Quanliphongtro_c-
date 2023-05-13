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
    public partial class frmThuePhong : Form
    {


        private Database db;
        public frmThuePhong()
        {
            InitializeComponent();
        }

        private void btnThueMoi_Click(object sender, EventArgs e)
        {
            var f = new FrmXuLyThue();

            f.ShowDialog();
            LoadDSThuePhong();


        }

        private void frmThuePhong_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDSThuePhong();
            /* dgvThuePhong.Columns["TenLoaiPhong"].Width= 150;
             dgvThuePhong.Columns["TenPhong"].Width = 80;
             dgvThuePhong.Columns["HoTen"].Width = 150;
             dgvThuePhong.Columns["DienThoai"].Width = 100;
             dgvThuePhong.Columns["CMND_CanCuoc"].Width = 100;
             dgvThuePhong.Columns["HKTT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ;
             dgvThuePhong.Columns["NgayThue"].Width = 80;
             dgvThuePhong.Columns["NgayTraPhong"].Width = 80;
             dgvThuePhong.Columns["TienDatCoc"].Width = 100;

             dgvThuePhong.Columns["TienDatCoc"].DefaultCellStyle.Format = "N0";
             dgvThuePhong.Columns["TienDatCoc"].DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleRight;


             dgvThuePhong.Columns["TenLoaiPhong"].HeaderText = "Loại Phòng";
             dgvThuePhong.Columns["TenPhong"].HeaderText = "Phòng";
             dgvThuePhong.Columns["HoTen"].HeaderText = "Khách Hàng";
             dgvThuePhong.Columns["DienThoai"].HeaderText = "Điện Thoại";
             dgvThuePhong.Columns["CMND_CanCuoc"].HeaderText = "CMND/CCCD";
             dgvThuePhong.Columns["HKTT"].HeaderText = "HKTT";
             dgvThuePhong.Columns["NgayThue"].HeaderText = "Ngày Thuê";
             dgvThuePhong.Columns["NgayTraPhong"].HeaderText = "Ngày Trả";
             dgvThuePhong.Columns["TienDatCoc"].HeaderText = "Đặt Cọc";*/
        }

        private void LoadDSThuePhong()
        {
            List<CustomParameter> lstPra = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key="@tuKhoa",
                    value= txtTìmKiem.Text

                }



            };

            dgvThuePhong.DataSource = db.SelectData("LoadDSThuePhong", lstPra);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSThuePhong();


        }

        private void dgvThuePhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvThuePhong.Columns["btnThanhToan"].Index)
                {
                    var IDThuePhong = dgvThuePhong.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    new FrmThanhToan(IDThuePhong).ShowDialog();

                }
            }
        }
    }
}
