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
        //This is a table that contains every note that is detectable by the TunerFish
        public Note[] noteFrequencyTable;

        //The note names for every note within an octave
        string[] noteNames = { "A", "A#/Bb", "B", "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab" };

        public Tuner()
        {
            setupNoteFrequencyTable();
        }

        //Fills the noteFrequencyTable with the Notes
        void setupNoteFrequencyTable()
        {
            //Number of octaves from A1 to detect
            int octaves = 8;

            int tempIndex;
            int tempOctave;

            //This is A1, and it is the lowest note this tuner can detect
            double currentFrequency = 55;

            noteFrequencyTable = new Note[12 * octaves];

            for (int i = 0; i< (12 * octaves); i++)
            {
                //Find out the note name
                tempIndex = i % noteNames.Length;

                //Find out the octave of the note using integer division
                tempOctave = (int)(i / 12) + 1;

                //Create a new Note element and add it to the table of frequencies
                noteFrequencyTable[i] = new Note(noteNames[tempIndex], tempOctave, currentFrequency, i);

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

        //Debug Tool
        //Outputs the contents of the noteFrequencyTable array into the console
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

                Console.WriteLine(name + oct.ToString() + " = " + freq.ToString() );
            }
        }

        //Finds the closest note given any frequency and outputs it
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

        //Perform an FFT on an array of doubles
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
    }

    class Note
    {
        //Note name
        public string name;

        //Octave of the note
        public int octave;

        //Frequency of the note in Hertz(Hz)
        public double frequency;

        //Index within the noteFrequencyTable
        public int index;

        public Note(String noteName, int noteOctave, double noteFrequency, int noteIndex)
        {
            name = noteName;
            octave = noteOctave;
            frequency = noteFrequency;
            index = noteIndex;
        }
    }
}
