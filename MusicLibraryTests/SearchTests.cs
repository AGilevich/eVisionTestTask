using System.Collections.Generic;
using FluentAssertions;
using MusicLibrary.Models;
using MusicLibrary.Repositories;
using MusicLibrary.Services;
using NUnit.Framework;

namespace MusicLibraryTests
{
    public class SearchTests
    {
        private SearchService _searchService;

        private static readonly List<Song> Songs = new List<Song>
        {
            new Song { Title = "We Wish You Merry Christmas", Genre = new Genre { Name = "Pop" }, Artist = new Artist { Name = "ABBA" } },
            new Song { Title = "We Will Rock You", Genre = new Genre { Name = "Rock" }, Artist = new Artist { Name = "Queen" } },
            new Song { Title = "The Real Slim Shady", Genre = new Genre { Name = "Hip-Hop" }, Artist = new Artist { Name = "Eminem" } }
        };

        [SetUp]
        public void Setup()
        {

            ISongsRepository songsRepository = new SongsRepository(Songs);
            _searchService = new SearchService(songsRepository);
        }

        [Test]
        public void ShouldSearchSongsByName()
        {
            // Act
            ICollection<Song> searchResult = _searchService.SearchSongs("We");

            // Assert
            searchResult.Should().NotBeNull();
            searchResult.Should().HaveCount(2);
            searchResult.Should().Equal(Songs[0], Songs[1]);
        }
    }
}