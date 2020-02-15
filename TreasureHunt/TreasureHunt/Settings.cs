using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreasureHunt
{
    public partial class Settings : Form
    {
        private MainWindow MainForm;
        public Settings(int Levels, int Chests, int Sonars, int GameScores, MainWindow previous)
        {  
            InitializeComponent();
            GameLevels.Value = Levels;
            ChestsParam.Value = Chests;
            RadarParam.Value = Sonars;
            ScoresParam.Value = GameScores;
            MainForm = previous;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            

            MainForm.paramLevels = (int)GameLevels.Value;
            MainForm.paramChests = (int)ChestsParam.Value;
            MainForm.paramRadars = (int)RadarParam.Value;
            MainForm.paramScore = (int)ScoresParam.Value;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
