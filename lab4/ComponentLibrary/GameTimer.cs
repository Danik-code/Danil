using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentLibrary
{
    public partial class GameTimer : UserControl
    {
        int sec, min, h;
        string Ssec, Smin, Sh;

        public GameTimer ()
        {
            InitializeComponent();
        }
        public void Start()
        {
            timer.Enabled = true;
        }
        public void Stop()
        {
            timer.Enabled = false;
        }
        public void Res()
        {
            sec = 0;
            min = 0;
            h = 0;
            Ssec = null;
            Smin = null;
            Sh = null;
            display.Text = "00:00:00";
        }

        private void GameTimer_Load(object sender, EventArgs e)
        {
            display.Text = "00:00:00";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            sec += 1;
            if (sec == 60)
            {
                sec = 0;
                min += 1;
            }
            if (min == 60)
            {
                min = 0;
                h += 1;
            }
            if (h == 24)
            {
                h = 0;
            }

            if (h < 24) display.Text = ($"0{h}:");
            else display.Text = ($"{h}:");

            if (min < 10) display.Text += ($"0{min}:");
            else display.Text += ($"{min}:");

            if (sec < 10) display.Text += ($"0{sec}");
            else display.Text += ($"{sec}");
        }

        private void display_Click(object sender, EventArgs e)
        {
            Start();
        }

        public string TextT()
        {
            if (h < 24) Sh = ($"0{h}:");
            else Sh = ($"{h}:");

            if (min < 10) Smin += ($"0{min}:");
            else Smin += ($"{min}:");

            if (sec < 10) Ssec += ($"0{sec}");
            else Ssec += ($"{sec}");

            return "Время: " + Sh + Smin + Ssec;
        }
    }
}