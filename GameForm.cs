using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
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
            CenterScoreLabel();
            CenterTimeLabel();
            CenterPlayAgainButton();
            CenterQuitGameButton();
            CenterPauseGameButton();
            CenterResumeGameButton();

            gamePanel.BringToFront();
            gamePanel.InitializeGame();
            gamePanel.ScoreChanged += GamePanel_ScoreChanged;
            gamePanel.TimeChanged += GamePanel_TimeChanged;
            gamePanel.GameOver += GamePanel_GameOver;
        }

        private void GameForm_Resize(object sender, EventArgs e)
        {
            CenterBackgroundPanel();
            CenterGamePanel();
            CenterScoreLabel();
            CenterTimeLabel();
            CenterPlayAgainButton();
            CenterQuitGameButton();
            CenterPauseGameButton();
            CenterResumeGameButton();
        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (var segment in gamePanel.Snake)
            {
                g.FillRectangle(Brushes.Green, segment.X * gamePanel.CellSize, segment.Y * gamePanel.CellSize,
                    gamePanel.CellSize, gamePanel.CellSize);
            }

            g.FillRectangle(Brushes.Red, gamePanel.Food.X * gamePanel.CellSize, gamePanel.Food.Y * gamePanel.CellSize,
                gamePanel.CellSize, gamePanel.CellSize);
        }

        private void backgroundPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Customize your border style
            int thickness = 10; // Thickness of the border
            Color borderColor = Color.Black; // Color of the border

            // For having the borders of the same thickness
            float offsetThickness = thickness / 2f;

            using (Pen pen = new Pen(borderColor, thickness))
            {
                // Drawing just inside the bounds to avoid clipping
                g.DrawRectangle(pen, offsetThickness, offsetThickness, backgroundPanel.Width - thickness,
                    backgroundPanel.Height - thickness);
            }
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Handle arrow keys as part of the game control here
            switch (keyData)
            {
                case Keys.Up:
                    if (gamePanel.CurrentDirection != Direction.Down)
                        gamePanel.CurrentDirection = Direction.Up;
                    break;
                case Keys.Down:
                    if (gamePanel.CurrentDirection != Direction.Up)
                        gamePanel.CurrentDirection = Direction.Down;
                    break;
                case Keys.Left:
                    if (gamePanel.CurrentDirection != Direction.Right)
                        gamePanel.CurrentDirection = Direction.Left;
                    break;
                case Keys.Right:
                    if (gamePanel.CurrentDirection != Direction.Left)
                        gamePanel.CurrentDirection = Direction.Right;
                    break;
            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData); 
        }

        private void GamePanel_ScoreChanged(int newScore)
        {
            lblScore.Text = $"Score: {newScore}"; 
        }

        private void GamePanel_TimeChanged(int newTime)
        {
            lblTime.Text = $"Time: {newTime}";
        }

        private void SetPlayingView()
        {
            btnPlayAgain.Visible = false;
            btnPlayAgain.Enabled = false;
            btnPlayAgain.Text = "Play Again";

            btnQuit.Visible = false;
            btnQuit.Enabled = false;

            btnPause.Visible = true;
            btnPause.Enabled = true;

            btnResume.Visible = false;
            btnResume.Enabled = false;
        }

        private void GamePanel_GameOver()
        {
            btnPlayAgain.Visible = true;
            btnPlayAgain.Enabled = true;

            btnQuit.Visible = true;
            btnQuit.Enabled = true;

            btnPause.Visible = false;
            btnPause.Enabled = false;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            SetPlayingView();
            gamePanel.InitializeGame();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            gamePanel.CountTimer.Stop();
            gamePanel.GameTimer.Stop();

            btnPlayAgain.Text = "Restart Game";
            btnPlayAgain.Visible = true;
            btnPlayAgain.Enabled = true;

            btnQuit.Visible = true;
            btnQuit.Enabled = true;

            btnResume.Visible = true;
            btnResume.Enabled = true;

            btnPause.Visible = false;
            btnPause.Enabled = false;
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            SetPlayingView();
            gamePanel.CountTimer.Start();
            gamePanel.GameTimer.Start();
        }
    }
}
