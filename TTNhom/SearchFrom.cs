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
    public partial class SearchFrom : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MAYTINH-JCRJIC4;Initial Catalog=TTCSDL;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable table;
        public SearchFrom()
        {
            InitializeComponent();
            getData(conn);
        }

        private void getData(SqlConnection sql)
        {
            conn.Open();
            adapter = new SqlDataAdapter("select * from MatHang", sql);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            
            string key = txtTimKiem.Text.Trim();
            if (key.Equals(""))
            {
                getData(conn);
            }
            else
            {
                conn.Open();
                adapter = new SqlDataAdapter("SELECT * FROM dbo.MatHang WHERE TenMatHang LIKE N'%" + key + "%'", conn);
                table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                conn.Close();
            }

        }
    }
}
