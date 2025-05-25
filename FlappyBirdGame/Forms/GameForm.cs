using FlappyBirdGame.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        List<Pillar> pillars = new List<Pillar>();
        GameState state = AppGlobals.gameState;
        private System.Windows.Forms.Timer gameLoopTimer;
        private System.Windows.Forms.Timer pillarTimer;
        private System.Windows.Forms.Timer pillarSpeedUpTimer;
        private float pillarSpeed = 1f; // Speed at which pillars move
        private float pillarSpawnRate = 4000f; // Time in seconds between pillar spawns
        private float pillarSpeedUpRate = 10000f; // Time in seconds to increase pillar speed
        public GameForm()
        {
            pillars.Add(new Pillar(this.ClientSize.Width, this.ClientSize.Height, 50, 150, true));
            pillars.Add(new Pillar(this.ClientSize.Width, 0f, 50, 150, false));
            InitializeComponent();
            transpause = new PauseForm(this);
            gameLoopTimer = new System.Windows.Forms.Timer
            {
                Interval = (int)AppGlobals.refreshRate // Set the timer interval to 1 second (1000 ms)
            };
            gameLoopTimer.Tick += (sender, e) => GameLoop(); // Attach the Tick event to the OnTimerElapsed method
            gameLoopTimer.Start();
            pillarTimer = new System.Windows.Forms.Timer
            {
                Interval = (int)pillarSpawnRate // Set the timer interval to 1 second (1000 ms)
            };
            pillarTimer.Tick += (sender, e) => SpawnPillar(); // Attach the Tick event to the SpawnPillar method
            pillarTimer.Start();
            pillarSpeedUpTimer = new System.Windows.Forms.Timer
            {
                Interval = (int)pillarSpeedUpRate // Set the timer interval to 10 seconds (10000 ms)
            };
            pillarSpeedUpTimer.Tick += (sender, e) => IncreasePillarSpeed(); // Attach the Tick event to the IncreasePillarSpeed method
            pillarSpeedUpTimer.Start();
        }

        private void GameLoop()
        {
            // Game loop logic here
            // This is where you would update the game state, check for collisions, etc.
            if (state.IsInGame())
            {
                foreach(Pillar pillar in pillars)
                pillar.transform.Translate(new Vector2(-pillarSpeed,0f));

            }

            //update the compnents to show result
            foreach (Pillar pillar in pillars)
            {
                pillar.Update();
            }

        }

        private void SpawnPillar()
        {
            // Create a random gap between the top and bottom pillars
            Random random = new Random();
            int gapHeight = random.Next(50, 200); // Random gap height between 100 and 200 pixels
            int gapWidth = 150; // Width of the gap
            int bottomPillarLength = 550; // Height of each pillar

            // Add the top pillar
            pillars.Add(new Pillar(this.ClientSize.Width, 0f, 50, gapHeight, true));

            // Add the bottom pillar, positioned below the gap
            pillars.Add(new Pillar(this.ClientSize.Width, gapHeight+gapWidth , 50, bottomPillarLength, false));
            foreach (Pillar pillar in pillars)
            {
                Controls.Add(pillar.button); // Add the pillar to the form for demonstration purposes
            }

            // Remove pillars that are out of bounds
            for (int i = pillars.Count - 1; i >= 0; i--)
            {
                Pillar pillar = pillars[i];
                if (pillar.transform.position.x < -100)
                {
                    Controls.Remove(pillar.button); // Remove the pillar's button from the form
                    pillars.RemoveAt(i); // Remove the pillar from the list
                }
            }
        }

        private void IncreasePillarSpeed()
        {
            pillarSpeed *=1.5f; // Increase the speed by 0.5 units
            pillarTimer.Interval = Math.Max((int)(pillarSpawnRate / pillarSpeed),1); // Adjust the spawn rate based on the new speed
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