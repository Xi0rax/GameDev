using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureHunt
{
   public class Game
   {
        public Cell[] chests;

        public Cell[] Treasure
        {
            get { return chests; }
            set { this.chests = value; }
        }

        public Game(int chestsNumber)
        {
            chests = new Cell[chestsNumber];
        }

        private bool Cross(int x, int y, Cell[] array)
        {
            foreach(var cell in array)
            {
                if (x == cell.CoordX && y == cell.CoordY)
                    return true;
            }
            return false;
        }

        public void Start()
        {
            Random rand = new Random();
           
            for (int j = 0; j < chests.Length; j++)
            {
                chests[j] = new Cell();
            }
                for (var i = 0; i < chests.Length; i++)
                {


                    int x = -1, y = -1;
                    while (Cross(x, y, chests))
                    {
                        x = rand.Next(1, 61);
                        y = rand.Next(1, 20);
                    }
                    chests[i].CoordX = x;
                    chests[i].CoordY = y;
                }
        }
       public void nextLevel()
        {
            Random rand = new Random();
            for (var i = 0; i < chests.Length; i++)
            {
                chests[i].Opened = false;
                int x = rand.Next(1, 61), y = rand.Next(1, 20);
                while (Cross(x, y, chests))
                {
                    x = rand.Next(1, 61);
                    y = rand.Next(1, 20);
                }
                chests[i].CoordX = x;
                chests[i].CoordY = y;
            }
        }
    }
}
