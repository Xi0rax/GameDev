namespace TreasureHunt
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InitGameParameter = new System.Windows.Forms.ToolStripMenuItem();
            this.endGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitParameter = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonarLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.sonars = new System.Windows.Forms.TextBox();
            this.points = new System.Windows.Forms.TextBox();
            this.levelLabel = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.TextBox();
            this.found = new System.Windows.Forms.Label();
            this.complete = new System.Windows.Forms.TextBox();
            this.task = new System.Windows.Forms.TextBox();
            this.delimiter = new System.Windows.Forms.Label();
            this.levelSwitcher = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.gameField = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameField)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 390);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(938, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InitGameParameter,
            this.endGameToolStripMenuItem,
            this.ExitParameter});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // InitGameParameter
            // 
            this.InitGameParameter.Name = "InitGameParameter";
            this.InitGameParameter.Size = new System.Drawing.Size(132, 22);
            this.InitGameParameter.Text = "New Game";
            this.InitGameParameter.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // endGameToolStripMenuItem
            // 
            this.endGameToolStripMenuItem.Enabled = false;
            this.endGameToolStripMenuItem.Name = "endGameToolStripMenuItem";
            this.endGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.endGameToolStripMenuItem.Text = "End Game";
            this.endGameToolStripMenuItem.Click += new System.EventHandler(this.endGameToolStripMenuItem_Click);
            // 
            // ExitParameter
            // 
            this.ExitParameter.Name = "ExitParameter";
            this.ExitParameter.Size = new System.Drawing.Size(132, 22);
            this.ExitParameter.Text = "Exit";
            this.ExitParameter.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticsToolStripMenuItem,
            this.rulesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.справкаToolStripMenuItem.Text = "Help";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // sonarLabel
            // 
            this.sonarLabel.AutoSize = true;
            this.sonarLabel.Location = new System.Drawing.Point(12, 35);
            this.sonarLabel.Name = "sonarLabel";
            this.sonarLabel.Size = new System.Drawing.Size(43, 13);
            this.sonarLabel.TabIndex = 3;
            this.sonarLabel.Text = "Sonars:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(781, 35);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(38, 13);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Score:";
            // 
            // sonars
            // 
            this.sonars.Enabled = false;
            this.sonars.Location = new System.Drawing.Point(61, 32);
            this.sonars.Name = "sonars";
            this.sonars.ReadOnly = true;
            this.sonars.Size = new System.Drawing.Size(36, 20);
            this.sonars.TabIndex = 5;
            this.sonars.TabStop = false;
            this.sonars.Text = "0";
            this.sonars.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // points
            // 
            this.points.Enabled = false;
            this.points.Location = new System.Drawing.Point(825, 32);
            this.points.Name = "points";
            this.points.ReadOnly = true;
            this.points.Size = new System.Drawing.Size(100, 20);
            this.points.TabIndex = 6;
            this.points.TabStop = false;
            this.points.Text = "0";
            this.points.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(137, 35);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(36, 13);
            this.levelLabel.TabIndex = 7;
            this.levelLabel.Text = "Level:";
            // 
            // level
            // 
            this.level.Enabled = false;
            this.level.Location = new System.Drawing.Point(179, 32);
            this.level.Name = "level";
            this.level.ReadOnly = true;
            this.level.Size = new System.Drawing.Size(37, 20);
            this.level.TabIndex = 8;
            this.level.TabStop = false;
            this.level.Text = "0";
            this.level.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // found
            // 
            this.found.AutoSize = true;
            this.found.Location = new System.Drawing.Point(431, 35);
            this.found.Name = "found";
            this.found.Size = new System.Drawing.Size(75, 13);
            this.found.TabIndex = 9;
            this.found.Text = "Chests Found:";
            // 
            // complete
            // 
            this.complete.Enabled = false;
            this.complete.Location = new System.Drawing.Point(512, 33);
            this.complete.Name = "complete";
            this.complete.ReadOnly = true;
            this.complete.Size = new System.Drawing.Size(22, 20);
            this.complete.TabIndex = 10;
            this.complete.TabStop = false;
            this.complete.Text = "0";
            this.complete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // task
            // 
            this.task.Enabled = false;
            this.task.Location = new System.Drawing.Point(558, 33);
            this.task.Name = "task";
            this.task.ReadOnly = true;
            this.task.Size = new System.Drawing.Size(22, 20);
            this.task.TabIndex = 11;
            this.task.TabStop = false;
            this.task.Text = "0";
            this.task.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // delimiter
            // 
            this.delimiter.AutoSize = true;
            this.delimiter.Location = new System.Drawing.Point(540, 36);
            this.delimiter.Name = "delimiter";
            this.delimiter.Size = new System.Drawing.Size(12, 13);
            this.delimiter.TabIndex = 12;
            this.delimiter.Text = "/";
            // 
            // levelSwitcher
            // 
            this.levelSwitcher.Location = new System.Drawing.Point(250, 32);
            this.levelSwitcher.Name = "levelSwitcher";
            this.levelSwitcher.Size = new System.Drawing.Size(75, 20);
            this.levelSwitcher.TabIndex = 13;
            this.levelSwitcher.Text = "Next Level";
            this.levelSwitcher.UseVisualStyleBackColor = true;
            this.levelSwitcher.Visible = false;
            this.levelSwitcher.Click += new System.EventHandler(this.levelSwitcher_Click);
            // 
            // endButton
            // 
            this.endButton.Enabled = false;
            this.endButton.Location = new System.Drawing.Point(331, 32);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(75, 20);
            this.endButton.TabIndex = 14;
            this.endButton.Text = "End Game";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // gameField
            // 
            this.gameField.Enabled = false;
            this.gameField.Image = global::TreasureHunt.Data.gameField;
            this.gameField.InitialImage = global::TreasureHunt.Data.gameField;
            this.gameField.Location = new System.Drawing.Point(12, 65);
            this.gameField.Name = "gameField";
            this.gameField.Size = new System.Drawing.Size(913, 299);
            this.gameField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameField.TabIndex = 0;
            this.gameField.TabStop = false;
            this.gameField.Click += new System.EventHandler(this.gameField_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TreasureHunt.Data.chest;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(586, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "  New             Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(700, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "Clear field";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 412);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.levelSwitcher);
            this.Controls.Add(this.delimiter);
            this.Controls.Add(this.task);
            this.Controls.Add(this.complete);
            this.Controls.Add(this.found);
            this.Controls.Add(this.level);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.points);
            this.Controls.Add(this.sonars);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.sonarLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gameField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TreasureHunt";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gameField;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InitGameParameter;
        private System.Windows.Forms.ToolStripMenuItem ExitParameter;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label sonarLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox sonars;
        private System.Windows.Forms.TextBox points;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.TextBox level;
        private System.Windows.Forms.Label found;
        private System.Windows.Forms.TextBox complete;
        private System.Windows.Forms.TextBox task;
        private System.Windows.Forms.Label delimiter;
        private System.Windows.Forms.Button levelSwitcher;
        private System.Windows.Forms.ToolStripMenuItem endGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;





    }
}

