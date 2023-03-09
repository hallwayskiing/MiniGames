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
            SuspendLayout();
            // 
            // welcLabel
            // 
            welcLabel.AutoSize = true;
            welcLabel.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            welcLabel.Location = new Point(140, 46);
            welcLabel.Name = "welcLabel";
            welcLabel.Size = new Size(263, 28);
            welcLabel.TabIndex = 0;
            welcLabel.Text = "Welcome to MiniGames!";
            welcLabel.TextAlign = ContentAlignment.TopCenter;
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
            logOK.Location = new Point(218, 248);
            logOK.Name = "logOK";
            logOK.Size = new Size(95, 28);
            logOK.TabIndex = 7;
            logOK.Text = "Login";
            logOK.UseVisualStyleBackColor = true;
            logOK.Visible = false;
            // 
            // regOK
            // 
            regOK.Location = new Point(218, 269);
            regOK.Name = "regOK";
            regOK.Size = new Size(95, 28);
            regOK.TabIndex = 8;
            regOK.Text = "Register";
            regOK.UseVisualStyleBackColor = true;
            regOK.Visible = false;
            // 
            // codeBox
            // 
            codeBox.Location = new Point(236, 225);
            codeBox.Name = "codeBox";
            codeBox.Size = new Size(167, 23);
            codeBox.TabIndex = 9;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 316);
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
    }
}