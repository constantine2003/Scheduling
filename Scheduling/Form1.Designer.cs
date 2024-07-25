namespace Scheduling
{
    partial class RegistrationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            TeamNametxt = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            CaptainBalltxt = new TextBox();
            CoachNametxt = new TextBox();
            Addbtn = new Button();
            dataGridView1 = new DataGridView();
            Category = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            label6 = new Label();
            teamIDtxt = new TextBox();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // TeamNametxt
            // 
            TeamNametxt.Location = new Point(239, 166);
            TeamNametxt.Name = "TeamNametxt";
            TeamNametxt.Size = new Size(249, 31);
            TeamNametxt.TabIndex = 0;
            TeamNametxt.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(515, 34);
            label1.Name = "label1";
            label1.Size = new Size(782, 43);
            label1.TabIndex = 1;
            label1.Text = "SUMMER LEAGUE VOLLEYBALL REGISTRATION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(45, 297);
            label4.Name = "label4";
            label4.Size = new Size(177, 27);
            label4.TabIndex = 3;
            label4.Text = "COACH NAME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 166);
            label2.Name = "label2";
            label2.Size = new Size(161, 27);
            label2.TabIndex = 4;
            label2.Text = "TEAM NAME:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 228);
            label3.Name = "label3";
            label3.Size = new Size(188, 27);
            label3.TabIndex = 5;
            label3.Text = "CAPTAIN BALL:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(45, 376);
            label5.Name = "label5";
            label5.Size = new Size(141, 27);
            label5.TabIndex = 6;
            label5.Text = "CATEGORY:";
            // 
            // CaptainBalltxt
            // 
            CaptainBalltxt.Location = new Point(239, 224);
            CaptainBalltxt.Name = "CaptainBalltxt";
            CaptainBalltxt.Size = new Size(249, 31);
            CaptainBalltxt.TabIndex = 7;
            // 
            // CoachNametxt
            // 
            CoachNametxt.Location = new Point(239, 293);
            CoachNametxt.Name = "CoachNametxt";
            CoachNametxt.Size = new Size(249, 31);
            CoachNametxt.TabIndex = 8;
            // 
            // Addbtn
            // 
            Addbtn.BackColor = SystemColors.ActiveBorder;
            Addbtn.FlatStyle = FlatStyle.Flat;
            Addbtn.Font = new Font("Times New Roman", 11F);
            Addbtn.ForeColor = SystemColors.ActiveCaptionText;
            Addbtn.Location = new Point(45, 439);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(112, 34);
            Addbtn.TabIndex = 10;
            Addbtn.Text = "ADD";
            Addbtn.UseVisualStyleBackColor = false;
            Addbtn.Click += Addbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(515, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(342, 442);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Category
            // 
            Category.FormattingEnabled = true;
            Category.Items.AddRange(new object[] { "Male", "Female", "Mixed" });
            Category.Location = new Point(239, 370);
            Category.Name = "Category";
            Category.Size = new Size(249, 33);
            Category.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 11F);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(376, 439);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 13;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 11F);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(211, 439);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 14;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 11F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(376, 617);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 15;
            button1.Text = "UPDATE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(45, 111);
            label6.Name = "label6";
            label6.Size = new Size(116, 27);
            label6.TabIndex = 17;
            label6.Text = "TEAM ID:";
            // 
            // teamIDtxt
            // 
            teamIDtxt.Location = new Point(239, 111);
            teamIDtxt.Name = "teamIDtxt";
            teamIDtxt.Size = new Size(249, 31);
            teamIDtxt.TabIndex = 16;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(850, 111);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(342, 442);
            dataGridView2.TabIndex = 18;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(1187, 111);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(342, 442);
            dataGridView3.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(648, 81);
            label7.Name = "label7";
            label7.Size = new Size(80, 27);
            label7.TabIndex = 20;
            label7.Text = "MALE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(949, 81);
            label8.Name = "label8";
            label8.Size = new Size(108, 27);
            label8.TabIndex = 21;
            label8.Text = "FEMALE";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(1310, 81);
            label9.Name = "label9";
            label9.Size = new Size(90, 27);
            label9.TabIndex = 22;
            label9.Text = "MIXED";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1568, 564);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(Category);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(teamIDtxt);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(Addbtn);
            Controls.Add(CoachNametxt);
            Controls.Add(CaptainBalltxt);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(TeamNametxt);
            ForeColor = Color.Magenta;
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TeamNametxt;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox CaptainBalltxt;
        private TextBox CoachNametxt;
        private Button Addbtn;
        private DataGridView dataGridView1;
        private ComboBox Category;
        private Button button2;
        private Button button3;
        private Button button1;
        private Label label6;
        private TextBox teamIDtxt;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
