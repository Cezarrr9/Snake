using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private List<Point> snake;
        private int cellSize;
        private Size gridSize;
        private Direction currentDirection;
        private Point food;

        public GameForm()
        {
            InitializeComponent();
            CenterGamePanel();
            InitializeGame();
        }

        private void GameForm_Resize(object sender, EventArgs e)
        {
            CenterGamePanel();
        }

        private void InitializeGame()
        {
            
            snake = new List<Point>();
            food = Point.Empty; 
            gridSize = new Size(20, 20); 
            cellSize = 20; 
            currentDirection = Direction.Right;

            snake.Clear();
            snake.Add(new Point(5, 5)); // Starting point of the snake
            PlaceFood();
        }

        private void PlaceFood()
        {
            Random rnd = new Random();
            int x = rnd.Next(GamePanel.Width / cellSize);
            int y = rnd.Next(GamePanel.Height / cellSize);
            food = new Point(x, y);
        }

        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Customize your border style
            int thickness = 2; // Thickness of the border
            Color borderColor = Color.Black; // Color of the border

            using (Pen pen = new Pen(borderColor, thickness))
            {
                // Drawing just inside the bounds to avoid clipping
                g.DrawRectangle(pen, 0, 0, GamePanel.Width - thickness, GamePanel.Height - thickness);
            }

            foreach (var segment in snake)
            {
                g.FillRectangle(Brushes.Green, segment.X * cellSize, segment.Y * cellSize, cellSize, cellSize);
            }

            g.FillRectangle(Brushes.Red, food.X * cellSize, food.Y * cellSize, cellSize, cellSize);
        }
    }
}
