using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SandBox.Models
{
    public partial class MediaContext : DbContext
    {
        public MediaContext()
        {
           
        }

        public MediaContext(DbContextOptions<MediaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Album> Albums { get; set; } = null!;
        public virtual DbSet<Artist> Artists { get; set; } = null!;
        public virtual DbSet<Song> Songs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile(@"appsettings.json").Build();
            var ret = ConfigurationExtensions.GetRequiredSection(configuration, "ConnectionStrings:DefaultConnection");
                
            if (!optionsBuilder.IsConfigured)
            {
                
                optionsBuilder.UseSqlServer(ret.Value); /*GetConnectionString("DefaultConnection")*/
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>(entity =>
            {
                entity.Property(e => e.AlbumId).HasColumnName("albumId");

                entity.Property(e => e.AlbumArtistId).HasColumnName("albumArtistId");

                entity.Property(e => e.AlbumTitle)
                    .HasMaxLength(250)
                    .HasColumnName("albumTitle");
            });

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.Property(e => e.ArtistId).HasColumnName("artistId");

                entity.Property(e => e.ArtistName)
                    .HasMaxLength(250)
                    .HasColumnName("artistName");

                entity.Property(e => e.ArtistNameSort)
                    .HasMaxLength(250)
                    .HasColumnName("artistName_Sort");
            });

            modelBuilder.Entity<Song>(entity =>
            {
                entity.Property(e => e.SongId).HasColumnName("songId");

                entity.Property(e => e.SongAlbumId).HasColumnName("songAlbumId");

                entity.Property(e => e.SongTitle)
                    .HasMaxLength(250)
                    .HasColumnName("songTitle");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
