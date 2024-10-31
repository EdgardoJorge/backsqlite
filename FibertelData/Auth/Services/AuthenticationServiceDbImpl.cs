
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

using FibertelData.Sources.BaseDeDatos;
using FibertelDomain.Auth.Models;
using FibertelDomain.Auth.Services;
using FibertelDomain.Errors;
using FibertelDomain.Store.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;



namespace FibertelData.Auth.Services
{
    public class AuthenticationServiceDbImpl : IAuthenticationService
    {
        private readonly FibertelDbContext _db;

        public AuthenticationServiceDbImpl(FibertelDbContext db)
        {
            _db = db;
        }
        public LoginResponse Login(LoginRequest login)
        {
            var administrador = _db.administradors.Where(
                (a) => a.email == login.email && a.password == login.password && a.estado
            ).FirstOrDefault();

            if (administrador == null)
            {
                throw new MessageExeption("Credenciales incorrectas.");
            }

            var appAdministrador = new AppAdministrador
            {
                idAdministrador = administrador.idAdministrador,
                nombres = administrador.nombres,
                telefonoMovil = administrador.telefonoMovil,
                estado = administrador.estado,
                email = administrador.email
            };

            return new LoginResponse
            {
                token = GetJWT(appAdministrador),
                administrador = appAdministrador,

            };
        }

        private string GetJWT(AppAdministrador administrador)
        {
            ClaimsIdentity claims = GenerateClaims(administrador);

            int expireInMinuts = 30;
            DateTime expire = DateTime.UtcNow.AddMinutes(expireInMinuts);
            string LLAVE = "saflkcbnxz,w342349324#$#$sdfsafdashw4h3kln34,234$%#$%$#%$#%$#fdsfsdfdsfdsfdsfdsfdsfdsfdsfdsfdsf";

            return GenerateToken(claims, expire, LLAVE);
        }

        private ClaimsIdentity GenerateClaims(AppAdministrador administrador)
        {
            ClaimsIdentity claimsIdentity = new ClaimsIdentity();

            claimsIdentity.AddClaim(
                new Claim(ClaimTypes.NameIdentifier, administrador.idAdministrador.ToString())
                );
            claimsIdentity.AddClaim(
                new Claim(ClaimTypes.Email, administrador.email)

                );
            claimsIdentity.AddClaim(
               new Claim(ClaimTypes.Name, administrador.nombres)

               );

            return claimsIdentity;
        }

        private string GenerateToken(ClaimsIdentity claimsIdentity, DateTime expires, string secret)
        {
            var key = Encoding.ASCII.GetBytes(secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claimsIdentity,
                Expires = expires,

                SigningCredentials = new SigningCredentials
                (
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature
                )
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var createdToken = tokenHandler.CreateToken(tokenDescriptor);
            string token = tokenHandler.WriteToken(createdToken);
            return token;
        }
    }
}