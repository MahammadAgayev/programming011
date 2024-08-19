using System.Drawing.Text;

namespace _42
{
    public partial class GameForm : Form
    {
        private readonly List<Circle> _snake = new List<Circle>();
        private Circle _food;
        private bool _gameOver = false;

        private readonly GameSettings _gameSettings;
        private readonly System.Timers.Timer _timer;

        private int _currentDirection;

        public GameForm()
        {
            InitializeComponent();

            _gameSettings = new GameSettings
            {
                Height = 30,
                Width = 30,
                RefreshMilliseconds = 500
            };

            _timer = new System.Timers.Timer();
            _timer.Elapsed += timerElapsed;
            _timer.Interval = _gameSettings.RefreshMilliseconds;

            StartGame();
        }

        private void StartGame()
        {
            _snake.Clear();
            _gameOver = false;

            Circle head = new Circle();
            _snake.Add(head);

            GenerateFood();
            _currentDirection = Direction.Right;

            _timer.Start();
        }

        private void timerElapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            if (_gameOver)
            {
                return;
            }

            Circle head = _snake[0];
            for (int i = _snake.Count - 1; i > 0; i--)
            {
                _snake[i].X = _snake[i - 1].X;
                _snake[i].Y = _snake[i - 1].Y;
            }

            switch (_currentDirection)
            {
                case Direction.Up:
                    head.Y--;
                    break;
                case Direction.Down:
                    head.Y++;
                    break;
                case Direction.Right:
                    head.X++;
                    break;
                case Direction.Left:
                    head.X--;
                    break;
            }

            /*
             *   5 6 7
             *   4 5 6
             *   3 4 5
             *   
             *   [100] [101] [102]
             *   
             *   [99] [100] [101]
             *   
             *   [100, 100] [101,100] [102,100]
             *   [100, 99] [100, 100]
             */

            for (int i = 1; i < _snake.Count; i++)
            {
                if(head.X == _snake[i].X  && 
                    head.Y == _snake[i].Y)
                {
                    GameOver();
                }
            }

            if (head.X == _food.X && head.Y == _food.Y)
            {
                Eat();
            }

            if (
                head.X < 0 ||
                head.Y < 0 ||
                head.X > pnlGameBoard.Width / _gameSettings.Width ||
                head.Y > pnlGameBoard.Height / _gameSettings.Width
               )
            {
                GameOver();
            }

            pnlGameBoard.Invalidate();
        }

        private void pnlGameBoard_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < _snake.Count; i++)
            {
                Brush color = Brushes.Black;

                if (i == 0)
                {
                    color = Brushes.Red;
                }

                Circle c = _snake[i];

                g.FillEllipse(color,
                    new Rectangle(c.X * _gameSettings.Width,
                    c.Y * _gameSettings.Height,
                    _gameSettings.Width, _gameSettings.Height));
            }

            if (_food != null)
            {
                g.FillEllipse(Brushes.Green,
                    new Rectangle(_food.X * _gameSettings.Width,
                    _food.Y * _gameSettings.Height,
                    _gameSettings.Width, _gameSettings.Height));
            }


            if (_gameOver)
            {
                lblGameOver.Visible = true;
            }
            else
            {
                lblGameOver.Visible = false;
            }
        }

        private void GameForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up when _currentDirection != Direction.Down:
                    _currentDirection = Direction.Up;
                    break;
                case Keys.Down when _currentDirection != Direction.Up:
                    _currentDirection = Direction.Down;
                    break;
                case Keys.Right when _currentDirection != Direction.Left:
                    _currentDirection = Direction.Right;
                    break;
                case Keys.Left when _currentDirection != Direction.Right:
                    _currentDirection = Direction.Left;
                    break;
                case Keys.Space when _gameOver:
                    StartGame();
                    break;
            }
        }

        private void Eat()
        {
            Circle head = _snake[0];

            _snake.Add(new Circle
            {
                X = head.X,
                Y = head.Y
            });

            GenerateFood();
        }

        private void GenerateFood()
        {
            _food = new Circle();
            Random r = new Random();
            _food.X = r.Next(0, pnlGameBoard.Width / _gameSettings.Width);
            _food.Y = r.Next(0, pnlGameBoard.Height / _gameSettings.Height);
        }

        private void GameOver()
        {
            _gameOver = true;
            _timer.Stop();
            _snake.Clear();
        }
    }
}
