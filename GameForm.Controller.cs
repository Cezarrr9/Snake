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

        private void btnIncreaseDif_Click(object sender, EventArgs e)
        {
            if (gameTimer.Interval != 40)
            {
                gameTimer.Interval -= 30;
                if (gameTimer.Interval == 40)
                {
                    lblDif.Text = "Mode: Hard";
                    lblHighscore.Text = $"Highscore: {_highscoreHard}";
                }
                else
                {
                    lblDif.Text = "Mode: Medium";
                    lblHighscore.Text = $"Highscore: {_highscoreMedium}";
                }
            }

            RestartGame();
        }

        private void btnDecreaseDif_Click(object sender, EventArgs e)
        {
            if (gameTimer.Interval != 100)
            {
                gameTimer.Interval += 30;
                if (gameTimer.Interval == 100)
                {
                    lblDif.Text = "Mode: Easy";
                    lblHighscore.Text = $"Highscore: {_highscoreEasy}";
                }
                else
                {
                    lblDif.Text = "Mode: Medium";
                    lblHighscore.Text = $"Highscore: {_highscoreMedium}";
                }
            }

            RestartGame();
        }

        // Buttons from CD View
        private void btnEDif_Click(object sender, EventArgs e)
        {
            gameTimer.Interval = 100;
            lblDif.Text = "Mode: Easy";

            GameView();

            RestartGame();
        }

        private void btnMDif_Click(object sender, EventArgs e)
        {
            gameTimer.Interval = 70;
            lblDif.Text = "Mode: Medium";

            GameView();

            RestartGame();
        }

        private void btnHDif_Click(object sender, EventArgs e)
        {
            gameTimer.Interval = 40;
            lblDif.Text = "Mode: Hard";

            GameView();

            RestartGame();
        }

        // Button from the Start Game View
        private void btnStart_Click(object sender, EventArgs e)
        {
            ChooseDifficultyView();
        }

        // Key down control
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
                if (_pauseFlag == false && gameTimer.Enabled)
                {
                    gameTimer.Stop();

                    _pauseFlag = true;

                    btnPlayAgain.Enabled = true;
                    btnPlayAgain.Text = "Restart Game";
                    btnPlayAgain.Visible = true;

                    btnQuit.Enabled = true;
                    btnQuit.Visible = true;

                    btnIncreaseDif.Enabled = true;
                    btnIncreaseDif.Visible = true;

                    btnDecreaseDif.Enabled = true;
                    btnDecreaseDif.Visible = true;
                }
                else if (_pauseFlag == true)
                {
                    _pauseFlag = false;

                    btnPlayAgain.Enabled = false;
                    btnPlayAgain.Visible = false;
                    btnPlayAgain.Text = "Play Again";

                    btnQuit.Enabled = false;
                    btnQuit.Visible = false;

                    btnIncreaseDif.Enabled = false;
                    btnIncreaseDif.Visible = false;

                    btnDecreaseDif.Enabled = false;
                    btnDecreaseDif.Visible = false;

                    gameTimer.Start();
                }
                return;
            }
        }
    }
}
