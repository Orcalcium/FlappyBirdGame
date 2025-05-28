using FlappyBirdGame.Objects;
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
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_SYSMENU = 0x80000; // System menu (close button)
                const int WS_MINIMIZEBOX = 0x20000; // Minimize button
                const int WS_MAXIMIZEBOX = 0x10000; // Maximize button

                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU; // Disable close button
                cp.Style &= ~WS_MINIMIZEBOX; // Disable minimize button
                cp.Style &= ~WS_MAXIMIZEBOX; // Disable maximize button
                return cp;
            }
        }
        public int AppVolume = 50; // Default volume level
        GameState state = AppGlobals.GameState; // Game state instance


        public static Character SelectedCharacter = AppGlobals.Characters[0]; // Default selected character
        public OptionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainMenu = Application.OpenForms.OfType<MainMenu>().FirstOrDefault();
            mainMenu.pictureBox.Image = AppGlobals.characterImage; // Update the main menu character image
            mainMenu.Refresh();
            state.InMainMenu();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppGlobals.characterImage = Properties.Resources.green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppGlobals.characterImage = Properties.Resources.StupidBird;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectedCharacter = AppGlobals.Characters[2];
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            AppVolume = trackBar1.Value;
            volumelabel.Text = $"Volume: {AppVolume}";
            AppGlobals.CharacterSize = (AppVolume+30)/5*3-10;
        }

        private void volume_Click(object sender, EventArgs e)
        {

        }
    }
}