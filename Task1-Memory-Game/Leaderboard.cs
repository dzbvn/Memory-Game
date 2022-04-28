using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Task1_Memory_Game
{

    public partial class Leaderboard : Form
    {

        List<Result> resultList;
        List<Result> currentResultList;
        HashSet<int> boardSizeSet;
        HashSet<string> playerNamesSet;

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
        public Leaderboard()
        {
            InitializeComponent();
            this.BackColor = Color.LightSkyBlue;
            //ButtonInit();
            //this.listBox1.Items = 
            ReadJson();
            ListViewInit();
        }
        public void ButtonInit()
        {
            this.BackColor = Color.LightSkyBlue;
            foreach (Button btn in Controls.OfType<Button>())
            {
                btn.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.Yellow;
                btn.FlatAppearance.BorderSize = 1;
            }
            
        }
        public void ListViewInit()
        {
            
            listView1.Columns.Add("Player name"); //column 1 heading
            listView1.Columns.Add("Board size"); //column 2 heading
            listView1.Columns.Add("Time"); //column 1 heading
            listView1.Columns.Add("Points"); //column 2 heading
            listView1.View = View.Details; //make column headings visible
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            updateLeaderboard();
            comboBoxSort.Items.Add("Player Name ↓");
            comboBoxSort.Items.Add("Player Name ↑");
            comboBoxSort.Items.Add("Board Size ↓");
            comboBoxSort.Items.Add("Board Size ↑");
            comboBoxSort.Items.Add("Time ↓");
            comboBoxSort.Items.Add("Time ↑");
            comboBoxSort.Items.Add("Points ↓");
            comboBoxSort.Items.Add("Points ↑");

        }
        public void ReadJson()
        {
            resultList = new List<Result>();
            using (StreamReader r = new StreamReader(@"C:\Users\szymo\AGH\Semestr IV\PZ2\Lab3\Task1-Memory-Game\results\resultList.json"))
            {
                string json = r.ReadToEnd();
                resultList = JsonConvert.DeserializeObject<List<Result>>(json);
            }
            Console.WriteLine(resultList[0].playerName);
        }
        public void updateLeaderboard()
        {
            listView1.Items.Clear();
            
            currentResultList = new List<Result>();
            foreach (Result res in resultList)
            {
                // create new ListViewItem
                //boardSizeSet.Add(Convert.ToInt32(res.memorySize));
                //playerNamesSet.Add(res.playerName);
                if (!comboBoxBoardSize.Items.Contains(res.memorySize))
                {
                    comboBoxBoardSize.Items.Add(res.memorySize);
                }
                if (!comboBoxPName.Items.Contains(res.playerName))
                {
                    comboBoxPName.Items.Add(res.playerName);
                }
            }
            if (comboBoxPName.SelectedItem != null && comboBoxBoardSize.SelectedItem != null)
            {

                foreach (Result res in resultList)
                {
                    if (res.playerName == comboBoxPName.SelectedItem && res.memorySize == Convert.ToInt32(comboBoxBoardSize.SelectedItem))
                    {
                        ListViewItem lvi = new ListViewItem(res.playerName);
                        lvi.SubItems.Add(res.memorySize.ToString());
                        lvi.SubItems.Add(res.time.ToString());
                        lvi.SubItems.Add(res.points.ToString());
                        // add the listviewitem to a new row of the ListView control
                        listView1.Items.Add(lvi);
                        currentResultList.Add(res);
                    }
                }
            }
            else if (comboBoxPName.SelectedItem != null)
            {
                foreach (Result res in resultList)
                {
                    if (res.playerName == comboBoxPName.SelectedItem)
                    {
                        ListViewItem lvi = new ListViewItem(res.playerName);
                        lvi.SubItems.Add(res.memorySize.ToString());
                        lvi.SubItems.Add(res.time.ToString());
                        lvi.SubItems.Add(res.points.ToString());
                        // add the listviewitem to a new row of the ListView control
                        listView1.Items.Add(lvi);
                        currentResultList.Add(res);
                    }
                }
            }
            else if (comboBoxBoardSize.SelectedItem != null)
            {
                foreach (Result res in resultList)
                {
                    if (res.memorySize == Convert.ToInt32(comboBoxBoardSize.SelectedItem))
                    {
                        ListViewItem lvi = new ListViewItem(res.playerName);
                        lvi.SubItems.Add(res.memorySize.ToString());
                        lvi.SubItems.Add(res.time.ToString());
                        lvi.SubItems.Add(res.points.ToString());
                        // add the listviewitem to a new row of the ListView control
                        listView1.Items.Add(lvi);
                        currentResultList.Add(res);
                    }
                }
            }
            else
            {
                foreach (Result res in resultList)
                {

                    ListViewItem lvi = new ListViewItem(res.playerName);
                    lvi.SubItems.Add(res.memorySize.ToString());
                    lvi.SubItems.Add(res.time.ToString());
                    lvi.SubItems.Add(res.points.ToString());
                    // add the listviewitem to a new row of the ListView control
                    listView1.Items.Add(lvi);
                    currentResultList.Add(res);
                }
            }
        }

        public void updateSorting()
        {
            if(comboBoxSort.SelectedItem == "Player Name ↑")
            {
                resultList = resultList.OrderBy(r => r.playerName).ToList();
            }
            else if (comboBoxSort.SelectedItem == "Board Size ↑")
            {
                resultList = resultList.OrderBy(r => r.memorySize).ToList();
            }
            else if (comboBoxSort.SelectedItem == "Time ↑")
            {
                resultList = resultList.OrderBy(r => r.time).ToList();
            }
            else if (comboBoxSort.SelectedItem == "Points ↑")
            {
                resultList = resultList.OrderBy(r => r.points).ToList();
            }
            else if (comboBoxSort.SelectedItem == "Player Name ↓")
            {
                resultList = resultList.OrderByDescending(r => r.playerName).ToList();
            }
            else if (comboBoxSort.SelectedItem == "Board Size ↓")
            {
                resultList = resultList.OrderByDescending(r => r.memorySize).ToList();
            }
            else if (comboBoxSort.SelectedItem == "Time ↓")
            {
                resultList = resultList.OrderByDescending(r => r.time).ToList();
            }
            else if (comboBoxSort.SelectedItem == "Points ↓")
            {
                resultList = resultList.OrderByDescending(r => r.points).ToList();
            }
        }
       

        private void comboBoxBoardSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateLeaderboard(); 
        }

        private void comboBoxPName_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateLeaderboard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxBoardSize.SelectedIndex = -1;
            comboBoxPName.SelectedIndex = -1;
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateSorting();
            updateLeaderboard();
        }
    }
}
