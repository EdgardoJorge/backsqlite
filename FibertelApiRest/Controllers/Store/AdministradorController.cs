using FibertelApiRest.Models;
using FibertelDomain.Auth.Models;
using FibertelDomain.Auth.Repositories;
using FibertelDomain.Auth.Services;
using FibertelDomain.Errors;
using FibertelDomain.Store.Models;
using FibertelDomain.Store.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FibertelApiRest.Controllers.Store
{
    [ApiController]
    [Route("/api/store/administrador")]
    public class AdministradorController : ControllerBase
    {
        public readonly IProductoRepository   _producto;
        public readonly ILogger<AdministradorController> _logger;

        public AdministradorController(
            IProductoRepository producto,
            ILogger<AdministradorController> logger
        )
        {
            _producto = producto;
            _logger = logger;
        }


        [HttpGet]
        [Route("")]
        public ActionResult<List<Administrador>> Listar()
        {
            try
            {
                List<Administrador> administradors = _producto.administrador().GetAll();
                return Ok(administradors);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[AuthController][Listar]{ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[AuthController][Listar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("{idAdministrador}")]
        public ActionResult<Administrador> Obtener([FromRoute] int idAdministrador)
        {
            try
            {
                Administrador? Administrador = _producto.administrador().GetById(idAdministrador);
                if (Administrador == null)
                {
                    return NotFound();
                }
                return Ok(Administrador);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[AuthController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[AuthController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpPost]
        [Route("")]
        public ActionResult<Administrador> Crear([FromBody] AdministradorBody body)
        {
            try
            {
                Administrador Administrador = _producto.administrador().Create((Administrador)body);

                return Ok(Administrador);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[AuthController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[AuthController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpPut]
        [Route("{idAdministrador}")]
        public ActionResult<CustomResponse> Actualizar([FromRoute] int idAdministrador,
        [FromBody] AdministradorBody body)
        {
            try
            {
                _producto.administrador().Update(idAdministrador, (Administrador)body);

                return Ok(new CustomResponse());
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[AuthController][Actualizar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[AuthController][Actualizar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        //[HttpPost("{idAdministrador}/validate-password")]
        //public async Task<IActionResult> ValidatePassword(int idAdministrador, [FromBody] string password)
        //{
        //    var administrador = await _producto.administrador.FindAsync(idAdministrador);
        //    if (administrador == null)
        //    {
        //        return NotFound();
        //    }

        //    // Validar la contraseña utilizando BCrypt.Net
        //    bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, administrador.PasswordHash);

        //    if (isPasswordValid)
        //    {
        //        return Ok(new { message = "Contraseña válida" });
        //    }
        //    else
        //    {
        //        return Unauthorized(new { message = "Contraseña inválida" });
        //    }
        //}

    }
}
