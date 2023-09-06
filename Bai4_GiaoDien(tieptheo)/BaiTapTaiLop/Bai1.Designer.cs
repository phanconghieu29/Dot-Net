namespace BaiTapTaiLop
{
    partial class Bai1
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbSelect = new System.Windows.Forms.Label();
            this.rdo_PTBN = new System.Windows.Forms.RadioButton();
            this.rdo_PTBH = new System.Windows.Forms.RadioButton();
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lbC = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(73, 130);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(33, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(223, 25);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "GIẢI PHƯƠNG TRÌNH";
            // 
            // lbSelect
            // 
            this.lbSelect.AutoSize = true;
            this.lbSelect.Location = new System.Drawing.Point(25, 52);
            this.lbSelect.Name = "lbSelect";
            this.lbSelect.Size = new System.Drawing.Size(96, 13);
            this.lbSelect.TabIndex = 2;
            this.lbSelect.Text = "Bạn vui lòng chọn:";
            // 
            // rdo_PTBN
            // 
            this.rdo_PTBN.AutoSize = true;
            this.rdo_PTBN.Location = new System.Drawing.Point(50, 69);
            this.rdo_PTBN.Name = "rdo_PTBN";
            this.rdo_PTBN.Size = new System.Drawing.Size(130, 17);
            this.rdo_PTBN.TabIndex = 3;
            this.rdo_PTBN.TabStop = true;
            this.rdo_PTBN.Text = "Phương trình bậc nhất";
            this.rdo_PTBN.UseVisualStyleBackColor = true;
            this.rdo_PTBN.CheckedChanged += new System.EventHandler(this.rdo_PTBN_CheckedChanged);
            // 
            // rdo_PTBH
            // 
            this.rdo_PTBH.AutoSize = true;
            this.rdo_PTBH.Location = new System.Drawing.Point(50, 92);
            this.rdo_PTBH.Name = "rdo_PTBH";
            this.rdo_PTBH.Size = new System.Drawing.Size(123, 17);
            this.rdo_PTBH.TabIndex = 4;
            this.rdo_PTBH.TabStop = true;
            this.rdo_PTBH.Text = "Phương trình bậc hai";
            this.rdo_PTBH.UseVisualStyleBackColor = true;
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(25, 133);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(48, 13);
            this.lbA.TabIndex = 5;
            this.lbA.Text = "Nhập a :";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(25, 155);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(48, 13);
            this.lbB.TabIndex = 6;
            this.lbB.Text = "Nhập b :";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(73, 152);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 7;
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Location = new System.Drawing.Point(25, 177);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(48, 13);
            this.lbC.TabIndex = 8;
            this.lbC.Text = "Nhập c :";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(73, 174);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 9;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(197, 141);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 40);
            this.btnSolve.TabIndex = 10;
            this.btnSolve.Text = "Giải";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(81, 200);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(175, 35);
            this.txtResult.TabIndex = 11;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(25, 203);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(50, 13);
            this.lbResult.TabIndex = 12;
            this.lbResult.Text = "Kết quả :";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(105, 245);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 28);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 285);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.rdo_PTBH);
            this.Controls.Add(this.rdo_PTBN);
            this.Controls.Add(this.lbSelect);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.txtA);
            this.Name = "Bai1";
            this.Text = "Giải phương trình bậc 1-2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbSelect;
        private System.Windows.Forms.RadioButton rdo_PTBN;
        private System.Windows.Forms.RadioButton rdo_PTBH;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnExit;
    }
}