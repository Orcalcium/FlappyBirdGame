namespace FlappyBirdGame
{
    partial class FlappyBirdGame
    {
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
            this.Text = "Flappy bird";
            this.Size = new Size(AppGlobals.FormWidth, AppGlobals.FormHeight);

            //Determine title specifications
            Font titleFont = new Font("Arial", 48, FontStyle.Bold);
            int titleWidth = TextRenderer.MeasureText("Flappy Bird", titleFont).Width;
            int titleCenterX = (AppGlobals.FormWidth - titleWidth) / 2;
            int titleCenterY = 40;
            titleLabel = new Label
            {
                Text = "Flappy Bird",
                Font = titleFont,
                Location = new Point(titleCenterX, titleCenterY),
                AutoSize = true
            };
            this.Controls.Add(titleLabel);
            Button[] menuButtons = new Button[3];

            string[] buttonNames = { "Start", "Option", "Quit" };
            for (int i = 0; i < menuButtons.Length; i++)
            {
                int buttonWidth = 120;
                int btnCenterX = (AppGlobals.FormWidth - buttonWidth) / 2;
                int buttonHeight = 40;
                int buttonY = AppGlobals.FormHeight / 2 + (i - 1) * (buttonHeight + 20);
                menuButtons[i] = new Button
                {
                    Text = buttonNames[i],
                    Location = new Point(btnCenterX, buttonY),
                    Size = new Size(buttonWidth, 40)
                };
                this.Controls.Add(menuButtons[i]);
            }
            menuButtons[0].Click += new EventHandler(StartButton_Click);
            menuButtons[1].Click += new EventHandler(OptionButton_Click);
            menuButtons[2].Click += new EventHandler(QuitButton_Click);

        }

        #endregion
    }
}