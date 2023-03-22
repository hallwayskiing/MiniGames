namespace MiniGames.GameForms
{
    public partial class SnakeForm : Form
    {
        Snake snake;

        Food food;
        public SnakeForm()
        {
            InitializeComponent();
            snake = new Snake(new List<Label> { label1, label2, label3 });
            food = new Food(foodLabel, ClientSize);
            timer.Interval = 200;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            snake.Move();
            if (Check())
            {
                snake.Eat();
                food.create();
            }
        }

        private bool Check()
        {
            int snakeX = snake.body[0].Location.X;
            int snakeY = snake.body[0].Location.Y;
            if (Math.Abs(snakeX - foodLabel.Location.X) < 10 && Math.Abs(snakeY - foodLabel.Location.Y) < 10)
                return true;
            return false;
        }

        private void SnakeForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            snake.Turn(e.KeyChar);
        }
    }
}
