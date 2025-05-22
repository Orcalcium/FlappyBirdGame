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
        public GameForm()
        {
            InitializeComponent();
            transpause = new PauseForm(this);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            
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