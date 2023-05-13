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
    public partial class FrmDichVu : Form
    {

        private Database db;
        public FrmDichVu()
        {
            InitializeComponent();
            db = new Database();
        }

        private void FrmDichVu_Load(object sender, EventArgs e)
        {
            loadDSDichVu();

            dgvDV.Columns[1].HeaderText = "Tên dịch vụ";
            dgvDV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void loadDSDichVu()
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

            var dt = db.SelectData("loadDSDichVu", lstPra);

            dgvDV.DataSource = dt;

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (txtTenDV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ", "Chú ý!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            var lstPra = new List<CustomParameter>() {

             new CustomParameter()
             {

                 key ="@tenDV",
                 value = txtTenDV.Text.Trim()
             }

            };

            if (db.ExeCute("themDichVu", lstPra) == 1)
            {
                MessageBox.Show("Thêm mới dịch vụ thành công ");
                loadDSDichVu();
                txtTenDV.Text = null;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTìmKiem.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ", "Chú ý!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            var lstPra = new List<CustomParameter>() {


             new CustomParameter()
             {

                 key ="@timKiem",
                 value = txtTìmKiem.Text.Trim()
             }

            };

            if (db.SelectData("[loadDSDichVu]", lstPra) != null)
            {
                MessageBox.Show(" Dịch vụ bạn cần tìm .", "Successful!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDSDichVu();


            }



        }

        private void tbnCapNhat_click(object sender, EventArgs e)
        {
            if (id < 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần cập nhật", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTenDV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ", "Chú ý!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            var lstPra = new List<CustomParameter>() {

             new CustomParameter()
             {

                 key ="@id",
                 value = id.ToString()
             }
             ,
             new CustomParameter()
             {

                 key ="@tenDV",
                 value = txtTenDV.Text.Trim()
             }

            };

            if (db.ExeCute("capNhatDichVu", lstPra) == 1)
            {
                MessageBox.Show("Cập nhật dịch vụ thành công ", "Successful!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDSDichVu();
                txtTenDV.Text = null;
            }

        }

        int id = -1;
        private void dgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = int.Parse(dgvDV.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTenDV.Text = dgvDV.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id < 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần cập nhật", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắn muốn xóa dịch vụ này", "Xác nhận!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                var lstPra = new List<CustomParameter>() {

             new CustomParameter()
             {

                 key ="@id",
                 value = id.ToString()
             }

            };

                if (db.ExeCute("deleteDichVu", lstPra) == 1)
                {
                    MessageBox.Show("Xóa dịch vụ thành công ", "Successful!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDSDichVu();
                    txtTenDV.Text = null;
                }
            }
        }
    }
}
