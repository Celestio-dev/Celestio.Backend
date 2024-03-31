using System.Runtime.CompilerServices;
using AutoMapper;
using Celestio.Api.Data.Entities;
using Celestio.Core.Models.Company;

namespace Celestio.Api.Profiles;

public class CompanyProfile : Profile
{
    public CompanyProfile()
    {
        CreateMap<Company, CompanyDto>();
        CreateMap<CompanyDto, Company>();
    }
}