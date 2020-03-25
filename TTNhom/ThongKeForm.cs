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
using Excel =  Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace TTNhom
{
    public partial class ThongKeForm : Form
    {
        DBAccess access = new DBAccess();
        DataTable table, table2;

        //private static string strConn = "Data Source=MAYTINH-JCRJIC4;Initial Catalog=TTCSDL;Integrated Security=True";
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        public ThongKeForm()
        {
            InitializeComponent();
        }
        private void GetData(string query, DataGridView grid, DataTable table)
        {
            access.createConn();
            adt = new SqlDataAdapter(query, conn);
            adt.Fill(table);
            grid.DataSource = table;
            conn.Close();
            
        }

        private void buttonTK_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            GetData("SELECT * FROM ThongKe_View", dataGridViewHH, table);

            int sc = dataGridViewHH.Rows.Count;
            float tongHH = 0;
            for (int i = 0; i < sc - 1; i++)
            {
                tongHH += float.Parse(dataGridViewHH.Rows[i].Cells[2].Value.ToString());
            }
            labelTongSl.Text = tongHH.ToString();
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            GetData("SELECT * FROM Quay", dataGridViewQuay, table);

        }

        private void xuatExcel(DataGridView g, string DuongDan, string tenFile)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i=1; i< g.Columns.Count +1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            //noi dung
            for(int i=0; i<g.Rows.Count; i++)
            {
                for(int j = 0; j < g.Columns.Count; j++)
                {
                    if(g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(DuongDan + tenFile + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        
        private void xuấtFileDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xuatExcel(dataGridViewHH, @"D:\", "thongKeHanghoa");
        }

        private void xuấtFileDữLiệuQuầyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xuatExcel(dataGridViewQuay, @"D:\", "thongKeQuay");
        }

        private void xuấtFileDữLiệuNhậpXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xuatExcel(dataGridViewNhap, @"D:\", "thongKeLuuLuongNhap");
            xuatExcel(dataGridViewXuat, @"D:\", "thongKeLuuLuongXuat");
        }

        private void buttonLL_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            table2 = new DataTable();
            GetData("SELECT * FROM Dong_PhieuNhap", dataGridViewNhap, table);
            GetData("SELECT * FROM Dong_PhieuTra", dataGridViewXuat, table2);

            int sc = dataGridViewNhap.Rows.Count;
            float tongNhap = 0;
            for (int i = 0; i < sc - 1; i++)
            {
                tongNhap += float.Parse(dataGridViewNhap.Rows[i].Cells[2].Value.ToString());
            }
            labelNhap.Text = tongNhap.ToString();

            int sc1 = dataGridViewXuat.Rows.Count;
            float tongXuat = 0;
            for (int i = 0; i < sc1 - 1; i++)
            {
                tongXuat += float.Parse(dataGridViewXuat.Rows[i].Cells[2].Value.ToString());
            }
            labelXuat.Text = tongXuat.ToString();

            //tong
            float tongNhapXuat = tongNhap + tongXuat;
            float tyleNhap = (float)tongNhap/tongNhapXuat, tyleXuat = (float)tongXuat/tongNhapXuat;

            labelTLNhap.Text = tyleNhap.ToString();
            labelTLXuat.Text = tyleXuat.ToString();
        }
    }
}
