using System;
using System.Windows.Forms;

namespace Snake
{
    public partial class GameForm : Form
    {
        
        // Buttons from Game View

        /// <summary>
        /// Event for clicking the play again button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        /// <summary>
        /// Event for clicking the quit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Event for clicking the increase difficulty button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIncreaseDif_Click(object sender, EventArgs e)
        {
            IncreaseDif();
            RestartGame();
        }

        /// <summary>
        /// Event for clicking the decrease difficulty button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecreaseDif_Click(object sender, EventArgs e)
        {
            DecreaseDif();
            RestartGame();
        }

        // Buttons from CD View

        /// <summary>
        /// Event for clicking the easy button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEDif_Click(object sender, EventArgs e)
        {
            gameTimer.Interval = 100;
            lblDif.Text = "Mode: Easy";

            GameView();

            RestartGame();
        }

        /// <summary>
        /// Event for clicking the medium button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMDif_Click(object sender, EventArgs e)
        {
            gameTimer.Interval = 70;
            lblDif.Text = "Mode: Medium";

            GameView();

            RestartGame();
        }

        /// <summary>
        /// Event for clicking the hard button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHDif_Click(object sender, EventArgs e)
        {
            gameTimer.Interval = 40;
            lblDif.Text = "Mode: Hard";

            GameView();

            RestartGame();
        }

        // Button from Rules view

        /// <summary>
        /// Event for clicking the ready button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReady_Click(object sender, EventArgs e)
        {
            ChooseDifficultyView();
        }

        // Button from the Start Game View

        /// <summary>
        /// Event for clicking the start button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            RulesView();
        }

        /// <summary>
        /// Event for pressing down a key.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Up arrow => snake up
            if (e.KeyCode == Keys.Up && _currentDirection != Direction.Down)
            {
                if (_waitingFlag == false)
                {
                    _currentDirection = Direction.Up;
                    _waitingFlag = true;
                }
                return;
            }

            // Down arrow => snake down
            if (e.KeyCode == Keys.Down && _currentDirection != Direction.Up)
            {
                if (_waitingFlag == false)
                {
                    _currentDirection = Direction.Down;
                    _waitingFlag = true;
                }
                return;
            }

            // Right arrow => snake right
            if (e.KeyCode == Keys.Right && _currentDirection != Direction.Left)
            {
                if (_waitingFlag == false)
                {
                    _currentDirection = Direction.Right;
                    _waitingFlag = true;
                }
                return;
            }

            // Left arrow => snake left
            if (e.KeyCode == Keys.Left && _currentDirection != Direction.Right)
            {
                if (_waitingFlag == false)
                {
                    _currentDirection = Direction.Left;
                    _waitingFlag = true;
                }
                return;
            }

            // spacebar => Pause/Resume
            if (e.KeyCode == Keys.Space)
            {
                if (_pauseFlag == false && gameTimer.Enabled)
                {
                    gameTimer.Stop();

                    _pauseFlag = true;

                    btnPlayAgain.Text = "Restart Game";

                    GameStoppedView();
                }
                else if (_pauseFlag == true)
                {
                    _pauseFlag = false;

                    RestartGameView();

                    gameTimer.Start();
                }
                return;
            }
        }
    }
}
