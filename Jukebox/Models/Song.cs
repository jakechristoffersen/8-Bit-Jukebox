using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Jukebox.Models
{
    public class Song 
    {
        
        public string Artist { get; set; }
        public string Title { get; set; }
        public List<Note> Notes = new List<Note>();
      
        public Song(string artist, string title, List<Note> notes)
        {
            Artist = artist;
            Title = title;
            Notes = notes;
        }

       

        public void Play()
        {
            Console.Clear();
           
            foreach (var note in Notes)
            {
                if (note.Name == "note")
                {

                    Console.Beep(note.Frequency, note.Duration);
                }
                else
                {
                    Thread.Sleep(note.Duration);
                }
            }
        }

    }
}
