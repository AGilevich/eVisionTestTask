using System;
using System.Collections.Generic;
using System.Linq;
using MusicLibrary.Models;
using MusicLibrary.Repositories;

namespace MusicLibrary.Services
{
    public class SearchService : ISearchService
    {
        private readonly ISongsRepository _songsRepository;

        public SearchService(ISongsRepository songsRepository)
        {
            _songsRepository = songsRepository;
        }

        public ICollection<Song> SearchSongs(string query)
        {
            IEnumerable<Song> songs = _songsRepository.GetAllSongs();
            return songs
                .Where(s => s.Title.IndexOf(query, StringComparison.OrdinalIgnoreCase) != -1
                    || s.Genre.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) != -1
                    || s.Artist.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) != -1)
                .ToList();
        }
    }
}
