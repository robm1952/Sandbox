using SandBox.Models;
using SandBox.Managers;

ArtistsManager am = new ArtistsManager();
int theNumbr = 0;
Random random = new Random();
theNumbr = random.Next(1, am.GetAllArtists().ToList().Count);
Artist art2 = am.GetArtist(theNumbr);
Console.WriteLine($"{art2.ArtistName}");
foreach (Album album in am.GetArtistsAlbums(theNumbr).ToList()) {
    Console.WriteLine("\t" + album.AlbumTitle);
    foreach (Song song in am.GetAlbumSongs(album.AlbumId)) {
        Console.WriteLine("\t\t" + song.SongTitle);
    }
}
Console.ReadKey();
