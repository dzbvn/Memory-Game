using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Newtonsoft.Json;
using System.IO;


namespace Task1_Memory_Game
{
    public partial class Form1 : Form
    {


        bool started = false;
        int memorySize = 10;
        int pairsGuessed = 0;
        int badGuesses = 0;
        int points = 0;
        public int startVisibility;
        public double afterClickVisibility;

        PictureBox previousBox;
        Random rnd = new Random();

        Image defaultImg = Image.FromFile(@"C:\Users\szymo\AGH\Semestr IV\PZ2\Lab3\Task1-Memory-Game\data\background.png");
        Image formBackground = Image.FromFile(@"C:\Users\szymo\AGH\Semestr IV\PZ2\Lab3\Task1-Memory-Game\data\formBackground.png");
        string playerName;

        PictureBox[] pictureBoxes;
        List<Result> resultList;
        int seconds = 0;

        public class Result
        {
            public string playerName;
            public int time;
            public int memorySize;
            public int points;
            public Result(string playerName, int time, int memorySize, int points)
            {
                this.playerName = playerName;
                this.time = time;
                this.memorySize = memorySize;
                this.points = points;
            }
        }


        public Form1()
        {
            Form2 f = new Form2();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.memorySize = f.memorySize;
                this.startVisibility = f.startVisibility;
                this.afterClickVisibility = f.afterClickVisibility;
                this.playerName = f.playerName;

            }
          
            this.BackColor = Color.LightSkyBlue;
            InitializeComponent();
            LabelButtonInit();
            timer1.Tick += new System.EventHandler(OnTimerEvent);

        }

        public void LabelButtonInit()
        {

            foreach (Button btn in Controls.OfType<Button>())
            { 
                btn.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.Yellow;
                btn.FlatAppearance.BorderSize = 1;
            }

            this.buttonNewGame.Location = new Point(this.Width - 145, 135);
            this.buttonStart.Location = new Point(this.Width - 145, 165);
            this.buttonStop.Location = new Point(this.Width - 145, 195);
            this.buttonSettings.Location = new Point(this.Width - 145, 225);
            this.buttonLeader.Location = new Point(this.Width - 145, 255);
            this.buttonQuit.Location = new Point(this.Width - 145, this.Height - 100);

            this.buttonStart.Enabled = false;
            this.buttonStop.Enabled = false;


            this.labelPlayerName.Text = this.playerName;
            this.labelTime.Location = new Point(this.Width - 95, 80);
            this.labelPlayerName.Location = new Point(this.Width - 95, 50);
            this.label3.Location = new Point(this.Width - 145, 50);
            this.label4.Location = new Point(this.Width - 145, 80);
            this.labelPoints.Location = new Point(this.Width - 95, 110);
            this.label6.Location = new Point(this.Width - 145, 110);
            
        }

        public void Start()
        {
            seconds = 0;
            points = 0;
            pictureBoxes = new PictureBox[memorySize];
            labelPlayerName.Text = this.playerName;

            var images = GetImages();
            this.buttonStart.Enabled = false;
            this.buttonStop.Enabled = true;
            this.CreateBoard();
            this.NewGame(pictureBoxes, images);
            this.Refresh();

            ShowImages(pictureBoxes);
            
            System.Threading.Tasks.Task.Delay(Convert.ToInt32((startVisibility * 1000) + 1)).ContinueWith(_ =>
            {
                Invoke(new MethodInvoker(() => { HideImages(pictureBoxes); }));
            });
            timer1.Enabled = true;
            
            readJson();

        }
        private void OnTimerEvent(object sender, EventArgs e)
        {
            seconds++;
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            labelTime.Text = time.ToString(@"mm\:ss");
            //labelTime.Text = (Convert.ToInt32(labelTime.Text) + 1).ToString();
        }

       



        private List<Image> GetImages()
        {
            List<Image> images = new List<Image>();
            for(int i = 0; i < memorySize / 2; i++)
            {
                images.Add(Image.FromFile(@"./data/mem" + i.ToString() + ".png"));
            }
            return images;
        }

        public void NewGame(PictureBox[] pictureBoxes, List<Image> images)
        {
            foreach(PictureBox pbox in pictureBoxes)
            {
                pbox.Tag = null;
                pbox.Visible = true;
                
            }
            
            CreatePairs(pictureBoxes, images);
            HideImages(pictureBoxes);


        }

        public void HideImages(PictureBox[] pictureBoxes)
        {
            foreach (PictureBox pbox in pictureBoxes)
            {
                pbox.Image = defaultImg;
            }
            
        }

