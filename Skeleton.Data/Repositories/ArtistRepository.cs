using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Skeleton.Core.Models;
using Skeleton.Core.Repositories;

namespace Skeleton.Data.Repositories
{
    public class ArtistRepository: Repository<Artist>, IArtistRepository
    {
        public ArtistRepository(SkeletonDbContext context) 
            : base(context)
        { }
        
        public async Task<IEnumerable<Artist>> GetAllWithMusicsAsync()
        {
            return await SkeletonDbContext.Artists
                .Include(a => a.Musics)
                .ToListAsync();
        }

        public Task<Artist> GetWithMusicsByIdAsync(int id)
        {
            return SkeletonDbContext.Artists
                .Include(a => a.Musics)
                .SingleOrDefaultAsync(a => a.Id == id);
        }

        private SkeletonDbContext SkeletonDbContext
        {
            get { return Context as SkeletonDbContext; }
        }
    }
}