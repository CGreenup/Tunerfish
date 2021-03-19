using System;
using System.Collections.Generic;
using System.Text;


class Instrument
{
    int ID;
    int num_strings;
    List<Note> instrument_Strings; 

    public Instrument(int id, int ns, List<Note> IS) 
    {
        ID = id;
        num_strings = ns;
        instrument_Strings = IS;
    }

    public void SetInstString(List<Note> IS)
    {
        instrument_Strings = IS;
    }

}

