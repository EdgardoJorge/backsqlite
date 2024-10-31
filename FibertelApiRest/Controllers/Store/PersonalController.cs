using FibertelApiRest.Models;
using FibertelDomain.Errors;
using FibertelDomain.Store.Models;
using FibertelDomain.Store.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FibertelApiRest.Controllers.Store
{
    [ApiController]
    [Route("/api/store/personal")]
    public class PersonalController : ControllerBase
    {
        public readonly IMovimientosRepository _movimientos;
        public readonly ILogger<PersonalController> _logger;

        public PersonalController(
            IMovimientosRepository movimientos,
            ILogger<PersonalController> logger
        )
        {
            _movimientos = movimientos;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<List<Personal>> Listar()
        {
            try
            {
                List<Personal> personals = _movimientos.personal().GetAll();
                personals = personals.OrderByDescending(p => p.idPersonal).ToList();
                return Ok(personals);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[PersonalController][Listar]{ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[PersonalController][Listar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("{idPersonal}")]
        public ActionResult<Personal> Obtener([FromRoute] int idPersonal)
        {
            try
            {
                Personal? personal = _movimientos.personal().GetById(idPersonal);
                if (personal == null)
                {
                    return NotFound();
                }
                return Ok(personal);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[PersonalController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[PersonalController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpPost]
        [Route("")]
        public ActionResult<Personal> Crear([FromBody] PersonalBody body)
        {
            try
            {
                Personal personal = _movimientos.personal().Create((Personal)body);

                return Ok(personal);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[PersonalController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[PersonalController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpPut]
        [Route("{idPersonal}")]
        public ActionResult<CustomResponse> Actualizar([FromRoute] int idPersonal,
        [FromBody] PersonalBody body)
        {
            try
            {
                _movimientos.personal().Update(idPersonal, (Personal)body);

                return Ok(new CustomResponse());
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[PersonalController][Actualizar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[PersonalController][Actualizar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }
    }
}
