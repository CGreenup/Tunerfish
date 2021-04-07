using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace TunerFishTest
{
    class HistoryFeature
    {
        
        public void HistoryFeatureMain()
        {

            String fileAddress = @"C:\Users\qtran\source\repos\TunerFishTest\TunerFishTest\Test1.json";

            String temp = File.ReadAllText(fileAddress);

            Console.WriteLine(temp);

            List<Event> Events = JsonConvert.DeserializeObject<List<Event>>(File.ReadAllText(fileAddress));

            History history = new History();

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(Events[i].date);
                Console.WriteLine(Events[i].note);
                Console.WriteLine(Events[i].centOff);
            }
        }
    }
}