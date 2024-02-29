namespace LMS
{
    partial class Form_register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.text_confirmPassword = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.rbtn_sex2 = new System.Windows.Forms.RadioButton();
            this.rbtn_sex1 = new System.Windows.Forms.RadioButton();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.Label();
            this.text_phone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(107, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "类型";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(107, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(93, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(107, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_register.Location = new System.Drawing.Point(179, 334);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(94, 29);
            this.btn_register.TabIndex = 5;
            this.btn_register.Text = "注册";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // text_confirmPassword
            // 
            this.text_confirmPassword.Location = new System.Drawing.Point(183, 177);
            this.text_confirmPassword.Name = "text_confirmPassword";
            this.text_confirmPassword.PasswordChar = '*';
            this.text_confirmPassword.Size = new System.Drawing.Size(176, 27);
            this.text_confirmPassword.TabIndex = 7;
            this.text_confirmPassword.TextChanged += new System.EventHandler(this.text_confirmPassword_TextChanged);
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(183, 134);
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '*';
            this.text_password.Size = new System.Drawing.Size(176, 27);
            this.text_password.TabIndex = 8;
            this.text_password.TextChanged += new System.EventHandler(this.text_password_TextChanged);
            // 
            // rbtn_sex2
            // 
            this.rbtn_sex2.AutoSize = true;
            this.rbtn_sex2.Location = new System.Drawing.Point(278, 230);
            this.rbtn_sex2.Name = "rbtn_sex2";
            this.rbtn_sex2.Size = new System.Drawing.Size(45, 24);
            this.rbtn_sex2.TabIndex = 9;
            this.rbtn_sex2.TabStop = true;
            this.rbtn_sex2.Text = "女";
            this.rbtn_sex2.UseVisualStyleBackColor = true;
            this.rbtn_sex2.CheckedChanged += new System.EventHandler(this.rbtn_sex2_CheckedChanged);
            // 
            // rbtn_sex1
            // 
            this.rbtn_sex1.AutoSize = true;
            this.rbtn_sex1.Location = new System.Drawing.Point(203, 230);
            this.rbtn_sex1.Name = "rbtn_sex1";
            this.rbtn_sex1.Size = new System.Drawing.Size(45, 24);
            this.rbtn_sex1.TabIndex = 10;
            this.rbtn_sex1.TabStop = true;
            this.rbtn_sex1.Text = "男";
            this.rbtn_sex1.UseVisualStyleBackColor = true;
            this.rbtn_sex1.CheckedChanged += new System.EventHandler(this.rbtn_sex1_CheckedChanged);
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "教师",
            "职工",
            "学生"});
            this.cb_type.Location = new System.Drawing.Point(183, 88);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(176, 28);
            this.cb_type.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(193, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 41);
            this.label6.TabIndex = 13;
            this.label6.Text = "注册";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.AutoSize = true;
            this.txt_phone.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_phone.Location = new System.Drawing.Point(93, 275);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(84, 25);
            this.txt_phone.TabIndex = 14;
            this.txt_phone.Text = "电话号码";
            this.txt_phone.Click += new System.EventHandler(this.label7_Click);
            // 
            // text_phone
            // 
            this.text_phone.Location = new System.Drawing.Point(183, 275);
            this.text_phone.Name = "text_phone";
            this.text_phone.Size = new System.Drawing.Size(176, 27);
            this.text_phone.TabIndex = 15;
            // 
            // Form_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(494, 398);
            this.Controls.Add(this.text_phone);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.rbtn_sex1);
            this.Controls.Add(this.rbtn_sex2);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_confirmPassword);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form_register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_register;
        private TextBox text_confirmPassword;
        private TextBox text_password;
        private RadioButton rbtn_sex2;
        private RadioButton rbtn_sex1;
        private NumericUpDown nud_age;
        private ComboBox cb_type;
        private Label label6;
        private Label txt_phone;
        private TextBox text_phone;
    }
}