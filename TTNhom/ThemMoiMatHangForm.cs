using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTNhom
{
    public partial class ThemMoiMatHangForm : Form
    {
        DBAccess access = new DBAccess();
        DataTable table;

        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        string variable;

        public object FormAddLoaiHangMoi { get; private set; }

        public ThemMoiMatHangForm()
        {
            InitializeComponent();
            addData();
        }

        private void addComboBox(SqlConnection conn, SqlCommand cmd, List<string> list, string tenCot, string tenTable, ComboBox cb)
        {
            conn.Open();
            cmd = new SqlCommand("Select " + tenCot + " FROM " + tenTable, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(dr.GetString(0));
            }
            cb.DataSource = list;
            conn.Close();
        }

        private string queryID(SqlCommand sql, string colomn, string table, string dieuKien, string ndDieuKien)
        {
            conn.Open();

            cmd = new SqlCommand("SELECT " + colomn + " FROM " + table + " WHERE " + dieuKien + " = N'" + ndDieuKien + "'  ", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                variable = dr.GetInt32(0).ToString();
            }
            conn.Close();
            return variable;
        }

        private void addData()
        {
            List<string> listTenLoaiHang = new List<string>();
            List<string> listTenQuay = new List<string>();
            addComboBox(conn, cmd, listTenQuay, "TenQuay", "Quay", comboBoxTenQuay);
            addComboBox(conn, cmd, listTenLoaiHang, "TenLoaiHang", "LoaiHang", comboBoxTenLoaiHang);
        }
        private void comboBoxTenLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            table = new DataTable();
        }

        private void comboBoxTenQuay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string tenMatHang, tenQuay, tenLoaiHang;
            tenMatHang = textBoxTenMatHang.Text;
            tenQuay = comboBoxTenQuay.Text;
            tenLoaiHang = comboBoxTenLoaiHang.Text;
            if (tenMatHang.Equals(""))
            {
                MessageBox.Show("Nhap Thieu Thong Tin");
            }
            else
            {
                string maQuay, maLoaiHang;
                maQuay = queryID(cmd, "MaQuay", "Quay", "TenQuay", tenQuay);
                maLoaiHang = queryID(cmd, "MaLoaiHang", "LoaiHang", "TenLoaiHang", tenLoaiHang);

                conn.Open();
                string queryInsert = "INSERT dbo.MatHang ( MaQuay, MaLoaiHang, TenMatHang ) VALUES  ( " + int.Parse(maQuay) + ", " + int.Parse(maLoaiHang) + ", N'" + tenMatHang + "')";
                cmd = new SqlCommand(queryInsert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm mặt hàng thành công");
            }
        }

        private void pictureBoxThemLoaiHang_Click(object sender, EventArgs e)
        {
            FormAddLoaiHangMoi formAddLoaiHangMoi = new FormAddLoaiHangMoi();
            formAddLoaiHangMoi.ShowDialog();
        }
    }
}
