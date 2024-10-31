using FibertelApiRest.Models;
using FibertelDomain.Errors;
using FibertelDomain.Store.Models;
using FibertelDomain.Store.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FibertelApiRest.Controllers.Store
{
    [ApiController]
    [Route("/api/store/envio")]
    public class EnvioController : ControllerBase
    {
        public readonly IMovimientosRepository _movimientos;
        public readonly ILogger<EnvioController> _logger;

        public EnvioController(
            IMovimientosRepository movimientos,
            ILogger<EnvioController> logger
        )
        {
            _movimientos = movimientos;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<List<Envio>> Listar()
        {
            try
            {
                List<Envio> envios = _movimientos.envio().GetAll();
                envios = envios.OrderByDescending(e => e.idEnvio).ToList();
                return Ok(envios);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[EnvioController][Listar]{ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[EnvioController][Listar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("{idEnvio}")]
        public ActionResult<Envio> Obtener([FromRoute] int idEnvio)
        {
            try
            {
                Envio? envio = _movimientos.envio().GetById(idEnvio);
                if (envio == null)
                {
                    return NotFound();
                }
                return Ok(envio);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[EnvioController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[EnvioController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpPost]
        [Route("")]
        public ActionResult<Envio> Crear([FromBody] EnvioBody body)
        {
            try
            {
                Envio envio = _movimientos.envio().Create((Envio)body);

                return Ok(envio);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[EnvioController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[EnvioController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpPut]
        [Route("{idEnvio}")]
        public ActionResult<CustomResponse> Actualizar([FromRoute] int idEnvio,
        [FromBody] EnvioBody body)
        {
            try
            {
                _movimientos.envio().Update(idEnvio, (Envio)body);

                return Ok(new CustomResponse());
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[EnvioController][Actualizar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[EnvioController][Actualizar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }
    }
}
