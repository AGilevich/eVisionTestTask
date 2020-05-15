using System.Collections.Generic;

namespace MusicLibrary.Models
{
    public class Playlist
    {
        public string Name { get; set; }

        public IEnumerable<Song> Song { get; set; }
    }
}
