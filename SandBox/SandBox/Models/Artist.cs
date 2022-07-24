using System;
using System.Collections.Generic;
using SandBox.Media;

namespace SandBox.Models
{
    public partial class Artist
    {
        public int ArtistId { get; set; }
        public string ArtistName { get; set; } = null!;
        public string? ArtistNameSort { get; set; }
        public Artist() { }
    }
    
}
