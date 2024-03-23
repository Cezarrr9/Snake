using System;
using System.Linq;
using System.Windows.Forms;

namespace Snake
{
    // The directions in which the snake can move 
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            CenterBackgroundPanel();
            CenterGamePanel();
            PlaceScoreLabel();
            PlaceTimeLabel();
            PlacePlayAgainButton();
            PlaceQuitGameButton();
            PlacePauseGameButton();
            PlaceResumeGameButton();

            gamePanel.BringToFront();
            gamePanel.InitializeGame();
            gamePanel.ScoreChanged += GamePanel_ScoreChanged;
            gamePanel.TimeChanged += GamePanel_TimeChanged;
            gamePanel.GameStopped += GamePanel_GameStopped;
        }

        /// <summary>
        /// Exits the application in case the form was closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        
        /// <summary>
        /// Processes the commands of the player in order to maneuver the snake.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns>true if the key was processed and consumed by control; othwerise, false</returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                // The snake can't move suddenly to the opposite direction.
                // Also, we allow just one key to be processed
                // before each update of the game panel.
                case Keys.Up:
                    if (gamePanel.CurrentDirection != Direction.Down && gamePanel.Moves.Count() == 0)
                        gamePanel.CurrentDirection = Direction.Up;
                        gamePanel.Moves.Add(gamePanel.CurrentDirection);
                    break;
                case Keys.Down:
                    if (gamePanel.CurrentDirection != Direction.Up && gamePanel.Moves.Count() == 0)
                        gamePanel.CurrentDirection = Direction.Down;
                        gamePanel.Moves.Add(gamePanel.CurrentDirection);
                    break;
                case Keys.Left:
                    if (gamePanel.CurrentDirection != Direction.Right && gamePanel.Moves.Count() == 0)
                        gamePanel.CurrentDirection = Direction.Left;
                        gamePanel.Moves.Add(gamePanel.CurrentDirection);
                    break;
                case Keys.Right:
                    if (gamePanel.CurrentDirection != Direction.Left && gamePanel.Moves.Count() == 0)
                        gamePanel.CurrentDirection = Direction.Right;
                        gamePanel.Moves.Add(gamePanel.CurrentDirection);
                    break;
            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData); 
        }

        /// <summary>
        /// Sets the playing view and start a new game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            SetPlayingView();
            gamePanel.InitializeGame();
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Pauses the game and offers the player the opportunity to
        /// either continue the game or start a new game. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPause_Click(object sender, EventArgs e)
        {
            gamePanel.CountTimer.Stop();
            gamePanel.GameTimer.Stop();

            btnPlayAgain.Text = "Restart Game";

            GamePanel_GameStopped();

            btnResume.Visible = true;
            btnResume.Enabled = true;
        }

        /// <summary>
        /// Sets the playing view and unpauses the timers. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResume_Click(object sender, EventArgs e)
        {
            SetPlayingView();
            gamePanel.CountTimer.Start();
            gamePanel.GameTimer.Start();
        }
    }
}
