using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlaylist
{
    class Program
    {
        private static List<MusicPlaylist> MusicPlaylistList = new List<MusicPlaylist>();
     
        static void Main(string[] args)
        {
            var line = reader.ReadLine();
            var values = line.Split(',');

            $"Row {lineNumber} contains {values.Length} values. It should contain {NumItemsInRow}."

            var popSongsByYearDescending = from song in songs where song.Genre == "Pop" orderby song.Year descending select song;

            foreach (var song in songs)
            {
                // do something with the song
            }

            foreach (Song song in popSongsByYearDescending)
            {
                report += song + "\n";
            }


        }
    }
}
