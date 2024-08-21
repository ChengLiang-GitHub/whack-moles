using System;
using static System.Formats.Asn1.AsnWriter;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        CancellationTokenSource[] cancellationTokenSource = new CancellationTokenSource[3];
        Task[] tasks = new Task[3];
        // Get the CancellationToken
        DateTime startTime;
        public int stopTime;
        int countTime;
        Button[][] btn;
        int roundNum;
        int highestScore;
        public enum Speed
        {
            Slow = 20,
            Normal = 10,
            Fast = 3
        };
        Speed speed;
        void eachMouseRowTask(int num)
        {
            Random r = new Random();
            int i;
            while (true)
            {
                i = r.Next(0, ((int)speed)); // 3 represents that there is not any mole in the row
                                             //MessageBox.Show("" + num + " " + i);
                if (i <= 2)
                {
                    btn[num][i].Invoke((Action)(() =>
                    {
                        btn[num][i].Image = Image.FromFile("..\\..\\..\\..\\img\\mouse-72.png");
                        btn[num][i].Enabled = true;
                    }));
                    Task.Delay(r.Next(1, 3) * 1000).Wait();
                    btn[num][i].Invoke((Action)(() =>
                    {
                        btn[num][i].Enabled = false;
                    }));

                }

                Task.Delay(r.Next(1, 3) * 500).Wait();


                if (countTime >= stopTime)
                {
                    for (int j = 0; j < btn[num].Length; j++)
                        btn[num][j].Invoke((Action)(() =>
                        {
                            btn[num][j].Enabled = false;
                        }));
                    break;
                }


            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.ShowDialog(this);

            btn = new Button[3][];
            for (int i = 0; i < btn.Length; i++)
            {
                btn[i] = new Button[3];
                for (int j = 0; j < btn[i].Length; j++)
                {
                    btn[i][j] = new Button();
                    btn[i][j].Size = new Size(100, 100);
                    btn[i][j].Location = new Point(40 + 120 * j, 40 + 120 * i);
                    btn[i][j].Image = Image.FromFile("..\\..\\..\\..\\img\\mouse-72.png");
                    btn[i][j].Enabled = false;
                    btn[i][j].Click += btn_click;
                    this.Controls.Add(btn[i][j]);

                }
            }

            startTime = DateTime.Now;
            Task.Run(() => eachMouseRowTask(0));
            Task.Run(() => eachMouseRowTask(1));
            Task.Run(() => eachMouseRowTask(2));



            timer1.Interval = 1000;
            timer1.Enabled = true;

            highestScore = 0;
            countTime = 0;
            scoreLB.Text = "0";
            timeLb.Text = countTime.ToString();
            roundNum = 1;
            restartBTN.Enabled = false;
        }
        int score = 0;
        private void btn_click(object sender, EventArgs e)
        {
            scoreLB.Text = (++score).ToString();
            (sender as Button).Image = Image.FromFile("..\\..\\..\\..\\img\\mouse-face-72.png");
            (sender as Button).Enabled = false;



        }
        private async void button1_Click(object sender, EventArgs e)
        {
            // string currentDirectory = Directory.GetCurrentDirectory();
            //MessageBox.Show(currentDirectory);
            Task.Delay(10000).Wait();
            Func<int, int> addFun = x => x++;
            MessageBox.Show("After " + addFun(10).ToString() + "s");
            await Task.Delay(10000);
            Func<int, int> addFun2 = x => { return x++; };
            MessageBox.Show("After " + addFun2(20).ToString() + "s");
            await Task.Delay(10000);
            Action<int> addFun3 = x => { MessageBox.Show("After " + (x++).ToString() + "s"); };
            addFun3(30);


        }
        string recorderStr;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countTime < stopTime)
                timeLb.Text = (countTime++).ToString();
            if (countTime == stopTime)
            {
                if(score> highestScore)
                    highestScore = score;
                timeLb.Text = (countTime++).ToString();
                recorderStr += $" (from {startTime} to {DateTime.Now}) \n Round {roundNum++}  is timeout  ,Your score is " + scoreLB.Text + "\n";
                MessageBox.Show(recorderStr+$"Highest score={highestScore}");
                restartBTN.Enabled = true;
            }
        }


        private void restartBTN_Click(object sender, EventArgs e)
        {
            countTime = 0;
            score = 0;
            timeLb.Text = countTime.ToString();
            scoreLB.Text = score.ToString();
            startTime = DateTime.Now;  
            Task.Run(() => eachMouseRowTask(0));
            Task.Run(() => eachMouseRowTask(1));
            Task.Run(() => eachMouseRowTask(2));
            restartBTN.Enabled = false;
        }

        private void levelCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (speedCB.SelectedIndex) 
            { 
                case 0:
                    speed = Speed.Slow;
                break;
                case 1:
                    speed = Speed.Normal;
                    break;
                case 2:
                    speed = Speed.Fast;
                    break;
            }
        }
    }
}
