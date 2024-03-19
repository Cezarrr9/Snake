using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
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
                g.DrawRectangle(pen, offsetThickness, offsetThickness, backgroundPanel.Width - thickness, backgroundPanel.Height - thickness);
            }
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
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
        }

        private void GamePanel_ScoreChanged(int newScore)
        {
            lblScore.Text = $"Score: {newScore}"; // Update the label with the new score
        }

        private void GamePanel_TimeChanged(int newTime)
        {
            lblTime.Text = $"Time: {newTime}";
        }

        private void GamePanel_GameOver()
        {
            btnPlayAgain.Visible = true;
            btnPlayAgain.Enabled = true;

            btnQuit.Visible = true;
            btnQuit.Enabled = true;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            btnPlayAgain.Visible = false;
            btnPlayAgain.Enabled = false;

            btnQuit.Visible = false;
            btnQuit.Enabled = false;

            gamePanel.InitializeGame();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class GamePanel : Panel
    {
        public List<Point> Snake { get; set; }
        public Point Food { get; set; }
        public Size GridSize { get; set; }
        public int CellSize { get; set; }
        public Direction CurrentDirection { get; set; }
        private int Score;
        private int Time;
        private Timer GameTimer;
        public event Action<int> ScoreChanged;
        public event Action<int> TimeChanged;
        public event Action GameOver;

        public GamePanel()
        {
            Snake = new List<Point>();
            Food = Point.Empty;
            GridSize = new Size(20, 20);
            CellSize = 20;
            GameTimer = new Timer();
        }
        
        private void ResetGame()
        {
            Score = 0;
            Time = 0;
            ScoreChanged?.Invoke(Score);
            TimeChanged?.Invoke(Time);
            CurrentDirection = Direction.Left;
        }

        private void PlaceFood()
        {
            Random rnd = new Random();
            int x = rnd.Next(Width / CellSize);
            int y = rnd.Next(Height / CellSize);
            Food = new Point(x, y);
        }

        private void PlaceSnake()
        {
            Snake.Clear();
            Snake.Add(new Point(5, 5));
        }

        public void UpdateGame(object sender, EventArgs e)
        {
            // Update snake's position based on currentDirection
            Point head = Snake[0];
            Point newHead = head;

            switch (CurrentDirection)
            {
                case Direction.Left:
                    newHead = new Point(head.X - 1, head.Y);
                    break;
                case Direction.Right:
                    newHead = new Point(head.X + 1, head.Y);
                    break;
                case Direction.Up:
                    newHead = new Point(head.X, head.Y - 1);
                    break;
                case Direction.Down:
                    newHead = new Point(head.X, head.Y + 1);
                    break;
            }

            // Check for collisions
            if (newHead.X < 0 ||
                newHead.Y < 0 ||
                newHead.X >= Width / CellSize ||
                newHead.Y >= Height / CellSize)
            {
                GameTimer.Stop(); // Stop the game
                //MessageBox.Show("Game Over!");
                GameTimer.Stop();
                GameOver?.Invoke();
                return;
            }

            if (Snake.Contains(newHead))
            {
                GameTimer.Stop(); // Stop the game
                //MessageBox.Show("Game Over!");
                GameTimer.Stop();
                GameOver?.Invoke();
                return;
            }

            // Check if the food is eaten and grow the snake
            Snake.Insert(0, newHead);
            if (newHead != Food)
            {
                // Only remove the tail if the snake didn't eat food
                Snake.RemoveAt(Snake.Count - 1);
            }
            else
            {
                // If the snake ate the food, place a new food item
                Score += 1;
                PlaceFood();
                ScoreChanged?.Invoke(Score);
            }
            
            Time += 1;
            if (Time % 10 == 0)
            {
                TimeChanged?.Invoke(Time / 10);
            }

            // If the game is still on, call panel1.Invalidate() to redraw
            Invalidate();
        }
        public void InitializeGame()
        {
            ResetGame();
            PlaceSnake();
            PlaceFood();

            GameTimer = new Timer();
            GameTimer.Interval = 100;
            GameTimer.Tick += UpdateGame;
            GameTimer.Start();
        }
    }
}
