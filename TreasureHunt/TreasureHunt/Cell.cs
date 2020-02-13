using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureHunt
{
   public class Cell
    {
        private int x, y;
        private bool opened;
        public int CoordX
        {
            get { return x;}
            set { x = value;}
        }
        public int CoordY
        {
            get { return y;}
            set { y = value;}
        }       

       public bool Opened
        {
            get { return opened; }
            set { opened = value; }
        }

       public Cell()
        {
            this.CoordX = -1;
            this.CoordY = -1;
            this.opened = false;
        }
    }
}
