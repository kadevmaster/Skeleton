using System;
using System.Threading.Tasks;
using Skeleton.Core.Repositories;

namespace Skeleton.Core
{
    public interface IUnitOfWork:IDisposable
    {
         IMusicRepository Musics { get; }
        IArtistRepository Artists { get; }
        Task<int> CommitAsync();
    }
}