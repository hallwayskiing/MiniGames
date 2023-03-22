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
            topLabel = new Label();
            startBtn = new Button();
            menuStrip = new MenuStrip();
            speedMenu = new ToolStripMenuItem();
            normalToolStripMenuItem = new ToolStripMenuItem();
            fastToolStripMenuItem = new ToolStripMenuItem();
            crazyToolStripMenuItem = new ToolStripMenuItem();
            stopItem = new ToolStripMenuItem();
            scoreItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // foodLabel
            // 
            foodLabel.AutoSize = true;
            foodLabel.Location = new Point(366, 167);
            foodLabel.Name = "foodLabel";
            foodLabel.Size = new Size(18, 17);
            foodLabel.TabIndex = 1;
            foodLabel.Text = "★";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 167);
            label3.Name = "label3";
            label3.Size = new Size(17, 17);
            label3.TabIndex = 2;
            label3.Text = "█";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 167);
            label2.Name = "label2";
            label2.Size = new Size(17, 17);
            label2.TabIndex = 3;
            label2.Text = "█";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(134, 167);
            label1.Name = "label1";
            label1.Size = new Size(17, 17);
            label1.TabIndex = 4;
            label1.Text = "█";
            // 
            // topLabel
            // 
            topLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topLabel.Font = new Font("Mistral", 42F, FontStyle.Regular, GraphicsUnit.Point);
            topLabel.Location = new Point(1, 44);
            topLabel.Name = "topLabel";
            topLabel.Size = new Size(497, 65);
            topLabel.TabIndex = 5;
            topLabel.Text = "GREEDY SNAKE";
            topLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startBtn
            // 
            startBtn.Location = new Point(214, 241);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(75, 23);
            startBtn.TabIndex = 6;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { speedMenu, stopItem, scoreItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(499, 25);
            menuStrip.TabIndex = 7;
            menuStrip.Text = "menuStrip";
            // 
            // speedMenu
            // 
            speedMenu.DropDownItems.AddRange(new ToolStripItem[] { normalToolStripMenuItem, fastToolStripMenuItem, crazyToolStripMenuItem });
            speedMenu.Name = "speedMenu";
            speedMenu.Size = new Size(72, 21);
            speedMenu.Text = "Speed(&S)";
            // 
            // normalToolStripMenuItem
            // 
            normalToolStripMenuItem.Checked = true;
            normalToolStripMenuItem.CheckState = CheckState.Checked;
            normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            normalToolStripMenuItem.Size = new Size(120, 22);
            normalToolStripMenuItem.Tag = "200";
            normalToolStripMenuItem.Text = "Normal";
            normalToolStripMenuItem.Click += speedChange;
            // 
            // fastToolStripMenuItem
            // 
            fastToolStripMenuItem.Name = "fastToolStripMenuItem";
            fastToolStripMenuItem.Size = new Size(120, 22);
            fastToolStripMenuItem.Tag = "150";
            fastToolStripMenuItem.Text = "Fast";
            fastToolStripMenuItem.Click += speedChange;
            // 
            // crazyToolStripMenuItem
            // 
            crazyToolStripMenuItem.Name = "crazyToolStripMenuItem";
            crazyToolStripMenuItem.Size = new Size(120, 22);
            crazyToolStripMenuItem.Tag = "100";
            crazyToolStripMenuItem.Text = "Crazy";
            crazyToolStripMenuItem.Click += speedChange;
            // 
            // stopItem
            // 
            stopItem.Enabled = false;
            stopItem.Name = "stopItem";
            stopItem.Size = new Size(62, 21);
            stopItem.Text = "Stop(&P)";
            stopItem.Click += stopItem_Click;
            // 
            // scoreItem
            // 
            scoreItem.Alignment = ToolStripItemAlignment.Right;
            scoreItem.Name = "scoreItem";
            scoreItem.Size = new Size(63, 21);
            scoreItem.Text = "Score:0";
            // 
            // SnakeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 301);
            Controls.Add(startBtn);
            Controls.Add(topLabel);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(foodLabel);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(2);
            Name = "SnakeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Snake";
            FormClosing += SnakeForm_FormClosing;
            KeyPress += SnakeForm_KeyPress;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
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
        private Label topLabel;
        private Button startBtn;
        private MenuStrip menuStrip;
        private ToolStripMenuItem speedMenu;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem fastToolStripMenuItem;
        private ToolStripMenuItem crazyToolStripMenuItem;
        private ToolStripMenuItem stopItem;
        private ToolStripMenuItem scoreItem;
    }
}