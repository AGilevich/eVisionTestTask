using System.Collections;
using System.Collections.Generic;

namespace MusicLibrary.Models
{
    public class Artist
    {
        public string Name { get; set; }

        public IEnumerable<Album> Albums { get; set; }
    }
}
