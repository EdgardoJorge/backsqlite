

using FibertelApiRest.Models;
using FibertelDomain.Auth.Models;
using FibertelDomain.Auth.Repositories;
using FibertelDomain.Errors;
using FibertelDomain.Store.Models;
using Microsoft.AspNetCore.Mvc;

namespace FibertelApiRest.Controllers.Auth
{
    [ApiController]
    [Route("/api/auth/")]
    public class AuthenticacionController : ControllerBase
    {
        public readonly ILogger _logger;
        private readonly IAuthenticationRepository _auth;
        public AuthenticacionController(
            ILogger<AuthenticacionController> logger,
            IAuthenticationRepository auth
        )
        {
            _auth = auth;
            _logger = logger;
        } 

        [HttpPost]
        [Route("login")]
        public ActionResult<LoginResponse> Login ([FromBody]LoginRequest body)
        {
            try
            {
                return Ok(_auth.Login(body));
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[AuthenticacionController][Listar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[AuthenticacionController][Listar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }
    }
}
