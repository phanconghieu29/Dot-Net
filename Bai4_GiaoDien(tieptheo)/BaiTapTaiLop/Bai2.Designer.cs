namespace BaiTapTaiLop
{
    partial class Bai2
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
            this.lbInput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.rdo_SortInc = new System.Windows.Forms.RadioButton();
            this.rdo_SortDec = new System.Windows.Forms.RadioButton();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbSort.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(118, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(209, 25);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "MẢNG SỐ NGUYÊN";
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(24, 46);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(71, 13);
            this.lbInput.TabIndex = 1;
            this.lbInput.Text = "Nhập mảng : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kết quả mảng : ";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(105, 43);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(204, 20);
            this.txtInput.TabIndex = 3;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(105, 65);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(204, 20);
            this.txtOutput.TabIndex = 4;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(332, 46);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 35);
            this.btnInput.TabIndex = 5;
            this.btnInput.Text = "Nhập";
            this.btnInput.UseVisualStyleBackColor = true;
            // 
            // gbSort
            // 
            this.gbSort.Controls.Add(this.rdo_SortDec);
            this.gbSort.Controls.Add(this.rdo_SortInc);
            this.gbSort.Location = new System.Drawing.Point(27, 91);
            this.gbSort.Name = "gbSort";
            this.gbSort.Size = new System.Drawing.Size(282, 48);
            this.gbSort.TabIndex = 6;
            this.gbSort.TabStop = false;
            this.gbSort.Text = "Sắp Xếp";
            // 
            // rdo_SortInc
            // 
            this.rdo_SortInc.AutoSize = true;
            this.rdo_SortInc.Location = new System.Drawing.Point(29, 19);
            this.rdo_SortInc.Name = "rdo_SortInc";
            this.rdo_SortInc.Size = new System.Drawing.Size(92, 17);
            this.rdo_SortInc.TabIndex = 0;
            this.rdo_SortInc.TabStop = true;
            this.rdo_SortInc.Text = "Sắp xếp Tăng";
            this.rdo_SortInc.UseVisualStyleBackColor = true;
            // 
            // rdo_SortDec
            // 
            this.rdo_SortDec.AutoSize = true;
            this.rdo_SortDec.Location = new System.Drawing.Point(162, 19);
            this.rdo_SortDec.Name = "rdo_SortDec";
            this.rdo_SortDec.Size = new System.Drawing.Size(91, 17);
            this.rdo_SortDec.TabIndex = 1;
            this.rdo_SortDec.TabStop = true;
            this.rdo_SortDec.Text = "Sắp xếp Giảm";
            this.rdo_SortDec.UseVisualStyleBackColor = true;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(315, 91);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(92, 48);
            this.btnThucHien.TabIndex = 7;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.textBox2);
            this.gbSearch.Controls.Add(this.textBox1);
            this.gbSearch.Controls.Add(this.radioButton2);
            this.gbSearch.Controls.Add(this.radioButton1);
            this.gbSearch.Location = new System.Drawing.Point(27, 146);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(189, 100);
            this.gbSearch.TabIndex = 8;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Tìm Kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(222, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(116, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nhập giá trị cần tìm";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(114, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nhập ví trí cần tìm";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(35, 20);
            this.textBox2.TabIndex = 3;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 310);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.gbSort);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.lbTitle);
            this.Name = "Bai2";
            this.Text = "Mảng Số Nguyên";
            this.gbSort.ResumeLayout(false);
            this.gbSort.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.RadioButton rdo_SortDec;
        private System.Windows.Forms.RadioButton rdo_SortInc;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}