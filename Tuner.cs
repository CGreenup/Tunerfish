using System;
using System.Collections.Generic;
using System.Text;


class Tuner
{
    List<float> soundSample;
    int cents;
    float pitchCorrectness;
    Boolean isSharp;
    List<Note> pitch_Table;
    List<Instrument> instrument_list;
    float temperment;
    Note closestNote;
    float dbThreshold;

    public Note FindClosestNote()
    {
        //some code to find out which one is the closest note
        return closestNote;
    }

    public Boolean IsSharp()
    {
        //some code to find out if it is Sharp here
        return isSharp;
    }
}
