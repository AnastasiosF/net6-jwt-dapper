using net6_jwt_dapper.Entities;

namespace net6_jwt_dapper.Repositories;

public interface ICompanyRepository
{
    public Task<IEnumerable<Company>> GetCompanies();
}