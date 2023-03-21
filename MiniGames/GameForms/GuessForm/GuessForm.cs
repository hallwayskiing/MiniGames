namespace MiniGames.GameForms
{
    public partial class GuessForm : Form
    {
        private int randomNum;//[0,100]
        private int guessTimes;

        public GuessForm()
        {
            InitializeComponent();
            randomNum = new Random().Next(101);
            guessTimes = 0;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            guessTimes++;

            int input;
            try
            {
                input = int.Parse(inputBox.Text);
                if (input > 100 || input < 0)
                    throw new Exception("Input out of range!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                inputBox.Clear();
                inputBox.Focus();
            }

            if (input == randomNum)
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
            else if (guessTimes == 10)
            {

                this.DialogResult = MessageBox.Show("You lose!", "Loser", MessageBoxButtons.RetryCancel);
                Close();
            }
            else tipLabel.Text = (input < randomNum ? "Larger" : "Smaller") + " than " + input + "!";
        }

        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == System.Convert.ToChar(13))
            {
                e.Handled = true;
                confirmBtn_Click(sender, e);
            }
        }
    }
}

