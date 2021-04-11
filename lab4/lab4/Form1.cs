using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Fifteen : Form
    {
        private Button GetButton(int index)
        {
            Button button = button0;
            switch (index)
            {
                case 1:
                    button = button1;
                    break;
                case 2:
                    button = button2;
                    break;
                case 3:
                    button = button3;
                    break;
                case 4:
                    button = button4;
                    break;
                case 5:
                    button = button5;
                    break;
                case 6:
                    button = button6;
                    break;
                case 7:
                    button = button7;
                    break;
                case 8:
                    button = button8;
                    break;
                case 9:
                    button = button9;
                    break;
                case 10:
                    button = button10;
                    break;
                case 11:
                    button = button11;
                    break;
                case 12:
                    button = button12;
                    break;
                case 13:
                    button = button13;
                    break;
                case 14:
                    button = button14;
                    break;
                case 15:
                    button = button15;
                    break;
            }
            return button;
        }
        private int CoordinatesToPosition(int x, int y)
        {
            return
        }
        private void PositionToCoordinates(int position, out int x, out int y)
        {
            return
        }

        public Fifteen()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Fifteen_Load(object sender, EventArgs e)
        {

        }

        private void Fifteen_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
