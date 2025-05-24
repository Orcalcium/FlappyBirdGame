using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame
{

    public partial class PauseForm : Form
    {
        private GameForm gameForm; // Reference to the main game form
        GameState state = AppGlobals.gameState; // Game state instance

        public PauseForm(GameForm gameForm)
        {
            this.gameForm = gameForm;
            
            InitializeComponent();
        }


        private void PauseForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Paused";
            btnResume.Text = "Resume";
            btnQuit.Text = "Quit";
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            state.InGame();
            gameForm.Show();
            this.Hide();
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                form.Close();
            }
            if (MessageBox.Show("Sure to quit?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}