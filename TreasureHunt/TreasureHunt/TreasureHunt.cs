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
    
    public partial class MainWindow : Form
    {
            public int paramLevels = 1;
            public int paramChests = 1;
            public int paramRadars = 20;
            public int paramScore = 10;
            public int record = 0;
            public bool session = false;
            public LinkedList<Player> Statistics = new LinkedList<Player>();

        public MainWindow()
        {
            InitializeComponent();
        }
            public Image Success = Data.cell_with_chest;
            public Image Failed = Data.cell_failed;
            public Image[] distances = new Image[9];
            public Radar[] radars;
            public Game newGame;
            public int Level = 0;
            public int Sonars = 0;
            public int Found = 0;
            public int To_find = 0;
            public int Score = 0;
                             
        private int InRange(int CoordX, int CoordY, Cell[] array)
        {
            int distance = (int)Math.Sqrt(Math.Pow((CoordX - array[0].CoordX),2) + Math.Pow((CoordY - array[0].CoordY),2));
            foreach(var chest in array)
            {
                int temp = (int)Math.Sqrt(Math.Pow((CoordX - chest.CoordX), 2) + Math.Pow((CoordY - chest.CoordY), 2));
                if (temp < distance&&!chest.Opened) distance = temp;
            }
            return distance;
        }

        public void EndSession()
        {
            gameField.Enabled = false;
            this.DisableInfo();
            endButton.Enabled = false;
            endGameToolStripMenuItem.Enabled = false;
            gameField.Image = gameField.InitialImage;
            toolStripStatusLabel1.Text = "Session complete";
        }

        private void MatchComplete()
        {
            this.session = false;
            Score += paramScore;
            this.points.Text = Score.ToString();
            gameField.Enabled = false;
            this.DisableInfo();
            this.endButton.Enabled = false;
            this.endGameToolStripMenuItem.Enabled = false;
            MessageBox.Show("Congratulations!","MatchReport");
            if (record<Score)
            {
                NewRecord newrec = new NewRecord(this, Score);
                newrec.ShowDialog();
                record = Score;
            }
        }

        private bool RadarIsUsed(int x, int y, Radar[] array)
        {
            foreach(var radar in array)
            {
                if (x == radar.X && y == radar.Y)
                    return true;
            }
            return false;
        }

        private void DisableInfo()
        {
            this.sonars.Enabled = false;
            this.complete.Enabled = false;
            this.task.Enabled = false;
            this.level.Enabled = false;
            this.points.Enabled = false;
        }

        private void NextLevel()
        {
            endButton.Enabled = true;
            endGameToolStripMenuItem.Enabled = true;
            Sonars = 20;
            sonars.Text = Sonars.ToString();
            Found = 0;
            complete.Text = Found.ToString();
            Level++;
            level.Text = Level.ToString();
            Score += 10;
            newGame.nextLevel();
            for(var i = 0; i < radars.Length; i++)
            {
                radars[i].X = -1;
                radars[i].Y = -1;
            }
        }


        private void StartGame()
        {
            this.endButton.Enabled = true;
            this.endGameToolStripMenuItem.Enabled = true;
            session = true;
            Level = 1;
            Sonars = paramRadars;
            Found = 0;
            To_find = paramChests;
            Score = 0;
            level.Text = Level.ToString();
            level.Enabled = true;
            sonars.Text = Sonars.ToString();
            sonars.Enabled = true;
            complete.Text = Found.ToString();
            complete.Enabled = true;
            task.Text = To_find.ToString();
            task.Enabled = true;
            points.Text = Score.ToString();
            points.Enabled = true;
            gameField.Image = gameField.InitialImage;
            newGame = new Game(paramChests);
            Bitmap background = new Bitmap(gameField.Image,gameField.Width,gameField.Height);
            Graphics r = Graphics.FromImage(background);            
            newGame.Start();
            Cell[] chests = newGame.Treasure;           
            gameField.Image = background;
            gameField.Enabled = true;
            radars = new Radar[paramRadars];
            for (int j = 0; j < radars.Length; j++)
            radars[j] = new Radar();
        }

        private void GameOver()
        {
            this.session = false;
            this.toolStripStatusLabel1.Text = "Game over";
            this.gameField.Enabled = false;
            this.endButton.Enabled = false;
            this.endGameToolStripMenuItem.Enabled = false;
            this.DisableInfo();
            string coordinates = "";
            if (record < Score)
            {
                record = Score;
                NewRecord newrec = new NewRecord(this, Score);
                newrec.ShowDialog();
            }
            foreach (var chest in newGame.Treasure)
            {
                if (!chest.Opened)
                {
                    coordinates += "X: " + chest.CoordX + "; " + "Y: " + chest.CoordY + '\n';
                }
            }
            GameReport report = new GameReport(coordinates);
            report.ShowDialog();
        }

        private void Check(EventArgs e)
        {
            MouseEventArgs MouseCoordinates = (MouseEventArgs)e;
            Bitmap background = new Bitmap(gameField.Image, gameField.Width, gameField.Height);
            Graphics g = Graphics.FromImage(background);
            Point Coords = MouseCoordinates.Location;
            int CoordCellX = Coords.X / 15;
            int CoordCellY = Coords.Y / 15;
            if (!RadarIsUsed(CoordCellX, CoordCellY, radars))
            {
                if (InRange(CoordCellX, CoordCellY, newGame.Treasure) == 0)
                {
                    g.DrawImage(Success, new Point(15 * CoordCellX, 15 * CoordCellY));
                    Sonars--;
                    sonars.Text = Sonars.ToString();
                    Found++;
                    for (var i = 0; i < newGame.Treasure.Length; i++)
                    {
                        if (newGame.Treasure[i].CoordX == CoordCellX && newGame.Treasure[i].CoordY == CoordCellY)
                            newGame.Treasure[i].Opened = true;
                    }

                    complete.Text = Found.ToString();
                    Score += Sonars;
                    points.Text = Score.ToString();
                    if (Level==paramLevels)
                    {
                        this.MatchComplete();
                    }
                    else if (complete.Text==task.Text)
                    {
                        Score += paramScore;
                        toolStripStatusLabel1.Text = "Level Complete";
                        endButton.Enabled = false;
                        endGameToolStripMenuItem.Enabled = false;
                        levelSwitcher.Visible = true;
                        gameField.Enabled = false;
                    }

                }
                else if (InRange(CoordCellX, CoordCellY, newGame.Treasure) <= 9)
                {

                    g.DrawImage(distances[InRange(CoordCellX, CoordCellY, newGame.Treasure) - 1], new Point(15 * CoordCellX, 15 * CoordCellY));
                    Sonars--;
                    sonars.Text = Sonars.ToString();
                    if (Sonars == 0)
                    {
                        GameOver();
                    }
                    else
                    {
                        radars[Sonars - 1].X = CoordCellX;
                        radars[Sonars - 1].Y = CoordCellY;
                    }
                }
                else
                {
                    g.DrawImage(Failed, new Point(15 * CoordCellX, 15 * CoordCellY));
                    Sonars--;
                    sonars.Text = Sonars.ToString();
                    if (Sonars == 0)
                    {
                        GameOver();
                    }
                    else
                    {
                        radars[Sonars - 1].X = CoordCellX;
                        radars[Sonars - 1].Y = CoordCellY;
                    }
                }
                gameField.Image = background;   
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            for (var i = 0; i < distances.Length; i++)
            {
                string filename = "cell_" + (i+1).ToString();
                distances[i] =(Image)Data.ResourceManager.GetObject(filename);
            }
        }
       
        private void gameField_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Left)
                Check(e);
            else if (me.Button == MouseButtons.Right)
            {
                int CoordX =  me.Location.X / 15 + 1;
                int CoordY = me.Location.Y / 15 + 1;
                toolStripStatusLabel1.Text = CoordX.ToString() + "; " + CoordY.ToString();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StartGame();
        }

        private void levelSwitcher_Click(object sender, EventArgs e)
        {
            this.NextLevel();
            toolStripStatusLabel1.Text = "Level " + Level.ToString();
            gameField.Image = gameField.InitialImage;
            levelSwitcher.Visible = false;
            gameField.Enabled = true;

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!session)
            {
                Settings settings = new Settings(paramLevels, paramChests, paramRadars, paramScore, this);
                settings.ShowDialog();
            }
            else
            {
                Confirmation confirm = new Confirmation(this);
                confirm.ShowDialog();
            }
        }

        private void endGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.GameOver();
            endButton.Enabled = false;
            endGameToolStripMenuItem.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.GameOver();
            endButton.Enabled = false;
            endGameToolStripMenuItem.Enabled = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rules rules = new Rules();
            rules.ShowDialog();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Record records = new Record(Statistics, this);
            records.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.StartGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameField.Image = gameField.InitialImage;
        }
    }
}
