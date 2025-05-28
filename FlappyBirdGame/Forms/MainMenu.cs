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

        GameState state = AppGlobals.GameState;
        private Label titleLabel;
        public MainMenu()
        {
            titleLabel = new Label();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.Text = "";
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
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                form.Close();
            }
            Application.Exit();

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            AppGlobals.id= TextBox.Text.Trim(); // Update the global id with the text from the TextBox
        }
    }
}