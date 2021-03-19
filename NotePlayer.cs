using System;
using System.Collections.Generic;
using System.Text;


class NotePlayer
{
    List<Note> noteList;
    Boolean beingSustained;
    Boolean beingPlayed;

    public void Sustained()
    {
        if (beingSustained == true)
        {
            //play sound of the note continuously
        }
    }

    public void Play()
    {
        if (beingPlayed == true)
        {
            //play note sound once
        }
    }
}

