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
        Game game;
        public int ms, sec, min;
        int counter = 0;
        private Button GetButton(int index)
        {
            Button button;
            button = button0;
            switch (index)
            {
                case 0:
                    button = button0;
                    break;
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

        public Fifteen()
        {
            InitializeComponent();
            game=new Game(4);
        }
        private void GameStart()
        {
            game.Start();
            RefreshButtonField();
            for (int i = 0; i < 150; i++)
            {
                game.ShiftRandom();
                RefreshButtonField();
            }
        }

        private void RefreshButtonField()
        {
            for (int position = 0; position < 16; position++)
            {
                Button button = GetButton(position);
                button.Show();
                GetButton(position).Text = game.GetNumber(position).ToString();
                if (game.GetNumber(position)==0)
                    button.Hide();
            }
        }


        private void Fifteen_Load(object sender, EventArgs e)
        {
            GameStart();
            label1.Text = "Ходов: ";
			label2.Text = "Время: " + "0" + ":" + "0";
		}

        private void Fifteen_MouseClick(object sender, MouseEventArgs e)
        {}

        private void начатьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.Start();
            RefreshButtonField();
            for (int i = 0; i < 150; i++)
            {
                game.ShiftRandom();
                RefreshButtonField();
            }

            ms = 0; sec = 0;
            timer1.Enabled = false;
            label2.Text = "Время: " + sec + ":" + ms;

            counter = 0;
            label1.Text = "Ходов: " + counter.ToString();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt32(((Button)sender).Tag);
            game.Shift(position);
            RefreshButtonField();


            counter++;
            label1.Text = "Ходов: "+ counter.ToString();

            timer1.Enabled = true;
            if (game.Check())
            {
                timer1.Enabled = false;
                MessageBox.Show("Победа");
                ms = 0; sec = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {}

        private void timer1_Tick(object sender, EventArgs e)
        {
            ms += 1;
            if (ms == 60)
            {
                ms = 0;
                sec += 1;
            }
            if (sec == 60)
            {
                sec = 0;
                min += 1;
            }
            label2.Text = "Время: " + sec + ":" + ms;
        }

        private void label2_Click(object sender, EventArgs e)
        {}
    }
}