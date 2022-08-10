using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SandBox.Models;
using SandBox.Managers;


namespace SandboxRazorPages.Pages.Artists
{
    public class IndexModel : PageModel
    {
        private readonly SandBox.Models.MediaContext _context;

        public IndexModel(MediaContext context)
        {
            _context = context;
        }
        public IList<Artist> Artist { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Artists != null)
            {
                Artist = await _context.Artists.ToListAsync();
            }
        }
        #region old_OnGet()
        //public void OnGet()
        //{
        //    ArtistsManager am = new ArtistsManager();
        //    var jelly = am.GetArtistsAlbums(1);
        //    MediaContext mc = new MediaContext();
        //    List<Artist> artists = mc.Artists.ToList();
        //}
        #endregion
    }
}
