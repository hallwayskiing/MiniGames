namespace MiniGames
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            userLabel.Visible = true;
            pwdLabel.Visible = true;
            userBox.Visible = true;
            pwdBox.Visible = true;
            logOK.Visible = true;
            logBtn.Visible = false;
            regBtn.Visible = false;
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            userLabel.Visible = true;
            pwdLabel.Visible = true;
            userBox.Visible = true;
            pwdBox.Visible = true;
            codeLabel.Visible = true;
            codeBox.Visible = true;
            regOK.Visible = true;
            logBtn.Visible = false;
            regBtn.Visible = false;
        }
    }
}