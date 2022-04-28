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
    public partial class Settings : Form
    {
        public int memorySize = 2;
        public int startVisibility = 2;
        public double afterClickVisibility = 0.5;
        public Settings()
        {
            InitializeComponent();
            this.BackColor = Color.LightSkyBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            memorySize = Convert.ToInt32(numericUpDownMemorySize.Value);
            startVisibility = Convert.ToInt32(numericUpDownStartVisibility.Value);
            afterClickVisibility = Convert.ToDouble(numericUpDownClickVisibility.Value);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
