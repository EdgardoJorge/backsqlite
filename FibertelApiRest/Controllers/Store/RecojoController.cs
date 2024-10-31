using FibertelApiRest.Models;
using FibertelDomain.Errors;
using FibertelDomain.Store.Models;
using FibertelDomain.Store.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FibertelApiRest.Controllers.Store
{
    [ApiController]
    [Route("/api/store/recojo")]
    public class RecojoController : ControllerBase
    {
        public readonly IMovimientosRepository _movimientos;
        public readonly ILogger<RecojoController> _logger;

        public RecojoController(
            IMovimientosRepository movimientos,
            ILogger<RecojoController> logger
        )
        {
            _movimientos = movimientos;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<List<Recojo>> Listar()
        {
            try
            {
                List<Recojo> recojos = _movimientos.recojo().GetAll();
                recojos = recojos.OrderByDescending(r => r.idRecojo).ToList();
                return Ok(recojos);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[RecojoController][Listar]{ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[RecojoController][Listar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("{idRecojo}")]
        public ActionResult<Recojo> Obtener([FromRoute] int idRecojo)
        {
            try
            {
                Recojo? recojo = _movimientos.recojo().GetById(idRecojo);
                if (recojo == null)
                {
                    return NotFound();
                }
                return Ok(recojo);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[RecojoController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[RecojoController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpPost]
        [Route("")]
        public ActionResult<Recojo> Crear([FromBody] RecojoBody body)
        {
            try
            {
                Recojo recojo = _movimientos.recojo().Create((Recojo)body);

                return Ok(recojo);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[RecojoController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[RecojoController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpPut]
        [Route("{idRecojo}")]
        public ActionResult<CustomResponse> Actualizar([FromRoute] int idRecojo,
        [FromBody] RecojoBody body)
        {
            try
            {
                _movimientos.recojo().Update(idRecojo, (Recojo)body);

                return Ok(new CustomResponse());
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[RecojoController][Actualizar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[RecojoController][Actualizar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }
    }
}
