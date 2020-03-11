using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTNhom
{
    public partial class ThemMoiMatHangForm : Form
    {
        public ThemMoiMatHangForm()
        {
            InitializeComponent();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            FromAddLoaiHang f = new FromAddLoaiHang();
            f.Show();
        }
    }
}
