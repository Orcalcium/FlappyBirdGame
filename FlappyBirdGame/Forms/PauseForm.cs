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
        GameState state = AppGlobals.GameState; // Game state instance
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
        public PauseForm(GameForm gameForm)
        {
            this.gameForm = gameForm;
            
            InitializeComponent();
        }


        private void PauseForm_Load(object sender, EventArgs e)
        {
            this.Text = "";
            label1.Text = "Paused";
            btnResume.Text = "Resume";
            btnQuit.Text = "Quit";
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            gameForm.ResumeTimers();
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