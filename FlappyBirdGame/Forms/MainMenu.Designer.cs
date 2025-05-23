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
            int buttonWidth = 120;
            int buttonHeight = 40;

            // Button 1: Start
            int btn1CenterX = (AppGlobals.FormWidth - buttonWidth) / 2;
            int btn1Y = AppGlobals.FormHeight / 2 - (buttonHeight + 20);
            Button startButton = new Button
            {
                Text = buttonNames[0],
                Location = new Point(btn1CenterX, btn1Y),
                Size = new Size(buttonWidth, buttonHeight)
            };
            this.Controls.Add(startButton);
            startButton.Click += new EventHandler(StartButton_Click);

            // Button 2: Option
            int btn2CenterX = (AppGlobals.FormWidth - buttonWidth) / 2;
            int btn2Y = AppGlobals.FormHeight / 2;
            Button optionButton = new Button
            {
                Text = buttonNames[1],
                Location = new Point(btn2CenterX, btn2Y),
                Size = new Size(buttonWidth, buttonHeight)
            };
            this.Controls.Add(optionButton);
            optionButton.Click += new EventHandler(OptionButton_Click);

            // Button 3: Quit
            int btn3CenterX = (AppGlobals.FormWidth - buttonWidth) / 2;
            int btn3Y = AppGlobals.FormHeight / 2 + (buttonHeight + 20);
            Button quitButton = new Button
            {
                Text = buttonNames[2],
                Location = new Point(btn3CenterX, btn3Y),
                Size = new Size(buttonWidth, buttonHeight)
            };
            this.Controls.Add(quitButton);
            quitButton.Click += new EventHandler(QuitButton_Click);
            {
                int btnCenterX = (AppGlobals.FormWidth - buttonWidth) / 2;
                int buttonY = AppGlobals.FormHeight / 2 + (2 - 1) * (buttonHeight + 20);
                menuButtons[0] = new Button
                {
                    Text = buttonNames[0],
                    Location = new Point(btnCenterX, buttonY),
                    Size = new Size(buttonWidth, 40)
                };
                this.Controls.Add(menuButtons[0]);
                // Create and configure the button
                menuButtons[1] = new Button
                {
                    Text = buttonNames[1],
                    Location = new Point(btnCenterX, buttonY),
                    Size = new Size(buttonWidth, 40)
                };
                this.Controls.Add(menuButtons[1]);
                menuButtons[2] = new Button
                {
                    Text = buttonNames[2],
                    Location = new Point(btnCenterX, buttonY),
                    Size = new Size(buttonWidth, 40)
                };
                this.Controls.Add(menuButtons[2]);
            }
            menuButtons[0].Click += new EventHandler(StartButton_Click);
            menuButtons[1].Click += new EventHandler(OptionButton_Click);
            menuButtons[2].Click += new EventHandler(QuitButton_Click);

        }

        #endregion
    }
}