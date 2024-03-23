using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public class GamePanel : Panel
    {
        // List of all the points in the snake
        public List<Point> Snake { get; set; }

        // List of all the moves that await to be executed 
        public List<Direction> Moves { get; set; }

        // The position of the food
        public Point Food { get; set; }

        // Timer which tracks the speed at which the 
        // game panel is updated 
        public Timer GameTimer { get; set; }

        // Timer which keeps track of the seconds that 
        // have passed since the beginning of the game 
        public Timer CountTimer { get; set; }

        // The score of the player (or how much food the snake ate)
        public int Score { get; set; }

        // The number of seconds that have passed
        // since the beginning of the game
        public int Time { get; set; }

        // The size of a cell inside the game panel
        public const int CELL_SIZE = 20;

        // The current direction in which the snake is moving
        public Direction CurrentDirection { get; set; }

        // Event for changing the  score label
        public event Action<int> ScoreChanged;

        // Event for changing the time label
        public event Action<int> TimeChanged;

        // Event for when the game has stopped
        public event Action GameStopped;

        public GamePanel()
        {
            Moves = new List<Direction>();
            Snake = new List<Point>();
            Food = Point.Empty;
            GameTimer = new Timer();
        }

        /// <summary>
        /// Gets the score, time and current direction to their initial values.
        /// </summary>
        private void ResetGame()
        {
            Score = 0;
            Time = 0;
            ScoreChanged?.Invoke(Score);
            TimeChanged?.Invoke(Time);
            CurrentDirection = Direction.Left;
        }

        /// <summary>
        /// Generates a random location for the food to be placed. 
        /// </summary>
        private void PlaceFood()
        {
            var rnd = new Random();
            // It continues to generate random points until
            // it finds one that is not on the snake.
            do
            {
                int x = rnd.Next(Width / CELL_SIZE);
                int y = rnd.Next(Height / CELL_SIZE);
                Food = new Point(x, y);
            } while (Snake.Contains(Food));
        }

        /// <summary>
        /// Place the snake in the center of the panel.
        /// </summary>
        private void PlaceSnake()
        {
            Snake.Clear();
            Snake.Add(new Point(10, 10));
        }

        /// <summary>
        /// Increases the number of seconds that have passed since
        /// the beginning of the game and invokes the event that changes 
        /// the time label with the new value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateTime(object sender, EventArgs e)
        {
            Time += 1;
            TimeChanged?.Invoke(Time);
        }

        /// <summary>
        /// Updates the state of the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                GameStopped?.Invoke();
                return;
            }

            // Check for collisions with itself
            if (Snake.Contains(newHead))
            {
                GameTimer.Stop(); 
                CountTimer.Stop();
                GameStopped?.Invoke();
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
                    GameStopped?.Invoke();
                    return;
                }

                // If they didn't win, then generate new food
                // and increase the speed of the snake.
                PlaceFood();
                GameTimer.Interval -= 1;
            }

            // Empty the list of moves 
            Moves.Clear();

            // If the game is still on, redraw
            Invalidate();
        }

        /// <summary>
        /// Declares the game timer.
        /// </summary>
        private void InitializeGameTimer()
        {
            GameTimer = new Timer();
            GameTimer.Interval = 400;
            GameTimer.Tick += UpdateGame;
            GameTimer.Start();
        }

        /// <summary>
        /// Declares the count timer.
        /// </summary>
        private void InitializeCountTimer()
        {
            CountTimer = new Timer();
            CountTimer.Interval = 1000;
            CountTimer.Tick += UpdateTime;
            CountTimer.Start();
        }

        /// <summary>
        /// Starts a game. 
        /// </summary>
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
