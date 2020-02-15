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
    public partial class Record : Form
    {

        MainWindow parent;

        public Record(LinkedList<Player>income, MainWindow main)
        {
            InitializeComponent();
            this.parent = main;
            foreach(Player player in income)
            {
                string[] row = { player.NickName, player.Scores.ToString() };
                this.RecordTable.Rows.Add(row);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            parent.Statistics.Clear();
            this.RecordTable.Rows.Clear();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
