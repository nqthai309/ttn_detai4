namespace TTNhom
{
    partial class ThongKeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabHangHoa = new System.Windows.Forms.TabPage();
            this.dataGridViewHH = new System.Windows.Forms.DataGridView();
            this.tabQuay = new System.Windows.Forms.TabPage();
            this.tabNhapXuat = new System.Windows.Forms.TabPage();
            this.tabControl2.SuspendLayout();
            this.tabHangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHH)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabHangHoa);
            this.tabControl2.Controls.Add(this.tabQuay);
            this.tabControl2.Controls.Add(this.tabNhapXuat);
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(711, 435);
            this.tabControl2.TabIndex = 1;
            // 
            // tabHangHoa
            // 
            this.tabHangHoa.Controls.Add(this.dataGridViewHH);
            this.tabHangHoa.Location = new System.Drawing.Point(4, 22);
            this.tabHangHoa.Name = "tabHangHoa";
            this.tabHangHoa.Padding = new System.Windows.Forms.Padding(3);
            this.tabHangHoa.Size = new System.Drawing.Size(703, 409);
            this.tabHangHoa.TabIndex = 0;
            this.tabHangHoa.Text = "Hàng Hóa";
            this.tabHangHoa.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHH
            // 
            this.dataGridViewHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHH.Location = new System.Drawing.Point(0, 3);
            this.dataGridViewHH.Name = "dataGridViewHH";
            this.dataGridViewHH.Size = new System.Drawing.Size(700, 240);
            this.dataGridViewHH.TabIndex = 0;
            // 
            // tabQuay
            // 
            this.tabQuay.Location = new System.Drawing.Point(4, 22);
            this.tabQuay.Name = "tabQuay";
            this.tabQuay.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuay.Size = new System.Drawing.Size(703, 409);
            this.tabQuay.TabIndex = 2;
            this.tabQuay.Text = "Quầy";
            this.tabQuay.UseVisualStyleBackColor = true;
            // 
            // tabNhapXuat
            // 
            this.tabNhapXuat.Location = new System.Drawing.Point(4, 22);
            this.tabNhapXuat.Name = "tabNhapXuat";
            this.tabNhapXuat.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhapXuat.Size = new System.Drawing.Size(703, 409);
            this.tabNhapXuat.TabIndex = 1;
            this.tabNhapXuat.Text = "Lưu lượng Nhập Xuất";
            this.tabNhapXuat.UseVisualStyleBackColor = true;
            // 
            // ThongKeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 448);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeForm";
            this.Text = "ThongKeForm";
            this.tabControl2.ResumeLayout(false);
            this.tabHangHoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabHangHoa;
        private System.Windows.Forms.DataGridView dataGridViewHH;
        private System.Windows.Forms.TabPage tabQuay;
        private System.Windows.Forms.TabPage tabNhapXuat;
    }
}