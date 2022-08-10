using System;
using System.Collections.Generic;

namespace SandBox.Models
{
    public partial class Album
    {
        public int AlbumId { get; set; }
        public int AlbumArtistId { get; set; }
        public string? AlbumTitle { get; set; }
    }
}
