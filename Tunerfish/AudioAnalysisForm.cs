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
    public partial class AudioAnalysisForm : Form
    {
        private Form parentForm;

        private Tuner tuner = new Tuner();
        private string[] seriesArray = { "Live Analysis", "Paused Sample", "Found Note"};
       
        private static int RATE = 44100; //Sample rate of the microphone 
        private static int BUFFERSIZE = (int)Math.Pow(2, 15); //Buffer size for the FFT
                                                               //Must be a power of two
        private BufferedWaveProvider bwp;
        private int micDeviceNum = 0;



        public AudioAnalysisForm(Form parent)
        {
            
            InitializeComponent();

            //Get the parent form
            parentForm = parent;

            this.FormClosed += new FormClosedEventHandler(AudioAnalysisForm_FormClosed);


            for (int i = 0; i < seriesArray.Length-1; i++)
            {
                chart1.Series.Add(seriesArray[i]).ChartType = SeriesChartType.Line;
                //chart1.ChartAreas[0].AxisY.Maximum = 20;
            }
            chart1.Series.Add(seriesArray[2]).ChartType = SeriesChartType.Column;


            // see what audio devices are available
            int devcount = WaveIn.DeviceCount;
            Console.WriteLine("Device Count: {0}.", devcount);

            // get the WaveIn class started
            WaveIn wi = new WaveIn();
            wi.DeviceNumber = micDeviceNum;
            wi.WaveFormat = new NAudio.Wave.WaveFormat(RATE, 1);
            wi.BufferMilliseconds = (int)((double)BUFFERSIZE / (double)RATE * 1000.0);

            // create a wave buffer and start the recording
            wi.DataAvailable += new EventHandler<WaveInEventArgs>(wi_DataAvailable);
            bwp = new BufferedWaveProvider(wi.WaveFormat);
            bwp.BufferLength = BUFFERSIZE * 2;

            bwp.DiscardOnBufferOverflow = true;
            wi.StartRecording();

            //DEBUG
            //Start the timer
            //Not needed in actual code
            timer1.Enabled = true;
        }

        private void AudioAnalysisForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }

        void wi_DataAvailable(object sender, WaveInEventArgs e)
        {
            bwp.AddSamples(e.Buffer, 0, e.BytesRecorded);
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

            // convert it to int32 
            int SAMPLE_RESOLUTION = 16;
            int BYTES_PER_POINT = SAMPLE_RESOLUTION / 8;
            Int32[] vals = new Int32[frames.Length / BYTES_PER_POINT];
            double[] Ys = new double[frames.Length / BYTES_PER_POINT];
            double[] Ys2 = new double[frames.Length / BYTES_PER_POINT];
            double[] Xs2 = new double[frames.Length / BYTES_PER_POINT];
            for (int i = 0; i < vals.Length; i++)
            {
                // bit shift the byte buffer into the right variable format
                byte hByte = frames[i * 2 + 1];
                byte lByte = frames[i * 2 + 0];
                vals[i] = (int)(short)((hByte << 8) | lByte);
                Ys[i] = vals[i];

                //x-axis for the FFT, contains the pitch information Ys2
                Xs2[i] = (double)i / Ys.Length * RATE * 1.0017;// / 1000.0; // units are in kHz
            }

           
            //y-axis of the FFT
            Ys2 = tuner.FFT(Ys);
            double[] result = new double[frames.Length / BYTES_PER_POINT / 2];
            

            chart1.Series[seriesArray[0]].Points.Clear();
            //((Ys2.Length) / 2) - (Ys2.Length*2 / 5)
            for (int i = 1; i < ((Ys2.Length) / 2) - (Ys2.Length * 4.4 / 10); i++)
            {
                chart1.Series[seriesArray[0]].Points.AddXY(Xs2[i], Ys2[i]);
                result[i] = Ys2[i];
            }
            //---------------------------
            // update the displays

            //Find the loudest pitch
            double loudest = result.Max();
            int index = Array.FindIndex(result, x => x == loudest);

            Note note = tuner.findClosest(Xs2[index]);
            noteText.Text = note.name.ToString();


            pitchText.Text = Xs2[index].ToString();

            HzText.Text = (Xs2[index] - note.frequency).ToString();

            //Add a bar of the same magnitude as the loudest at the index of the loudest on a separate bar
            chart1.Series[seriesArray[2]].Points.Clear();
            chart1.Series[seriesArray[2]].Points.AddXY(Xs2[index], loudest);


            Application.DoEvents();

            timer1.Enabled = true;


        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateAudioGraph();
        }

        private void tunerBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
