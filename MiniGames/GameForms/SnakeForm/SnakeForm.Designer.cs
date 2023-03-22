namespace MiniGames.GameForms
{
    partial class SnakeForm
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
            components = new System.ComponentModel.Container();
            timer = new System.Windows.Forms.Timer(components);
            foodLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // foodLabel
            // 
            foodLabel.AutoSize = true;
            foodLabel.Location = new Point(248, 141);
            foodLabel.Name = "foodLabel";
            foodLabel.Size = new Size(24, 17);
            foodLabel.TabIndex = 1;
            foodLabel.Text = "❤";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 141);
            label3.Name = "label3";
            label3.Size = new Size(17, 17);
            label3.TabIndex = 2;
            label3.Text = "█";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 141);
            label2.Name = "label2";
            label2.Size = new Size(17, 17);
            label2.TabIndex = 3;
            label2.Text = "█";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 141);
            label1.Name = "label1";
            label1.Size = new Size(17, 17);
            label1.TabIndex = 4;
            label1.Text = "█";
            // 
            // SnakeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 301);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(foodLabel);
            Margin = new Padding(2);
            Name = "SnakeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Snake";
            KeyPress += SnakeForm_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer;
        public Label foodBody;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label foodLabel;
    }
}