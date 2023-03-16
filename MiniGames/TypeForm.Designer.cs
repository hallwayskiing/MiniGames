namespace MiniGames
{
    partial class TypeForm
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
            inputBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            showLabel = new Label();
            label4 = new Label();
            startBtn = new Button();
            label3 = new Label();
            timeLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            subBtn = new Button();
            endLabel = new Label();
            menuStrip1 = new MenuStrip();
            toolStripComboBox = new ToolStripMenuItem();
            difficultyToolStripMenuItem = new ToolStripMenuItem();
            normalItem = new ToolStripMenuItem();
            hardItem = new ToolStripMenuItem();
            crazyItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.Enabled = false;
            inputBox.Location = new Point(160, 151);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(251, 23);
            inputBox.TabIndex = 0;
            inputBox.KeyPress += inputBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(192, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 1;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 58);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 2;
            label2.Text = "Sentence:";
            // 
            // showLabel
            // 
            showLabel.AutoEllipsis = true;
            showLabel.AutoSize = true;
            showLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            showLabel.Location = new Point(157, 58);
            showLabel.Name = "showLabel";
            showLabel.Size = new Size(186, 21);
            showLabel.TabIndex = 3;
            showLabel.Text = "Type the same as here!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(107, 150);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 4;
            label4.Text = "Type:";
            // 
            // startBtn
            // 
            startBtn.Location = new Point(180, 203);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(75, 23);
            startBtn.TabIndex = 5;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(100, 106);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 6;
            label3.Text = "Timer:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(157, 106);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(155, 21);
            timeLabel.TabIndex = 7;
            timeLabel.Text = "Value of timeDelay";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // subBtn
            // 
            subBtn.Location = new Point(180, 203);
            subBtn.Name = "subBtn";
            subBtn.Size = new Size(75, 23);
            subBtn.TabIndex = 8;
            subBtn.Text = "Submit";
            subBtn.UseVisualStyleBackColor = true;
            subBtn.Visible = false;
            subBtn.Click += subBtn_Click;
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            endLabel.Location = new Point(136, 205);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(0, 21);
            endLabel.TabIndex = 9;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBox, difficultyToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(448, 25);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripComboBox
            // 
            toolStripComboBox.Name = "toolStripComboBox";
            toolStripComboBox.Size = new Size(12, 21);
            // 
            // difficultyToolStripMenuItem
            // 
            difficultyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { normalItem, hardItem, crazyItem });
            difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            difficultyToolStripMenuItem.Size = new Size(86, 21);
            difficultyToolStripMenuItem.Text = "Difficulty(&D)";
            // 
            // normalItem
            // 
            normalItem.Name = "normalItem";
            normalItem.Size = new Size(180, 22);
            normalItem.Text = "Normal";
            normalItem.Click += diffToolStrip_OnChange;
            // 
            // hardItem
            // 
            hardItem.Name = "hardItem";
            hardItem.Size = new Size(180, 22);
            hardItem.Text = "Hard";
            hardItem.Click += diffToolStrip_OnChange;
            // 
            // crazyItem
            // 
            crazyItem.Name = "crazyItem";
            crazyItem.Size = new Size(180, 22);
            crazyItem.Text = "Crazy";
            crazyItem.Click += diffToolStrip_OnChange;
            // 
            // TypeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 247);
            Controls.Add(endLabel);
            Controls.Add(subBtn);
            Controls.Add(timeLabel);
            Controls.Add(label3);
            Controls.Add(startBtn);
            Controls.Add(label4);
            Controls.Add(showLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inputBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TypeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Type";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputBox;
        private Label label1;
        private Label label2;
        private Label showLabel;
        private Label label4;
        private Button startBtn;
        private Label label3;
        private Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private Button subBtn;
        private Label endLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripComboBox;
        private ToolStripMenuItem difficultyToolStripMenuItem;
        private ToolStripMenuItem normalItem;
        private ToolStripMenuItem hardItem;
        private ToolStripMenuItem crazyItem;
    }
}