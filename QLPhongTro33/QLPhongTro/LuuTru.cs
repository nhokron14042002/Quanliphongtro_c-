using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QLPhongTro
{
    internal class LuuTru
    {
        private static bool kt = true;
        private static SqlConnection con = null;

        public static bool Kt
        {
            get { return kt; }
            set { kt = value; }
        }

        public static SqlConnection Con
        {
            get { return con; }
            set { con = value; }
        }

        public static void hienthi(DataGrid dgv, String s)
        {
            SqlCommand con = new SqlCommand(s, Con);
            SqlDataReader drd = con.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(drd);
            table.Columns.Add("TT");
            for (int i = 1; i <= table.Rows.Count; i++)
            {
                table.Rows[i - 1]["TT"] = i;

            }
            dgv.DataSource = table;
        }

        internal static void hienthi(DataGridView dgvLop, string v)
        {
            SqlCommand con = new SqlCommand(v, Con);
            SqlDataReader drd = con.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(drd);
            table.Columns.Add("TT");
            for (int i = 1; i <= table.Rows.Count; i++)
            {
                table.Rows[i - 1]["TT"] = i;

            }
            dgvLop.DataSource = table;
        }

        internal static void hienthisv(DataGridView dgvSv, string v)
        {
            SqlCommand con = new SqlCommand(v, Con);
            SqlDataReader drd = con.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(drd);
            tbl.Columns.Add("TT");
            for (int i = 1; i <= tbl.Rows.Count; i++)
            {
                tbl.Rows[i - 1]["TT"] = i;

            }
            dgvSv.DataSource = tbl;
        }

        internal static void loadComboBox(ComboBox cmb, string s)
        {

            cmb.Items.Clear();
            SqlCommand command = new SqlCommand(s, Con);
            SqlDataReader drd = command.ExecuteReader();
            while (drd.Read()) cmb.Items.Add(drd[0]);
            cmb.SelectedIndex = 0;
            drd.Close();

        }
    }
}
