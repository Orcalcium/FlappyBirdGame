using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace FlappyBirdGame
{
    public partial class OptionForm : Form
    {
        public int AppVolume = 50; // Default volume level
        public static readonly Character[] Characters = new Character[3]
        {
            new Character("Bird"),
            new Character("Cat"),
            new Character("Dog")
        }; // Character options

        public static Character SelectedCharacter = Characters[0]; // Default selected character
        public OptionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SelectedCharacter = Characters[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectedCharacter = Characters[2];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectedCharacter = Characters[1];
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            AppVolume = trackBar1.Value;
            volumelabel.Text = $"Volume: {AppVolume}";
        }

    }
}