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
    public partial class NewRecord : Form
    {
        MainWindow parent;
        int Score;
        public NewRecord(MainWindow value,int RecScore)
        {
            InitializeComponent();
            this.parent = value;
            this.Score = RecScore;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            player.NickName = Nick.Text;
            player.Scores = Score.ToString();
            parent.Statistics.AddFirst(player);
            Record records = new Record(parent.Statistics, parent);
            records.ShowDialog();
            this.Close();
        }

        private void Nick_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                Player player = new Player();
                player.NickName = Nick.Text;
                player.Scores = Score.ToString();
                parent.Statistics.AddFirst(player);
                Record records = new Record(parent.Statistics, parent);
                records.ShowDialog();
                this.Close();
            }
        }
    }
}
