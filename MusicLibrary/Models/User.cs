using System.Collections.Generic;

namespace MusicLibrary.Models
{
    public class User
    {
        public string Name { get; set; }

        public IEnumerable<Playlist> Playlists { get; set; }
    }
}
