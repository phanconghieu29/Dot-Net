namespace QL_SinhVien
{
    partial class FormLop
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
            this.txt_Ten_Lop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Ma_Lop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_Ma_Khoa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(187, 101);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 13;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(106, 101);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(25, 101);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên lớp";
            // 
            // txt_Ten_Lop
            // 
            this.txt_Ten_Lop.Location = new System.Drawing.Point(77, 40);
            this.txt_Ten_Lop.Name = "txt_Ten_Lop";
            this.txt_Ten_Lop.Size = new System.Drawing.Size(185, 20);
            this.txt_Ten_Lop.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã lớp";
            // 
            // txt_Ma_Lop
            // 
            this.txt_Ma_Lop.Location = new System.Drawing.Point(77, 14);
            this.txt_Ma_Lop.Name = "txt_Ma_Lop";
            this.txt_Ma_Lop.Size = new System.Drawing.Size(185, 20);
            this.txt_Ma_Lop.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã khoa";
            // 
            // cbo_Ma_Khoa
            // 
            this.cbo_Ma_Khoa.FormattingEnabled = true;
            this.cbo_Ma_Khoa.Location = new System.Drawing.Point(77, 66);
            this.cbo_Ma_Khoa.Name = "cbo_Ma_Khoa";
            this.cbo_Ma_Khoa.Size = new System.Drawing.Size(185, 21);
            this.cbo_Ma_Khoa.TabIndex = 15;
            // 
            // FormLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 133);
            this.Controls.Add(this.cbo_Ma_Khoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Ten_Lop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Ma_Lop);
            this.Name = "FormLop";
            this.Text = "Quản lý Lớp";
            this.Load += new System.EventHandler(this.FormLop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ten_Lop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Ma_Lop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_Ma_Khoa;
    }
}