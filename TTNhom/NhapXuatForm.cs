using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTNhom
{
    public partial class NhapXuatForm : Form
    {
        DBAccess access = new DBAccess();
        DataTable table;

        //private static string strConn = "Data Source=MAYTINH-JCRJIC4;Initial Catalog=TTCSDL;Integrated Security=True";
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        string variable;
        //string maNV, maNCC, maMH;

        public NhapXuatForm()
        {
            InitializeComponent();
            addData();
            
        }
        private void addComboBox(SqlConnection conn,SqlCommand cmd, List<string> list, string tenCot, string tenTable, ComboBox cb)
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

        private void addData()
        {
            List<string> listNCC = new List<string>();
            List<string> listMH = new List<string>();
            List<string> listTenQuay = new List<string>();
            List<string> listMH1 = new List<string>();
            addComboBox(conn, cmd, listTenQuay, "TenQuay", "Quay", cbTenQuay);
            addComboBox(conn, cmd, listNCC, "TenNCC", "NhaCungCap", cbNCC);
            addComboBox(conn, cmd, listMH, "TenMatHang", "MatHang", cbTenMatHang);
            addComboBox(conn, cmd, listMH1, "TenMatHang", "MatHang", cbTenMatHang2);
            txtTenNV.Text = FormLogin.ten;
            txtTenNV.Enabled = false;
            txtTenNV2.Text = FormLogin.ten;
            txtTenNV2.Enabled = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ThemNCCForm f = new ThemNCCForm();
            f.Show();
        }
        private string queryID(SqlCommand sql, string colomn, string table, string dieuKien, string ndDieuKien)
        {
            conn.Open();
           
            cmd = new SqlCommand("SELECT "+colomn+" FROM "+table+" WHERE "+dieuKien+" = N'"+ndDieuKien+"'  ", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                variable = dr.GetInt32(0).ToString();
            }
            conn.Close();
            return variable;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ThemQuayForm f = new ThemQuayForm();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tenQuay, thoiGian, tenNV, tenMH, soLuong;
            tenQuay = cbTenQuay.Text;
            thoiGian = dtThoiGian2.Value.ToString();
            tenMH = cbTenMatHang2.Text;
            soLuong = txtSoLuong2.Text;

            if(tenQuay.Equals("") || thoiGian.Equals("") || tenMH.Equals("") || soLuong.Equals(""))
            {
                MessageBox.Show("Nhap Thieu Thong Tin");
            }
            else
            {
                string maQuay, maNV, maMH;
                maQuay = queryID(cmd, "MaQuay", "Quay", "TenQuay", tenQuay);
             //   MessageBox.Show(maQuay);
                maNV = queryID(cmd, "MaNhanVien", "NhanVien", "TaiKhoan", FormLogin.TaiKhoan);
                maMH = queryID(cmd, "MaMatHang", "MatHang", "TenMatHang", tenMH);
                conn.Open();
                string queryInsert1 = "INSERT dbo.PhieuTra ( MaQuay, NgayTra, MaNhanVien ) VALUES  ( "+int.Parse(maQuay)+", '"+thoiGian+"', "+int.Parse(maNV)+")";
                cmd = new SqlCommand(queryInsert1, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if(i != 0){
                    conn.Open();
                    string queryInsert2 = "SELECT TOP 1 idPhieuTra FROM dbo.PhieuTra ORDER BY idPhieuTra DESC";
                    cmd = new SqlCommand(queryInsert2, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        variable = dr.GetInt32(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    string queryInsert3 = "INSERT dbo.Dong_PhieuTra ( idPhieuTra, MaMatHang, SoLuong ) VALUES  ( "+int.Parse(variable)+","+int.Parse(maMH)+","+int.Parse(soLuong)+")";
                    cmd = new SqlCommand(queryInsert3, conn);
                    int i2 = cmd.ExecuteNonQuery();
                    if(i != 0)
                    {
                        MessageBox.Show("Trả hàng về kho thành công");
                    }
                    conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenNCC, thoiGian, tenNV, tenMH, soLuong, donGia;
            tenNCC = cbNCC.Text;
            thoiGian = dtThoiGian1.Value.ToString();
            tenNV = txtTenNV.Text;
            tenMH = cbTenMatHang.Text;
            soLuong = txtSoLuong.Text;
            donGia = txtDonGia.Text;
            
            string maNV, maNCC, maMH;

            maNV = queryID(cmd, "MaNhanVien", "NhanVien", "TaiKhoan", FormLogin.TaiKhoan);
            maNCC = queryID(cmd, "MaNCC", "NhaCungCap", "TenNCC", tenNCC);
            maMH = queryID(cmd, "MaMatHang", "MatHang", "TenMatHang", tenMH);

           // MessageBox.Show(maNV+" "+maNCC+" "+maMH);



            if (tenNCC.Equals("") || thoiGian.Equals("") || tenNV.Equals("") || tenMH.Equals("") || soLuong.Equals("") || donGia.Equals(""))
            {
                MessageBox.Show("Thieu thong tin");

            }
            else
            {
                conn.Open();
                string queryInsert = "INSERT dbo.PhieuNhap( MaNCC, NgayCC, MaNhanVien ) VALUES  ( " + int.Parse(maNCC) + ",   '" + thoiGian + "',   " + int.Parse(maNV) + " )";
                cmd = new SqlCommand(queryInsert, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i != 0)
                {

                    conn.Open();
                    string queryInsert2 = "SELECT TOP 1 idPhieuNhap FROM dbo.PhieuNhap ORDER BY idPhieuNhap DESC";
                    cmd = new SqlCommand(queryInsert2, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                          variable = dr.GetInt32(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    string queryInsert3 = "INSERT dbo.Dong_PhieuNhap( idPhieuNhap ,MaMatHang ,SoLuong ,DonGia) VALUES  ( " + int.Parse(variable) + " , " + int.Parse(maMH) + " , " + int.Parse(soLuong) + " ,  " + int.Parse(donGia) + ")";
                    cmd = new SqlCommand(queryInsert3, conn);
                    int  i1 = cmd.ExecuteNonQuery();
                    if (i1 != 0)
                    {
                        MessageBox.Show("Them Thanh Cong");
                        conn.Close();
                    }
                    
                }
                
               
            }


        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            {

                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
            }


        }
    }
}
