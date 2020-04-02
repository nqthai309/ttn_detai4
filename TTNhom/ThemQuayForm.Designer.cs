namespace TTNhom
{
    partial class ThemQuayForm
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
            this.txtTenQuay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemQuay = new System.Windows.Forms.Button();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtTenQuay
            // 
            this.txtTenQuay.Location = new System.Drawing.Point(111, 32);
            this.txtTenQuay.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenQuay.Name = "txtTenQuay";
            this.txtTenQuay.Size = new System.Drawing.Size(166, 20);
            this.txtTenQuay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ten Quay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MaNV";
            // 
            // btnThemQuay
            // 
            this.btnThemQuay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemQuay.Location = new System.Drawing.Point(72, 114);
            this.btnThemQuay.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemQuay.Name = "btnThemQuay";
            this.btnThemQuay.Size = new System.Drawing.Size(147, 36);
            this.btnThemQuay.TabIndex = 4;
            this.btnThemQuay.Text = "Thêm Quầy";
            this.btnThemQuay.UseVisualStyleBackColor = true;
            this.btnThemQuay.Click += new System.EventHandler(this.btnThemQuay_Click);
            // 
            // cbMaNV
            // 
            this.cbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(111, 72);
            this.cbMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(166, 21);
            this.cbMaNV.TabIndex = 5;
            // 
            // ThemQuayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 161);
            this.Controls.Add(this.cbMaNV);
            this.Controls.Add(this.btnThemQuay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenQuay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ThemQuayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemQuayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenQuay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemQuay;
        private System.Windows.Forms.ComboBox cbMaNV;
    }
}