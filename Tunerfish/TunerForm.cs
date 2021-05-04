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

namespace Tunerfish
{
    public partial class TunerForm : Form
    {
        Form parentForm;
        private Tuner tuner = new Tuner();

        private static int RATE = 44100; //Sample rate of the microphone 
        private static int BUFFERSIZE = (int)Math.Pow(2, 15); //Buffer size for the FFT
                                                              //Must be a power of two
        private BufferedWaveProvider bwp;
        private int micDeviceNum = 0;

        public TunerForm(Form parent)
        {
            InitializeComponent();
            parentForm = parent;

            this.FormClosed += new FormClosedEventHandler(TunerForm_FormClosed);

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

        }

        private void TunerForm_FormClosed(object sender, FormClosedEventArgs e)
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
            double[] microphoneData = new double[frames.Length / BYTES_PER_POINT];
            double[] FFTArray = new double[frames.Length / BYTES_PER_POINT];
            double[] hertzValues = new double[frames.Length / BYTES_PER_POINT];
            for (int i = 0; i < vals.Length; i++)
            {
                // bit shift the byte buffer into the right variable format
                byte highByte = frames[i * 2 + 1];
                byte lowByte = frames[i * 2 + 0];
                vals[i] = (int)(short)((highByte << 8) | lowByte);
                microphoneData[i] = vals[i];

                //x-axis for the FFT, contains the pitch information Ys2
                hertzValues[i] = (double)i / microphoneData.Length * RATE;
            }


            //y-axis of the FFT
            FFTArray = tuner.FFT(microphoneData);
            double[] result = new double[frames.Length / BYTES_PER_POINT / 2];

            
            // update the displays

            for (int i = 1; hertzValues[i] < 5000; i++)
                result[i] = FFTArray[i];
            

            //Find the loudest pitch
            double loudestDecibel = result.Max();
            int index = Array.FindIndex(result, x => x == loudestDecibel);

            Note detectedNote = tuner.findClosest(hertzValues[index]);
            NoteText.Text = detectedNote.name.ToString();

            //Display the exact pitch in Hertz (Hz)
            double exactHertz = hertzValues[index];
            HzText.Text = exactHertz.ToString();

            Note neighborNote = findNeighborNote(exactHertz, detectedNote.index);
            Console.WriteLine("Neighboring note: " + neighborNote.name.ToString());

            //Update either of the cents-off text boxes (sharpText and flatText)
            UpdateCents(exactHertz, detectedNote, neighborNote);

            Application.DoEvents();

            timer1.Enabled = true;


        }

        private Note findNeighborNote(double pitchValue, int currentNoteIndex)
        {
            Note currentNote = tuner.noteFrequencyTable[currentNoteIndex];
            int index;

            //If the note being played is a higher frequency than the closest note, then it is sharp
            if (pitchValue > currentNote.frequency)
                index = (currentNoteIndex + 1) % tuner.noteFrequencyTable.Length;

            //Otherwise, that means the note is perfectly in-tune or is flat
            else
            {
                index = currentNoteIndex - 1;
                if (index < 0)
                    index = tuner.noteFrequencyTable.Length - 1;
            }
    

            return tuner.noteFrequencyTable[index];
            
        }

        private void UpdateCents(double pitchValue, Note currentNote, Note neighborNote)
        {
            double frequencyDifference = Math.Abs(currentNote.frequency - neighborNote.frequency);
            double centDistance = frequencyDifference / 100;

            double offBy = pitchValue - currentNote.frequency;

            double centsOff = offBy / centDistance;

            if (centsOff < 0)
            {
                centsOff = Math.Abs(centsOff);
                SharpText.Text = "";
                FlatText.Text = centsOff.ToString();
            }
            else
            {
                FlatText.Text = "";
                SharpText.Text = centsOff.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateAudioGraph();
        }
    }
}
