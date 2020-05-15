using System.Collections.Generic;
using MusicLibrary.Models;

namespace MusicLibrary.Repositories
{
    public class SongsRepository : ISongsRepository
    {
        private readonly IEnumerable<Song> _songs;

        public SongsRepository(IEnumerable<Song> songs)
        {
            _songs = songs;
        }

        public IEnumerable<Song> GetAllSongs()
        {
            return _songs;
        }
    }
}
