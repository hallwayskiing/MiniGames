namespace MiniGames.GameForms
{
    public partial class GuessForm : Form
    {
        private int random;
        private int guessTimes;
        public GuessForm()
        {
            InitializeComponent();
            random = new Random().Next(101);
            guessTimes = 0;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (++guessTimes == 11)
            {
                this.DialogResult = MessageBox.Show("You lose!", "Loser", MessageBoxButtons.RetryCancel);
                Close();
            }

            int input;
            try
            {
                input = int.Parse(inputBox.Text);
                if (input > 100)
                    throw new Exception("Input too large!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                inputBox.Clear();
            }

            if (input == random)
            {
                string winText = "You win!\nGuess times: " + guessTimes + "\n";
                switch (guessTimes)
                {
                    case 1: winText += "Lucky!"; break;
                    case 2:
                    case 3:
                    case 4: winText += "Excellent!"; break;
                    case 5:
                    case 6:
                    case 7: winText += "Good!"; break;
                    case 8:
                    case 9:
                    case 10: winText += "Bad!"; break;
                }
                this.DialogResult = MessageBox.Show(winText, "Winner", MessageBoxButtons.RetryCancel);
                Close();
            }
            else
            {
                tipLabel.Text = (input < random ? "Larger" : "Smaller") + " than " + input + "!";
            }
        }
    }
}

