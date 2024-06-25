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

        private void Form1_Load(object sender, EventArgs e)
        {

            Button[][] btn = new Button[3][];
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


            async void eachMouseRowTask(int num)
            {
                Random r = new Random();
                int i;
                while (true)
                {
                    i = r.Next(0, 3); // 3 represents that there is not any mole in the row
                    // MessageBox.Show("" + num);
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


                    await Task.Delay(r.Next(1, 3) * 500);

                }
            }


            Task.Run( () => eachMouseRowTask(0));
            Task.Run( () => eachMouseRowTask(1));
            Task.Run( () => eachMouseRowTask(2));
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
            Func<int, int> addFun = x =>  x++;
            MessageBox.Show("After " + addFun(10).ToString() + "s");
            await Task.Delay(10000);
            Func<int, int> addFun2 = x => { return x++;  };
            MessageBox.Show("After " + addFun2(20).ToString() + "s");
           await Task.Delay(10000);
            Action<int> addFun3 = x => { MessageBox.Show("After " + (x++).ToString() + "s"); };
            addFun3(30);


        }



    }
}
