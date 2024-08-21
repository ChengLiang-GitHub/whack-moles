namespace WinFormsApp1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            scoreLB = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timeLb = new Label();
            monthCalendar1 = new MonthCalendar();
            restartBTN = new Button();
            label2 = new Label();
            speedCB = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(673, 391);
            button1.Name = "button1";
            button1.Size = new Size(92, 25);
            button1.TabIndex = 0;
            button1.Text = "Test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(653, 354);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "score";
            // 
            // scoreLB
            // 
            scoreLB.AutoSize = true;
            scoreLB.Location = new Point(696, 354);
            scoreLB.Name = "scoreLB";
            scoreLB.Size = new Size(0, 15);
            scoreLB.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timeLb
            // 
            timeLb.AutoSize = true;
            timeLb.Location = new Point(696, 329);
            timeLb.Name = "timeLb";
            timeLb.Size = new Size(0, 15);
            timeLb.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(525, 29);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // restartBTN
            // 
            restartBTN.Location = new Point(525, 290);
            restartBTN.Name = "restartBTN";
            restartBTN.Size = new Size(75, 23);
            restartBTN.TabIndex = 5;
            restartBTN.Text = "Restart";
            restartBTN.UseVisualStyleBackColor = true;
            restartBTN.Click += restartBTN_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(653, 329);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 6;
            label2.Text = "time";
            // 
            // speedCB
            // 
            speedCB.FormattingEnabled = true;
            speedCB.Items.AddRange(new object[] { "Slow", "Normal", "Fast" });
            speedCB.Location = new Point(525, 251);
            speedCB.Name = "speedCB";
            speedCB.Size = new Size(121, 23);
            speedCB.TabIndex = 7;
            speedCB.SelectedIndexChanged += levelCB_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(524, 222);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 8;
            label3.Text = "Speed";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(speedCB);
            Controls.Add(label2);
            Controls.Add(restartBTN);
            Controls.Add(monthCalendar1);
            Controls.Add(timeLb);
            Controls.Add(scoreLB);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label scoreLB;
        private System.Windows.Forms.Timer timer1;
        private Label timeLb;
        private MonthCalendar monthCalendar1;
        private Button restartBTN;
        private Label label2;
        public ComboBox speedCB;
        private Label label3;
    }
}
