

namespace FibertelDomain.Auth.Models
{
    public class LoginResponse
    {
        public string token { get; set; }
        public AppAdministrador administrador { get; set; }
    }
}
