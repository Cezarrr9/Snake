using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Snake
{
    public partial class GameForm : Form
    {
        private List<Unit> _snake = new List<Unit>();
        private Unit _food = new Unit();

        private Direction _currentDirection = Direction.Right;
        private int _cellSize = 35;

        private int _score = 0;
        private int _highscoreEasy = 0;
        private int _highscoreMedium = 0;
        private int _highscoreHard = 0;

        private bool _waitingFlag = false;
        private bool _pauseFlag = false;

        private int _maxHeight;
        private int _maxWidth;

        public GameForm()
        {
            InitializeComponent();
            StartGameView();
        }

        /// <summary>
        /// Updates the elements of the game according to their logic.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateGame(object sender, EventArgs e)
        {
            int coordX = _snake[0].X;
            int coordY = _snake[0].Y;

            switch (_currentDirection)
            {
                case Direction.Left:
                    coordX--;
                    break;
                case Direction.Right:
                    coordX++;
                    break;
                case Direction.Up:
                    coordY--;
                    break;
                case Direction.Down:
                    coordY++;
                    break;
            }

            // Check if the snake collides with itself 
            for (int j = 1; j < _snake.Count; j++)
            {
                if (_snake[j].X == coordX && _snake[j].Y == coordY)
                {
                    GameOver();
                    return;
                }
            }

            // Check if the snake collides with the frame
            if (coordX < 0 ||
                coordY< 0 ||
                coordX > _maxWidth ||
                coordY > _maxHeight)
            {
                GameOver();
                return;
            }

            // Update snake
            for (int i = _snake.Count - 1; i >= 1; i--)
            {
                _snake[i].X = _snake[i - 1].X;
                _snake[i].Y = _snake[i - 1].Y;
            }

            _snake[0].X = coordX;
            _snake[0].Y = coordY;

            // Check if the snake ate something 
            if (_snake[0].X == _food.X && _snake[0].Y == _food.Y)
            {
                EatFood();
            }

            _waitingFlag = false;
            
            // Redraw
            picCanvas.Invalidate();
        }

        /// <summary>
        /// Performs the logic behind the snake eating food.
        /// </summary>
        private void EatFood()
        {
            _score++;
            
            // Check if the player won
            if (_score == ((picCanvas.Width - 1) / _cellSize) * ((picCanvas.Height - 1) / _cellSize) - 2) 
            {
                gameTimer.Stop();
                WinningView();
            }

            lblScore.Text = $"Score: {_score}";

            // Add a new unit to the snake
            _snake.Add(new Unit
            {
                X = _snake[_snake.Count - 1].X,
                Y = _snake[_snake.Count - 1].Y
            });

            PlaceFood();
        }

        /// <summary>
        /// Generates a new food after its previous version has been eaten.
        /// </summary>
        private void PlaceFood()
        {
            Random rand = new Random();

            int ok = 0;
            int x = 0;
            int y = 0;

            // Generate a position until the food 
            // will not be created inside the snake
            while (ok == 0)
            {
                ok = 1;

                x = rand.Next(0, _maxWidth);
                y = rand.Next(0, _maxHeight);

                for (int i = 0; i < _snake.Count; i++)
                {
                    if (_snake[i].X == x && _snake[i].Y == y)
                    {
                        ok = 0;
                        break;
                    }
                }
            }

            _food = new Unit { X = x, Y = y };
        }

        /// <summary>
        /// Places the snake in its initial position.
        /// </summary>
        private void PlaceSnake()
        {
            _snake.Clear();
            _snake.Add(new Unit { X = 1, Y = 0 });
            _snake.Add(new Unit { X = 0, Y = 0 });
            _currentDirection = Direction.Right;
        }

        /// <summary>
        /// Stops the game.
        /// </summary>
        private void GameStopped()
        {
            gameTimer.Stop();
            GameStoppedView();
        }

        /// <summary>
        /// Stops the game and modifies highscore if the current scote is higher.
        /// </summary>
        private void GameOver()
        {
            GameStopped();

            switch (lblDif.Text)
            {
                case "Mode: Easy":
                    if (_score > _highscoreEasy)
                    {
                        _highscoreEasy = _score;
                        lblHighscore.Text = $"Highscore: {_highscoreEasy}";
                    }
                    break;
                case "Mode: Medium":
                    if (_score > _highscoreMedium)
                    {
                        _highscoreMedium = _score;
                        lblHighscore.Text = $"Highscore: {_highscoreMedium}";
                    }
                    break;
                case "Mode: Hard":
                    if (_score > _highscoreHard)
                    {
                        _highscoreHard = _score;
                        lblHighscore.Text = $"Highscore: {_highscoreHard}";
                    }
                    break;
            }
        }

        /// <summary>
        /// Increases the difficulty of the game by one level.
        /// </summary>
        private void IncreaseDif()
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
        }

        /// <summary>
        /// Decreases the difficulty of the game by one level.
        /// </summary>
        private void DecreaseDif()
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
        }

        /// <summary>
        /// Brings the game to its default settings and then starts it.
        /// </summary>
        private void RestartGame()
        {
            _maxWidth = picCanvas.Width / _cellSize - 1;
            _maxHeight = picCanvas.Height / _cellSize - 1;

            RestartGameView();

            _score = 0;
            lblScore.Text = "Score: 0";

            _pauseFlag = false;

            PlaceSnake();
            PlaceFood();

            gameTimer.Start();
        }
    }
}
