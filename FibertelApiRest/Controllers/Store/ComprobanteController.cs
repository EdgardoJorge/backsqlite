using FibertelApiRest.Models;
using FibertelDomain.Errors;
using FibertelDomain.Store.Models;
using FibertelDomain.Store.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FibertelApiRest.Controllers.Store
{
    [ApiController]
    [Route("/api/store/comprobante")]
    public class ComprobanteController : ControllerBase
    {
        public readonly IMovimientosRepository _movimientos;
        public readonly ILogger<ComprobanteController> _logger;

        public ComprobanteController(
            IMovimientosRepository movimientos,
            ILogger<ComprobanteController> logger
        )
        {
            _movimientos = movimientos;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<List<Comprobante>> Listar()
        {
            try
            {
                List<Comprobante> comprobantes = _movimientos.comprobante().GetAll();
                comprobantes = comprobantes.OrderByDescending(c => c.idComprobante).ToList();
                return Ok(comprobantes);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[ComprobanteController][Listar]{ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[ComprobanteController][Listar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("{idComprobante}")]
        public ActionResult<Comprobante> Obtener([FromRoute] int idComprobante)
        {
            try
            {
                Comprobante? comprobante = _movimientos.comprobante().GetById(idComprobante);
                if (comprobante == null)
                {
                    return NotFound();
                }
                return Ok(comprobante);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[ComprobanteController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[ComprobanteController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpPost]
        [Route("")]
        public ActionResult<Comprobante> Crear([FromBody] ComprobanteBody body)
        {
            try
            {
                Comprobante comprobante = _movimientos.comprobante().Create((Comprobante)body);

                return Ok(comprobante);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[ComprobanteController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[ComprobanteController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }
    }
}
