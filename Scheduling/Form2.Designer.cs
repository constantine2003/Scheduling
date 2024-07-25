namespace Scheduling
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            groupBox1 = new GroupBox();
            gamedate = new DateTimePicker();
            button1 = new Button();
            venuetxt = new TextBox();
            label5 = new Label();
            timetxt = new TextBox();
            team2txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            team1txt = new TextBox();
            button3 = new Button();
            button2 = new Button();
            gamedatetxt = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(21, 50);
            label1.Name = "label1";
            label1.Size = new Size(88, 27);
            label1.TabIndex = 0;
            label1.Text = "Team 1:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(gamedate);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(venuetxt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(timetxt);
            groupBox1.Controls.Add(team2txt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(team1txt);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(40, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(573, 425);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Game Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // gamedate
            // 
            gamedate.Font = new Font("Times New Roman", 12F);
            gamedate.Location = new Point(171, 154);
            gamedate.Name = "gamedate";
            gamedate.Size = new Size(300, 35);
            gamedate.TabIndex = 2;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(171, 367);
            button1.Name = "button1";
            button1.Size = new Size(219, 34);
            button1.TabIndex = 11;
            button1.Text = "Add to the Schedule";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // venuetxt
            // 
            venuetxt.BackColor = SystemColors.InactiveCaption;
            venuetxt.Location = new Point(171, 264);
            venuetxt.Name = "venuetxt";
            venuetxt.Size = new Size(300, 30);
            venuetxt.TabIndex = 10;
            venuetxt.TextChanged += venuetxt_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(21, 268);
            label5.Name = "label5";
            label5.Size = new Size(77, 27);
            label5.TabIndex = 9;
            label5.Text = "Venue:";
          //  label5.Click += this.label5_Click;
            // 
            // timetxt
            // 
            timetxt.BackColor = SystemColors.InactiveCaption;
            timetxt.Location = new Point(171, 211);
            timetxt.Name = "timetxt";
            timetxt.Size = new Size(300, 30);
            timetxt.TabIndex = 8;
            // 
            // team2txt
            // 
            team2txt.BackColor = SystemColors.InactiveCaption;
            team2txt.Location = new Point(171, 99);
            team2txt.Name = "team2txt";
            team2txt.Size = new Size(300, 30);
            team2txt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(21, 211);
            label4.Name = "label4";
            label4.Size = new Size(66, 27);
            label4.TabIndex = 4;
            label4.Text = "Time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(21, 154);
            label3.Name = "label3";
            label3.Size = new Size(127, 27);
            label3.TabIndex = 3;
            label3.Text = "Game Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(21, 99);
            label2.Name = "label2";
            label2.Size = new Size(88, 27);
            label2.TabIndex = 2;
            label2.Text = "Team 2:";
            // 
            // team1txt
            // 
            team1txt.BackColor = SystemColors.InactiveCaption;
            team1txt.Location = new Point(171, 50);
            team1txt.Name = "team1txt";
            team1txt.Size = new Size(300, 30);
            team1txt.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(718, 383);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 14;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(734, 301);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 12;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // gamedatetxt
            // 
            gamedatetxt.BackColor = SystemColors.InactiveCaption;
            gamedatetxt.Location = new Point(655, 353);
            gamedatetxt.Name = "gamedatetxt";
            gamedatetxt.Size = new Size(300, 31);
            gamedatetxt.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(655, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(650, 486);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(gamedatetxt);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox timetxt;
        private TextBox team2txt;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox team1txt;
        private DateTimePicker gamedate;
        private TextBox venuetxt;
        private Label label5;
        private Button button1;
        private Button button2;
        private TextBox gamedatetxt;
        private Button button3;
        private DataGridView dataGridView1;
    }
}