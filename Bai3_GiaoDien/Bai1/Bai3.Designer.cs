namespace Buoi3
{
    partial class Bai3
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lbUSC = new System.Windows.Forms.Label();
            this.lbBSC = new System.Windows.Forms.Label();
            this.txtUSC = new System.Windows.Forms.TextBox();
            this.txtBSC = new System.Windows.Forms.TextBox();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(307, 25);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Ước Số Chung - Bội Số Chung";
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(40, 63);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(77, 17);
            this.lbA.TabIndex = 1;
            this.lbA.Text = "Nhập số a:";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.Location = new System.Drawing.Point(40, 90);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(77, 17);
            this.lbB.TabIndex = 2;
            this.lbB.Text = "Nhập số b:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(123, 62);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(162, 20);
            this.txtA.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(123, 89);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(162, 20);
            this.txtB.TabIndex = 4;
            // 
            // lbUSC
            // 
            this.lbUSC.AutoSize = true;
            this.lbUSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUSC.Location = new System.Drawing.Point(40, 121);
            this.lbUSC.Name = "lbUSC";
            this.lbUSC.Size = new System.Drawing.Size(154, 17);
            this.lbUSC.TabIndex = 5;
            this.lbUSC.Text = "Ước số chung lớn nhất:";
            // 
            // lbBSC
            // 
            this.lbBSC.AutoSize = true;
            this.lbBSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBSC.Location = new System.Drawing.Point(40, 148);
            this.lbBSC.Name = "lbBSC";
            this.lbBSC.Size = new System.Drawing.Size(154, 17);
            this.lbBSC.TabIndex = 6;
            this.lbBSC.Text = "Bội số chung nhỏ nhất:";
            // 
            // txtUSC
            // 
            this.txtUSC.Location = new System.Drawing.Point(201, 121);
            this.txtUSC.Name = "txtUSC";
            this.txtUSC.Size = new System.Drawing.Size(84, 20);
            this.txtUSC.TabIndex = 7;
            // 
            // txtBSC
            // 
            this.txtBSC.Location = new System.Drawing.Point(201, 147);
            this.txtBSC.Name = "txtBSC";
            this.txtBSC.Size = new System.Drawing.Size(84, 20);
            this.txtBSC.TabIndex = 8;
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Location = new System.Drawing.Point(129, 183);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(75, 23);
            this.btnTiepTuc.TabIndex = 9;
            this.btnTiepTuc.Text = "Tiếp Tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(225, 183);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(32, 183);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(75, 23);
            this.btnThucHien.TabIndex = 11;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 232);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.txtBSC);
            this.Controls.Add(this.txtUSC);
            this.Controls.Add(this.lbBSC);
            this.Controls.Add(this.lbUSC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.lbTitle);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lbUSC;
        private System.Windows.Forms.Label lbBSC;
        private System.Windows.Forms.TextBox txtUSC;
        private System.Windows.Forms.TextBox txtBSC;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThucHien;
    }
}