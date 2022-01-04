using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_Game
{
    class Crate
    {
        public int L;
        public int T;
        Wall[,] ar;

        public Crate(int L, int T, Wall[,] ar)
        {
            this.L = L;
            this.T = T;
            this.ar = ar;
        }

        public bool move(string direction)
        {
            if (direction == "L")
            {
                if (!ar[T, L + 1].iswall)
                {
                    this.L++;
                    return true;
                }
                return false;


            }
            else if (direction == "R")
            {
                if (!ar[T, L - 1].iswall)
                {
                    this.L--;
                    return true;
                }
                return false;
            }
            else if (direction == "T")
            {
                if (!ar[T - 1, L].iswall)
                {
                    this.T--;
                    return true;
                }
                return false;
            }
            else if (direction == "D")
            {
                if (!ar[T + 1, L].iswall)
                {
                    this.T++;
                    return true;
                }
                return false;
            }


            return true;
        }

    }
}
