using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameTemplate.Dialogs;

namespace GameTemplate.Screens
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();
            tank = Properties.Resources.Player1;
            tank2 = Properties.Resources.Player2;
        }

        #region required global values - DO NOT CHANGE

        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown;

        //player2 button control keys - DO NOT CHANGE
        Boolean aDown, sDown, dDown, wDown, cDown, vDown, xDown, zDown;

        #endregion

        //TODO - Place game global variables here
        //---------------------------------------

        Image tank;
        Image tank2;

        //initial starting points for black rectangle
        int drawX = 100;
        int drawY = 100;

        int drawXX = 500;
        int drawYY = 500; 

        //Graphics objects
        SolidBrush heroBrush = new SolidBrush(Color.Black);

        //----------------------------------------

        // PreviewKeyDown required for UserControl instead of KeyDown as on a form
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                pauseGame();
            }

            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    
                    tank = Properties.Resources.Player1_Left;
                    break;
                case Keys.Down:
                    downArrowDown = true;

                    tank = Properties.Resources.Player1_Down;
                    break;
                case Keys.Right:
                    rightArrowDown = true;

                    tank = Properties.Resources.Player1_Right;
                    break;
                case Keys.Up:
                    upArrowDown = true;

                    tank = Properties.Resources.Player1;
                    break;
                case Keys.B:
                    bDown = true;
                    break;
                case Keys.N:
                    nDown = true;
                    break;
                case Keys.M:
                    mDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                default:
                    break;
            }

            //player 2 button presses
            switch (e.KeyCode)
            {
                case Keys.A:
                    aDown = true;

                    tank2 = Properties.Resources.Player2_Left;
                    break;
                case Keys.S:
                    sDown = true;

                    tank2 = Properties.Resources.Player2_Down;
                    break;
                case Keys.D:
                    dDown = true;

                    tank2 = Properties.Resources.Player2_Right;
                    break;
                case Keys.W:
                    wDown = true;

                    tank2 = Properties.Resources.Player2;
                    break;
                case Keys.C:
                    cDown = true;
                    break;
                case Keys.V:
                    vDown = true;
                    break;
                case Keys.X:
                    xDown = true;
                    break;
                case Keys.Z:
                    zDown = true;
                    break;
                default:
                    break;
            }
        }
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;

                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.B:
                    bDown = false;
                    break;
                case Keys.N:
                    nDown = false;
                    break;
                case Keys.M:
                    mDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                default:
                    break;
            }

            //player 2 button releases
            switch (e.KeyCode)
            {
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.C:
                    cDown = false;
                    break;
                case Keys.V:
                    vDown = false;
                    break;
                case Keys.X:
                    xDown = false;
                    break;
                case Keys.Z:
                    zDown = false;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// All game update logic must be placed in this event method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region main character movements

            if (leftArrowDown == true && (100 + drawX) > 0)
            {
                drawX--;
            }
            if (downArrowDown == true && (100 + drawY) < (this.Height - 30))
            {
                drawY++;
            }
            if (rightArrowDown == true)
            {
                drawX++;
            }
            if (upArrowDown == true)
            {
                drawY--;
            }

            //player 2 movements 
            if (aDown == true)
            {
                drawXX--;
            }
            if (sDown == true)
            {
                drawYY++;
            }
            if (dDown == true)
            {
                drawXX++;
            }
            if (wDown == true)
            {
                drawYY--;
            }



            #region collision detection - TO BE COMPLETED


            #endregion


            //refresh the screen, which causes the GameScreen_Paint method to run
            Refresh();
        }

        /// <summary>
        /// Open the pause dialog box and gets Cancel or Abort result from it
        /// </summary>
        private void pauseGame()
        {
            gameTimer.Enabled = false;
            rightArrowDown = leftArrowDown = upArrowDown = downArrowDown = false;

            DialogResult result = PauseDialog.Show();

            if (result == DialogResult.Cancel)
            {
                gameTimer.Enabled = true;
            }
            if (result == DialogResult.Abort)
            {
                ScreenControl.changeScreen(this, "MenuScreen");
            }
        }

        /// <summary>
        /// All drawing, (and only drawing), to be done here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw rectangle to screen
            //e.Graphics.FillRectangle(heroBrush, drawX, drawY, 20, 20);
           e.Graphics.DrawImage(tank, drawX, drawY, 50, 50);
            e.Graphics.DrawImage(tank2, drawXX, drawYY, 50, 50); 
        }
    }
}
#endregion