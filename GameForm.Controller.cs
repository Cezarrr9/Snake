using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class GameForm : Form
    {
        
        // Buttons from Game View
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Buttons from CD View
        private void btnEDif_Click(object sender, EventArgs e)
        {
            GameView();
            gameTimer.Interval = 150;
            RestartGame();
        }

        private void btnMDif_Click(object sender, EventArgs e)
        {
            GameView();
            gameTimer.Interval = 100;
            RestartGame();
        }

        private void btnHDif_Click(object sender, EventArgs e)
        {
            GameView();
            gameTimer.Interval = 50;
            RestartGame();
        }

        // Button from the Start Game View
        private void btnStart_Click(object sender, EventArgs e)
        {
            ChooseDifficultyView();
        }

        private void GameForm_Resize(object sender, EventArgs e)
        {
            CenterTitleLabel();
            CenterStartButton();

            CenterMediumButton();
            CenterEasyButton();
            CenterHardButton();
            CenterCDLabel();

            CenterCanvas();
            PlaceScoreLabel();
            PlaceHighscoreLabel();

            PlacePlayAgainButton();
            PlaceQuitButton();
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && _currentDirection != Direction.Down)
            {
                if (_waitingFlag == false)
                {
                    _currentDirection = Direction.Up;
                    _waitingFlag = true;
                }
                return;
            }

            if (e.KeyCode == Keys.Down && _currentDirection != Direction.Up)
            {
                if (_waitingFlag == false)
                {
                    _currentDirection = Direction.Down;
                    _waitingFlag = true;
                }
                return;
            }

            if (e.KeyCode == Keys.Right && _currentDirection != Direction.Left)
            {
                if (_waitingFlag == false)
                {
                    _currentDirection = Direction.Right;
                    _waitingFlag = true;
                }
                return;
            }

            if (e.KeyCode == Keys.Left && _currentDirection != Direction.Right)
            {
                if (_waitingFlag == false)
                {
                    _currentDirection = Direction.Left;
                    _waitingFlag = true;
                }
                return;
            }

            if (e.KeyCode == Keys.Space)
            {
                if (_pauseFlag == false)
                {
                    _pauseFlag = true;

                    gameTimer.Stop();

                    btnPlayAgain.Enabled = true;
                    btnPlayAgain.Text = "Restart Game";
                    btnPlayAgain.Visible = true;

                    btnQuit.Enabled = true;
                    btnQuit.Visible = true;
                }
                else
                {
                    _pauseFlag = false;

                    btnPlayAgain.Enabled = false;
                    btnPlayAgain.Visible = false;
                    btnPlayAgain.Text = "Play Again";
                   
                    btnQuit.Enabled = false;
                    btnQuit.Visible = false;

                    gameTimer.Start();
                }
                
            }
        }
    }
}
