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
            if (CheckFood())
            {
                Label label = new Label();              
                Controls.Add(label);
                food.create();
                snake.GrowWith(label);
            }

            try
            {
                CheckBorder();
                snake.CheckBody();
            }
            catch(Exception ex)
            {
                timer.Stop();
                MessageBox.Show("Game over!\n" + ex.Message, "Game over", MessageBoxButtons.RetryCancel);
            }
        }

        private bool CheckFood()
        {
            if (Math.Abs(snake.GetHead().X - foodLabel.Location.X) < 10 &&
                Math.Abs(snake.GetHead().Y - foodLabel.Location.Y) < 10)
                return true;
            return false;
        }

        private void CheckBorder()
        {
            Point pos = snake.GetHead();
            if (pos.X < 0 || pos.X > this.ClientSize.Width || pos.Y < 0 || pos.Y > this.ClientSize.Width)
                throw new Exception("Crash into border!");
        }

        private void SnakeForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            snake.Turn(e.KeyChar);
        }
    }
}
