using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTemplate.Screens
{
    public partial class MenuScreen : UserControl
    {
        Color buttonBackColor = Color.White;
        Color buttonActiveColor = Color.Green;

        public MenuScreen()
        {
            InitializeComponent();

            //ScreenControl.setComponentValues(this);

            defaultOverride();
            playButton.Location = new Point(ScreenControl.controlWidth / 2 - playButton.Size.Width / 2, 290);
            exitButton.Location = new Point(ScreenControl.controlWidth / 2 - playButton.Size.Width / 2, 390);
            logoBox.Location = new Point(50, 150);
            logoBox.Size = new Size(250, 250);
            gameTitle.Location = new Point(325, 150);
            howtoButton.Location = new Point(ScreenControl.controlWidth / 2 - playButton.Size.Width / 2, 340);

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "GameScreen");
        }

        private void instructionButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "InstructionScreen");
        }

        private void scoresButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "ScoreScreen");
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "OptionScreen");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Change any control default values here
        /// </summary>
        public void defaultOverride()
        {


            foreach (Control c in this.Controls)
            {
                c.Location = new Point(c.Location.X, c.Location.Y + 75);             
            }

            gameTitle.Font = new Font("Courier New", 30);
            gameTitle.Location = new Point(ScreenControl.controlWidth / 2 - gameTitle.Size.Width / 2, 50);
        }


    }
}
