namespace TTNhom
{
    partial class FormAddLoaiHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxThemLoaiHang = new System.Windows.Forms.TextBox();
            this.buttonThemMoiLoaiHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Loại Hàng Mới";
            // 
            // textBoxThemLoaiHang
            // 
            this.textBoxThemLoaiHang.Location = new System.Drawing.Point(117, 20);
            this.textBoxThemLoaiHang.Name = "textBoxThemLoaiHang";
            this.textBoxThemLoaiHang.Size = new System.Drawing.Size(154, 20);
            this.textBoxThemLoaiHang.TabIndex = 1;
            // 
            // buttonThemMoiLoaiHang
            // 
            this.buttonThemMoiLoaiHang.Location = new System.Drawing.Point(286, 18);
            this.buttonThemMoiLoaiHang.Name = "buttonThemMoiLoaiHang";
            this.buttonThemMoiLoaiHang.Size = new System.Drawing.Size(93, 23);
            this.buttonThemMoiLoaiHang.TabIndex = 2;
            this.buttonThemMoiLoaiHang.Text = "Thêm Mới";
            this.buttonThemMoiLoaiHang.UseVisualStyleBackColor = true;
            this.buttonThemMoiLoaiHang.Click += new System.EventHandler(this.buttonThemMoiLoaiHang_Click);
            // 
            // FormAddLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 54);
            this.Controls.Add(this.buttonThemMoiLoaiHang);
            this.Controls.Add(this.textBoxThemLoaiHang);
            this.Controls.Add(this.label1);
            this.Name = "FormAddLoaiHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FromAddLoaiHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxThemLoaiHang;
        private System.Windows.Forms.Button buttonThemMoiLoaiHang;
    }
}