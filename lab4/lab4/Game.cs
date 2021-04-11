using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Game
    {
        int[,] field;
        int size;
        public Game(int size)
        {
            this.size = size;
            int[,] field = new int[size, size];
        }
    }
}
