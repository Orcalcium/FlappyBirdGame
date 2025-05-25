using FlappyBirdGame.Objects;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FlappyBirdGame
{
    public static class KeyboardHelper
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        public static bool IsKeyDown(Keys key)
        {
            return (GetAsyncKeyState((int)key) & 0x8000) != 0;
        }
    }
    public partial class GameForm : Form
    {
        PauseForm transpause;
        List<Pillar> pillars = new List<Pillar>();
        private Character character = AppGlobals.SelectedCharacter;
        GameState state = AppGlobals.GameState;
        private System.Windows.Forms.Timer gameLoopTimer;
        private System.Windows.Forms.Timer pillarTimer;
        private System.Windows.Forms.Timer pillarSpeedUpTimer;
        private System.Windows.Forms.Timer jumpTimer; // Timer for jump duration
        private float pillarSpeed = 1f; // Speed at which pillars move
        private float pillarSpawnRate = 4000f; // Time in seconds between pillar spawns
        private float pillarSpeedUpRate = 10000f; // Time in seconds to increase pillar speed
        private Vector2 characterSpeed = new Vector2(0f, 0f); // Speed of the character
        private bool isJumping = false; // Flag to check if the character is jumping
        private float jumpVelocity = -3f; // Initial jump velocity
        private float gravity = 1f; // Gravity effect on the character

        public GameForm()
        {
            InitializeComponent();
            transpause = new PauseForm(this);
            gameLoopTimer = new System.Windows.Forms.Timer
            {
                Interval = (int)AppGlobals.RefreshRate // Set the timer interval to 1 second (1000 ms)
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
            // Initialize the jump timer
            jumpTimer = new System.Windows.Forms.Timer
            {
                Interval = 500 // Set the jump duration to 500ms (adjust as needed)
            };
            jumpTimer.Tick += (sender, e) =>
            {
                isJumping = false; // Reset the jump state
                jumpTimer.Stop(); // Stop the timer
            };

            SpawnCharacter();
        }

        private void GameLoop()
        {
            // Game loop logic here
            // This is where you would update the game state, check for collisions, etc.
            if (state.IsInGame())
            {
                foreach (Pillar pillar in pillars)
                    pillar.transform.Translate(new Vector2(-pillarSpeed, 0f));
                CharacterMove();
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
            pillars.Add(new Pillar(this.ClientSize.Width, gapHeight + gapWidth, 50, bottomPillarLength, false));
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

        private void SpawnCharacter()
        {
            character.transform.position.x = 100; // Set the initial x position of the character
            character.transform.position.y = this.ClientSize.Height / 2; // Set the initial y position of the character
            Controls.Add(character.button); // Add the character's button to the form
        }

        private void IncreasePillarSpeed()
        {
            pillarSpeed *= 1.5f; // Increase the speed by 0.5 units
            pillarTimer.Interval = Math.Max((int)(pillarSpawnRate / pillarSpeed), 1); // Adjust the spawn rate based on the new speed
        }
        private void CharacterMove()
        {
            if (state.IsInGame())
            {
                // Check for jump input
                if ((KeyboardHelper.IsKeyDown(Keys.Z) || KeyboardHelper.IsKeyDown(Keys.Up)) && !isJumping)
                {
                    isJumping = true; // Set the jump flag
                    character.transform.Translate(characterSpeed); // Apply upward velocity
                    jumpTimer.Start(); // Start the jump timer
                }

                // Apply gravity to bring the character down
                if (isJumping)
                {
                    character.transform.Translate(new Vector2(0, jumpVelocity)); // Simulate gravity
                    characterSpeed = new Vector2(0f,0f);
                }
                else
                {
                    characterSpeed.y += gravity; // Increase downward speed due to gravity
                    character.transform.Translate(characterSpeed); // Apply gravity when not jumping
                }
                character.Update();
            }
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            state.Pause();
            PuaseTimers();
            transpause.Location = this.Location;
            transpause.StartPosition = this.StartPosition;
            transpause.FormClosing += delegate { this.Show(); };
            transpause.Show();
            this.Hide();
        }
        public void PuaseTimers()
        {
            gameLoopTimer.Stop();
            pillarTimer.Stop();
            pillarSpeedUpTimer.Stop();
            jumpTimer.Stop();
        }
        public void ResumeTimers()
        {
            gameLoopTimer.Start();
            pillarTimer.Start();
            pillarSpeedUpTimer.Start();
            jumpTimer.Start();
        }
        private void GameForm_Load(object sender, EventArgs e)
        {

        }


    }
}