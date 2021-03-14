using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Skeleton.Core.Models;
using Skeleton.Core.Repositories;

namespace Skeleton.Data.Repositories
{
    public class MusicRepository: Repository<Music>, IMusicRepository
    {
        public MusicRepository(SkeletonDbContext context) 
            : base(context)
        { }

        public async Task<IEnumerable<Music>> GetAllWithArtistAsync()
        {
            return await SkeletonDbContext.Musics
                .Include(m => m.Artist)
                .ToListAsync();
        }

        public async Task<Music> GetWithArtistByIdAsync(int id)
        {
            return await SkeletonDbContext.Musics
                .Include(m => m.Artist)
                .SingleOrDefaultAsync(m => m.Id == id);;
        }

        public async Task<IEnumerable<Music>> GetAllWithArtistByArtistIdAsync(int artistId)
        {
            return await SkeletonDbContext.Musics
                .Include(m => m.Artist)
                .Where(m => m.ArtistId == artistId)
                .ToListAsync();
        }
        
        private SkeletonDbContext SkeletonDbContext
        {
            get { return Context as SkeletonDbContext; }
        }
    }
}