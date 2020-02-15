namespace TreasureHunt
{
    partial class Settings
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
            this.Confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.GameLevels = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChestsParam = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.RadarParam = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ScoresParam = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.GameLevels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChestsParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadarParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoresParam)).BeginInit();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(30, 228);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 0;
            this.Confirm.Text = "OK";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(145, 228);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // GameLevels
            // 
            this.GameLevels.Location = new System.Drawing.Point(100, 42);
            this.GameLevels.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.GameLevels.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GameLevels.Name = "GameLevels";
            this.GameLevels.Size = new System.Drawing.Size(120, 20);
            this.GameLevels.TabIndex = 2;
            this.GameLevels.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Levels:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chests:";
            // 
            // ChestsParam
            // 
            this.ChestsParam.Location = new System.Drawing.Point(100, 85);
            this.ChestsParam.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ChestsParam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChestsParam.Name = "ChestsParam";
            this.ChestsParam.Size = new System.Drawing.Size(120, 20);
            this.ChestsParam.TabIndex = 5;
            this.ChestsParam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sonars:";
            // 
            // RadarParam
            // 
            this.RadarParam.Location = new System.Drawing.Point(100, 136);
            this.RadarParam.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.RadarParam.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.RadarParam.Name = "RadarParam";
            this.RadarParam.Size = new System.Drawing.Size(120, 20);
            this.RadarParam.TabIndex = 7;
            this.RadarParam.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Scores for the complete level:";
            // 
            // ScoresParam
            // 
            this.ScoresParam.Location = new System.Drawing.Point(100, 186);
            this.ScoresParam.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ScoresParam.Name = "ScoresParam";
            this.ScoresParam.Size = new System.Drawing.Size(120, 20);
            this.ScoresParam.TabIndex = 9;
            this.ScoresParam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ScoresParam.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 297);
            this.Controls.Add(this.ScoresParam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RadarParam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChestsParam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GameLevels);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Confirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.GameLevels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChestsParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadarParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoresParam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.NumericUpDown GameLevels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ChestsParam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown RadarParam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ScoresParam;
    }
}