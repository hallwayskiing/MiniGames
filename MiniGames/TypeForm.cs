namespace MiniGames
{
    public partial class TypeForm : Form
    {
        string[] typelist;
        int timeCount;
        int timeDelay;
        int listLength;
        int correctNum;
        int inputTimes;
        int randomNum;
        Random random;

        public TypeForm()
        {
            InitializeComponent();
            typelist = File.ReadAllLines("D:\\code\\MiniGames\\MiniGames\\typelist.txt");
            listLength = typelist.Length;
            timeDelay = 10;
            timeCount = timeDelay;
            correctNum = 0;
            inputTimes = 0;
            randomNum = 0;
            random = new Random();
            timeLabel.Text = timeDelay.ToString();

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            startBtn.Visible = false;
            subBtn.Visible = true;
            difficultyToolStripMenuItem.Visible = false;
            inputBox.Enabled = true;
            inputBox.Focus();
            randomNum = random.Next(listLength);
            showLabel.Text = typelist[randomNum];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = (--timeCount).ToString();
            if (timeCount < 0)
                subBtn_Click(sender, e);
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            timeLabel.Text = (timeCount = timeDelay).ToString();
            string input = inputBox.Text;
            if (input == showLabel.Text)
                correctNum++;
            inputBox.Clear();

            int tmp;
            do
            {
                tmp = random.Next(listLength);
            } while (tmp == randomNum);
            randomNum = tmp;
            showLabel.Text = typelist[randomNum];

            if (++inputTimes == 10)
            {
                subBtn.Visible = false;
                timer1.Enabled = false;
                inputBox.Enabled = false;
                endLabel.Text = "Game over! Correct: " + correctNum.ToString();

            }
        }

        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == System.Convert.ToChar(13))
            {
                e.Handled = true;
                subBtn_Click(sender, e);
            }
        }

        private void diffToolStrip_OnChange(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in difficultyToolStripMenuItem.DropDownItems)
            {
                if (item == sender)
                {
                    item.Checked = true;
                    timeDelay = int.Parse((string)item.Tag);
                    timeCount = timeDelay;
                    timeLabel.Text = timeDelay.ToString();
                }
                else item.Checked = false;
            }
        }
    }
}
