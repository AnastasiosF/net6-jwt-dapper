using net6_jwt_dapper.Entities;

namespace net6_jwt_dapper.Services;

public interface ICompanyService
{
    public Task<IEnumerable<Company>> GetCompanies();
}