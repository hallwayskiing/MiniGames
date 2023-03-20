namespace MiniGames.GameForms
{
    partial class GuessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            inputBox = new TextBox();
            confirmBtn = new Button();
            label3 = new Label();
            tipLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(169, 26);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 0;
            label1.Text = "Guess:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(104, 123);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 1;
            label2.Text = "Your guess:";
            // 
            // inputBox
            // 
            inputBox.Location = new Point(208, 124);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(90, 23);
            inputBox.TabIndex = 2;
            inputBox.KeyPress += inputBox_KeyPress;
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(169, 185);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(80, 23);
            confirmBtn.TabIndex = 3;
            confirmBtn.Text = "confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(82, 80);
            label3.Name = "label3";
            label3.Size = new Size(263, 21);
            label3.TabIndex = 4;
            label3.Text = "Enter a number between 0 ~ 100";
            // 
            // tipLabel
            // 
            tipLabel.AutoSize = true;
            tipLabel.Location = new Point(163, 155);
            tipLabel.Name = "tipLabel";
            tipLabel.Size = new Size(0, 17);
            tipLabel.TabIndex = 5;
            // 
            // GuessForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 229);
            Controls.Add(tipLabel);
            Controls.Add(label3);
            Controls.Add(confirmBtn);
            Controls.Add(inputBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GuessForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuessForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox inputBox;
        private Button confirmBtn;
        private Label label3;
        private Label tipLabel;
    }
}