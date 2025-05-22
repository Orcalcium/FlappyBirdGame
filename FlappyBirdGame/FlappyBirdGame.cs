using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public static class AppGlobals
    {
        // Global constants
        public const int FormWidth = 900;
        public const int FormHeight = 600;

        public const int AppVolume = 50; // Default volume level
        public static readonly Character[] Characters = new Character[3]
        {
            new Character("Bird"),
            new Character("Cat"),
            new Character("Dog")
        }; // Character options

        public static Character SelectedCharacter = Characters[0]; // Default selected character
    }
    // The following class is used to represent a character
    // It contains a name and an image
    // For now the image member doesn't need to be implemented
    public class Character
    {
        public string Name { get; set; }
        //public Image CharacterImage { get; set; }

        public Character(string name)
        {
            Name = name;
            //CharacterImage = characterImage;
        }
    }
    public class OptionsForm : Form
    {
        //TODO: add following components to the form
        // 1. A label with the text "Options"
        // 2. A Label with the text "Volume"
        // 3. A slider to adjust the volume
        // 3.1 the slider should be placed below the volume label
        // 3.1 The slider should have a range of 0 to 100
        // 3.2 The slider should have a default value of 50
        // 3.3 When the slider is moved, the volume(APP_VOLUME in AppGlobals class) should be updated
        //     e.g. AppGlobals.AppVolume = slider.Value;
        // 4. A button to go back to the main menu
        // 4.1 When the button is clicked, close the OptionsForm
        // 5. A listbox contain three Items for character selection
        // 5.1 The listbox should contain the following items: "Bird", "Cat", "Dog"
        // 5.2 When the user selects an item, the SELECTED_CHARACTER should be updated in the AppGlobals class
        //     e.g. AppGlobals.SelectedCharacter = Characters[the selected index];
    }
    public partial class FlappyBirdGame : Form
    {

        private Label titleLabel;
        public FlappyBirdGame()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
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


    }
}