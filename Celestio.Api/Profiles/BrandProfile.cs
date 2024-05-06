using System.Runtime.CompilerServices;
using AutoMapper;
using Celestio.Api.Data.Entities;
using Celestio.Core.Models.Brand;

namespace Celestio.Api.Profiles;

public class BrandProfile : Profile
{
    public BrandProfile()
    {
        CreateMap<Brand, BrandDto>();
        
        CreateMap<Brand, BrandMiniDto>();
    }
}