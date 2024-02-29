namespace LMS
{
    partial class readers_management
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.readers = new System.Windows.Forms.ListView();
            this.readerID = new System.Windows.Forms.ColumnHeader();
            this.type = new System.Windows.Forms.ColumnHeader();
            this.phone = new System.Windows.Forms.ColumnHeader();
            this.sex = new System.Windows.Forms.ColumnHeader();
            this.borrowingNum = new System.Windows.Forms.ColumnHeader();
            this.hasBorrowedNum = new System.Windows.Forms.ColumnHeader();
            this.situation = new System.Windows.Forms.ColumnHeader();
            this.remark = new System.Windows.Forms.ColumnHeader();
            this.violationNum = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.td_phone = new System.Windows.Forms.TextBox();
            this.td_situation = new System.Windows.Forms.TextBox();
            this.td_remark = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(315, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "读者信息表";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // readers
            // 
            this.readers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.readerID,
            this.type,
            this.phone,
            this.sex,
            this.borrowingNum,
            this.hasBorrowedNum,
            this.situation,
            this.remark,
            this.violationNum});
            this.readers.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.readers.FullRowSelect = true;
            this.readers.GridLines = true;
            this.readers.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.readers.Location = new System.Drawing.Point(29, 215);
            this.readers.MultiSelect = false;
            this.readers.Name = "readers";
            this.readers.Size = new System.Drawing.Size(743, 350);
            this.readers.TabIndex = 1;
            this.readers.UseCompatibleStateImageBehavior = false;
            this.readers.View = System.Windows.Forms.View.Details;
            this.readers.SelectedIndexChanged += new System.EventHandler(this.readers_SelectedIndexChanged);
            // 
            // readerID
            // 
            this.readerID.Text = "读者ID";
            this.readerID.Width = 80;
            // 
            // type
            // 
            this.type.Text = "读者类型";
            this.type.Width = 80;
            // 
            // phone
            // 
            this.phone.Text = "电话";
            this.phone.Width = 80;
            // 
            // sex
            // 
            this.sex.Text = "性别";
            this.sex.Width = 80;
            // 
            // borrowingNum
            // 
            this.borrowingNum.Text = "当前借阅数";
            this.borrowingNum.Width = 90;
            // 
            // hasBorrowedNum
            // 
            this.hasBorrowedNum.Text = "累计借阅数";
            this.hasBorrowedNum.Width = 90;
            // 
            // situation
            // 
            this.situation.Text = "状态";
            this.situation.Width = 80;
            // 
            // remark
            // 
            this.remark.Text = "备注";
            this.remark.Width = 80;
            // 
            // violationNum
            // 
            this.violationNum.Text = "违规次数";
            this.violationNum.Width = 80;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(643, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(116, 92);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(125, 27);
            this.tb_id.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "输入ID查询";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(267, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(417, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "电话";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(417, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "状态";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(417, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "备注";
            // 
            // td_phone
            // 
            this.td_phone.Location = new System.Drawing.Point(483, 70);
            this.td_phone.Name = "td_phone";
            this.td_phone.Size = new System.Drawing.Size(125, 27);
            this.td_phone.TabIndex = 10;
            // 
            // td_situation
            // 
            this.td_situation.Location = new System.Drawing.Point(483, 109);
            this.td_situation.Name = "td_situation";
            this.td_situation.Size = new System.Drawing.Size(125, 27);
            this.td_situation.TabIndex = 11;
            // 
            // td_remark
            // 
            this.td_remark.Location = new System.Drawing.Point(483, 142);
            this.td_remark.Name = "td_remark";
            this.td_remark.Size = new System.Drawing.Size(125, 27);
            this.td_remark.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(315, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(459, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "注意：当前表中只可修改电话，添加状态和备注，不可修改其他信息";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(208, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Green;
            this.button4.Location = new System.Drawing.Point(53, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 14;
            this.button4.Text = "刷新";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // readers_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.td_remark);
            this.Controls.Add(this.td_situation);
            this.Controls.Add(this.td_phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.readers);
            this.Controls.Add(this.label1);
            this.Name = "readers_management";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.readers_management_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListView readers;
        private ColumnHeader readerID;
        private ColumnHeader type;
        private ColumnHeader sex;
        private ColumnHeader phone;
        private ColumnHeader borrowingNum;
        private ColumnHeader hasBorrowedNum;
        private ColumnHeader violationNum;
        private ColumnHeader situation;
        private ColumnHeader remark;
        private Button button1;
        private Button button2;
        private TextBox tb_id;
        private Label label2;
        private Button button3;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox td_phone;
        private TextBox td_situation;
        private TextBox td_remark;
        private Label label6;
        private Button button4;
    }
}
