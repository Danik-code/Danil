using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Memento
    {
        int[,] field;
        int size;

        public Memento(int size)
        {
            this.size = size;
            field = new int[size, size];
        }

        public void SetMemento(int[,] Field)
        {
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    field[x, y] = Field[x, y];
                }
            }
        }

        public int[,] GetMemento => field;
    }
}