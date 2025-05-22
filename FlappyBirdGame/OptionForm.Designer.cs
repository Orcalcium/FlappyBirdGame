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
            this.menu = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.character = new System.Windows.Forms.Label();
            this.character3 = new System.Windows.Forms.Button();
            this.character2 = new System.Windows.Forms.Button();
            this.character1 = new System.Windows.Forms.Button();
            this.volumelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Location = new System.Drawing.Point(110, 346);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(181, 52);
            this.menu.TabIndex = 0;
            this.menu.Text = "back to menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(129, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(141, 45);
            this.label.TabIndex = 1;
            this.label.Text = "options";
            // 
            // volume
            // 
            this.volume.AutoSize = true;
            this.volume.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volume.Location = new System.Drawing.Point(158, 90);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(84, 27);
            this.volume.TabIndex = 2;
            this.volume.Text = "Volume";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.Location = new System.Drawing.Point(20, 120);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(360, 69);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // character
            // 
            this.character.AutoSize = true;
            this.character.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.character.Location = new System.Drawing.Point(149, 190);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(102, 27);
            this.character.TabIndex = 4;
            this.character.Text = "character";
            // 
            // character3
            // 
            this.character3.Location = new System.Drawing.Point(262, 260);
            this.character3.Name = "character3";
            this.character3.Size = new System.Drawing.Size(75, 40);
            this.character3.TabIndex = 5;
            this.character3.Text = "cat";
            this.character3.UseVisualStyleBackColor = true;
            this.character3.Click += new System.EventHandler(this.button2_Click);
            // 
            // character2
            // 
            this.character2.Location = new System.Drawing.Point(162, 260);
            this.character2.Name = "character2";
            this.character2.Size = new System.Drawing.Size(76, 40);
            this.character2.TabIndex = 6;
            this.character2.Text = "dog";
            this.character2.UseVisualStyleBackColor = true;
            this.character2.Click += new System.EventHandler(this.button3_Click);
            // 
            // character1
            // 
            this.character1.Location = new System.Drawing.Point(62, 260);
            this.character1.Name = "character1";
            this.character1.Size = new System.Drawing.Size(75, 40);
            this.character1.TabIndex = 7;
            this.character1.Text = "bird";
            this.character1.UseVisualStyleBackColor = true;
            this.character1.Click += new System.EventHandler(this.button4_Click);
            // 
            // volumelabel
            // 
            this.volumelabel.AutoSize = true;
            this.volumelabel.Location = new System.Drawing.Point(160, 169);
            this.volumelabel.Name = "volumelabel";
            this.volumelabel.Size = new System.Drawing.Size(79, 18);
            this.volumelabel.TabIndex = 8;
            this.volumelabel.Text = "volume:50";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 450);
            this.Controls.Add(this.volumelabel);
            this.Controls.Add(this.character1);
            this.Controls.Add(this.character2);
            this.Controls.Add(this.character3);
            this.Controls.Add(this.character);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.label);
            this.Controls.Add(this.menu);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

