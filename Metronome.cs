/*********************************\
|            Tunerfish            |
|        Metronome Feature        |
|        by Gavin Werenczuk       |
|     Last Updated 04/08/2021     |
\*********************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Metronome
{
    /* This class stores and converts variables that are read from the user's input in the Main method,
       then called in the timerElapsed method to control the metronome's Tempo.*/
    public class Tempo
    {
        public static string val;
        public static int res;
    }

    // This class contains the metronome's logic.
    class Metronome
    {
        // The Main method establishes the timer used to run the metronome.
        // It also reads the user's input.
        static void Main(string[] args)
        {
            // Allows the user to input a new tempo.
            while (true)
            {
                // Reads user's tempo input.
                Console.WriteLine("Enter a tempo in milliseconds or type '0' to exit:");
                Tempo.val = Console.ReadLine();

                // Converts input to integer.
                Tempo.res = Convert.ToInt32(Tempo.val);

                // Exits the program.
                if (Tempo.val.Equals("0"))
                {
                    break;
                }

                // Creates and instance for timer.
                System.Timers.Timer timer = new System.Timers.Timer();

                // Event handler.
                timer.Elapsed += timerElapsed;

                // Timer Interval.
                timer.Interval += 1000;
                
                Console.WriteLine("Press'ENTER' to enter a new tempo.");

                // Starts and stops the program.
                timer.Start();
                Console.ReadLine();
                timer.Stop();
            }
        }

        // The timerElapsed method controls the metronome's tempo and sound.
        static void timerElapsed(object sender, ElapsedEventArgs e)
        {
            // First parameter contols frequency of the sound, second controls duration(BPM) in milliseconds.
            // The Second parameter is controlled by the user.
            Console.Beep(1500, Tempo.res);
        }
    }
}
