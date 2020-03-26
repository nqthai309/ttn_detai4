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
    public partial class ThemQuayForm : Form
    {
        //private static string strConn = "Data Source=MAYTINH-JCRJIC4;Initial Catalog=TTCSDL;Integrated Security=True";
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        public ThemQuayForm()
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
                list.Add(dr.GetInt32(0).ToString());
            }
            cb.DataSource = list;
            conn.Close();
        }
        private void addData()
        {
            List<string> listMaNV = new List<string>();
            addComboBox(conn, cmd, listMaNV, "MaNhanVien", "NhanVien", cbMaNV);
        }
        private void btnThemQuay_Click(object sender, EventArgs e)
        {
            string tenQuay, maNV;
            tenQuay = txtTenQuay.Text;
            maNV = cbMaNV.Text;
            if(tenQuay.Equals("") || maNV.Equals(""))
            {
                MessageBox.Show("Thiếu thông tin");
            }
            else
            {
                conn.Open();
                string queryInsert = "INSERT dbo.Quay ( TenQuay, MaNhanVien ) VALUES  ( N'"+tenQuay+"',"+maNV+")";
                cmd = new SqlCommand(queryInsert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Them thanh cong");

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
