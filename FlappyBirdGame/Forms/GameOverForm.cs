using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame.Forms
{
    public partial class GameOverForm : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_SYSMENU = 0x80000; // System menu (close button)
                const int WS_MINIMIZEBOX = 0x20000; // Minimize button
                const int WS_MAXIMIZEBOX = 0x10000; // Maximize button

                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU; // Disable close button
                cp.Style &= ~WS_MINIMIZEBOX; // Disable minimize button
                cp.Style &= ~WS_MAXIMIZEBOX; // Disable maximize button
                return cp;
            }
        }
        public string labelText
        {
            get => label1.Text;
            set => label1.Text = value;
        }
        public GameOverForm()
        {
            this.Name = "";
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnMenu_Click(object sender, EventArgs e)
        {
            var mainMenu = Application.OpenForms.OfType<MainMenu>().FirstOrDefault();
            if (mainMenu != null)
            {
                mainMenu.Show();
                this.Close();
                return;
            }
            mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                form.Close();
            }
            Application.Exit();
        }

        private void GameOverForm_Load(object sender, EventArgs e)
        {

        }
    }
}
