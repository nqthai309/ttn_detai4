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
    public partial class MainForm : Form
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
        public MainForm()
        {
            InitializeComponent();
            init();
        }
        

        private void init()
        {

            btnNhanVienQuanLy.Enabled = false;

            txtHoTen.Text = FormLogin.ten;
            txtNVQL.Text = FormLogin.NVQL;
            txtSoDienThoai.Text = FormLogin.phone;
            txtTuoi.Text = FormLogin.ngaySinh;
            if (FormLogin.role_id.Equals("0"))
            {
                txtViTri.Text = "Quản Lý";
                btnNhanVienQuanLy.Enabled = true;
            }
            else
            {
                txtViTri.Text = "Nhân Viên";
            }

            this.IsMdiContainer = true;
        }
        private void AddForm(Form f)
        {
            f.MdiParent = this;
            groupBoxView.Controls.Add(f);
            f.Show();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f = new FormLogin();
            f.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnThemHangHoa_Click(object sender, EventArgs e)
        {
            groupBoxView.Controls.Clear();
            ThemMoiMatHangForm f = new ThemMoiMatHangForm();
            AddForm(f);
        }

        private void BtnTraHangHoa_Click(object sender, EventArgs e)
        {
            groupBoxView.Controls.Clear();
            NhapXuatForm f = new NhapXuatForm();
            AddForm(f);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            groupBoxView.Controls.Clear();
            TimKiemForm f = new TimKiemForm();
            AddForm(f);
        }

        private void BtnThongKe_Click(object sender, EventArgs e)
        {
            groupBoxView.Controls.Clear();
            ThongKeForm f = new ThongKeForm();
            AddForm(f);
        }

        private void BtnNhanVienQuanLy_Click(object sender, EventArgs e)
        {
            groupBoxView.Controls.Clear();
            QuanLyNhanVienForm f = new QuanLyNhanVienForm();
            AddForm(f);
        }
    }
}
