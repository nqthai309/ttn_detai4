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
    public partial class QuanLyNhanVienForm : Form
    {
        DBAccess access = new DBAccess();
        DataTable table;

        //private static string strConn = "Data Source=MAYTINH-JCRJIC4;Initial Catalog=TTCSDL;Integrated Security=True";
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();

        string taiKhoan;
        string ten;
        string tuoi;
        string gioiTinh;
        string thanhPho;
        string luong;
        string sdt;
        string nvql;
        string quyenHan;
        string matKhau;
        string manv;
        public QuanLyNhanVienForm()
        {
            InitializeComponent();
            comboBoxColumn.SelectedItem = comboBoxColumn.Items[0];
        }
        private void GetData(string query, DataGridView grid, DataTable table)
        {
            access.createConn();
            adt = new SqlDataAdapter(query, conn);
            adt.Fill(table);
            grid.DataSource = table;
            conn.Close();
        }
        private bool CheckTaiKhoan(string query, DataTable table)
        {
            access.readDataToAdapter(query, table);
            int a = table.Rows.Count;
            if (a != 0)
            {
                MessageBox.Show("Tài Khoản đã bị trùng với người khác, Vui lòng sử dụng tên tài khoản khác!");
                return false;
            }
            return true;
        }
        private bool CheckThieuThongTin()
        {
            taiKhoan = txtTaiKhoanNVQL.Text;
            ten = txtTenNVQL.Text;
            tuoi = txtTuoiNVQL.Text;
            gioiTinh = txtGioiTinhNVQL.Text;
            thanhPho = txtThanhPhoNVQL.Text;
            luong = txtLuongNVQL.Text;
            sdt = txtSdtNVQL.Text;
            nvql = txtNvqlNVQL.Text;
            quyenHan = txtQuyenHanNVQL.Text;
            matKhau = txtMatKhauNVQL.Text;

            if (taiKhoan.Equals("") || ten.Equals("") || tuoi.Equals("") || gioiTinh.Equals("") || thanhPho.Equals("")
                || luong.Equals("") || sdt.Equals("") || quyenHan.Equals("") || matKhau.Equals(""))
            {
                MessageBox.Show("Thiếu thông tin !!");
                return true;
            }
            return false;
        }

        private void BtnSearchQLNV_Click(object sender, EventArgs e)
        {
            conn.Open();
            string key = txtSearchQLNV.Text.Trim();
            if (key.Equals(""))
            {
                table = new DataTable();
                GetData("select * from NhanVien where NVQL = N'"+FormLogin.ten+"'", gridView2, table);
            }
            else
            {
                string query = "SELECT * FROM dbo.NhanVien WHERE (TenNhanVien LIKE N'%" + key + "%' or ThanhPho LIKE N'%" + key + "%' or NVQL LIKE N'%" + key + "%' or TaiKhoan LIKE '%" + key + "%') AND NVQL = N'"+FormLogin.ten+"'";
                table = new DataTable();
                GetData(query, gridView2, table);
            }
        }

        private void GridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectRow = gridView2.Rows[index];
                txtTenNVQL.Text = selectRow.Cells[1].Value.ToString().Trim();
                txtTuoiNVQL.Text = selectRow.Cells[2].Value.ToString().Trim();
                txtGioiTinhNVQL.Text = selectRow.Cells[3].Value.ToString().Trim();
                txtThanhPhoNVQL.Text = selectRow.Cells[4].Value.ToString().Trim();
                txtLuongNVQL.Text = selectRow.Cells[5].Value.ToString().Trim();
                txtSdtNVQL.Text = selectRow.Cells[6].Value.ToString().Trim();
                txtNvqlNVQL.Text = selectRow.Cells[7].Value.ToString().Trim();
                txtQuyenHanNVQL.Text = selectRow.Cells[8].Value.ToString().Trim();
                txtTaiKhoanNVQL.Text = selectRow.Cells[9].Value.ToString().Trim();
                txtMatKhauNVQL.Text = selectRow.Cells[10].Value.ToString().Trim();

                manv = selectRow.Cells[0].Value.ToString().Trim();
            }
            catch
            {

            }
        }

        private void BtnThemQLNV_Click(object sender, EventArgs e)
        {
            if (CheckThieuThongTin() == false)
            {
                table = new DataTable();
                string query = "select * from NhanVien where TaiKhoan = N'" + taiKhoan + "'";
                if (CheckTaiKhoan(query, table) == true)
                {
                    conn.Open();
                    string queryInsert = "Insert INTO NhanVien VALUES( N'" + ten + "' , " + int.Parse(tuoi) + " ,'" + gioiTinh + "' ,N'" + thanhPho + "' , " + int.Parse(luong) + " , '" + sdt + "' , N'" + nvql + "' ," + int.Parse(quyenHan) + " ,N'" + taiKhoan + "' ,N'" + matKhau + "' )";
                    GetData(queryInsert, gridView2, table);
                    GetData("select * from NhanVien", gridView2, table);
                }
            }
        }

        private void BtnXoaQLNV_Click(object sender, EventArgs e)
        {
            if (CheckThieuThongTin() == false)
            {
                table = new DataTable();
                string queryDelete = "delete NhanVien where TaiKhoan = N'" + taiKhoan + "' ";
                GetData(queryDelete, gridView2, table);
                GetData("select * from NhanVien", gridView2, table);
            }
        }

        private void BtnSuaQLNV_Click(object sender, EventArgs e)
        {
            if (CheckThieuThongTin() == false)
            {
                table = new DataTable();
                string query = "select * from NhanVien where TaiKhoan = N'" + taiKhoan + "'";
                if (CheckTaiKhoan(query, table) == true)
                {
                    string queryUpdate = "update NhanVien set TenNhanVien = N'" + ten + "', Tuoi = " + int.Parse(tuoi) + ", Sex = '" + gioiTinh + "'," +
                        "Thanhpho = N'" + thanhPho + "', Luong = " + int.Parse(luong) + ", SoDienThoai = '" + sdt + "', NVQL = N'" + nvql + "', Role_id = " + int.Parse(quyenHan) + "," +
                        "TaiKhoan = N'" + taiKhoan + "', MatKhau = N'" + matKhau + "' where MaNhanVien = " + int.Parse(manv) + " ";
                    GetData(queryUpdate, gridView2, table);
                    GetData("select * from NhanVien", gridView2, table);
                }
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtSearchQLNV_TextChanged(object sender, EventArgs e)
        {
            table = new DataTable();
            string key = comboBoxColumn.Text;
            string keySearch = txtSearchQLNV.Text;
            switch (key)
            {
                case ("Mã Nhân Viên"):
                    {
                        GetData("select * from NhanVien where (MaNhanVien like '%" + keySearch + "%') AND NVQL = N'" + FormLogin.ten + "'", gridView2, table);
                        break;
                    }
                case ("Tên Nhân Viên"):
                    {
                        GetData("select * from NhanVien where (TenNhanVien like '%" + keySearch + "%') AND NVQL = N'" + FormLogin.ten + "' ", gridView2, table);
                        break;
                    }
                case ("Tuổi"):
                    {
                        GetData("select * from NhanVien where (Tuoi like '%" + keySearch + "%') AND NVQL = N'" + FormLogin.ten + "'", gridView2, table);
                        break;
                    }
                case ("Giới Tính"):
                    {
                        GetData("select * from NhanVien where (Sex like '%" + keySearch + "%') AND NVQL = N'" + FormLogin.ten + "'", gridView2, table);
                        break;
                    }
                case ("Thành Phố"):
                    {
                        GetData("select * from NhanVien where (ThanhPho like '%" + keySearch + "%') AND NVQL = N'" + FormLogin.ten + "'", gridView2, table);
                        break;
                    }
                case ("SĐT"):
                    {
                        GetData("select * from NhanVien where (SoDienThoai like '%" + keySearch + "%') AND NVQL = N'" + FormLogin.ten + "'", gridView2, table);
                        break;
                    }
                case ("Tài Khoản"):
                    {
                        GetData("select * from NhanVien where (TaiKhoan like '%" + keySearch + "%') AND NVQL = N'" + FormLogin.ten + "'", gridView2, table);
                        break;
                    }
                
            }
            if (keySearch == "")
            {
                GetData("select * from NhanVien where NVQL = N'" + FormLogin.ten + "'", gridView2, table);
            }
            
        }

        private void QuanLyNhanVienForm_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            GetData("select * from NhanVien where NVQL = N'" + FormLogin.ten + "'", gridView2, table);
        }
    }
}
