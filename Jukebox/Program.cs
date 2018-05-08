using Jukebox.Models;
using System;
using System.Collections.Generic;

namespace Jukebox
{
    class Program
    {
        static void Main(string[] args)
        {
            SongJukebox songJukebox = new SongJukebox("RockBox", "Finns");
            songJukebox.Setup();

            Song superMario = new Song("Nintendo", "Super Mario", marioNotes);
            Song tetris = new Song("Nintendo", "Tetris", tetrisNotes);
            Song metroid = new Song("Nintendo", "Metroid", metroidNotes);

            songJukebox.AddItem(superMario);
            songJukebox.AddItem(tetris);
            songJukebox.AddItem(metroid);

            while (songJukebox.Playing)
            {
                songJukebox.MainMenuSelection();
            }

        }
        public static List<Note> tetrisNotes = new List<Note>
            {
                new Note("note", 1320, 400),
                new Note("note", 990, 200),
                new Note("note", 1056, 200),
                new Note("note", 1188, 200),
                new Note("note", 1320, 200),
                new Note("note", 1188, 200),
                new Note("note", 1056, 200),
                new Note("note", 990, 200),
                new Note("note", 880, 400),
                new Note("note", 880, 200),
                new Note("note", 1056, 200),
                new Note("note", 1320, 400),
                new Note("note", 1188, 200),
                new Note("note", 1056, 200),
                new Note("note", 990, 600),
                new Note("note", 1056, 200),
                new Note("note", 1188, 400),
                new Note("note", 1320, 400),
                new Note("note", 1056, 400),
                new Note("note", 880, 400),
                new Note("note", 880, 400)
            };

        public static List<Note> metroidNotes = new List<Note>
            {
                new Note("note", 1320, 4),
                new Note("note", 990, 2),
                new Note("note", 1056, 2),
                new Note("note", 1188, 2),
                new Note("note", 1320, 2),
                new Note("note", 1188, 2),
                new Note("note", 1056, 2),
                new Note("note", 990, 2),
                new Note("note", 880, 4),
                new Note("note", 880, 2),
                new Note("note", 1056, 2),
                new Note("note", 1320, 4),
                new Note("note", 1188, 2),
                new Note("note", 1056, 2),
                new Note("note", 990, 6),
                new Note("note", 1056, 2),
                new Note("note", 1188, 4),
                new Note("note", 1320, 4),
                new Note("note", 1056, 4),
                new Note("note", 880, 4),
                new Note("note", 880, 4)
            };

        public static List<Note> marioNotes = new List<Note>
            {
                new Note("note", 1320, 4),
                new Note("note", 990, 2),
                new Note("note", 1056, 2),
                new Note("note", 1188, 2),
                new Note("note", 1320, 2),
                new Note("note", 1188, 2),
                new Note("note", 1056, 2),
                new Note("note", 990, 2),
                new Note("note", 880, 4),
                new Note("note", 880, 2),
                new Note("note", 1056, 2),
                new Note("note", 1320, 4),
                new Note("note", 1188, 2),
                new Note("note", 1056, 2),
                new Note("note", 990, 6),
                new Note("note", 1056, 2),
                new Note("note", 1188, 4),
                new Note("note", 1320, 4),
                new Note("note", 1056, 4),
                new Note("note", 880, 4),
                new Note("note", 880, 4)
            };


    }
}





 
    
