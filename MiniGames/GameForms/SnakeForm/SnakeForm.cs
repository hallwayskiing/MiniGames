namespace MiniGames.GameForms
{
    public partial class SnakeForm : Form
    {
        Snake snake;

        Food food;

        int score;

        Size size;

        Mode mode;
        enum Mode { NORMAL, AUTO }

        public SnakeForm()
        {
            InitializeComponent();
            snake = new Snake(new List<Label> { label1, label2, label3 });
            food = new Food(foodLabel, ClientSize);
            score = 0;
            size = this.Size;
            mode = Mode.NORMAL;
            timer.Interval = 200;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            switch (mode)
            {
                case Mode.NORMAL:
                    break;
                case Mode.AUTO:
                    Point head=snake.GetHead();
                    if (snake.direction == Snake.Direction.LEFT || snake.direction == Snake.Direction.RIGHT)
                    {
                        if (head.Y < foodLabel.Location.Y - 8)
                            snake.Turn('S');
                        else if (head.Y > foodLabel.Location.Y + 8)
                            snake.Turn('W');
                    }
                    else
                    {
                        if (head.X < foodLabel.Location.X - 8)
                            snake.Turn('D');
                        else if (head.X > foodLabel.Location.X + 8)
                            snake.Turn('A');
                    }

                    if (Math.Abs(head.Y - foodLabel.Location.Y) < 8 && 
                        ((snake.direction == Snake.Direction.LEFT && head.X < foodLabel.Location.X - 8) ||
                         (snake.direction == Snake.Direction.RIGHT && head.X > foodLabel.Location.X + 8)))
                        snake.Turn('S');
                    if (Math.Abs(head.X - foodLabel.Location.X) < 8 && 
                        ((snake.direction == Snake.Direction.UP && head.Y < foodLabel.Location.Y - 8) ||
                         (snake.direction == Snake.Direction.DOWN && head.Y > foodLabel.Location.Y + 8)))
                        snake.Turn('D');
                    break;
            }

            snake.Move();
            if (HasEaten())
            {
                scoreItem.Text = "Score:" + ++score;
                Label label = new Label();
                Controls.Add(label);
                food.Create();
                snake.GrowWith(label);
            }

            try
            {
                this.CheckBorder();
                if (mode != Mode.AUTO)
                    snake.CheckBody();
            }
            catch (Exception ex)
            {
                timer.Stop();
                this.DialogResult = MessageBox.Show("Game over!\n" + ex.Message, "Game over", MessageBoxButtons.RetryCancel);
                Close();
            }
        }

        private bool HasEaten()
        {
            if (Math.Abs(snake.GetHead().X - foodLabel.Location.X) < 10 &&
                Math.Abs(snake.GetHead().Y - foodLabel.Location.Y) < 10)
                return true;
            return false;
        }

        private void CheckBorder()
        {
            Point pos = snake.GetHead();
            if (pos.X < 0 || pos.X > size.Width - 20 || pos.Y < 0 || pos.Y > size.Height - 20)
                throw new Exception("Crash into border!");
        }

        private void SnakeForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            snake.Turn(e.KeyChar);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            topLabel.Visible = false;
            startBtn.Visible = false;
            this.KeyPreview = true;
            stopItem.Enabled = true;
            timer.Start();
        }

        private void speedChange(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in speedMenu.DropDownItems)
            {
                if (item == sender)
                {
                    item.Checked = true;
                    timer.Interval = int.Parse((string)item.Tag);
                }
                else item.Checked = false;
            }
        }

        private void SnakeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
        }

        private void stopItem_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                stopItem.Text = "Start(&P)";
            }
            else
            {
                timer.Start();
                stopItem.Text = "Stop(&P)";
            }
        }

        private void autoAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mode != Mode.AUTO)
            {
                mode = Mode.AUTO;
                autoAToolStripMenuItem.Text = "Normal(&A)";
            }
            else
            {
                mode = Mode.NORMAL;
                autoAToolStripMenuItem.Text = "Auto(&A)";
            }
        }
    }
}
