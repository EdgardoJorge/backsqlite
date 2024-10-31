using FibertelApiRest.Models;
using FibertelDomain.Errors;
using FibertelDomain.Store.Models;
using FibertelDomain.Store.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FibertelApiRest.Controllers.Store
{
    [ApiController]
    [Route("/api/store/detallePedido")]
    public class DetallePedidoController : ControllerBase
    {
        public readonly IMovimientosRepository _movimientos;
        public readonly ILogger<DetallePedidoController> _logger;

        public DetallePedidoController(
            IMovimientosRepository movimientos,
            ILogger<DetallePedidoController> logger
        )
        {
            _movimientos = movimientos;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<List<DetallePedido>> Listar()
        {
            try
            {
                List<DetallePedido> detallePedidos = _movimientos.detallePedido().GetAll();
                return Ok(detallePedidos);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[DetallePedidoController][Listar]{ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[DetallePedidoController][Listar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("{idDetallePedido}")]
        public ActionResult<DetallePedido> Obtener([FromRoute] int idDetallePedido)
        {
            try
            {
                DetallePedido? detallePedido = _movimientos.detallePedido().GetById(idDetallePedido);
                if (detallePedido == null)
                {
                    return NotFound();
                }
                return Ok(detallePedido);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[DetallePedidoController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[DetallePedidoController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpPost]
        [Route("")]
        public ActionResult<DetallePedido> Crear([FromBody] DetallePedidoBody body)
        {
            try
            {
                DetallePedido detallePedido = _movimientos.detallePedido().Create((DetallePedido)body);

                return Ok(detallePedido);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[DetallePedidoController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[DetallePedidoController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet("detallePedidos/{idPedido}")]
        public async Task<IActionResult> GetDetallesPorPedido(int idPedido)
        {
            try
            {
                Pedido? pedido = _movimientos.pedido().GetById(idPedido);
                if (pedido == null)
                {
                    return NotFound();
                }

                List<DetallePedido> detalles = _movimientos.detallePedido().GetByPedidoId(idPedido);

                return Ok(detalles);
            }
            catch (Exception ex)
            {
                _logger.LogError($"[DetallePedidoController][GetDetallesPorPedido] {ex.Message}\n {ex.StackTrace}");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }
    }
}
