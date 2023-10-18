namespace QL_SinhVien
{
    partial class FormMain
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
            this.btn_Khoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Lop = new System.Windows.Forms.Button();
            this.btn_SinhVien = new System.Windows.Forms.Button();
            this.bt_MonHoc = new System.Windows.Forms.Button();
            this.btn_Diem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Khoa
            // 
            this.btn_Khoa.Location = new System.Drawing.Point(12, 49);
            this.btn_Khoa.Name = "btn_Khoa";
            this.btn_Khoa.Size = new System.Drawing.Size(75, 34);
            this.btn_Khoa.TabIndex = 0;
            this.btn_Khoa.Text = "Khoa";
            this.btn_Khoa.UseVisualStyleBackColor = true;
            this.btn_Khoa.Click += new System.EventHandler(this.btn_Khoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORM MENU";
            // 
            // btn_Lop
            // 
            this.btn_Lop.Location = new System.Drawing.Point(93, 49);
            this.btn_Lop.Name = "btn_Lop";
            this.btn_Lop.Size = new System.Drawing.Size(75, 34);
            this.btn_Lop.TabIndex = 2;
            this.btn_Lop.Text = "Lớp";
            this.btn_Lop.UseVisualStyleBackColor = true;
            this.btn_Lop.Click += new System.EventHandler(this.btn_Lop_Click);
            // 
            // btn_SinhVien
            // 
            this.btn_SinhVien.Location = new System.Drawing.Point(174, 49);
            this.btn_SinhVien.Name = "btn_SinhVien";
            this.btn_SinhVien.Size = new System.Drawing.Size(75, 34);
            this.btn_SinhVien.TabIndex = 3;
            this.btn_SinhVien.Text = "Sinh Viên";
            this.btn_SinhVien.UseVisualStyleBackColor = true;
            this.btn_SinhVien.Click += new System.EventHandler(this.btn_SinhVien_Click);
            // 
            // bt_MonHoc
            // 
            this.bt_MonHoc.Location = new System.Drawing.Point(255, 49);
            this.bt_MonHoc.Name = "bt_MonHoc";
            this.bt_MonHoc.Size = new System.Drawing.Size(75, 34);
            this.bt_MonHoc.TabIndex = 4;
            this.bt_MonHoc.Text = "Môn Học";
            this.bt_MonHoc.UseVisualStyleBackColor = true;
            this.bt_MonHoc.Click += new System.EventHandler(this.bt_MonHoc_Click);
            // 
            // btn_Diem
            // 
            this.btn_Diem.Location = new System.Drawing.Point(336, 49);
            this.btn_Diem.Name = "btn_Diem";
            this.btn_Diem.Size = new System.Drawing.Size(75, 34);
            this.btn_Diem.TabIndex = 5;
            this.btn_Diem.Text = "Điểm";
            this.btn_Diem.UseVisualStyleBackColor = true;
            this.btn_Diem.Click += new System.EventHandler(this.btn_Diem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 108);
            this.Controls.Add(this.btn_Diem);
            this.Controls.Add(this.bt_MonHoc);
            this.Controls.Add(this.btn_SinhVien);
            this.Controls.Add(this.btn_Lop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Khoa);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Khoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Lop;
        private System.Windows.Forms.Button btn_SinhVien;
        private System.Windows.Forms.Button bt_MonHoc;
        private System.Windows.Forms.Button btn_Diem;

    }
}