using System;
using System.Collections.Generic;

namespace SandBox.Models
{
    public partial class Song
    {
        public int SongId { get; set; }
        public int SongAlbumId { get; set; }
        public string? SongTitle { get; set; }
    }
}
