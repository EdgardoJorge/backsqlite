


using FibertelDomain.Auth.Models;
using FibertelDomain.Auth.Repositories;
using FibertelDomain.Auth.Services;

namespace FibertelData.Auth.Repositories
{
    public class AuthenticationRepositoryImpl : IAuthenticationRepository
    {
        private readonly IAuthenticationService _authService;
        public AuthenticationRepositoryImpl(
            IAuthenticationService authService
        )
        {
            _authService = authService;
        }
        public LoginResponse Login(LoginRequest login)
        {
            return _authService.Login( login );
        }
    }
}
