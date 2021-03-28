using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NAudio.Wave;
using NAudio.CoreAudioApi;
using System.Numerics;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tunerfish
{
    public partial class Form1 : Form
    {

        /* Example stuff
        int a = 1;
        int b = 2;
        string[] seriesArray = { "Cats", "Dogs" };
        */
        string[] seriesArray = { "Live Analysis", "Paused Sample"};

        public WaveIn wi;
        private static int RATE = 44100; //Sample rate of the microphone 
        private static int BUFFERSIZE = (int)Math.Pow(2, 10); //Buffer size for the FFT
                                                               //Must be a power of two
        public BufferedWaveProvider bwp;
        public int micDeviceNum = 0;


        public Form1()
        {
            
            InitializeComponent();


            for (int i = 0; i < seriesArray.Length; i++)
            {
                chart1.Series.Add(seriesArray[i]);
            }


            // see what audio devices are available
            int devcount = WaveIn.DeviceCount;
            Console.Out.WriteLine("Device Count: {0}.", devcount);

            // get the WaveIn class started
            WaveIn wi = new WaveIn();
            wi.DeviceNumber = 0;
            wi.WaveFormat = new NAudio.Wave.WaveFormat(RATE, 1);
            wi.BufferMilliseconds = (int)((double)BUFFERSIZE / (double)RATE * 1000.0);

            // create a wave buffer and start the recording
            wi.DataAvailable += new EventHandler<WaveInEventArgs>(wi_DataAvailable);
            bwp = new BufferedWaveProvider(wi.WaveFormat);
            bwp.BufferLength = BUFFERSIZE * 2;

            bwp.DiscardOnBufferOverflow = true;
            wi.StartRecording();

            timer1.Enabled = true;
        }

        void wi_DataAvailable(object sender, WaveInEventArgs e)
        {
            bwp.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }

        public double[] FFT(double[] data)
        {

            double[] fft = new double[data.Length]; // this is where we will store the output (fft)
            Complex[] fftComplex = new Complex[data.Length]; // the FFT function requires complex format
            for (int i = 0; i < data.Length; i++)
            {
                fftComplex[i] = new Complex(data[i], 0.0); // make it complex format (imaginary = 0)
            }
            Accord.Math.FourierTransform.FFT(fftComplex, Accord.Math.FourierTransform.Direction.Forward);
            for (int i = 0; i < data.Length; i++)
            {
                fft[i] = fftComplex[i].Magnitude; // back to double
                //fft[i] = Math.Log10(fft[i]); // convert to dB
            }
            return fft;
        }

        public void UpdateAudioGraph()
        {

            // read the bytes from the stream
            int frameSize = BUFFERSIZE;
            var frames = new byte[frameSize];
            bwp.Read(frames, 0, frameSize);
            if (frames.Length == 0) return;
            if (frames[frameSize - 2] == 0) return;

            timer1.Enabled = false;

            // convert it to int32 manually (and a double for scottplot)
            int SAMPLE_RESOLUTION = 16;
            int BYTES_PER_POINT = SAMPLE_RESOLUTION / 8;
            Int32[] vals = new Int32[frames.Length / BYTES_PER_POINT];
            double[] Ys = new double[frames.Length / BYTES_PER_POINT];
            double[] Xs = new double[frames.Length / BYTES_PER_POINT];
            double[] Ys2 = new double[frames.Length / BYTES_PER_POINT];
            double[] Xs2 = new double[frames.Length / BYTES_PER_POINT];
            for (int i = 0; i < vals.Length; i++)
            {
                // bit shift the byte buffer into the right variable format
                byte hByte = frames[i * 2 + 1];
                byte lByte = frames[i * 2 + 0];
                vals[i] = (int)(short)((hByte << 8) | lByte);
                Xs[i] = i;
                Ys[i] = vals[i];
                Xs2[i] = (double)i / Ys.Length * RATE / 1000.0; // units are in kHz
            }

           
            Ys2 = FFT(Ys);

            chart1.Series[seriesArray[0]].Points.Clear();

            for (int i = 0; i < Ys2.Length / 2; i++)
            {
                chart1.Series[seriesArray[0]].Points.Add(Ys2[i]);
            }

            // update the displays


            Application.DoEvents();

            timer1.Enabled = true;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void noteplayerBtn_Click(object sender, EventArgs e)
        {

        }

        private void metronomeBtn_Click(object sender, EventArgs e)
        {

        }

        private void tunerBtn_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void analysisBtn_Click(object sender, EventArgs e)
        {

        }

        private void historyBtn_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateAudioGraph();
            /*
            a++;
            b++;

            // Data array
            int[] pointsArray = { a, b };

            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Add point.
                chart1.Series[i].Points.Add(pointsArray[i]);
            }
            */
        }
    }
}
