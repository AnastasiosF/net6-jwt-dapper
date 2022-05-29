using System.Data;
using Microsoft.Data.SqlClient;

namespace net6_jwt_dapper.Context;

/**
 * Here you can create your own "Connection Pooling" if you want.
 * Notice that if you will user Oracle as DB, has default enabled
 * the connection pooling. For other DBs you have to do your own
 * search.
 */
public class DapperContext
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public DapperContext(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("SqlConnection");
    }
    
    
    public IDbConnection CreateConnection()
        => new SqlConnection(_connectionString);
} 
