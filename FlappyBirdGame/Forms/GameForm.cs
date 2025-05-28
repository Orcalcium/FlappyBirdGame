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
using FlappyBirdGame.Utilities;
using FlappyBirdGame.Forms;

namespace FlappyBirdGame
{
    public class KeyStateTracker
    {
        private static HashSet<Keys> pressedKeys = new HashSet<Keys>();

        public static bool IsKeyDown(Keys key)
        {
            return pressedKeys.Contains(key);
        }

        public static void SetKeyState(Keys key, bool isDown)
        {
            if (isDown)
                pressedKeys.Add(key);
            else
                pressedKeys.Remove(key);
        }
    }
    public partial class GameForm : Form
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
        PauseForm pauseform;
        GameOverForm gameOverForm;
        List<Pillar> pillars = new List<Pillar>();
        private Character character = AppGlobals.SelectedCharacter;
        GameState state = AppGlobals.GameState;

        private float pillarSpeed = 1f; // Speed at which pillars move
        private float pillarSpawnRate = 6000f; // Time in seconds between pillar spawns
        private float pillarSpeedUpRate = 10000f; // Time in seconds to increase pillar speed
        private Vector2 characterSpeed = new Vector2(0f, 0f); // Speed of the character
        private bool isJumping = false; // Flag to check if the character is jumping
        private float jumpVelocity = -3f; // Initial jump velocity
        private float gravity = 1f; // Gravity effect on the character
        private System.Windows.Forms.Timer mainTimer;
        private float elapsedPillarSpawn = 0f;
        private float elapsedPillarSpeedUp = 0f;
        private float elapsedJump = 0f;
        private readonly float jumpDuration = 500f; // ms
        public GameForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            character.button.BackgroundImage= AppGlobals.characterImage; // Set the character's image from AppGlobals
            SuspendLayout();
            InitializeComponent();
            this.Text = "";
            this.KeyPreview = true;
            this.KeyDown += GameForm_KeyDown;
            this.KeyUp += GameForm_KeyUp;
            gameOverForm = new GameOverForm();

            pauseform = new PauseForm(this);
            
