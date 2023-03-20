namespace MiniGames
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            welcLabel = new Label();
            logBtn = new Button();
            regBtn = new Button();
            userBox = new TextBox();
            pwdBox = new TextBox();
            userLabel = new Label();
            pwdLabel = new Label();
            logOK = new Button();
            regOK = new Button();
            codeBox = new TextBox();
            codeLabel = new Label();
            guessBtn = new Button();
            typeBtn = new Button();
            snakeBtn = new Button();
            ballBtn = new Button();
            backBtn = new Button();
            skipBtn = new Button();
            guessFormBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)guessFormBindingSource).BeginInit();
            SuspendLayout();
            // 
            // welcLabel
            // 
            welcLabel.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            welcLabel.Location = new Point(140, 46);
            welcLabel.Name = "welcLabel";
            welcLabel.Size = new Size(263, 30);
            welcLabel.TabIndex = 0;
            welcLabel.Text = "Welcome to MiniGames!";
            welcLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logBtn
            // 
            logBtn.Location = new Point(218, 178);
            logBtn.Name = "logBtn";
            logBtn.Size = new Size(95, 35);
            logBtn.TabIndex = 1;
            logBtn.Text = "Login";
            logBtn.UseVisualStyleBackColor = true;
            logBtn.Click += logBtn_Click;
            // 
            // regBtn
            // 
            regBtn.Location = new Point(218, 230);
            regBtn.Name = "regBtn";
            regBtn.Size = new Size(95, 33);
            regBtn.TabIndex = 2;
            regBtn.Text = "Register";
            regBtn.UseVisualStyleBackColor = true;
            regBtn.Click += regBtn_Click;
            // 
            // userBox
            // 
            userBox.Location = new Point(236, 120);
            userBox.Name = "userBox";
            userBox.Size = new Size(167, 23);
            userBox.TabIndex = 3;
            userBox.Visible = false;
            // 
            // pwdBox
            // 
            pwdBox.Location = new Point(236, 173);
            pwdBox.Name = "pwdBox";
            pwdBox.Size = new Size(167, 23);
            pwdBox.TabIndex = 4;
            pwdBox.UseSystemPasswordChar = true;
            pwdBox.Visible = false;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userLabel.Location = new Point(139, 120);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(91, 21);
            userLabel.TabIndex = 5;
            userLabel.Text = "Username:";
            userLabel.Visible = false;
            // 
            // pwdLabel
            // 
            pwdLabel.AutoSize = true;
            pwdLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pwdLabel.Location = new Point(140, 173);
            pwdLabel.Name = "pwdLabel";
            pwdLabel.Size = new Size(86, 21);
            pwdLabel.TabIndex = 6;
            pwdLabel.Text = "Password:";
            pwdLabel.Visible = false;
            // 
            // logOK
            // 
            logOK.Location = new Point(172, 265);
            logOK.Name = "logOK";
            logOK.Size = new Size(95, 28);
            logOK.TabIndex = 7;
            logOK.Text = "Login";
            logOK.UseVisualStyleBackColor = true;
            logOK.Visible = false;
            logOK.Click += logOK_Click;
            // 
            // regOK
            // 
            regOK.Location = new Point(172, 265);
            regOK.Name = "regOK";
            regOK.Size = new Size(95, 28);
            regOK.TabIndex = 8;
            regOK.Text = "Register";
            regOK.UseVisualStyleBackColor = true;
            regOK.Visible = false;
            regOK.Click += regOK_Click;
            // 
            // codeBox
            // 
            codeBox.Location = new Point(236, 225);
            codeBox.Name = "codeBox";
            codeBox.Size = new Size(167, 23);
            codeBox.TabIndex = 5;
            codeBox.Visible = false;
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            codeLabel.Location = new Point(172, 225);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(54, 21);
            codeLabel.TabIndex = 10;
            codeLabel.Text = "Code:";
            codeLabel.Visible = false;
            // 
            // guessBtn
            // 
            guessBtn.Location = new Point(140, 150);
            guessBtn.Margin = new Padding(2);
            guessBtn.Name = "guessBtn";
            guessBtn.Size = new Size(75, 25);
            guessBtn.TabIndex = 11;
            guessBtn.Text = "Guess";
            guessBtn.UseVisualStyleBackColor = true;
            guessBtn.Visible = false;
            guessBtn.Click += gameBtn_Click;
            // 
            // typeBtn
            // 
            typeBtn.Location = new Point(324, 150);
            typeBtn.Margin = new Padding(2);
            typeBtn.Name = "typeBtn";
            typeBtn.Size = new Size(75, 25);
            typeBtn.TabIndex = 12;
            typeBtn.Text = "Type";
            typeBtn.UseVisualStyleBackColor = true;
            typeBtn.Visible = false;
            typeBtn.Click += gameBtn_Click;
            // 
            // snakeBtn
            // 
            snakeBtn.Location = new Point(139, 230);
            snakeBtn.Margin = new Padding(2);
            snakeBtn.Name = "snakeBtn";
            snakeBtn.Size = new Size(75, 25);
            snakeBtn.TabIndex = 13;
            snakeBtn.Text = "Snake";
            snakeBtn.UseVisualStyleBackColor = true;
            snakeBtn.Visible = false;
            snakeBtn.Click += gameBtn_Click;
            // 
            // ballBtn
            // 
            ballBtn.Location = new Point(324, 230);
            ballBtn.Margin = new Padding(2);
            ballBtn.Name = "ballBtn";
            ballBtn.Size = new Size(75, 25);
            ballBtn.TabIndex = 14;
            ballBtn.Text = "Ball";
            ballBtn.UseVisualStyleBackColor = true;
            ballBtn.Visible = false;
            ballBtn.Click += gameBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(279, 265);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(95, 28);
            backBtn.TabIndex = 15;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Visible = false;
            backBtn.Click += backBtn_Click;
            // 
            // skipBtn
            // 
            skipBtn.Location = new Point(449, 281);
            skipBtn.Name = "skipBtn";
            skipBtn.Size = new Size(75, 23);
            skipBtn.TabIndex = 16;
            skipBtn.Text = "skip";
            skipBtn.UseVisualStyleBackColor = true;
            skipBtn.Click += skipBtn_Click;
            // 
            // guessFormBindingSource
            // 
            guessFormBindingSource.DataSource = typeof(GameForms.GuessForm);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 316);
            Controls.Add(skipBtn);
            Controls.Add(backBtn);
            Controls.Add(ballBtn);
            Controls.Add(snakeBtn);
            Controls.Add(typeBtn);
            Controls.Add(guessBtn);
            Controls.Add(codeLabel);
            Controls.Add(codeBox);
            Controls.Add(regOK);
            Controls.Add(logOK);
            Controls.Add(pwdLabel);
            Controls.Add(userLabel);
            Controls.Add(pwdBox);
            Controls.Add(userBox);
            Controls.Add(regBtn);
            Controls.Add(logBtn);
            Controls.Add(welcLabel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniGames";
            ((System.ComponentModel.ISupportInitialize)guessFormBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcLabel;
        private Button logBtn;
        private Button regBtn;
        private TextBox userBox;
        private TextBox pwdBox;
        private Label userLabel;
        private Label pwdLabel;
        private Button logOK;
        private Button regOK;
        private TextBox codeBox;
        private Label codeLabel;
        private Button guessBtn;
        private Button typeBtn;
        private Button snakeBtn;
        private Button ballBtn;
        private Button backBtn;
        private Button skipBtn;
        private BindingSource guessFormBindingSource;
    }
}