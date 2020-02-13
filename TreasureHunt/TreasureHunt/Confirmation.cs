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
    public partial class Confirmation : Form
    {
        MainWindow parent;
        public Confirmation(MainWindow address)
        {
            InitializeComponent();
            this.parent = address;
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            parent.EndSession();
            Settings settings =  new Settings(parent.paramLevels, parent.paramChests, parent.paramRadars, parent.paramScore, parent);
            this.Close();
            settings.ShowDialog();
        }
    }
}
