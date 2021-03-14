using Microsoft.EntityFrameworkCore;
using Skeleton.Core.Models;
using Skeleton.Data.Configurations;

namespace Skeleton.Data
{
    public class SkeletonDbContext : DbContext
    {
        public DbSet<Music> Musics { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public SkeletonDbContext(DbContextOptions<SkeletonDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new MusicConfiguration());

            builder
                .ApplyConfiguration(new ArtistConfiguration());
        }
    }
}