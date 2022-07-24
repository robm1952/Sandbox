using SandBox.Models;

namespace SandBox.Media
{
    internal class MediasRepository
    {
        private MediaContext context;
           
        public MediasRepository() { context = new MediaContext(); }

        public IEnumerable<Artist> GetAllArtists() {
            return context.Artists.ToList();
        }

        public Artist GetArtist(int id)
        {
            return context.Artists.Where(x => x.ArtistId == id).FirstOrDefault();
        }

        public IEnumerable<Album> GetAllAlbums()
        {
            return context.Albums.ToList();
        }

        public IEnumerable<Song> GetAllSongs()
        {
            return context.Songs.ToList();
        }

        public IEnumerable<Album> GetArtistsAlbums(int ArtistId) {
            return context.Albums.Where(x => x.AlbumArtistId == ArtistId).ToList();
        }

        public IEnumerable<Song> GetAlbumSongs(int AlbumId) {
            return context.Songs.Where(x => x.SongAlbumId == AlbumId).ToList();
        }
    }
}
