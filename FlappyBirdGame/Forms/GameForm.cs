using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public partial class GameForm : Form
    {
        PauseForm transpause ;
        GameState state = AppGlobals.gameState;

        public GameForm()
        {
            InitializeComponent(); 
            transpause = new PauseForm(this);

        }
        public void GameLoop()
        {
            // Game loop logic here
            // This is where you would update the game state, check for collisions, etc.
            while (!state.IsPaused())
            {

            }

        }
        
        private void btnPause_Click(object sender, EventArgs e)
        {
            state.Pause();
            transpause.Location = this.Location;
            transpause.StartPosition = this.StartPosition;
            transpause.FormClosing += delegate { this.Show(); };
            transpause.Show();
            this.Hide();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
}