using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SandBox.Models;

namespace SandboxRazorPages.Pages.Albums
{
    public class IndexModel : PageModel
    {
        private readonly SandBox.Models.MediaContext _context;

        public IndexModel(SandBox.Models.MediaContext context)
        {
            _context = context;
        }

        public IList<Album> Album { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Albums != null)
            {
                Album = await _context.Albums.ToListAsync();
            }
        }
    }
}
