using FibertelDomain.Auth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelDomain.Auth.Services
{
    public interface IAuthenticationService
    {
        public LoginResponse Login(LoginRequest login);
    }
}