        public void ShowImages(PictureBox[] pictureBoxes)
        {
            foreach (PictureBox pbox in pictureBoxes)
            {
                pbox.Image = (Image)pbox.Tag;
                pbox.Refresh();
            }

        }

        public void MoveBoard()
        {
            int currentHeight = 0;
            int currentWidth = 0;
            int maxHeight = this.Height-38;
            int maxWidth = this.Width - 150;
            int columns = Convert.ToInt32(Math.Sqrt(memorySize));
            int pictureBoxesize;
            int heightGrowth;
            int widthGrowth;

            //labels
            this.labelTime.Location = new Point(this.Width - 95,  80);
            this.labelPlayerName.Location = new Point(this.Width - 95, 50);
            this.label3.Location = new Point(this.Width - 145, 50);
            this.label4.Location = new Point(this.Width - 145, 80);
            this.labelPoints.Location = new Point(this.Width - 95, 110);
            this.label6.Location = new Point(this.Width - 145, 110);
            this.buttonSettings.Location = new Point(this.Width - 145, 225);
            this.buttonNewGame.Location = new Point(this.Width - 145, 135);
            this.buttonStart.Location = new Point(this.Width - 145, 165);
            this.buttonLeader.Location = new Point(this.Width - 145, 255);
            this.buttonStop.Location = new Point(this.Width - 145, 195);
            this.buttonQuit.Location = new Point(this.Width - 145, this.Height - 100);
            if (pictureBoxes != null)
            {
                heightGrowth = maxHeight / columns < maxHeight / (memorySize / columns) ? maxHeight / columns : maxHeight / (memorySize / columns);
                widthGrowth = maxWidth / columns < maxWidth / (memorySize / columns) ? maxWidth / columns : maxWidth / (memorySize / columns);
                if (maxWidth < maxHeight)
                {
                    pictureBoxesize = maxWidth / columns < maxWidth / (memorySize / columns) ? maxWidth / columns : maxWidth / (memorySize / columns);
                }
                else
                {
                    pictureBoxesize = maxHeight / columns < maxHeight / (memorySize / columns) ? maxHeight / columns : maxHeight / (memorySize / columns);
                }
                for (int i = 0; i < memorySize; i++)
                {

                    if (i % columns == 0 && i != 0)
                    {
                        currentHeight += heightGrowth;
                    }
                    if (i % columns == 0 && i != 0)
                    {
                        currentWidth = 0;
                    }

                    pictureBoxes[i].Location = new Point(currentWidth, currentHeight);
                    pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxes[i].Size = new System.Drawing.Size(pictureBoxesize, pictureBoxesize);

                    currentWidth += widthGrowth;
                }
            }
        }


        public void CreateBoard()
        {
            int currentHeight = 0;
            int currentWidth = 0;
            int maxHeight = this.Height-38;
            int maxWidth = this.Width - 150;
            int columns = Convert.ToInt32(Math.Sqrt(memorySize));
            int pictureBoxesize;
            int heightGrowth;
            int widthGrowth;
        
            

            heightGrowth = maxHeight / columns < maxHeight / (memorySize / columns) ? maxHeight / columns : maxHeight / (memorySize / columns);
            widthGrowth = maxWidth / columns < maxWidth / (memorySize / columns) ? maxWidth / columns : maxWidth / (memorySize / columns);
            if (maxWidth < maxHeight)
            {
                pictureBoxesize = maxWidth / columns < maxWidth / (memorySize / columns) ? maxWidth / columns : maxWidth / (memorySize / columns);
            }
            else
            {
                pictureBoxesize = maxHeight / columns < maxHeight / (memorySize / columns) ? maxHeight / columns : maxHeight / (memorySize / columns);
            }
            for (int i = 0; i < memorySize; i++)
            {

                if (i % columns == 0 && i != 0)
                {
                    currentHeight += heightGrowth;
                    
                }
                if (i % columns == 0 && i != 0)
                {
                    currentWidth = 0;
                }

             
                pictureBoxes[i] = new PictureBox();
                pictureBoxes[i].Location = new Point(currentWidth, currentHeight);
                pictureBoxes[i].Image = defaultImg;
                pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxes[i].Size = new System.Drawing.Size(pictureBoxesize, pictureBoxesize);
                pictureBoxes[i].MouseClick += new MouseEventHandler(ClickImage);
             
                this.Controls.Add(pictureBoxes[i]);
               
                currentWidth += widthGrowth;
                
            }
        }
        

