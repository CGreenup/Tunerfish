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

namespace Metronome
{
    public partial class MetronomeForm1 : Form
    {
        public MetronomeForm1()
        {
            InitializeComponent();
        }

        //5 BPM
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             while (checkBox1.Checked == true)
             {
                Console.Beep(800, 300);
                Thread.Sleep(12000);
                Application.DoEvents();
            }
        }

        //10 BPM
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox2.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(6000);
                Application.DoEvents();
            }
        }

        //15 BPM
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox3.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(4000);
                Application.DoEvents();
            }
        }

        //20 BPM
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox4.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(3000);
                Application.DoEvents();
            }
        }

        //25 BPM
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox5.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(2400);
                Application.DoEvents();
            }
        }

        //30 BPM
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox6.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(2000);
                Application.DoEvents();
            }
        }

        //35 BPM
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox7.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(1714);
                Application.DoEvents();
            }
        }

        //40 BPM
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox8.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(1500);
                Application.DoEvents();
            }
        }

        //45 BPM
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox9.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(1333);
                Application.DoEvents();
            }
        }

        //50 BPM
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox10.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(1200);
                Application.DoEvents();
            }
        }

        //55 BPM
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox11.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(1091);
                Application.DoEvents();
            }
        }

        //60 BPM
        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox12.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(1000);
                Application.DoEvents();
            }
        }

        //65 BPM
        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox13.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(923);
                Application.DoEvents();
            }
        }

        //70 BPM
        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox14.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(857);
                Application.DoEvents();
            }
        }

        //75 BPM
        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox15.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(800);
                Application.DoEvents();
            }
        }

        //80 BPM
        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox16.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(750);
                Application.DoEvents();
            }
        }

        //85 BPM
        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox17.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(706);
                Application.DoEvents();
            }
        }

        //90 BPM
        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox18.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(667);
                Application.DoEvents();
            }
        }

        //95 BPM
        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox19.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(632);
                Application.DoEvents();
            }
        }

        //100 BPM
        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox20.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(600);
                Application.DoEvents();
            }
        }

        //105 BPM
        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox21.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(571);
                Application.DoEvents();
            }
        }

        //110 BPM
        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox22.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(545);
                Application.DoEvents();
            }
        }

        //115 BPM
        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox23.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(300);
                Application.DoEvents();
            }
        }

        //120 BPM
        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox24.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(522);
                Application.DoEvents();
            }
        }

        //125 BPM
        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox25.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(480);
                Application.DoEvents();
            }
        }

        //130 BPM
        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox26.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(462);
                Application.DoEvents();
            }
        }

        //135 BPM
        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox27.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(444);
                Application.DoEvents();
            }
        }

        //140 BPM
        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox28.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(429);
                Application.DoEvents();
            }
        }

        //145 BPM
        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox29.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(414);
                Application.DoEvents();
            }
        }

        //150 BPM
        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox30.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(400);
                Application.DoEvents();
            }
        }

        //155 BPM
        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox31.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(387);
                Application.DoEvents();
            }
        }

        //160 BPM
        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox32.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(375);
                Application.DoEvents();
            }
        }

        //165 BPM
        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox33.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(364);
                Application.DoEvents();
            }
        }

        //170 BPM
        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox34.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(353);
                Application.DoEvents();
            }
        }

        //175 BPM
        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox35.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(343);
                Application.DoEvents();
            }
        }

        //180 BPM
        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox36.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(333);
                Application.DoEvents();
            }
        }

        //185 BPM
        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox37.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(324);
                Application.DoEvents();
            }
        }

        //190 BPM
        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox38.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(316);
                Application.DoEvents();
            }
        }

        //195 BPM
        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox39.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(308);
                Application.DoEvents();
            }
        }

        //200 BPM
        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox40.Checked == true)
            {
                Console.Beep(800, 300);
                Thread.Sleep(300);
                Application.DoEvents();
            }
        }
    }
}
