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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            titleLabel = new Label();
            startButton = new Button();
            optionButton = new Button();
            quitButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Noto Sans Mono CJK TC Bold", 5.99999952F, FontStyle.Bold, GraphicsUnit.Point, 128);
            titleLabel.ForeColor = SystemColors.Control;
            titleLabel.Location = new Point(24, 93);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(834, 113);
            titleLabel.TabIndex = 0;
            titleLabel.Text = resources.GetString("titleLabel.Text");
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.Click += titleLabel_Click;
            // 
            // startButton
            // 
            startButton.BackColor = SystemColors.ControlText;
            startButton.Font = new Font("Noto Sans Mono CJK TC Bold", 3F, FontStyle.Bold);
            startButton.ForeColor = SystemColors.Control;
            startButton.Location = new Point(287, 209);
            startButton.Name = "startButton";
            startButton.Size = new Size(299, 68);
            startButton.TabIndex = 1;
            startButton.Text = resources.GetString("startButton.Text");
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += StartButton_Click;
            // 
            // optionButton
            // 
            optionButton.BackColor = SystemColors.ControlText;
            optionButton.Font = new Font("Noto Sans Mono CJK TC Bold", 3F, FontStyle.Bold);
            optionButton.ForeColor = SystemColors.Control;
            optionButton.Location = new Point(287, 302);
            optionButton.Name = "optionButton";
            optionButton.Size = new Size(299, 68);
            optionButton.TabIndex = 2;
            optionButton.Text = resources.GetString("optionButton.Text");
            optionButton.UseVisualStyleBackColor = false;
            optionButton.Click += OptionButton_Click;
            // 
            // quitButton
            // 
            quitButton.BackColor = SystemColors.Control;
            quitButton.Font = new Font("Noto Sans Mono CJK TC Bold", 3F, FontStyle.Bold);
            quitButton.Location = new Point(287, 395);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(299, 68);
            quitButton.TabIndex = 3;
            quitButton.Text = " ██████╗ ██╗   ██╗██╗████████╗\r\n██╔═══██╗██║   ██║██║╚══██╔══╝\r\n██║   ██║██║   ██║██║   ██║   \r\n██║▄▄ ██║██║   ██║██║   ██║   \r\n╚██████╔╝╚██████╔╝██║   ██║   \r\n ╚══▀▀═╝  ╚═════╝ ╚═╝   ╚═╝   ";
            quitButton.UseVisualStyleBackColor = false;
            quitButton.Click += QuitButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
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