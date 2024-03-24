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
        private int _highscore = 0;

        private int _maxHeight;
        private int _maxWidth;

        public GameForm()
        {
            InitializeComponent();
            new Settings();
            RestartGame();
        }

        private void UpdateGraphics(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush snakeColour;

            for (int i = 0; i < _snake.Count; i++)
            {
                snakeColour = Brushes.DarkOliveGreen;

                g.FillEllipse(snakeColour, new Rectangle(
                    _snake[i].X * Settings.CellSize,
                    _snake[i].Y * Settings.CellSize,
                    Settings.CellSize,
                    Settings.CellSize
                ));
            }

            Brush foodColour = Brushes.Red;

            g.FillEllipse(foodColour, new Rectangle(
                _food.X * Settings.CellSize,
                _food.Y * Settings.CellSize,
                Settings.CellSize,
                Settings.CellSize
            ));
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateGame(object sender, EventArgs e)
        {
            for (int i = _snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (_currentDirection)
                    {
                        case Direction.Left:
                            _snake[i].X--;
                            break;
                        case Direction.Right:
                            _snake[i].X++;
                            break;
                        case Direction.Up:
                            _snake[i].Y--;
                            break;
                        case Direction.Down:
                            _snake[i].Y++;
                            break;
                    }

                    // Check if the snake collides with itself 
                    for (int j = 1; j < _snake.Count; j++)
                    {
                        if (_snake[j].X == _snake[i].X && _snake[j].Y == _snake[i].Y)
                        {
                            GameOver();
                        }
                    }

                    // Check if the snake ate something 
                    if (_snake[0].X == _food.X && _snake[0].Y == _food.Y)
                    {
                        EatFood();
                    }
                }
                else
                {
                    _snake[i].X = _snake[i - 1].X;
                    _snake[i].Y = _snake[i - 1].Y;
                }
                
            }

            // Check if the snake collides with the frame
            if (_snake[0].X < 0 ||
                _snake[0].Y < 0 ||
                _snake[0].X > _maxWidth ||
                _snake[0].Y > _maxHeight)
            {
                GameOver();
            }

            picCanvas.Invalidate();
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && _currentDirection != Direction.Down)
            {
                _currentDirection = Direction.Up;
                return;
            }

            if (e.KeyCode == Keys.Down && _currentDirection != Direction.Up)
            {
                _currentDirection = Direction.Down;
                return;
            }

            if (e.KeyCode == Keys.Right && _currentDirection != Direction.Left)
            {
                _currentDirection = Direction.Right;
                return;
            }

            if (e.KeyCode == Keys.Left && _currentDirection != Direction.Right)
            {
                _currentDirection = Direction.Left;
                return;
            }
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
        }

        private void GameOver()
        {
            GameStopped();

            if (_score > _highscore)
            {
                _highscore = _score;
                lblHighscore.Text = $"Highscore: {_highscore}";
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

            _score = 0;
            lblScore.Text = $"Score: {_score}";

            PlaceSnake();
            PlaceFood();

            gameTimer.Start();
        }
    }
}
