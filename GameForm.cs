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
            gamePanel.BringToFront();
            gamePanel.InitializeGame();
        }

        private void GameForm_Resize(object sender, EventArgs e)
        {
            CenterBackgroundPanel();
            CenterGamePanel();
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
    }

    public class GamePanel : Panel
    {
        public List<Point> Snake { get; set; }
        public Point Food { get; set; }
        public Size GridSize { get; set; }
        public int CellSize { get; set; }
        public Direction CurrentDirection { get; set; }
        private Timer GameTimer;

        public GamePanel()
        {
            this.Snake = new List<Point>();
            this.Food = Point.Empty;
            this.GridSize = new Size(20, 20);
            this.CellSize = 20;
            this.CurrentDirection = Direction.Left;
            this.GameTimer = new Timer();
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
                MessageBox.Show("Game Over!");
                return;
            }

            if (Snake.Contains(newHead))
            {
                GameTimer.Stop(); // Stop the game
                MessageBox.Show("Game Over!");
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
                PlaceFood();
            }

            // If the game is still on, call panel1.Invalidate() to redraw
            Invalidate();
        }
        public void InitializeGame()
        {
            PlaceSnake();
            PlaceFood();

            GameTimer = new Timer();
            GameTimer.Interval = 100;
            GameTimer.Tick += UpdateGame;
            GameTimer.Start();
        }
    }
}
