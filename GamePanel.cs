using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public class GamePanel : Panel
    {
        public List<Point> Snake { get; set; }
        public Point Food { get; set; }
        public Timer GameTimer { get; set; }
        public Timer CountTimer { get; set; }
        public int Score { get; set; }
        public int Time { get; set; }
        public const int CELL_SIZE = 20;
        public Direction CurrentDirection { get; set; }

        public event Action<int> ScoreChanged;
        public event Action<int> TimeChanged;
        public event Action GameOver;

        public GamePanel()
        {
            Snake = new List<Point>();
            Food = Point.Empty;
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
            var rnd = new Random();
            do
            {
                int x = rnd.Next(Width / CELL_SIZE);
                int y = rnd.Next(Height / CELL_SIZE);
                Food = new Point(x, y);
            } while (Snake.Contains(Food));
        }

        private void PlaceSnake()
        {
            Snake.Clear();
            Snake.Add(new Point(10, 10));
        }

        private void UpdateTime(object sender, EventArgs e)
        {
            Time += 1;
            TimeChanged?.Invoke(Time);
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

            // Check for collisions with the frame
            if (newHead.X < 0 ||
                newHead.Y < 0 ||
                newHead.X >= Width / CELL_SIZE ||
                newHead.Y >= Height / CELL_SIZE)
            {
                GameTimer.Stop(); 
                CountTimer.Stop();
                GameOver?.Invoke();
                return;
            }

            // Check for collisions with itself
            if (Snake.Contains(newHead))
            {
                GameTimer.Stop(); 
                CountTimer.Stop();
                GameOver?.Invoke();
                return;
            }

            // Grow the snake
            Snake.Insert(0, newHead);

            // Check if the snake ate
            if (newHead != Food)
            {
                // Only remove the tail if the snake didn't eat food
                Snake.RemoveAt(Snake.Count - 1);
            }
            else
            {
                // If the snake ate the food, verify if the player won the game
                Score += 1;
                ScoreChanged?.Invoke(Score);
                if (Score == Width - 1)
                {
                    GameTimer.Stop();
                    CountTimer.Stop();
                    MessageBox.Show("You Won!");
                    GameOver?.Invoke();
                    return;
                }
                PlaceFood();
                GameTimer.Interval -= 1;
            }

            // If the game is still on, redraw
            Invalidate();
        }

        private void InitializeGameTimer()
        {
            GameTimer = new Timer();
            GameTimer.Interval = 400;
            GameTimer.Tick += UpdateGame;
            GameTimer.Start();
        }

        private void InitializeCountTimer()
        {
            CountTimer = new Timer();
            CountTimer.Interval = 1000;
            CountTimer.Tick += UpdateTime;
            CountTimer.Start();
        }

        public void InitializeGame()
        {
            ResetGame();
            PlaceSnake();
            PlaceFood();
            InitializeGameTimer();
            InitializeCountTimer();
        }
    }
}
