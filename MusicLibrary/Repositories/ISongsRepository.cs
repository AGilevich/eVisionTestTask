using System.Collections.Generic;
using MusicLibrary.Models;

namespace MusicLibrary.Repositories
{
    public interface ISongsRepository
    {
        IEnumerable<Song> GetAllSongs();
    }
}
