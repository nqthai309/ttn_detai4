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
    public partial class FormLogin : Form
    {
        
        DBAccess dbAccess = new DBAccess();
        DataTable dt = new DataTable();

        //private static string strConn = "Data Source=MAYTINH-JCRJIC4;Initial Catalog=TTCSDL;Integrated Security=True";
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();

        public static string ten;
        public static string role_id;
        public static string ngaySinh;
        public static string phone;
        public static string NVQL;
        public static string TaiKhoan;
        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            TaiKhoan = txtUser.Text;
            string matKhau = MaHoa(txtPass.Text.Trim());
            if(txtUser.Text != "" || txtPass.Text != "")
            {
                string query = "SELECT * FROM dbo.NhanVien WHERE TaiKhoan = '" + txtUser.Text + "' AND MatKhau = '" + matKhau + "' ";
                dbAccess.readDataToAdapter(query, dt);
                int a = dt.Rows.Count;
                if (a != 0)
                {
                    this.Hide();
                    adt = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adt.Fill(table);

                    ten = table.Rows[0][1].ToString();
                    role_id = table.Rows[0][8].ToString();
                    ngaySinh = table.Rows[0][2].ToString();
                    phone = table.Rows[0][6].ToString();
                    NVQL = table.Rows[0][7].ToString();

                    MainForm main = new MainForm();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Tài Khoản hoặc Mật Khẩu không đúng !! Vui Lòng thử lại.");
                    txtUser.Clear();
                    txtPass.Clear();
                    txtUser.Focus();
                }
            }
            else
            {
                MessageBox.Show("Thiếu Thông Tin!!!!");
            }
            


        }
        public static string MaHoa(string txt)
        {
            string str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }

        private void btnHuy_click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
