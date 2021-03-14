using System.Threading.Tasks;
using Skeleton.Core;
using Skeleton.Core.Repositories;
using Skeleton.Data.Repositories;

namespace Skeleton.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SkeletonDbContext _context;
        private MusicRepository _musicRepository;
        private ArtistRepository _artistRepository;

        public UnitOfWork(SkeletonDbContext context)
        {
            this._context = context;
        }

        public IMusicRepository Musics => _musicRepository = _musicRepository ?? new MusicRepository(_context);

        public IArtistRepository Artists => _artistRepository = _artistRepository ?? new ArtistRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}