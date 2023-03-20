namespace MiniGames
{
    public partial class MainForm : Form
    {
        DatabaseManager databaseManager;
        public MainForm()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager("server=localhost;port=3306;database=login;user=root;password=053111;");
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            userLabel.Visible = true;
            pwdLabel.Visible = true;
            userBox.Visible = true;
            pwdBox.Visible = true;
            logOK.Visible = true;
            backBtn.Visible = true;
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
            backBtn.Visible = true;
            logBtn.Visible = false;
            regBtn.Visible = false;
        }

        private void logOK_Click(object sender, EventArgs e)
        {
            try
            {
                string username = userBox.Text;
                string password = pwdBox.Text;
                if (username.Length == 0 || password.Length == 0) throw new Exception("Username or password cannot be empty!");
                User user = new User(username, password);
                if (databaseManager.IsExistedUser(user))
                {
                    MessageBox.Show("Login success!");
                    typeBtn.Visible = true;
                    guessBtn.Visible = true;
                    snakeBtn.Visible = true;
                    ballBtn.Visible = true;
                    welcLabel.Text = "Select one game:";
                    userLabel.Visible = false;
                    pwdLabel.Visible = false;
                    userBox.Visible = false;
                    pwdBox.Visible = false;
                    logOK.Visible = false;
                    backBtn.Visible = false;
                }
                else
                {
                    throw new Exception("Wrong username or password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                userBox.Clear();
                pwdBox.Clear();
                return;
            }

        }

        private void regOK_Click(object sender, EventArgs e)
        {
            try
            {
                string username = userBox.Text;
                string password = pwdBox.Text;
                string code = codeBox.Text;
                if (username.Length < 6 || password.Length < 6)
                    throw new Exception("Username or password should be no less than 6 characters!");
                if (databaseManager.IsExistedCode(code) == false)
                    throw new Exception("Invalid code!");
                if (databaseManager.IsExistedName(username))
                    throw new Exception("Existed user!");
                User user = new User(username, password);
                databaseManager.AddUser(user);
                MessageBox.Show("Register success!");
                backBtn_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                userBox.Clear();
                pwdBox.Clear();
                codeBox.Clear();
                return;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            userBox.Clear();
            pwdBox.Clear();
            codeBox.Clear();
            userBox.Visible = false;
            pwdBox.Visible = false;
            codeBox.Visible = false;
            userLabel.Visible = false;
            pwdLabel.Visible = false;
            codeLabel.Visible = false;
            logOK.Visible = false;
            regOK.Visible = false;
            backBtn.Visible = false;
            regBtn.Visible = true;
            logBtn.Visible = true;
        }

        private void typeBtn_Click(object sender, EventArgs e)
        {
            guessBtn.Visible = false;
            typeBtn.Visible = false;
            snakeBtn.Visible = false;
            ballBtn.Visible=false;
            this.Visible = false;
            new TypeForm().ShowDialog();
            this.Visible = true;
            guessBtn.Visible = true;
            typeBtn.Visible = true;
            snakeBtn.Visible = true;
            ballBtn.Visible = true;
        }
    }
}