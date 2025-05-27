namespace FlappyBirdGame
{
    partial class OptionForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            menu = new Button();
            label = new Label();
            volume = new Label();
            trackBar1 = new TrackBar();
            character = new Label();
            character3 = new Button();
            character2 = new Button();
            character1 = new Button();
            volumelabel = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu.Location = new Point(110, 365);
            menu.Name = "menu";
            menu.Size = new Size(181, 55);
            menu.TabIndex = 0;
            menu.Text = "back to menu";
            menu.UseVisualStyleBackColor = true;
            menu.Click += button1_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(129, 10);
            label.Name = "label";
            label.Size = new Size(122, 38);
            label.TabIndex = 1;
            label.Text = "options";
            // 
            // volume
            // 
            volume.AutoSize = true;
            volume.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            volume.Location = new Point(158, 95);
            volume.Name = "volume";
            volume.Size = new Size(68, 22);
            volume.TabIndex = 2;
            volume.Text = "Volume";
            // 
            // trackBar1
            // 
            trackBar1.BackColor = SystemColors.Control;
            trackBar1.Location = new Point(20, 127);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(360, 56);
            trackBar1.TabIndex = 3;
            trackBar1.TickFrequency = 10;
            trackBar1.Value = 50;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // character
            // 
            character.AutoSize = true;
            character.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            character.Location = new Point(149, 201);
            character.Name = "character";
            character.Size = new Size(83, 22);
            character.TabIndex = 4;
            character.Text = "character";
            // 
            // character3
            // 
            character3.Location = new Point(262, 274);
            character3.Name = "character3";
            character3.Size = new Size(75, 42);
            character3.TabIndex = 5;
            character3.Text = "cat";
            character3.UseVisualStyleBackColor = true;
            character3.Click += button2_Click;
            // 
            // character2
            // 
            character2.Location = new Point(162, 274);
            character2.Name = "character2";
            character2.Size = new Size(76, 42);
            character2.TabIndex = 6;
            character2.Text = "dog";
            character2.UseVisualStyleBackColor = true;
            character2.Click += button3_Click;
            // 
            // character1
            // 
            character1.Location = new Point(62, 274);
            character1.Name = "character1";
            character1.Size = new Size(75, 42);
            character1.TabIndex = 7;
            character1.Text = "bird";
            character1.UseVisualStyleBackColor = true;
            character1.Click += button4_Click;
            // 
            // volumelabel
            // 
            volumelabel.AutoSize = true;
            volumelabel.Location = new Point(160, 178);
            volumelabel.Name = "volumelabel";
            volumelabel.Size = new Size(82, 19);
            volumelabel.TabIndex = 8;
            volumelabel.Text = "volume:50";
            // 
            // OptionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 475);
            Controls.Add(volumelabel);
            Controls.Add(character1);
            Controls.Add(character2);
            Controls.Add(character3);
            Controls.Add(character);
            Controls.Add(trackBar1);
            Controls.Add(volume);
            Controls.Add(label);
            Controls.Add(menu);
            Name = "OptionForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label volume;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label character;
        private System.Windows.Forms.Button character3;
        private System.Windows.Forms.Button character2;
        private System.Windows.Forms.Button character1;
        private System.Windows.Forms.Label volumelabel;
    }
}

