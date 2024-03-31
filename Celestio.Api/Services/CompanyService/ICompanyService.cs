using Celestio.Core.Models.Company;

namespace Celestio.Api.Services.CompanyService;

public interface ICompanyService
{
    Task<CompanyDto?> GetCompanyProfileById(int companyId);
}