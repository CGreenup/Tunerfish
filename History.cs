using System;
using System.Collections.Generic;
using System.Text;

namespace TunerFishTest
{
    class History : Event
    {
        public List<Event> Events;
        public int length;

        public History()
        {
            length = 0;
        }
        public int getLength()
        {
            return length;
        }

        public void DisplayCurrEvent(int i)
        {
            Console.WriteLine(Events[i].date);
            Console.WriteLine(Events[i].note);
            Console.WriteLine(Events[i].centOff);
        }

        public void DeleteEvent(int id)
        {
            Events.RemoveAt(id);
        }

        public void AddEvent(Event e)
        {
            Events.Add(e);
            length++;
        }

        public void ClearHistory()
        {
            Events.Clear();
        }

    }
}