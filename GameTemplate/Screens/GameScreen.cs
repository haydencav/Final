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
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown, Player1shoot;
        
        //player2 button control keys - DO NOT CHANGE
        Boolean aDown, sDown, dDown, wDown, cDown, vDown, xDown, zDown, Player2shoot;

        #endregion

        //TODO - Place game global variables here
        //---------------------------------------

        Image tank;
        Image tank2;

        string tankDirection = "right";
        string tankDirection2 = "up";
        string winScreen = ""; 

        //initial starting points for  P1 and P2 
        int drawX = 100;
        int drawY = 100;

        int drawXX = 500;
        int drawYY = 500;
        
        //Bullets 
        int BX1 = -100;
        int BY1 = -100;
        string bDirection1 = "";
        string bDirection2 = "";
        //string bDirection3 = "Right";
        //string bDirection4 = "Down"; 

        int BX2 = -100;
        int BY2 = -100; 

        

        //Graphics objects
        SolidBrush heroBrush = new SolidBrush(Color.Black);
        SolidBrush BulletBrush = new SolidBrush(Color.Black);

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
                    tankDirection = "left"; 
                    break;
                case Keys.Down:
                    downArrowDown = true;

                    tank = Properties.Resources.Player1_Down;
                    tankDirection = "down"; 
                    break;
                case Keys.Right:
                    rightArrowDown = true;

                    tank = Properties.Resources.Player1_Right;
                    tankDirection = "right"; 
                    break;
                case Keys.Up:
                    upArrowDown = true;

                    tank = Properties.Resources.Player1;
                    tankDirection = "up"; 
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
                    tankDirection2 = "left"; 
                    break;
                case Keys.S:
                    sDown = true;
                    tank2 = Properties.Resources.Player2_Down;
                    tankDirection2 = "down"; 
                    break;
                case Keys.D:
                    dDown = true;
                    tank2 = Properties.Resources.Player2_Right;
                    tankDirection2 = "right"; 
                    break;
                case Keys.W:
                    wDown = true;
                    tank2 = Properties.Resources.Player2;
                    tankDirection2 = "up"; 
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

        double calculateDistance(int BX1, int BY1, int drawX, int drawY)//method to calculate distance in collision 
        {
            return ((Math.Sqrt(Math.Pow(BX1 - drawX, 2) + Math.Pow(BY1 - drawY, 2))));
        } 
        
        
        
        
        
        
        
        
        /// <summary>
        /// All game update logic must be placed in this event method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region main character movements

            if (leftArrowDown == true && drawX > 0)
            {
                drawX--;
            }
            if (downArrowDown == true && drawY < ScreenControl.controlHeight - 50) //&& (100 + drawY) < (this.Height - 30))
            {
                drawY++;
            }
            if (rightArrowDown == true && drawX < ScreenControl.controlWidth - 50)
            {
                drawX++;
            }
            if (upArrowDown == true && drawY > 0)
            {
                drawY--;
            }

            //player 2 movements 
            if (aDown == true && drawXX > 0)
            {
                drawXX--;
            }
            if (sDown == true && drawYY < ScreenControl.controlHeight - 50)
            {
                drawYY++;
            }
            if (dDown == true && drawXX < ScreenControl.controlWidth - 50)
            {
                drawXX++;
            }
            if (wDown == true && drawYY > 0)
            {
                drawYY--;
            }



            #region collision detection - TO BE COMPLETED

            if (mDown == true)
            {
                if (tankDirection == "right")
                {
                    BX1 = drawX + 50;
                    BY1 = drawY + 23;
                }
                else if (tankDirection == "left")
                {
                    BX1 = drawX + 0;
                    BY1 = drawY + 23;
                }
                else if (tankDirection == "down")
                {
                    BX1 = drawX + 25;
                    BY1 = drawY + 50;
                }
                else if (tankDirection == "up")
                {
                    BX1 = drawX + 23;
                    BY1 = drawY + 0;
                }

                bDirection1 = tankDirection;

                Player1shoot = true;

            }

            ///player 2 
            if (xDown == true)
            {
                if (tankDirection2 == "right")
                {
                    BX2 = drawXX + 50;
                    BY2 = drawYY + 23;
                }
                else if (tankDirection2 == "left")
                {
                    BX2 = drawXX + 0;
                    BY2 = drawYY + 23;
                }
                else if (tankDirection2 == "down")
                {
                    BX2 = drawXX + 25;
                    BY2 = drawYY + 50;
                }
                else if (tankDirection2 == "up")
                {
                    BX2 = drawXX + 23;
                    BY2 = drawYY + 0;
                }
                //check to see what direction tank is facing and set direction string.
                bDirection2 = tankDirection2;

                Player2shoot = true; 

            }

            if (Player1shoot == true)
            {
                if (bDirection1 == "right")
                {
                    BX1 += 5;
                }
                else if (bDirection1 == "up")
                {

                    BY1 -= 5;

                }
                else if (bDirection1 == "left")
                {

                    BX1 -= 5;
                }
                else if (bDirection1 == "down")
                {

                    BY1 += 5;

                }


            }

            if (Player2shoot == true)
            {
                if (bDirection2 == "right")
                {
                    BX2 += 5;
                }
                else if (bDirection2 == "up")
                {

                    BY2 -= 5;

                }
                else if (bDirection2 == "left")
                {

                    BX2 -= 5;
                }
                else if (bDirection2 == "down")
                {

                    BY2 += 5;


                }
            }

            if (Math.Sqrt(Math.Pow(BX1 - drawXX - 25, 2) + Math.Pow(BY1 - drawYY - 25, 2)) < 25)
            {
                tank2 = Properties.Resources.explosion;
                gameTimer.Enabled = false;
                winScreen = "Player 1 Wins!!!";
                winLabel.Text = winScreen; 

                
            }
            else if (Math.Sqrt(Math.Pow(BX2 - drawX - 25, 2) + Math.Pow(BY2 - drawY - 25, 2)) < 25)
            {
                tank = Properties.Resources.explosion;
                gameTimer.Enabled = false;
                winScreen = "Player 2 Wins!!!";
                winLabel.Text = winScreen;
            }

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
            //draw player
            
            e.Graphics.DrawImage(tank, drawX, drawY, 50, 50);
            e.Graphics.DrawImage(tank2, drawXX, drawYY, 50, 50);
            e.Graphics.FillEllipse(BulletBrush, BX1, BY1, 5, 5);
            e.Graphics.FillEllipse(BulletBrush, BX2, BY2, 5, 5);
        }
    }
}
#endregion