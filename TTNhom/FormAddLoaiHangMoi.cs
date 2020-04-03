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

namespace TTNhom {
    public partial class FormAddLoaiHangMoi : Form {
        DBAccess access = new DBAccess();

        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlCommand cmd;
        public FormAddLoaiHangMoi() {
            InitializeComponent();
        }

        private void buttonThemMoiLoaiHang_Click(object sender , EventArgs e) {
            string tenLoaiHang;
            tenLoaiHang = textBoxThemLoaiHang.Text;
            conn.Open();
            cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.LoaiHang WHERE TenLoaiHang=N'" + tenLoaiHang + "' " , conn);
            int records = (int) cmd.ExecuteScalar();
            if(tenLoaiHang.Equals("")) {
                MessageBox.Show("Vui lòng nhập tên loại hàng mới!");
            }
            else {
                if(records == 0) {
                    try {
                        string queryInsert = "INSERT dbo.LoaiHang ( TenLoaiHang  ) VALUES  (N'" + tenLoaiHang + "')";
                        cmd = new SqlCommand(queryInsert , conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm loại hàng thành công");
                        Close();
                    }
                    catch(Exception ex) { MessageBox.Show(ex.Message); }
                }

                else {
                    MessageBox.Show("Tên loại hàng " + tenLoaiHang + " đã tồn tại!");

                }
            }
            conn.Close();

        }

    }
}
