using System.Collections.Generic;
using System.Threading.Tasks;
using Skeleton.Core.Models;

namespace Skeleton.Core.Services
{
    public interface IMusicService
    {
         Task<IEnumerable<Music>> GetAllWithArtist();
        Task<Music> GetMusicById(int id);
        Task<IEnumerable<Music>> GetMusicsByArtistId(int artistId);
        Task<Music> CreateMusic(Music newMusic);
        Task UpdateMusic(Music musicToBeUpdated, Music music);
        Task DeleteMusic(Music music);
    }
}