using System.Collections.Generic;
using MusicLibrary.Models;

namespace MusicLibrary.Services
{
    public interface ISearchService
    {
        ICollection<Song> SearchSongs(string query); 
    }
}
