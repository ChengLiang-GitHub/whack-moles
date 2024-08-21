namespace WinFormsApp1
{
    partial class StartForm
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
            button1 = new Button();
            timeLB = new ListBox();
            label1 = new Label();
            label2 = new Label();
            speedCB = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(81, 60);
            button1.Name = "button1";
            button1.Size = new Size(121, 50);
            button1.TabIndex = 0;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timeLB
            // 
            timeLB.FormattingEnabled = true;
            timeLB.ItemHeight = 15;
            timeLB.Items.AddRange(new object[] { "30", "60", "100" });
            timeLB.Location = new Point(28, 31);
            timeLB.Name = "timeLB";
            timeLB.Size = new Size(47, 79);
            timeLB.TabIndex = 1;
            timeLB.SelectedIndexChanged += timeLB_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 9);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Speed";
            // 
            // speedCB
            // 
            speedCB.FormattingEnabled = true;
            speedCB.Items.AddRange(new object[] { "Slow", "Normal", "Fast" });
            speedCB.Location = new Point(81, 31);
            speedCB.Name = "speedCB";
            speedCB.Size = new Size(121, 23);
            speedCB.TabIndex = 4;
            speedCB.SelectedIndexChanged += speedCB_SelectedIndexChanged;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 124);
            Controls.Add(speedCB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(timeLB);
            Controls.Add(button1);
            Name = "StartForm";
            Text = "StartForm";
            Load += StartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox timeLB;
        private Label label1;
        private Label label2;
        private ComboBox speedCB;
    }
}