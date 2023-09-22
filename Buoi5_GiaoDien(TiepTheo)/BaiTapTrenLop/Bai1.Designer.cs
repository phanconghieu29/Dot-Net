namespace BaiTapTrenLop
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
            lbInput = new Label();
            txt_Input = new TextBox();
            btnUpdate = new Button();
            cbo_Number = new ComboBox();
            lst_Number = new ListBox();
            lbList = new Label();
            btn_Sum = new Button();
            btn_Count_Even = new Button();
            btn_Prime_Num = new Button();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // lbInput
            // 
            lbInput.AutoSize = true;
            lbInput.Location = new Point(29, 25);
            lbInput.Name = "lbInput";
            lbInput.Size = new Size(69, 20);
            lbInput.TabIndex = 0;
            lbInput.Text = "Nhập Số:";
            // 
            // txt_Input
            // 
            txt_Input.Location = new Point(29, 48);
            txt_Input.Name = "txt_Input";
            txt_Input.Size = new Size(125, 27);
            txt_Input.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(173, 47);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbo_Number
            // 
            cbo_Number.FormattingEnabled = true;
            cbo_Number.Location = new Point(29, 82);
            cbo_Number.Name = "cbo_Number";
            cbo_Number.Size = new Size(238, 28);
            cbo_Number.TabIndex = 3;
            cbo_Number.SelectedIndexChanged += cbo_Number_SelectedIndexChanged;
            // 
            // lst_Number
            // 
            lst_Number.FormattingEnabled = true;
            lst_Number.ItemHeight = 20;
            lst_Number.Location = new Point(300, 48);
            lst_Number.Name = "lst_Number";
            lst_Number.Size = new Size(254, 104);
            lst_Number.TabIndex = 4;
            // 
            // lbList
            // 
            lbList.AutoSize = true;
            lbList.Location = new Point(300, 25);
            lbList.Name = "lbList";
            lbList.Size = new Size(162, 20);
            lbList.TabIndex = 5;
            lbList.Text = "Danh Sách Các Ước Số:";
            // 
            // btn_Sum
            // 
            btn_Sum.Location = new Point(300, 158);
            btn_Sum.Name = "btn_Sum";
            btn_Sum.Size = new Size(254, 29);
            btn_Sum.TabIndex = 6;
            btn_Sum.Text = "Tổng Các Ước Số";
            btn_Sum.UseVisualStyleBackColor = true;
            // 
            // btn_Count_Even
            // 
            btn_Count_Even.Location = new Point(300, 193);
            btn_Count_Even.Name = "btn_Count_Even";
            btn_Count_Even.Size = new Size(254, 29);
            btn_Count_Even.TabIndex = 7;
            btn_Count_Even.Text = "Sỗ Lượng Các Ước Số Chẵn";
            btn_Count_Even.UseVisualStyleBackColor = true;
            // 
            // btn_Prime_Num
            // 
            btn_Prime_Num.Location = new Point(300, 228);
            btn_Prime_Num.Name = "btn_Prime_Num";
            btn_Prime_Num.Size = new Size(254, 29);
            btn_Prime_Num.TabIndex = 8;
            btn_Prime_Num.Text = "Sỗ Lượng Các Ước Số Nguyên Tố";
            btn_Prime_Num.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(87, 181);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(109, 53);
            btn_Exit.TabIndex = 9;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 284);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Prime_Num);
            Controls.Add(btn_Count_Even);
            Controls.Add(btn_Sum);
            Controls.Add(lbList);
            Controls.Add(lst_Number);
            Controls.Add(cbo_Number);
            Controls.Add(btnUpdate);
            Controls.Add(txt_Input);
            Controls.Add(lbInput);
            Name = "Bai1";
            Text = "`";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbInput;
        private TextBox txt_Input;
        private Button btnUpdate;
        private ComboBox cbo_Number;
        private ListBox lst_Number;
        private Label lbList;
        private Button btn_Sum;
        private Button btn_Count_Even;
        private Button btn_Prime_Num;
        private Button btn_Exit;
    }
}