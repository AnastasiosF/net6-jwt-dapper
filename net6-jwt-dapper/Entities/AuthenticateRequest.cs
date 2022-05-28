using System.ComponentModel.DataAnnotations;

namespace net6_jwt_dapper.Entities
{
    public class AuthenticateRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
