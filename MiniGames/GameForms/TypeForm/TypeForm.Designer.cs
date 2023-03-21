namespace MiniGames.GameForms
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
            showLabel = new Label();
            label4 = new Label();
            startBtn = new Button();
            label3 = new Label();
            timeLabel = new Label();
            typeTimer = new System.Windows.Forms.Timer(components);
            doneBtn = new Button();
            endLabel = new Label();
            typeMenuStrip = new MenuStrip();
            difficultyToolStripMenuItem = new ToolStripMenuItem();
            normalItem = new ToolStripMenuItem();
            hardItem = new ToolStripMenuItem();
            crazyItem = new ToolStripMenuItem();
            typeMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.Enabled = false;
            inputBox.Location = new Point(89, 148);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(268, 23);
            inputBox.TabIndex = 0;
            inputBox.KeyPress += inputBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(190, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 1;
            label1.Text = "Type";
            // 
            // showLabel
            // 
            showLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            showLabel.AutoEllipsis = true;
            showLabel.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            showLabel.Location = new Point(12, 61);
            showLabel.Name = "showLabel";
            showLabel.Size = new Size(424, 30);
            showLabel.TabIndex = 3;
            showLabel.Text = "Type the same as here!";
            showLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(87, 114);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 4;
            label4.Text = "Type here:";
            // 
            // startBtn
            // 
            startBtn.Location = new Point(180, 209);
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
            label3.Location = new Point(283, 174);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 6;
            label3.Text = "Timer:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(334, 174);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(28, 21);
            timeLabel.TabIndex = 7;
            timeLabel.Text = "10";
            timeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // typeTimer
            // 
            typeTimer.Interval = 1000;
            typeTimer.Tick += timer1_Tick;
            // 
            // doneBtn
            // 
            doneBtn.Location = new Point(180, 209);
            doneBtn.Name = "doneBtn";
            doneBtn.Size = new Size(75, 23);
            doneBtn.TabIndex = 8;
            doneBtn.Text = "Done";
            doneBtn.UseVisualStyleBackColor = true;
            doneBtn.Visible = false;
            doneBtn.Click += doneBtn_Click;
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
            // typeMenuStrip
            // 
            typeMenuStrip.Items.AddRange(new ToolStripItem[] { difficultyToolStripMenuItem });
            typeMenuStrip.Location = new Point(0, 0);
            typeMenuStrip.Name = "typeMenuStrip";
            typeMenuStrip.Size = new Size(448, 25);
            typeMenuStrip.TabIndex = 10;
            typeMenuStrip.Text = "menuStrip1";
            // 
            // difficultyToolStripMenuItem
            // 
            difficultyToolStripMenuItem.Checked = true;
            difficultyToolStripMenuItem.CheckState = CheckState.Checked;
            difficultyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { normalItem, hardItem, crazyItem });
            difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            difficultyToolStripMenuItem.Size = new Size(86, 21);
            difficultyToolStripMenuItem.Text = "Difficulty(&D)";
            // 
            // normalItem
            // 
            normalItem.Checked = true;
            normalItem.CheckState = CheckState.Checked;
            normalItem.Name = "normalItem";
            normalItem.Size = new Size(120, 22);
            normalItem.Tag = "10";
            normalItem.Text = "Normal";
            normalItem.Click += diffToolStrip_OnChange;
            // 
            // hardItem
            // 
            hardItem.Name = "hardItem";
            hardItem.Size = new Size(120, 22);
            hardItem.Tag = "8";
            hardItem.Text = "Hard";
            hardItem.Click += diffToolStrip_OnChange;
            // 
            // crazyItem
            // 
            crazyItem.Name = "crazyItem";
            crazyItem.Size = new Size(120, 22);
            crazyItem.Tag = "6";
            crazyItem.Text = "Crazy";
            crazyItem.Click += diffToolStrip_OnChange;
            // 
            // TypeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 247);
            Controls.Add(endLabel);
            Controls.Add(doneBtn);
            Controls.Add(timeLabel);
            Controls.Add(label3);
            Controls.Add(startBtn);
            Controls.Add(label4);
            Controls.Add(showLabel);
            Controls.Add(label1);
            Controls.Add(inputBox);
            Controls.Add(typeMenuStrip);
            MainMenuStrip = typeMenuStrip;
            Name = "TypeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Type";
            typeMenuStrip.ResumeLayout(false);
            typeMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputBox;
        private Label label1;
        private Label showLabel;
        private Label label4;
        private Button startBtn;
        private Label label3;
        private Label timeLabel;
        private System.Windows.Forms.Timer typeTimer;
        private Button doneBtn;
        private Label endLabel;
        private MenuStrip typeMenuStrip;
        private ToolStripMenuItem difficultyToolStripMenuItem;
        private ToolStripMenuItem normalItem;
        private ToolStripMenuItem hardItem;
        private ToolStripMenuItem crazyItem;
    }
}