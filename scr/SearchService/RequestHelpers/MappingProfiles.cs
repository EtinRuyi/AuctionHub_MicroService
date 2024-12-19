using AutoMapper;
using SearchService.Models;

namespace SearchService.RequestHelpers;

public class MappingProfiles : Profile
{
    CreateMap<AuctionCreated, Item>();
    CreateMap<AuctionUpdated, Item>();
}
