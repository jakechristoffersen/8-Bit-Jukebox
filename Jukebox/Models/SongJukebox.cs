using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Jukebox.Models
{
    public class SongJukebox
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public bool Playing { get; private set; }
        public bool InSection { get; private set; }
        public List<Song> Songs = new List<Song>();

        public Menu MainMenu { get; set; }
        public Menu SongMenu { get; set; }



        public SongJukebox(string name, string location)
        {
            Name = name;
            Location = location;
            Playing = true;
            InSection = false;
            MainMenu = BuildMainMenu();

        }

        Menu BuildMainMenu()
        {
            Console.WriteLine("Finns Jukebox");
            return new Menu(
                "Main Menu",
            new List<MenuOption>
                {
                    
                    new MenuOption(SongSelection, "Power on the JukeBox"),
                    new MenuOption(LeaveJukebox, "Walk Away from the Jukebox"),
                    
                });
            
        }

        public void Setup()
        {
            BuildSongMenu();
        }

        void BuildSongMenu()
        {
            
            SongMenu = new Menu(

                "Song Menu",
                new List<MenuOption>
                {
                    new MenuOption(PrintSongs, "View All Songs"),
                    new MenuOption(AddSong, "Add Song"),
                    new MenuOption(LeaveSection, "leave the Section")

                });
        }

        public void MainMenuSelection()
        {
            Action action = MainMenu.SelectOption();
            if (action != null)
            {
                action.Invoke();
            }
        }

        private void SongSelection()
        {
            Console.Clear();
            InSection = true;
            while (InSection)
             
            {
                Action action = SongMenu.SelectOption();
                
                if (action != null )
                {
                    action.Invoke();
                }
                
            }
        }

        private void LeaveJukebox()
        {
            Console.WriteLine("Thanks for playing");
            Playing = false;
        }

        private void LeaveSection()
        {
            Console.WriteLine("You've left the Section!");
            InSection = false;
        }

        private void PrintSongs()
        {
            Console.Clear();
            int count = 1;
            foreach (Song song in Songs)
            {
                Console.WriteLine($"{count++} {song.Artist} - {song.Title}");
            }
            string input = Console.ReadLine();
            int index = -1;
            bool valid = Int32.TryParse(input, out index);
            if(!valid || index <= 0 || index > Songs.Count)
            {
                 Console.WriteLine("Please make a valid selection.");
                return;
               
            }

            Songs[index - 1].Play();
        }

        private void AddSong()
        {
            foreach (Song song in Songs)
            {

                Console.WriteLine($"{song.Artist} - {song.Title}");
            }




        }

        internal void AddItem(Song song)
        {
            Songs.Add(song);

        }

        

    }
}
