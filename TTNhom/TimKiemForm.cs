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
    public partial class TimKiemForm : Form
    {
        DBAccess access = new DBAccess();
        DataTable table;

        //private static string strConn = "Data Source=DESKTOP-1NPLUNJ;Initial Catalog=TTCSDL;Integrated Security=True";
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();

        public TimKiemForm()
        {
            InitializeComponent();
        }

        public void createConn()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void GetData(string query, DataGridView grid, DataTable table)
        {
            access.createConn();
            adt = new SqlDataAdapter(query, conn);
            adt.Fill(table);
            grid.DataSource = table;
            conn.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            string key = txtTimKiem.Text.Trim();
            if (key.Equals(""))
            {
                GetData("SELECT * FROM MatHang_View", dataGridView1, table);
            }
            else
            {
                string query = "SELECT * FROM MatHang_View WHERE TenMatHang LIKE N'%" + key + "%'";
                GetData(query, dataGridView1, table);
            }
        }

        private void TimKiemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
