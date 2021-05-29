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
        int counter = 0;
        private MyButton GetButton(int index)
        {
            switch (index)
            {
                case 0: return button0;
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;
                case 10: return button10;
                case 11: return button11;
                case 12: return button12;
                case 13: return button13;
                case 14: return button14;
                case 15: return button15;
                default: return button0;
            }
        }

        public Fifteen()
        {
            InitializeComponent();
            game = new Game(4);
        }
        private void GameStart()
        {
            game.Start();
            RefreshButtonField();
        }

        private void RefreshButtonField()
        {
            for (int position = 0; position < 16; position++)
            {
                GetButton(position).Textb = game.GetNumber(position).ToString();
                GetButton(position).Visible = true;
                if (game.GetNumber(position).ToString() == "0") GetButton(position).Visible = false;
                GetButton(position).Invalidate();
            }
        }


        private void Fifteen_Load(object sender, EventArgs e)
        {
            GameStart();
            label1.Text = "Ходов: ";
        }

        private void Fifteen_MouseClick(object sender, MouseEventArgs e)
        { }

        private void начатьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.Start();
            game.RandomGame();
            RefreshButtonField();

            counter = 0;
            label1.Text = "Ходов: " + counter.ToString();
        }
        private void button0_Click_1(object sender, EventArgs e)
        {
            int position = Convert.ToInt32(((MyButton)sender).Tag);
            game.ShiftAndSave(position);
            RefreshButtonField();

            counter++;
            label1.Text = "Ходов: " + counter.ToString();

            gameTimer1.Start();
            if (game.Check())
            {
                gameTimer1.Stop();
                MessageBox.Show("Победа \n" + gameTimer1.TextT());
                gameTimer1.Res();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            game.Undo();
            RefreshButtonField();
            counter++;
            label1.Text = "Ходов: " + counter.ToString();
        }

        private void Fifteen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                game.Undo();
                RefreshButtonField();
                counter++;
                label1.Text = "Ходов: " + counter.ToString();
            }
        }

        private void gameTimer1_Load(object sender, EventArgs e)
        {

        }
    }
}