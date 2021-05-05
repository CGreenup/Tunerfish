# Tunerfish
A desktop tuning application

# INTRODUCTION
    
   The main feature, THE TUNER will have 3 key functions in order to work. First, it needs to be able to get audio information from a microphone into a buffer. 
From there, it needs to form the data in the buffer into usable wave-function data. 
With the wave-function data, a Fast Fourier Transform can be performed on the data to create a new wave function. 
This new function should contain peaks at frequencies which make up the original wave function. 
From this data, we ignore all frequencies below a certain volume threshold to filter out ambient noise. 
Once a signal is detected above the threshold, look for the loudest frequency. 
This frequency should be the fundamental note of whatever it hears, and will be graded against. 
From this fundamental note, the app finds it’s pitch. Once it knows the pitch, it compares it to a table of the standard tone frequencies in A=440hz. 
The program finds the closest pitch and compares it to what the program could hear. 
It then tells the user how many cents off as well as gives a visual indicator for how sharp or flat the signal is. 
50 cents flat being all the way to the left and 50 cents sharp on the right.
    
  The METRONOME feature will be the most straightforward feature. 
It takes a user input in terms of beats per minute (bpm) and, when started, plays a sound at that timing. 
Sounds will be done either through that same synthesizer or using a percussive sound as a sample. 
The timing will be calculated by converting the bpm into beats per millisecond. 
Using that, timing, play a sound at that interval when the user says to start and stop when they say stop.
    
  The NOTE PLAYER will play F, G, A, B, C, D, E, F#, G#, A#, C#, D# notes from octave 1 to 6. 
If the user choose the sustained button, the note will be playing repeatedly until the button stop is pressed
    
  The HISTORY feature will display History of Audio Analysis events. 
The events information will include date and time a note was detected, what note it was and how many cents off the sound was. 
If needed, the user can chose to clear all data or delete particular events


# INSTALLING THE APPLICATION:

Application needed: 
* Visual Studio 2017 or 2019
* Newtonsoft (can be installed by browsing NugetPackage)
        
To use the History and Note Player features, user needs to copy all the file from Note-History file into the directory: TunerFish->Tunerfish->bin->Debug
