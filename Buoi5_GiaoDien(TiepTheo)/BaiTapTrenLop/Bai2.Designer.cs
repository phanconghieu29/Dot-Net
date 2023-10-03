namespace BaiTapTrenLop
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
            trv_ListClass = new TreeView();
            cbo_Select_Class = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_Student_ID = new TextBox();
            txt_Name = new TextBox();
            label6 = new Label();
            txt_Address = new TextBox();
            btn_Update = new Button();
            btn_Delete = new Button();
            ckb_Add_Class = new CheckBox();
            txt_Class_Name = new TextBox();
            label5 = new Label();
            btn_Add_Class = new Button();
            gb_Class_Info = new GroupBox();
            groupBox1 = new GroupBox();
            gb_Class_Info.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // trv_ListClass
            // 
            trv_ListClass.Location = new Point(-1, 0);
            trv_ListClass.Name = "trv_ListClass";
            trv_ListClass.Size = new Size(305, 408);
            trv_ListClass.TabIndex = 0;
            // 
            // cbo_Select_Class
            // 
            cbo_Select_Class.FormattingEnabled = true;
            cbo_Select_Class.Location = new Point(432, 20);
            cbo_Select_Class.Name = "cbo_Select_Class";
            cbo_Select_Class.Size = new Size(315, 28);
            cbo_Select_Class.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 23);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 2;
            label1.Text = "Chọn Lớp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 29);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 4;
            label3.Text = "Mã SV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 83);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 5;
            label4.Text = "Họ Tên";
            // 
            // txt_Student_ID
            // 
            txt_Student_ID.Location = new Point(122, 26);
            txt_Student_ID.Name = "txt_Student_ID";
            txt_Student_ID.Size = new Size(315, 27);
            txt_Student_ID.TabIndex = 7;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(122, 80);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(315, 27);
            txt_Name.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 140);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 10;
            label6.Text = "Địa Chỉ";
            // 
            // txt_Address
            // 
            txt_Address.Location = new Point(122, 137);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(315, 27);
            txt_Address.TabIndex = 11;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(122, 184);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(161, 29);
            btn_Update.TabIndex = 12;
            btn_Update.Text = "Cập Nhật";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(289, 184);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(148, 29);
            btn_Delete.TabIndex = 13;
            btn_Delete.Text = "Xóa";
            btn_Delete.UseVisualStyleBackColor = true;
            // 
            // ckb_Add_Class
            // 
            ckb_Add_Class.AutoSize = true;
            ckb_Add_Class.Location = new Point(310, 295);
            ckb_Add_Class.Name = "ckb_Add_Class";
            ckb_Add_Class.Size = new Size(94, 24);
            ckb_Add_Class.TabIndex = 14;
            ckb_Add_Class.Text = "Thêm lớp";
            ckb_Add_Class.UseVisualStyleBackColor = true;
            ckb_Add_Class.CheckedChanged += ckb_Add_Class_CheckedChanged;
            // 
            // txt_Class_Name
            // 
            txt_Class_Name.Location = new Point(121, 26);
            txt_Class_Name.Name = "txt_Class_Name";
            txt_Class_Name.Size = new Size(184, 27);
            txt_Class_Name.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 29);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 15;
            label5.Text = "Tên Lớp";
            // 
            // btn_Add_Class
            // 
            btn_Add_Class.Location = new Point(311, 25);
            btn_Add_Class.Name = "btn_Add_Class";
            btn_Add_Class.Size = new Size(125, 29);
            btn_Add_Class.TabIndex = 18;
            btn_Add_Class.Text = "Thêm Lớp";
            btn_Add_Class.UseVisualStyleBackColor = true;
            btn_Add_Class.Click += btn_Add_Class_Click;
            // 
            // gb_Class_Info
            // 
            gb_Class_Info.Controls.Add(txt_Class_Name);
            gb_Class_Info.Controls.Add(btn_Add_Class);
            gb_Class_Info.Controls.Add(label5);
            gb_Class_Info.Location = new Point(310, 325);
            gb_Class_Info.Name = "gb_Class_Info";
            gb_Class_Info.Size = new Size(478, 73);
            gb_Class_Info.TabIndex = 19;
            gb_Class_Info.TabStop = false;
            gb_Class_Info.Text = "Thông Tin Lớp";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Delete);
            groupBox1.Controls.Add(txt_Student_ID);
            groupBox1.Controls.Add(btn_Update);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_Address);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_Name);
            groupBox1.Location = new Point(310, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 230);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Lớp";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 410);
            Controls.Add(groupBox1);
            Controls.Add(gb_Class_Info);
            Controls.Add(ckb_Add_Class);
            Controls.Add(label1);
            Controls.Add(cbo_Select_Class);
            Controls.Add(trv_ListClass);
            Name = "Bai2";
            Text = "Quản Lý Sinh Viên";
            Load += Bai2_Load;
            gb_Class_Info.ResumeLayout(false);
            gb_Class_Info.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView trv_ListClass;
        private ComboBox cbo_Select_Class;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txt_Student_ID;
        private TextBox txt_Name;
        private Label label6;
        private TextBox txt_Address;
        private Button btn_Update;
        private Button btn_Delete;
        private CheckBox ckb_Add_Class;
        private TextBox txt_Class_Name;
        private Label label5;
        private Button btn_Add_Class;
        private GroupBox gb_Class_Info;
        private GroupBox groupBox1;
    }
}