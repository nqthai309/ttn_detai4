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
    public partial class FormAddLoaiHangMoi : Form
    {
        DBAccess access = new DBAccess();
        DataTable table;

        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        public FormAddLoaiHangMoi()
        {
            InitializeComponent();
        }

        private void buttonThemMoiLoaiHang_Click(object sender, EventArgs e)
        {
            string tenLoaiHang;
            tenLoaiHang = textBoxThemLoaiHang.Text;
            if (tenLoaiHang.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập tên loại hàng mới!");

            }
            else
            {
                conn.Open();
                string queryInsert = "INSERT dbo.LoaiHang ( TenLoaiHang  ) VALUES  (N'" + tenLoaiHang + "')";
                cmd = new SqlCommand(queryInsert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm loại hàng thành công");
                Close();
            }

        }
    }
}
