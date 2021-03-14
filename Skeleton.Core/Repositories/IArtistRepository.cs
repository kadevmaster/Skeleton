using System.Collections.Generic;
using System.Threading.Tasks;
using Skeleton.Core.Models;

namespace Skeleton.Core.Repositories
{
    public interface IArtistRepository: IRepository<Artist>
    {
         Task<IEnumerable<Artist>> GetAllWithMusicsAsync();
        Task<Artist> GetWithMusicsByIdAsync(int id);
    }
}