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
            this.dataGridViewQuay = new System.Windows.Forms.DataGridView();
            this.tabNhapXuat = new System.Windows.Forms.TabPage();
            this.dataGridViewNhap = new System.Windows.Forms.DataGridView();
            this.buttonTK = new System.Windows.Forms.Button();
            this.buttonQ = new System.Windows.Forms.Button();
            this.buttonLL = new System.Windows.Forms.Button();
            this.dataGridViewXuat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTongSl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNhap = new System.Windows.Forms.Label();
            this.labelXuat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTLNhap = new System.Windows.Forms.Label();
            this.labelTLXuat = new System.Windows.Forms.Label();
            this.tabControl2.SuspendLayout();
            this.tabHangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHH)).BeginInit();
            this.tabQuay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuay)).BeginInit();
            this.tabNhapXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabHangHoa);
            this.tabControl2.Controls.Add(this.tabQuay);
            this.tabControl2.Controls.Add(this.tabNhapXuat);
            this.tabControl2.Location = new System.Drawing.Point(1, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(724, 442);
            this.tabControl2.TabIndex = 1;
            // 
            // tabHangHoa
            // 
            this.tabHangHoa.Controls.Add(this.labelTongSl);
            this.tabHangHoa.Controls.Add(this.label1);
            this.tabHangHoa.Controls.Add(this.buttonTK);
            this.tabHangHoa.Controls.Add(this.dataGridViewHH);
            this.tabHangHoa.Location = new System.Drawing.Point(4, 22);
            this.tabHangHoa.Name = "tabHangHoa";
            this.tabHangHoa.Padding = new System.Windows.Forms.Padding(3);
            this.tabHangHoa.Size = new System.Drawing.Size(716, 416);
            this.tabHangHoa.TabIndex = 0;
            this.tabHangHoa.Text = "Hàng Hóa";
            this.tabHangHoa.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHH
            // 
            this.dataGridViewHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHH.Location = new System.Drawing.Point(137, 3);
            this.dataGridViewHH.Name = "dataGridViewHH";
            this.dataGridViewHH.Size = new System.Drawing.Size(456, 197);
            this.dataGridViewHH.TabIndex = 0;
            // 
            // tabQuay
            // 
            this.tabQuay.Controls.Add(this.buttonQ);
            this.tabQuay.Controls.Add(this.dataGridViewQuay);
            this.tabQuay.Location = new System.Drawing.Point(4, 22);
            this.tabQuay.Name = "tabQuay";
            this.tabQuay.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuay.Size = new System.Drawing.Size(716, 416);
            this.tabQuay.TabIndex = 2;
            this.tabQuay.Text = "Quầy";
            this.tabQuay.UseVisualStyleBackColor = true;
            // 
            // dataGridViewQuay
            // 
            this.dataGridViewQuay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuay.Location = new System.Drawing.Point(157, 3);
            this.dataGridViewQuay.Name = "dataGridViewQuay";
            this.dataGridViewQuay.Size = new System.Drawing.Size(405, 195);
            this.dataGridViewQuay.TabIndex = 0;
            // 
            // tabNhapXuat
            // 
            this.tabNhapXuat.Controls.Add(this.labelTLXuat);
            this.tabNhapXuat.Controls.Add(this.labelTLNhap);
            this.tabNhapXuat.Controls.Add(this.label5);
            this.tabNhapXuat.Controls.Add(this.label4);
            this.tabNhapXuat.Controls.Add(this.labelXuat);
            this.tabNhapXuat.Controls.Add(this.labelNhap);
            this.tabNhapXuat.Controls.Add(this.label3);
            this.tabNhapXuat.Controls.Add(this.label2);
            this.tabNhapXuat.Controls.Add(this.dataGridViewXuat);
            this.tabNhapXuat.Controls.Add(this.buttonLL);
            this.tabNhapXuat.Controls.Add(this.dataGridViewNhap);
            this.tabNhapXuat.Location = new System.Drawing.Point(4, 22);
            this.tabNhapXuat.Name = "tabNhapXuat";
            this.tabNhapXuat.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhapXuat.Size = new System.Drawing.Size(716, 416);
            this.tabNhapXuat.TabIndex = 1;
            this.tabNhapXuat.Text = "Lưu lượng Nhập Xuất";
            this.tabNhapXuat.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNhap
            // 
            this.dataGridViewNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhap.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewNhap.Name = "dataGridViewNhap";
            this.dataGridViewNhap.Size = new System.Drawing.Size(340, 197);
            this.dataGridViewNhap.TabIndex = 0;
            // 
            // buttonTK
            // 
            this.buttonTK.Location = new System.Drawing.Point(322, 375);
            this.buttonTK.Name = "buttonTK";
            this.buttonTK.Size = new System.Drawing.Size(75, 35);
            this.buttonTK.TabIndex = 2;
            this.buttonTK.Text = "XEM";
            this.buttonTK.UseVisualStyleBackColor = true;
            this.buttonTK.Click += new System.EventHandler(this.buttonTK_Click);
            // 
            // buttonQ
            // 
            this.buttonQ.Location = new System.Drawing.Point(326, 375);
            this.buttonQ.Name = "buttonQ";
            this.buttonQ.Size = new System.Drawing.Size(75, 35);
            this.buttonQ.TabIndex = 3;
            this.buttonQ.Text = "XEM";
            this.buttonQ.UseVisualStyleBackColor = true;
            this.buttonQ.Click += new System.EventHandler(this.buttonQ_Click);
            // 
            // buttonLL
            // 
            this.buttonLL.Location = new System.Drawing.Point(321, 375);
            this.buttonLL.Name = "buttonLL";
            this.buttonLL.Size = new System.Drawing.Size(75, 35);
            this.buttonLL.TabIndex = 3;
            this.buttonLL.Text = "XEM";
            this.buttonLL.UseVisualStyleBackColor = true;
            this.buttonLL.Click += new System.EventHandler(this.buttonLL_Click);
            // 
            // dataGridViewXuat
            // 
            this.dataGridViewXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXuat.Location = new System.Drawing.Point(373, 3);
            this.dataGridViewXuat.Name = "dataGridViewXuat";
            this.dataGridViewXuat.Size = new System.Drawing.Size(340, 197);
            this.dataGridViewXuat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng số lượng Hàng hóa trong Kho : ";
            // 
            // labelTongSl
            // 
            this.labelTongSl.AutoSize = true;
            this.labelTongSl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongSl.Location = new System.Drawing.Point(459, 218);
            this.labelTongSl.Name = "labelTongSl";
            this.labelTongSl.Size = new System.Drawing.Size(39, 20);
            this.labelTongSl.TabIndex = 4;
            this.labelTongSl.Text = ". . . ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số lượng hàng Nhập : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng hàng Xuất : ";
            // 
            // labelNhap
            // 
            this.labelNhap.AutoSize = true;
            this.labelNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhap.Location = new System.Drawing.Point(201, 220);
            this.labelNhap.Name = "labelNhap";
            this.labelNhap.Size = new System.Drawing.Size(39, 20);
            this.labelNhap.TabIndex = 7;
            this.labelNhap.Text = ". . . ";
            // 
            // labelXuat
            // 
            this.labelXuat.AutoSize = true;
            this.labelXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXuat.Location = new System.Drawing.Point(577, 220);
            this.labelXuat.Name = "labelXuat";
            this.labelXuat.Size = new System.Drawing.Size(39, 20);
            this.labelXuat.TabIndex = 8;
            this.labelXuat.Text = ". . . ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tỷ Lệ Nhập : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tỷ Lệ Xuất : ";
            // 
            // labelTLNhap
            // 
            this.labelTLNhap.AutoSize = true;
            this.labelTLNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTLNhap.Location = new System.Drawing.Point(172, 253);
            this.labelTLNhap.Name = "labelTLNhap";
            this.labelTLNhap.Size = new System.Drawing.Size(39, 20);
            this.labelTLNhap.TabIndex = 11;
            this.labelTLNhap.Text = ". . . ";
            // 
            // labelTLXuat
            // 
            this.labelTLXuat.AutoSize = true;
            this.labelTLXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTLXuat.Location = new System.Drawing.Point(532, 253);
            this.labelTLXuat.Name = "labelTLXuat";
            this.labelTLXuat.Size = new System.Drawing.Size(39, 20);
            this.labelTLXuat.TabIndex = 12;
            this.labelTLXuat.Text = ". . . ";
            // 
            // ThongKeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 442);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeForm";
            this.Text = "ThongKeForm";
            this.tabControl2.ResumeLayout(false);
            this.tabHangHoa.ResumeLayout(false);
            this.tabHangHoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHH)).EndInit();
            this.tabQuay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuay)).EndInit();
            this.tabNhapXuat.ResumeLayout(false);
            this.tabNhapXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabHangHoa;
        private System.Windows.Forms.DataGridView dataGridViewHH;
        private System.Windows.Forms.TabPage tabQuay;
        private System.Windows.Forms.TabPage tabNhapXuat;
        private System.Windows.Forms.DataGridView dataGridViewQuay;
        private System.Windows.Forms.DataGridView dataGridViewNhap;
        private System.Windows.Forms.Button buttonTK;
        private System.Windows.Forms.Button buttonQ;
        private System.Windows.Forms.Button buttonLL;
        private System.Windows.Forms.DataGridView dataGridViewXuat;
        private System.Windows.Forms.Label labelTongSl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNhap;
        private System.Windows.Forms.Label labelXuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTLXuat;
        private System.Windows.Forms.Label labelTLNhap;
    }
}