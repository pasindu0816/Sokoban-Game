using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_Game
{
    class Wall
    {
        public int left;
        public int top;
        public bool istarget;
        public bool iswall;


        public Wall(int lf, int tp)
        {
            left = lf;
            top = tp;
        }

    }
}
