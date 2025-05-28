namespace FlappyBirdGame
{
    partial class PauseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PauseForm));
            label1 = new Label();
            btnResume = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Noto Sans Mono CJK TC Bold", 6F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(176, 88);
            label1.Name = "label1";
            label1.Size = new Size(482, 90);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            label1.Click += label1_Click;
            // 
            // btnResume
            // 
            btnResume.BackColor = Color.Turquoise;
            btnResume.Font = new Font("Microsoft JhengHei UI", 4F);
            btnResume.ForeColor = SystemColors.Control;
            btnResume.Location = new Point(257, 199);
            btnResume.Name = "btnResume";
            btnResume.Size = new Size(276, 97);
            btnResume.TabIndex = 1;
            btnResume.Text = resources.GetString("btnResume.Text");
            btnResume.UseVisualStyleBackColor = false;
            btnResume.Click += btnResume_Click;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.Turquoise;
            btnQuit.Font = new Font("Consolas", 5F, FontStyle.Bold);
            btnQuit.ForeColor = Color.Linen;
            btnQuit.Location = new Point(308, 302);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(178, 81);
            btnQuit.TabIndex = 2;
            btnQuit.Text = " ██████╗ ██╗   ██╗██╗████████╗\r\n██╔═══██╗██║   ██║██║╚══██╔══╝\r\n██║   ██║██║   ██║██║   ██║   \r\n██║▄▄ ██║██║   ██║██║   ██║   \r\n╚██████╔╝╚██████╔╝██║   ██║   \r\n ╚══▀▀═╝  ╚═════╝ ╚═╝   ╚═╝  ";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // PauseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.IMG_0667;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 475);
            Controls.Add(btnQuit);
            Controls.Add(btnResume);
            Controls.Add(label1);
            Name = "PauseForm";
            Text = "PauseForm";
            Load += PauseForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnQuit;
    }
}