/*********************************\
|            Tunerfish            |
|        Metronome Feature        |
|        by Gavin Werenczuk       |
|     Last Updated 05/04/2021     |
\*********************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tunerfish
{
    public partial class MetronomeForm1 : Form
    {
        Form parentForm;

        public MetronomeForm1(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        //5 BPM
        private void button1_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(12000);
            }
        }

        //10 BPM
        private void button2_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(6000);
            }
        }

        //15 BPM
        private void button3_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(4000);
            }
        }

        //20 BPM
        private void button4_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(3000);
            }
        }

        //25 BPM
        private void button5_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(2400);
            }
        }

        //30 BPM
        private void button6_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(2000);
            }
        }

        //35 BPM
        private void button7_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(1714);
            }
        }

        //40 BPM
        private void button8_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(1500);
            }
        }

        //45 BPM
        private void button9_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(1333);
            }
        }

        //50 BPM
        private void button10_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(1200);
            }
        }

        //55 BPM
        private void button11_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(1091);
            }
        }

        //60 BPM
        private void button12_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(1000);
            }
        }

        //65 BPM
        private void button13_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(923);
            }
        }

        //70 BPM
        private void button14_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(857);
            }
        }

        //75 BPM
        private void button15_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(800);
            }
        }

        //80 BPM
        private void button16_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(750);
            }
        }

        //85 BPM
        private void button17_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(706);
            }
        }

        //90 BPM
        private void button18_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(667);
            }
        }

        //95 BPM
        private void button19_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(632);
            }
        }

        //100 BPM
        private void button20_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(600);
            }
        }

        //105 BPM
        private void button21_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(571);
            }
        }

        //110 BPM
        private void button22_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(545);
            }
        }

        //115 BPM
        private void button23_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(522);
            }
        }

        //120 BPM
        private void button24_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(500);
            }
        }

        //125 BPM
        private void button25_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(480);
            }
        }

        //130 BPM
        private void button26_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(462);
            }
        }

        //135 BPM
        private void button27_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(444);
            }
        }

        //140 BPM
        private void button28_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(429);
            }
        }

        //145 BPM
        private void button29_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(414);
            }
        }

        //150 BPM
        private void button30_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(400);
            }
        }

        //155 BPM
        private void button31_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(387);
            }
        }

        //160 BPM
        private void button32_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(375);
            }
        }

        //165 BPM
        private void button33_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(364);
            }
        }

        //170 BPM
        private void button34_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(353);
            }
        }

        //175 BPM
        private void button35_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(343);
            }
        }

        //180 BPM
        private void button36_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(333);
            }
        }

        //185 BPM
        private void button37_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(324);
            }
        }

        //190 BPM
        private void button38_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(316);
            }
        }

        //195 BPM
        private void button39_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(308);
            }
        }

        //200 BPM
        private void button40_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(300);
            }
        }

        // Stop
        private void button41_Click(object sender, EventArgs e)
        {
            while (false)
            {
                break;
            }
        }
    }
}
