namespace TTNhom
{
    partial class FormAddLoaiHangMoi
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
            this.buttonThemMoiLoaiHang = new System.Windows.Forms.Button();
            this.textBoxThemLoaiHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonThemMoiLoaiHang
            // 
            this.buttonThemMoiLoaiHang.Location = new System.Drawing.Point(293, 16);
            this.buttonThemMoiLoaiHang.Name = "buttonThemMoiLoaiHang";
            this.buttonThemMoiLoaiHang.Size = new System.Drawing.Size(93, 23);
            this.buttonThemMoiLoaiHang.TabIndex = 8;
            this.buttonThemMoiLoaiHang.Text = "Thêm Mới";
            this.buttonThemMoiLoaiHang.UseVisualStyleBackColor = true;
            this.buttonThemMoiLoaiHang.Click += new System.EventHandler(this.buttonThemMoiLoaiHang_Click);
            // 
            // textBoxThemLoaiHang
            // 
            this.textBoxThemLoaiHang.Location = new System.Drawing.Point(124, 18);
            this.textBoxThemLoaiHang.Name = "textBoxThemLoaiHang";
            this.textBoxThemLoaiHang.Size = new System.Drawing.Size(154, 20);
            this.textBoxThemLoaiHang.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên Loại Hàng Mới";
            // 
            // FormAddLoaiHangMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 54);
            this.Controls.Add(this.buttonThemMoiLoaiHang);
            this.Controls.Add(this.textBoxThemLoaiHang);
            this.Controls.Add(this.label1);
            this.Name = "FormAddLoaiHangMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddLoaiHangMoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThemMoiLoaiHang;
        private System.Windows.Forms.TextBox textBoxThemLoaiHang;
        private System.Windows.Forms.Label label1;
    }
}