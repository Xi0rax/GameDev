﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureHunt
{
   public class Radar
    {
        private int x;
        private int y;

       public int X
        {
            get { return x; }
            set { x = value; }
        }

       public int Y
       {
           get { return y; }
           set { y = value; }
       }

        public Radar()
        {
            x = -1;
            y = -1;
        }
    }
}
