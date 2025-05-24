namespace FlappyBirdGame
{
    partial class MainMenu
    {
        string[] buttonNames = { "Start", "Option", "Quit" }; 
        Button[] menuButtons = new Button[3];
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            startButton = new Button();
            optionButton = new Button();
            quitButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Location = new Point(350, 50); // Centered at the top
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(200, 50);
            titleLabel.Text = "Flappy Bird";
            titleLabel.Font = new Font("Arial", 24, FontStyle.Bold);
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.Location = new Point(375, 150); // Below the title
            startButton.Name = "startButton";
            startButton.Size = new Size(150, 50);
            startButton.Text = "Start";
            startButton.Click += StartButton_Click;
            // 
            // optionButton
            // 
            optionButton.Location = new Point(375, 220); // Below the Start button
            optionButton.Name = "optionButton";
            optionButton.Size = new Size(150, 50);
            optionButton.Text = "Options";
            optionButton.Click += OptionButton_Click;
            // 
            // quitButton
            // 
            quitButton.Location = new Point(375, 290); // Below the Options button
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(150, 50);
            quitButton.Text = "Quit";
            quitButton.Click += QuitButton_Click;
            // 
            // MainMenu
            // 
            ClientSize = new Size(882, 553);
            Controls.Add(titleLabel);
            Controls.Add(startButton);
            Controls.Add(optionButton);
            Controls.Add(quitButton);
            Name = "MainMenu";
            Text = "Flappy Bird";
            Load += MainMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button startButton;
        private Button optionButton;
        private Button quitButton;
    }
}