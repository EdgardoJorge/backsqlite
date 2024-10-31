
using FibertelDomain.Auth.Models;


namespace FibertelDomain.Auth.Repositories
{
    public interface IAuthenticationRepository
    {
        public LoginResponse Login(LoginRequest login);
    }
}
