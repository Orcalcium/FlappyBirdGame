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
            label1 = new Label();
            btnResume = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 30F);
            label1.Location = new Point(330, 67);
            label1.Name = "label1";
            label1.Size = new Size(169, 64);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // btnResume
            // 
            btnResume.Font = new Font("Microsoft JhengHei UI", 20F);
            btnResume.Location = new Point(330, 146);
            btnResume.Name = "btnResume";
            btnResume.Size = new Size(150, 150);
            btnResume.TabIndex = 1;
            btnResume.Text = "button1";
            btnResume.UseVisualStyleBackColor = true;
            btnResume.Click += btnResume_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Microsoft JhengHei UI", 20F);
            btnQuit.Location = new Point(330, 313);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(150, 150);
            btnQuit.TabIndex = 2;
            btnQuit.Text = "button2";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // PauseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
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