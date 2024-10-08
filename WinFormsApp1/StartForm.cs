﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void speedCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                Form1 form1 = (Form1)this.Owner;
                form1.speedCB.SelectedIndex = speedCB.SelectedIndex;
            }
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                Form1 form1 = (Form1)this.Owner;
                speedCB.SelectedIndex = 0;
                timeLB.SelectedIndex = 0;
                form1.speedCB.SelectedIndex = speedCB.SelectedIndex;
                form1.stopTime = Int32.Parse(timeLB.SelectedItem.ToString());
            }
        }

        private void timeLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                Form1 form1 = (Form1)this.Owner;
                form1.stopTime = Int32.Parse(timeLB.SelectedItem.ToString());
            }
        }
    }
}
