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
            this.txtTenQuay.Location = new System.Drawing.Point(175, 39);
            this.txtTenQuay.Name = "txtTenQuay";
            this.txtTenQuay.Size = new System.Drawing.Size(220, 22);
            this.txtTenQuay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ten Quay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "MaNV";
            // 
            // btnThemQuay
            // 
            this.btnThemQuay.Location = new System.Drawing.Point(219, 151);
            this.btnThemQuay.Name = "btnThemQuay";
            this.btnThemQuay.Size = new System.Drawing.Size(104, 23);
            this.btnThemQuay.TabIndex = 4;
            this.btnThemQuay.Text = "Thêm Quầy";
            this.btnThemQuay.UseVisualStyleBackColor = true;
            this.btnThemQuay.Click += new System.EventHandler(this.btnThemQuay_Click);
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(175, 89);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(220, 24);
            this.cbMaNV.TabIndex = 5;
            // 
            // ThemQuayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 198);
            this.Controls.Add(this.cbMaNV);
            this.Controls.Add(this.btnThemQuay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenQuay);
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