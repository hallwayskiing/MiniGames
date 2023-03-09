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
            this.welcLabel = new System.Windows.Forms.Label();
            this.logBtn = new System.Windows.Forms.Button();
            this.regBtn = new System.Windows.Forms.Button();
            this.userBox = new System.Windows.Forms.TextBox();
            this.pwdBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.logOK = new System.Windows.Forms.Button();
            this.regOK = new System.Windows.Forms.Button();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.guessBtn = new System.Windows.Forms.Button();
            this.typeBtn = new System.Windows.Forms.Button();
            this.snakeBtn = new System.Windows.Forms.Button();
            this.ballBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcLabel
            // 
            this.welcLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcLabel.Location = new System.Drawing.Point(280, 84);
            this.welcLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.welcLabel.Name = "welcLabel";
            this.welcLabel.Size = new System.Drawing.Size(518, 55);
            this.welcLabel.TabIndex = 0;
            this.welcLabel.Text = "Welcome to MiniGames!";
            this.welcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logBtn
            // 
            this.logBtn.Location = new System.Drawing.Point(436, 325);
            this.logBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(190, 64);
            this.logBtn.TabIndex = 1;
            this.logBtn.Text = "Login";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(436, 419);
            this.regBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(190, 60);
            this.regBtn.TabIndex = 2;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(472, 219);
            this.userBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(330, 38);
            this.userBox.TabIndex = 3;
            this.userBox.Visible = false;
            // 
            // pwdBox
            // 
            this.pwdBox.Location = new System.Drawing.Point(472, 315);
            this.pwdBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.Size = new System.Drawing.Size(330, 38);
            this.pwdBox.TabIndex = 4;
            this.pwdBox.UseSystemPasswordChar = true;
            this.pwdBox.Visible = false;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLabel.Location = new System.Drawing.Point(278, 219);
            this.userLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(181, 41);
            this.userLabel.TabIndex = 5;
            this.userLabel.Text = "Username:";
            this.userLabel.Visible = false;
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pwdLabel.Location = new System.Drawing.Point(280, 315);
            this.pwdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(171, 41);
            this.pwdLabel.TabIndex = 6;
            this.pwdLabel.Text = "Password:";
            this.pwdLabel.Visible = false;
            // 
            // logOK
            // 
            this.logOK.Location = new System.Drawing.Point(344, 484);
            this.logOK.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.logOK.Name = "logOK";
            this.logOK.Size = new System.Drawing.Size(190, 51);
            this.logOK.TabIndex = 7;
            this.logOK.Text = "Login";
            this.logOK.UseVisualStyleBackColor = true;
            this.logOK.Visible = false;
            this.logOK.Click += new System.EventHandler(this.logOK_Click);
            // 
            // regOK
            // 
            this.regOK.Location = new System.Drawing.Point(344, 484);
            this.regOK.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.regOK.Name = "regOK";
            this.regOK.Size = new System.Drawing.Size(190, 51);
            this.regOK.TabIndex = 8;
            this.regOK.Text = "Register";
            this.regOK.UseVisualStyleBackColor = true;
            this.regOK.Visible = false;
            this.regOK.Click += new System.EventHandler(this.regOK_Click);
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(472, 410);
            this.codeBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(330, 38);
            this.codeBox.TabIndex = 5;
            this.codeBox.Visible = false;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codeLabel.Location = new System.Drawing.Point(344, 410);
            this.codeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(105, 41);
            this.codeLabel.TabIndex = 10;
            this.codeLabel.Text = "Code:";
            this.codeLabel.Visible = false;
            // 
            // guessBtn
            // 
            this.guessBtn.Location = new System.Drawing.Point(280, 273);
            this.guessBtn.Name = "guessBtn";
            this.guessBtn.Size = new System.Drawing.Size(150, 46);
            this.guessBtn.TabIndex = 11;
            this.guessBtn.Text = "Guess";
            this.guessBtn.UseVisualStyleBackColor = true;
            this.guessBtn.Visible = false;
            // 
            // typeBtn
            // 
            this.typeBtn.Location = new System.Drawing.Point(648, 273);
            this.typeBtn.Name = "typeBtn";
            this.typeBtn.Size = new System.Drawing.Size(150, 46);
            this.typeBtn.TabIndex = 12;
            this.typeBtn.Text = "Type";
            this.typeBtn.UseVisualStyleBackColor = true;
            this.typeBtn.Visible = false;
            // 
            // snakeBtn
            // 
            this.snakeBtn.Location = new System.Drawing.Point(278, 419);
            this.snakeBtn.Name = "snakeBtn";
            this.snakeBtn.Size = new System.Drawing.Size(150, 46);
            this.snakeBtn.TabIndex = 13;
            this.snakeBtn.Text = "Snake";
            this.snakeBtn.UseVisualStyleBackColor = true;
            this.snakeBtn.Visible = false;
            // 
            // ballBtn
            // 
            this.ballBtn.Location = new System.Drawing.Point(648, 419);
            this.ballBtn.Name = "ballBtn";
            this.ballBtn.Size = new System.Drawing.Size(150, 46);
            this.ballBtn.TabIndex = 14;
            this.ballBtn.Text = "Ball";
            this.ballBtn.UseVisualStyleBackColor = true;
            this.ballBtn.Visible = false;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(558, 484);
            this.backBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(190, 51);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Visible = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 576);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.ballBtn);
            this.Controls.Add(this.snakeBtn);
            this.Controls.Add(this.typeBtn);
            this.Controls.Add(this.guessBtn);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.regOK);
            this.Controls.Add(this.logOK);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.pwdBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.welcLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniGames";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}