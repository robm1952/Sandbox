using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SandBox.Models;

namespace BlazorApp.Pages.Artists
{
    public class IndexModel : PageModel
    {
        private readonly SandBox.Models.MediaContext _context;

        public IndexModel(SandBox.Models.MediaContext context)
        {
            _context = context;
        }

        public IList<Artist> Artist { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Artists != null)
            {
                Artist = await _context.Artists.ToListAsync();
            }
        }
    }
}
