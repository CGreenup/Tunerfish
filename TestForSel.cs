using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace TunerFishTest
{
    class TestForSel
    {
        public void TestForSelMain()
        {
            String fileAddress = @"C:\Users\qtran\source\repos\TunerFishTest\TunerFishTest\Test1.json";
            List<Event> Events = new List<Event>();
            for (int i = 0; i < 4; i++)
            {
                Event newEvent = new Event();
                newEvent.date = DateTime.Now;
                newEvent.centOff = i;
                newEvent.note = "A";

                Events.Add(newEvent);
            }

            string json = JsonConvert.SerializeObject(Events, Formatting.Indented);
            File.WriteAllText(fileAddress, json);
        }
    }
}