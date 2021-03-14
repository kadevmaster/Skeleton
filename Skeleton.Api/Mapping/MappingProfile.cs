using AutoMapper;
using Skeleton.Api.Resources;
using Skeleton.Core.Models;

namespace Skeleton.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Resource
            CreateMap<Music, MusicResource>().ReverseMap();
            CreateMap<Artist, ArtistResource>().ReverseMap();

            CreateMap<SaveMusicResource, Music>();
            CreateMap<SaveArtistResource, Artist>();
        }
    }
}