using System;
using System.Drawing;
using System.Windows.Forms;
 

namespace FlappyBirdGame
{


    // The following class is used to represent a character
    // It contains a name and an image
    // For now the image member doesn't need to be implemented
    public partial class MainMenu : Form
    {
        GameState state = AppGlobals.gameState;
        private Label titleLabel;
        public MainMenu()
        {
            titleLabel=new Label();
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            state.InGame();
            this.Hide();
            var gameForm = new GameForm();
            gameForm.ShowDialog();
        }
        private void OptionButton_Click(object sender, EventArgs e)
        {
            var OptionForm = new OptionForm();
            OptionForm.ShowDialog();
        }
        private void QuitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Exit Game?",
                "Yes",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {
                    form.Close();
                }
                Application.Exit();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}