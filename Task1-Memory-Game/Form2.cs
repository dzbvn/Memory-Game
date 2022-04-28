using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_Memory_Game
{
    public partial class Form2 : Form

    {
        public int memorySize = 2;
        public int startVisibility = 2;
        public double afterClickVisibility = 0.5;
        public string playerName = "Player";

        public Form2()
        {
            InitializeComponent();
            ButtonInit();
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

        private void button1_Click(object sender, EventArgs e)
        {
            memorySize = Convert.ToInt32(numericUpDownMemorySize.Value);
            startVisibility = Convert.ToInt32(numericUpDownStartVisibility.Value);
            afterClickVisibility = Convert.ToDouble(numericUpDownClickVisibility.Value);
            playerName = textBoxName.Text;
            this.Close();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Leaderboard l = new Leaderboard();
            l.ShowDialog();
        }
    }
}
