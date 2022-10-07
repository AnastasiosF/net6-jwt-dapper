using net6_jwt_dapper.Entities;

namespace net6_jwt_dapper.Services
{
    public interface IUserService
    {
        AuthenticateResponse? Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();
        User GetById(int id);

    }
}
