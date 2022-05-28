using Dapper;
using net6_jwt_dapper.Context;
using net6_jwt_dapper.Entities;

namespace net6_jwt_dapper.Repositories;

public class CompanyRepository: ICompanyRepository
{
    private readonly DapperContext _dapperContext;

    public CompanyRepository(DapperContext dapperContext)
    {
        _dapperContext = dapperContext;
    }

    public async Task<IEnumerable<Company>> GetCompanies()
    {
        var query = "SELECT * FROM Companies";

        using var connection = _dapperContext.CreateConnection();
        var companies = await connection.QueryAsync<Company>(query);
        return companies.ToList();
    }
}