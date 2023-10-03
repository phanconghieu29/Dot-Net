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
            label2 = new Label();
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
            gb_Class_Info.SuspendLayout();
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
            cbo_Select_Class.Location = new Point(447, 12);
            cbo_Select_Class.Name = "cbo_Select_Class";
            cbo_Select_Class.Size = new Size(315, 28);
            cbo_Select_Class.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 15);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 2;
            label1.Text = "Chọn Lớp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 53);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 3;
            label2.Text = "Thông Tin Sinh Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 93);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 4;
            label3.Text = "Mã SV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 147);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 5;
            label4.Text = "Họ Tên";
            // 
            // txt_Student_ID
            // 
            txt_Student_ID.Location = new Point(447, 90);
            txt_Student_ID.Name = "txt_Student_ID";
            txt_Student_ID.Size = new Size(315, 27);
            txt_Student_ID.TabIndex = 7;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(447, 144);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(315, 27);
            txt_Name.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(362, 204);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 10;
            label6.Text = "Địa Chỉ";
            // 
            // txt_Address
            // 
            txt_Address.Location = new Point(447, 201);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(315, 27);
            txt_Address.TabIndex = 11;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(447, 248);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(161, 29);
            btn_Update.TabIndex = 12;
            btn_Update.Text = "Cập Nhật";
            btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(614, 248);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(148, 29);
            btn_Delete.TabIndex = 13;
            btn_Delete.Text = "Xóa";
            btn_Delete.UseVisualStyleBackColor = true;
            // 
            // ckb_Add_Class
            // 
            ckb_Add_Class.AutoSize = true;
            ckb_Add_Class.Location = new Point(325, 295);
            ckb_Add_Class.Name = "ckb_Add_Class";
            ckb_Add_Class.Size = new Size(94, 24);
            ckb_Add_Class.TabIndex = 14;
            ckb_Add_Class.Text = "Thêm lớp";
            ckb_Add_Class.UseVisualStyleBackColor = true;
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
            // 
            // gb_Class_Info
            // 
            gb_Class_Info.Controls.Add(txt_Class_Name);
            gb_Class_Info.Controls.Add(btn_Add_Class);
            gb_Class_Info.Controls.Add(label5);
            gb_Class_Info.Location = new Point(343, 325);
            gb_Class_Info.Name = "gb_Class_Info";
            gb_Class_Info.Size = new Size(445, 73);
            gb_Class_Info.TabIndex = 19;
            gb_Class_Info.TabStop = false;
            gb_Class_Info.Text = "Thông Tin Lớp";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 410);
            Controls.Add(gb_Class_Info);
            Controls.Add(ckb_Add_Class);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(txt_Address);
            Controls.Add(label6);
            Controls.Add(txt_Name);
            Controls.Add(txt_Student_ID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbo_Select_Class);
            Controls.Add(trv_ListClass);
            Name = "Bai2";
            Text = "Quản Lý Sinh Viên";
            Load += Bai2_Load;
            gb_Class_Info.ResumeLayout(false);
            gb_Class_Info.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView trv_ListClass;
        private ComboBox cbo_Select_Class;
        private Label label1;
        private Label label2;
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
    }
}