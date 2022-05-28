using net6_jwt_dapper.Entities;
using net6_jwt_dapper.Repositories;

namespace net6_jwt_dapper.Services;

public class CompanyService: ICompanyService
{
    private readonly ICompanyRepository companyRepository;

    public CompanyService(ICompanyRepository companyRepository)
    {
        this.companyRepository = companyRepository;
    }

    public Task<IEnumerable<Company>> GetCompanies()
    {
        return companyRepository.GetCompanies();
        //throw new Exception("Easd");
    }
}