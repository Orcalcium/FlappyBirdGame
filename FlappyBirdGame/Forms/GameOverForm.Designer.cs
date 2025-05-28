namespace FlappyBirdGame.Forms
{
    partial class GameOverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOverForm));
            btnMenu = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Turquoise;
            btnMenu.Font = new Font("Noto Sans Mono CJK TC Bold", 3.5F);
            btnMenu.ForeColor = Color.Linen;
            btnMenu.Location = new Point(102, 308);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(304, 82);
            btnMenu.TabIndex = 3;
            btnMenu.Text = resources.GetString("btnMenu.Text");
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Unispace", 25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(95, 82);
            label1.Name = "label1";
            label1.Size = new Size(178, 50);
            label1.TabIndex = 4;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.Font = new Font("Noto Sans Mono CJK TC Bold", 3.5F);
            button1.ForeColor = Color.Linen;
            button1.Location = new Point(412, 308);
            button1.Name = "button1";
            button1.Size = new Size(302, 82);
            button1.TabIndex = 5;
            button1.Text = " ██████╗ ██╗   ██╗██╗████████╗\r\n██╔═══██╗██║   ██║██║╚══██╔══╝\r\n██║   ██║██║   ██║██║   ██║   \r\n██║▄▄ ██║██║   ██║██║   ██║   \r\n╚██████╔╝╚██████╔╝██║   ██║   \r\n ╚══▀▀═╝  ╚═════╝ ╚═╝   ╚═╝   ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // GameOverForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.IMG_0667;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnMenu);
            Name = "GameOverForm";
            Load += GameOverForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnMenu;
        private Label label1;
        private Button button1;
    }
}