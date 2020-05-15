using System.Collections.Generic;

namespace MusicLibrary.Models
{
    public class Album
    {
        public string Name { get; set; }

        public IEnumerable<Song> Songs { get; set; }
    }
}
