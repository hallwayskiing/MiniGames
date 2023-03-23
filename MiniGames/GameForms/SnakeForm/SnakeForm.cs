namespace MiniGames.GameForms
{
    public partial class SnakeForm : Form
    {
        Snake snake;

        Food food;

        int score;

        public SnakeForm()
        {
            InitializeComponent();
            snake = new Snake(new List<Label> { label1, label2, label3 });
            food = new Food(foodLabel, ClientSize);
            score = 0;
            timer.Interval = 200;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            snake.Move();
            if (HasEaten())
            {
                scoreItem.Text = "Score:" + ++score;
                Label label = new Label();
                Controls.Add(label);
                food.create();
                snake.GrowWith(label);
            }

            try
            {
                this.CheckBorder();
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
            if (Math.Abs(snake.GetHead().X - foodLabel.Location.X) < 8 &&
                Math.Abs(snake.GetHead().Y - foodLabel.Location.Y) < 8)
                return true;
            return false;
        }

        private void CheckBorder()
        {
            Point pos = snake.GetHead();
            if (pos.X < 0 || pos.X > ClientSize.Width - 20 || pos.Y < 0 || pos.Y > ClientSize.Height - 20)
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
    }
}