            mainTimer = new System.Windows.Forms.Timer
            {
                Interval = (int)AppGlobals.RefreshRate // e.g., 16ms for ~60fps
            };
            mainTimer.Tick += MainTimer_Tick;
            mainTimer.Start();
            SpawnCharacter();
            ResumeLayout();
            SpawnPillar();
        }
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            float delta = mainTimer.Interval;

            if (state.IsInGame())
            {
                // Game loop logic
                GameLoop();

                // Pillar spawn logic
                elapsedPillarSpawn += delta;
                if (elapsedPillarSpawn >= pillarSpawnRate)
                {
                    SpawnPillar();
                    elapsedPillarSpawn = 0f;
                }

                // Pillar speed up logic
                elapsedPillarSpeedUp += delta;
                if (elapsedPillarSpeedUp >= pillarSpeedUpRate)
                {
                    IncreasePillarSpeed();
                    elapsedPillarSpeedUp = 0f;
                }

                // Jump logic
                if (isJumping)
                {
                    elapsedJump += delta;
                    if (elapsedJump >= jumpDuration)
                    {
                        isJumping = false;
                        elapsedJump = 0f;
                    }
                }
            }
        }
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            KeyStateTracker.SetKeyState(e.KeyCode, true);
            e.Handled = true;
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            KeyStateTracker.SetKeyState(e.KeyCode, false);
            e.Handled = true;
        }

        private void GameLoop()
        {
            // Game loop logic here
            // This is where you would update the game state, check for collisions, etc.
            if (state.IsInGame())
            {
                foreach (Pillar pillar in pillars)
                {
                    pillar.transform.Translate(new Vector2(-pillarSpeed, 0f));
                  
                }
                    
                CharacterMove();
                //update the compnents to show result
                foreach (Pillar pillar in pillars)
                {
                    pillar.Update();
                }
                
                CheckCollisions();
                AppGlobals.score = (int)characterSpeed.y + (int)pillarSpeed;
                AppGlobals.score *= 2;
            }

        }

        private void CheckCollisions()
        {
            foreach(Pillar pillar in pillars)
            {
                bool crashflag = false;
                if (HitBox.IsCollided(character.hitbox, pillar.hitbox, character.transform, pillar.transform) )
                {
                    crashflag = true;
                }
                if(character.transform.position.y < 0 || character.transform.position.y > this.ClientSize.Height)
                {
                    crashflag = true;
                }

                if (crashflag)
                {
                    state.GameOver(); // Trigger game over if character collides with a pillar
                    PuaseTimers(); // Pause the game timers
                    gameOverForm.Location = this.Location;
                    gameOverForm.StartPosition = this.StartPosition;
                    if(character.transform.position.y < 0)
                    {
                        gameOverForm.labelText = $"{AppGlobals.id} \ncrashed into the ceiling \nwith a speed of {AppGlobals.score} km/s";
                    }
                    else if (character.transform.position.y > this.ClientSize.Height)
                    {
                        gameOverForm.labelText = $"{AppGlobals.id} \ncrashed into the floor \nwith a speed of {AppGlobals.score} km/s";
                    }
                    else
                    {
                        gameOverForm.labelText = $"{AppGlobals.id} \ncrashed into a pillar \nwith a speed of {AppGlobals.score} km/s";
                    }
                    gameOverForm.Show();
                    this.Close();
                    return; // Exit the game loop to prevent further processing
                }
            }
        }

        private void SpawnPillar()
        {
            SuspendLayout();
            // Create a random gap between the top and bottom pillars
            Random random = new Random();
            int gapHeight = random.Next(75, 225); // Random gap height between 100 and 200 pixels
            int gapWidth = 150; // Width of the gap
            int bottomPillarLength = 550; // Height of each pillar

            // Add the top pillar
            pillars.Add(new Pillar(this.ClientSize.Width, 0f, 50, gapHeight, true));

            // Add the bottom pillar, positioned below the gap
            pillars.Add(new Pillar(this.ClientSize.Width, gapHeight + gapWidth+bottomPillarLength/2, 50, bottomPillarLength, false));
            foreach (Pillar pillar in pillars)
            {
                Controls.Add(pillar.panel); // Add the pillar to the form for demonstration purposes
                pillar.Update();
            }

            // Remove pillars that are out of bounds
            for (int i = pillars.Count - 1; i >= 0; i--)
            {
                Pillar pillar = pillars[i];
                if (pillar.transform.position.x < -100)
                {
                    Controls.Remove(pillar.panel); // Remove the pillar's button from the form
                    pillars.RemoveAt(i); // Remove the pillar from the list
                }
            }
            ResumeLayout();
        }

        private void SpawnCharacter()
        {
            character = AppGlobals.SelectedCharacter; // Get the selected character from AppGlobals
            character.transform.position.x = 100; // Set the initial x position of the character
            character.transform.position.y = this.ClientSize.Height / 2; // Set the initial y position of the character
            Controls.Add(character.button); // Add the character's button to the form
            character.Update();
        }

        private void IncreasePillarSpeed()
        {
            pillarSpeed *= 1.5f; // Increase the speed by 0.5 units
            pillarSpawnRate = Math.Max(pillarSpawnRate / 1.5f, 500f);
        }
        private void CharacterMove()
        {
            if (state.IsInGame())
            {
                // Check for jump input
                if ((KeyStateTracker.IsKeyDown(Keys.Z) || KeyStateTracker.IsKeyDown(Keys.Up)) && !isJumping)
                {
                    isJumping = true;
                    elapsedJump = 0f;
                    character.transform.Translate(characterSpeed);
                }

                // Apply gravity to bring the character down
                if (isJumping)
                {
                    character.transform.Translate(new Vector2(0, jumpVelocity));
                    characterSpeed = new Vector2(0f, 0f);
                }
                else
                {
                    characterSpeed.y += gravity;
                    character.transform.Translate(characterSpeed);
                }
                character.Update();
            }
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            pause();
        }
        private void pause()
        {
            state.Pause();
            PuaseTimers();
            pauseform.Location = this.Location;
            pauseform.StartPosition = this.StartPosition;
            pauseform.FormClosing += delegate { this.Show(); };
            pauseform.Show();
            this.Hide();
        }
        public void PuaseTimers()
        {
            mainTimer.Stop();
        }

        public void ResumeTimers()
        {
            mainTimer.Start();
        }
        private void GameForm_Load(object sender, EventArgs e)
        {

        }


    }
}