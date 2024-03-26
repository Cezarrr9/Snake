using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class GameForm : Form
    {
        private List<Unit> _snake = new List<Unit>();
        private Direction _currentDirection = Direction.Right;
        private Unit _food = new Unit();
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
            new Settings();
            StartGameView();
        }

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
            
            picCanvas.Invalidate();
        }

        private void EatFood()
        {
            _score++;

            lblScore.Text = $"Score: {_score}";

            _snake.Add(new Unit
            {
                X = _snake[_snake.Count - 1].X,
                Y = _snake[_snake.Count - 1].Y
            });

            PlaceFood();
        }

        private void PlaceFood()
        {
            Random rand = new Random();

            int ok = 0;
            int x = 0;
            int y = 0;

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

        private void PlaceSnake()
        {
            _snake.Clear();
            _snake.Add(new Unit { X = 1, Y = 0 });
            _snake.Add(new Unit { X = 0, Y = 0});
            _currentDirection = Direction.Right;
        }

        private void GameStopped()
        {
            gameTimer.Stop();

            btnPlayAgain.Enabled = true;
            btnPlayAgain.Visible = true;

            btnQuit.Enabled = true;
            btnQuit.Visible = true;

            btnDecreaseDif.Enabled = true;
            btnDecreaseDif.Visible = true;

            btnIncreaseDif.Enabled = true;
            btnIncreaseDif.Visible = true;
        }

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

        private void RestartGame()
        {
            _maxWidth = picCanvas.Width / Settings.CellSize - 1;
            _maxHeight = picCanvas.Height / Settings.CellSize - 1;

            btnPlayAgain.Enabled = false;
            btnQuit.Enabled = false;

            btnPlayAgain.Visible = false;
            btnQuit.Visible = false;

            btnDecreaseDif.Enabled = false;
            btnDecreaseDif.Visible = false;

            btnIncreaseDif.Enabled = false;
            btnIncreaseDif.Visible = false;

            _score = 0;
            lblScore.Text = $"Score: {_score}";

            _pauseFlag = false;

            PlaceSnake();
            PlaceFood();

            gameTimer.Start();
        }
    }
}