        public void CreatePairs(PictureBox[] pictureBoxes, List<Image> images)
        {
            for (int i = 0; i < memorySize / 2; i++)
            {

                while (true)
                {
                    int PictureBoxIndex = rnd.Next(0, memorySize);
                    if (pictureBoxes[PictureBoxIndex].Tag == null)
                    {
                        pictureBoxes[PictureBoxIndex].Tag = images[i];
                        break;
                    }

                }
                while (true)
                {
                    int PictureBoxIndex = rnd.Next(0, memorySize);
                    if (pictureBoxes[PictureBoxIndex].Tag == null)
                    {
                        pictureBoxes[PictureBoxIndex].Tag = images[i];
                        break;
                    }

                }
            }
        }


        private void resizeEvent(object sender, EventArgs e)
        {
            /*foreach(PictureBox pbox in pictureBoxes)
            {
                pbox.Hide();
            }*/
            this.MoveBoard();
        }

        public void ClickImage(object sender, EventArgs e)
        {
            var pBox = (PictureBox)sender;
            if(previousBox == null)
            {
                previousBox = pBox;
                pBox.Image = (Image)pBox.Tag;
                return;
            }
            else if(previousBox != null && previousBox != pBox && previousBox.Tag == pBox.Tag)
            {
                pBox.Image = (Image)pBox.Tag;
                pBox.Refresh();
                Thread.Sleep(Convert.ToInt32(afterClickVisibility * 1000));
                previousBox.Visible = false;
                pBox.Visible = false;
                previousBox = pBox;
                pairsGuessed++;
                points += 5000;
                labelPoints.Text = points.ToString();

            }
            else if(previousBox != null && previousBox != pBox && previousBox.Tag != pBox.Tag)
            {
                pBox.Image = (Image)pBox.Tag;
                pBox.Refresh();
                Thread.Sleep(Convert.ToInt32(afterClickVisibility * 1000));
                pBox.Image = defaultImg;
                previousBox.Image = defaultImg;
                previousBox = pBox;
                badGuesses += 1;
                points -= 1000;
                labelPoints.Text = points.ToString();
            }
            //game ended
            if(pairsGuessed == memorySize / 2)
            {
                timer1.Enabled = false;
                var msg = MessageBox.Show("You won!", "Congratulations!");
                resultList.Add(new Result(playerName, seconds, memorySize, points));
                toJson(resultList);
                Console.WriteLine(resultList[0].time);
                pairsGuessed = 0;
                buttonNewGame.Enabled = true;
                timer1.Enabled = false;
                seconds = 0;
            }
            previousBox = null;
        }
        public void toJson(List<Result> resultList)
        {
            string output = JsonConvert.SerializeObject(resultList);
            using (StreamWriter outputFile = new StreamWriter(@"C:\Users\szymo\AGH\Semestr IV\PZ2\Lab3\Task1-Memory-Game\results\resultList.json"))
            {

                outputFile.WriteLine(output);
            }
            Console.WriteLine(output);

            /*using (StreamReader r = new StreamReader(@"C:\Users\szymo\AGH\Semestr IV\PZ2\Lab3\Task1-Memory-Game\results\resultList.json"))
            {
                string json = r.ReadToEnd();
                resultList = JsonConvert.DeserializeObject<List<Result>>(json);
            }
            Console.WriteLine(resultList[0].playerName);*/
        }
        public void readJson()
        {
            resultList = new List<Result>();
            using (StreamReader r = new StreamReader(@"C:\Users\szymo\AGH\Semestr IV\PZ2\Lab3\Task1-Memory-Game\results\resultList.json"))
            {
                string json = r.ReadToEnd();
                resultList = JsonConvert.DeserializeObject<List<Result>>(json);
            }
            Console.WriteLine(resultList[0].playerName);
        }

        public void DisableClickEvent()
        {
            foreach(PictureBox pbox in pictureBoxes)
            {
                pbox.MouseClick -= new MouseEventHandler(ClickImage);
            }
        }

        public void AddClickEvent()
        {
            foreach (PictureBox pbox in pictureBoxes)
            {
                pbox.MouseClick += new MouseEventHandler(ClickImage);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Start();
            buttonNewGame.Enabled = false;
            points = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Settings s = new Settings();
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.memorySize = s.memorySize;
                this.startVisibility = s.startVisibility;
                this.afterClickVisibility = s.afterClickVisibility;
                
                
                foreach (Control c in Controls)
                {
                    if (c is PictureBox)
                    {
                         this.Controls.Remove(c);
                    }
                }
                this.Start();
               

            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Leaderboard l = new Leaderboard();
            l.ShowDialog();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            timer1.Enabled = false;
            DisableClickEvent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            timer1.Enabled = true;
            AddClickEvent();
        }
    }
}
