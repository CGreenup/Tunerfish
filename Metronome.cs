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
    // This class contains the metronome's logic.
    class Metronome
    {
        // The Main method establishes the timer used to run the metronome.
        // It also reads the user's input.
        static void Main(string[] args)
        {
            // Variables.
            string val;
            int res;
            float pel;
            int gan;

            // Allows the user to input a new tempo.
            while (true)
            {
                // Reads user's BPM input.
                Console.WriteLine("Enter a tempo in BPM or type '1' to exit:");
                val = Console.ReadLine();

                // Converts input string to integer.
                res = Convert.ToInt32(val);

                // Divides BPM integer by 60000 (how many ms in a minute) and stores the sum as a floating point.
                pel = 60000 / res;

                // Coverts the floating point into an integer
                gan = Convert.ToInt32(pel);

                // Exits the program.
                if (val.Equals("1"))
                {
                    Console.WriteLine("\nExiting... Goodbye!");
                    break;
                }

                // Creates and instance for timer.
                System.Timers.Timer timer = new System.Timers.Timer();

                // Event handler.
                timer.Elapsed += timerElapsed;

                // Timer Interval.
                timer.Interval += gan;
                
                // Prompts user to click 'ENTER' to stop the current tempo so they can enter a new one.
                Console.WriteLine("\nPress'ENTER' to enter a new tempo.");

                // Starts and stops the program.
                timer.Start();
                Console.ReadLine();
                timer.Stop();
            }
        }

        // The timerElapsed method controls the metronome's tempo and sound.
        static void timerElapsed(object sender, ElapsedEventArgs e)
        {
            // First parameter contols frequency of the beep and the second controls duration of the beep in milliseconds.
            Console.Beep(800, 300);
        }
    }
}
