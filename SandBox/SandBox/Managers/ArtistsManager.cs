using SandBox.Models;
using SandBox.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox.Managers
{
    internal class ArtistsManager
    {
        private MediasRepository _ArtistMediasRepository;
        
        public ArtistsManager() { 
            _ArtistMediasRepository = new MediasRepository();
        }
        
        public IEnumerable<Artist> GetAllArtists() {
            return _ArtistMediasRepository.GetAllArtists();
        }
        public Artist GetArtist(int id) { 
            return _ArtistMediasRepository.GetArtist(id);
        }

        public IEnumerable<Album> GetArtistsAlbums(int id) { 
            return _ArtistMediasRepository.GetArtistsAlbums(id).ToList();
        }

        internal IEnumerable<Song> GetAlbumSongs(int albumId)
        {
            return _ArtistMediasRepository.GetAlbumSongs(albumId).ToList();
        }
    }
}
