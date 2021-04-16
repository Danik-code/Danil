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
        int x0, y0;
        public Game(int size)
        {
            this.size = size;
            field = new int[size, size];
        }
        private int CoordinatesToPosition(int x, int y)
        {
            int Nbutton = 1;
            if (x == 0 && y == 0)
                return Nbutton;
            if (x == 1 && y == 0)
                return Nbutton = 2;
            if (x == 2 && y == 0)
                return Nbutton = 3;
            if (x == 3 && y == 0)
                return Nbutton = 4;
            if (x == 0 && y == 1)
                return Nbutton = 5;
            if (x == 1 && y == 1)
                return Nbutton = 6;
            if (x == 2 && y == 1)
                return Nbutton = 7;
            if (x == 3 && y == 1)
                return Nbutton = 8;
            if (x == 0 && y == 2)
                return Nbutton = 9;
            if (x == 1 && y == 2)
                return Nbutton = 10;
            if (x == 2 && y == 2)
                return Nbutton = 11;
            if (x == 3 && y == 2)
                return Nbutton = 12;
            if (x == 0 && y == 3)
                return Nbutton = 13;
            if (x == 1 && y == 3)
                return Nbutton = 14;
            if (x == 2 && y == 3)
                return Nbutton = 15;
            if (x == 3 && y == 3)
                return Nbutton = 16;
            return Nbutton;
        }
        private void PositionToCoordinates(int position, out int x, out int y)
        {
            x = 0; y = 0;
            if (position == 0)
            { x = 0; y = 0; }
            if (position == 1)
            { x = 1; y = 0; }
            if (position == 2)
            { x = 2; y = 0; }
            if (position == 3)
            { x = 3; y = 0; }
            if (position == 4)
            { x = 0; y = 1; }
            if (position == 5)
            { x = 1; y = 1; }
            if (position == 6)
            { x = 2; y = 1; }
            if (position == 7)
            { x = 3; y = 1; }
            if (position == 8)
            { x = 0; y = 2; }
            if (position == 9)
            { x = 1; y = 2; }
            if (position == 10)
            { x = 2; y = 2; }
            if (position == 11)
            { x = 3; y = 2; }
            if (position == 12)
            { x = 0; y = 3; }
            if (position == 13)
            { x = 1; y = 3; }
            if (position == 14)
            { x = 2; y = 3; }
            if (position == 15)
            { x = 3; y = 3; }
        }
        public void Start()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    field[i, j] = CoordinatesToPosition(j, i);
                    if (field[i, j]==16)
                    {
                        field[i, j] = 0;
                    }
                }
            }
            x0 = size - 1;
            y0 = size - 1;
        }

        public void Shift(int position)
        {
            int x, y;
            PositionToCoordinates(position, out x, out y);
            if ((Math.Abs(x0-x)==1&& Math.Abs(y0 - y) == 0)|| (Math.Abs(x0 - x) == 0 && Math.Abs(y0 - y) == 1))
            {
                field[x0, y0] = field[x, y];
                field[x, y] = 0;
                x0 = x;
                y0 = y;
            }
        }

        public static int rand;
        //Random rand = new Random();
        public void ShiftRandom()
        {
            Random rand = new Random();
            int val = rand.Next(1, 101);

        }

        public int GetNumber(int position)
        {
            int x, y;
            PositionToCoordinates(position, out x, out y);
            if (x < 0 || y < 0)
            {
                return 0;
            }
            return field[x, y];
        }
    }
}