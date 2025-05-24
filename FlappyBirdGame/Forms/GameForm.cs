using FlappyBirdGame.Objects;
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
        PauseForm transpause;
        Pillar pillar;
        GameState state = AppGlobals.gameState;
        private System.Windows.Forms.Timer pauseTimer;

        public GameForm()
        {
            pillar = new Pillar(1f,1f,1f,1f,true);
            InitializeComponent();
            transpause = new PauseForm(this);
            pauseTimer = new System.Windows.Forms.Timer
            {
                Interval = (int)AppGlobals.refreshRate // Set the timer interval to 1 second (1000 ms)
            };
            pauseTimer.Tick += (sender, e) => GameLoop(); // Attach the Tick event to the OnTimerElapsed method
        }

        public void GameLoop()
        {
            // Game loop logic here
            // This is where you would update the game state, check for collisions, etc.
            if (state.IsInGame())
            {
                pillar.transform.Translate(new Vector2(0,1f));
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

        private void GameForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}