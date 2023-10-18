namespace QL_SinhVien
{
    partial class FormSinhVien
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
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Ho_Ten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Ma_SV = new System.Windows.Forms.TextBox();
            this.cbo_Ma_Lop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ngay_Sinh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(187, 133);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 22;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(106, 133);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 21;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(25, 133);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 20;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Họ tên";
            // 
            // txt_Ho_Ten
            // 
            this.txt_Ho_Ten.Location = new System.Drawing.Point(77, 72);
            this.txt_Ho_Ten.Name = "txt_Ho_Ten";
            this.txt_Ho_Ten.Size = new System.Drawing.Size(185, 20);
            this.txt_Ho_Ten.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã sv";
            // 
            // txt_Ma_SV
            // 
            this.txt_Ma_SV.Location = new System.Drawing.Point(77, 46);
            this.txt_Ma_SV.Name = "txt_Ma_SV";
            this.txt_Ma_SV.Size = new System.Drawing.Size(185, 20);
            this.txt_Ma_SV.TabIndex = 16;
            // 
            // cbo_Ma_Lop
            // 
            this.cbo_Ma_Lop.FormattingEnabled = true;
            this.cbo_Ma_Lop.Location = new System.Drawing.Point(77, 19);
            this.cbo_Ma_Lop.Name = "cbo_Ma_Lop";
            this.cbo_Ma_Lop.Size = new System.Drawing.Size(185, 21);
            this.cbo_Ma_Lop.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ngày sinh";
            // 
            // txt_Ngay_Sinh
            // 
            this.txt_Ngay_Sinh.Location = new System.Drawing.Point(77, 98);
            this.txt_Ngay_Sinh.Name = "txt_Ngay_Sinh";
            this.txt_Ngay_Sinh.Size = new System.Drawing.Size(185, 20);
            this.txt_Ngay_Sinh.TabIndex = 27;
            // 
            // SinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 169);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Ngay_Sinh);
            this.Controls.Add(this.cbo_Ma_Lop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Ho_Ten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Ma_SV);
            this.Name = "SinhVienForm";
            this.Text = "Quản lý Sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ho_Ten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Ma_SV;
        private System.Windows.Forms.ComboBox cbo_Ma_Lop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Ngay_Sinh;
    }
}