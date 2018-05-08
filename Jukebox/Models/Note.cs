using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Jukebox.Models
{
    public class Note
    {
        public string Name { get; set; }
        public int Frequency { get; set; }
        public int Duration { get; set; }

        public Note(string name, int frequency, int duration)
        {
            Name = name;
            Frequency = frequency;
            Duration = duration;
        }
    }
}
