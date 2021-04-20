using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Used to make complex numbers
using System.Numerics;

//Used for the Fast Fourier Transform
using MathNet.Numerics.IntegralTransforms;

namespace Tunerfish
{
    class Tuner
    {
        Note[] noteFrequencyTable;
        string[] noteNames = { "A", "A#/Bb", "B", "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab" };

        public Tuner()
        {
            setupNoteFrequencyTable();
        }

        void setupNoteFrequencyTable()
        {
            
            
            int octaves = 8;

            int tempIndex;
            int tempOctave;
            double currentFrequency = 55;

            noteFrequencyTable = new Note[12 * octaves];

            for (int i = 0; i< (12 * octaves); i++)
            {
                //Find out the note name
                tempIndex = i % noteNames.Length;

                //Find out the octave of the note using integer division
                tempOctave = (int)(i / 12) + 1;

                //Create a new Note element and add it to the table of frequencies
                noteFrequencyTable[i] = new Note(noteNames[tempIndex], tempOctave, currentFrequency);

                //Increment the frequency value to the next half-step, unless it's an octave of A
                //In which case, Double A1 to the octave
                //This helps reduce compounding computational errors
                if ((i+1)%12 == 0)
                {
                    currentFrequency = 55 * Math.Pow(2, tempOctave);
                }
                else
                {
                    currentFrequency *= 1.05946;
                }


            }
        }

        public void printNoteTable()
        {
            int oct;
            string name;
            double freq;

            for (int i = 0; i < noteFrequencyTable.Length; i++)
            {
                oct = noteFrequencyTable[i].octave;
                name = noteFrequencyTable[i].name;
                freq = noteFrequencyTable[i].frequency;

                Console.WriteLine(name+ (oct.ToString()) + " = " + freq.ToString() );
            }
        }

        public Note findClosest(double frequency)
        {
            Note closestNote = noteFrequencyTable[0];
            double frequencyDifference = Math.Abs(closestNote.frequency - frequency);
            double tempDifference;

            for (int i = 0; i < noteFrequencyTable.Length; i++)
            {
                tempDifference = Math.Abs(noteFrequencyTable[i].frequency - frequency);
                if (frequencyDifference > tempDifference)
                {
                    closestNote = noteFrequencyTable[i];
                    frequencyDifference = tempDifference;
                }
            }

            return closestNote;
        }

        public double[] FFT(double[] data)
        {
            
            double[] fft = new double[data.Length]; // this is where we will store the output (fft)
            Complex[] fftComplex = new Complex[data.Length]; // the FFT function requires complex format
            for (int i = 0; i < data.Length; i++)
            {
                fftComplex[i] = new Complex(data[i], 0.0); // make it complex format (imaginary = 0)
            }
            //Accord.Math.FourierTransform.FFT(fftComplex, Accord.Math.FourierTransform.Direction.Forward);
            Fourier.Forward(fftComplex, FourierOptions.NoScaling);
            for (int i = 0; i < data.Length; i++)
            {
                fft[i] = fftComplex[i].Magnitude; // back to double

                //This causes the application to crash
                //fft[i] = Math.Log10(fft[i]); // convert to dB
            }
            return fft;
        }
        //private double magnitude()
    }

    class Note
    {
        public string name;
        public int octave;
        public double frequency;

        public Note(String noteName, int noteOctave, double noteFrequency)
        {
            name = noteName;
            octave = noteOctave;
            frequency = noteFrequency;
        }
    }
}
