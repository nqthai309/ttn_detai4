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
    public partial class ThemNCCForm : Form
    {
        DBAccess access = new DBAccess();
        DataTable table;

        //private static string strConn = "Data Source=MAYTINH-JCRJIC4;Initial Catalog=TTCSDL;Integrated Security=True";
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        public ThemNCCForm()
        {

            InitializeComponent();
        }
      
        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            string tenNCC, phuong, quan, thanhPho;
            tenNCC = txtTenNCC.Text;
            phuong = txtPhuong.Text;
            quan = txtQuan.Text;
            thanhPho = txtThanhPho.Text;
            if (tenNCC.Equals("") || phuong.Equals("") || quan.Equals("") || thanhPho.Equals(""))
            {
                MessageBox.Show("Thieu thong tin");

            }
            else
            {
                conn.Open();
                string queryInsert = "  INSERT dbo.NhaCungCap( TenNCC, Phuong, Quan, ThanhPho ) VALUES  ( N'" + tenNCC + "',N'" + phuong + "', N'" + quan + "', N'" + thanhPho + "')";
                cmd = new SqlCommand(queryInsert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Them Thanh Cong");
            }

        }
    }
}
