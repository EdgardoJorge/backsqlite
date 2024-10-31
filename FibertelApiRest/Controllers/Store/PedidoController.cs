using FibertelApiRest.Models;
using FibertelDomain.Errors;
using FibertelDomain.Store.Models;
using FibertelDomain.Store.Repositories;
using FibertelDomain.Store.Services;
using Microsoft.AspNetCore.Mvc;

namespace FibertelApiRest.Controllers.Store
{
    [ApiController]
    [Route("/api/store/pedido")]
    public class PedidoController : ControllerBase
    {
        public readonly IMovimientosRepository _movimientos;
        public readonly ILogger<PedidoController> _logger;

        public PedidoController(
            IMovimientosRepository movimientos,
            ILogger<PedidoController> logger
        )
        {
            _movimientos = movimientos;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<List<Pedido>> Listar()
        {
            try
            {
                List<Pedido> pedidos = _movimientos.pedido().GetAll();
                pedidos = pedidos.OrderByDescending(p => p.idPedido).ToList();
                return Ok(pedidos);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[PedidoController][Listar]{ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[PedidoController][Listar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("{idPedido}")]
        public ActionResult<Pedido> Obtener([FromRoute] int idPedido)
        {
            try
            {
                Pedido? pedido = _movimientos.pedido().GetById(idPedido);
                if (pedido == null)
                {
                    return NotFound();
                }
                return Ok(pedido);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[PedidoController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[PedidoController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpPost]
        [Route("")]
        public ActionResult<Pedido> Crear([FromBody] PedidoBody body)
        {
            try
            {
                Pedido pedido = _movimientos.pedido().Create((Pedido)body);

                return Ok(pedido);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[PedidoController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[PedidoController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpPut]
        [Route("{idPedido}")]
        public ActionResult<CustomResponse> Actualizar([FromRoute] int idPedido,
        [FromBody] PedidoBody body)
        {
            try
            {
                _movimientos.pedido().Update(idPedido, (Pedido)body);

                return Ok(new CustomResponse());
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[PedidoController][Actualizar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[PedidoController][Actualizar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("pedidoPorIdEnvio/{idEnvio}")]
        public async Task<IActionResult> GetPedidoByIdEnvio(int idEnvio)
        {
            try
            {
                Pedido pedido = _movimientos.pedido().GetPedidoByIdEnvio(idEnvio);
                return Ok(pedido);
            }
            catch (Exception ex)
            {
                _logger.LogError($"[PedidoController][GetPedidoByIdEnvio] {ex.Message}\n {ex.StackTrace}");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("pedidoPorIdRecojo/{idRecojo}")]
        public async Task<IActionResult> GetPedidoByIdRecojo(int idRecojo)
        {
            try
            {
                Pedido pedido = _movimientos.pedido().GetPedidoByIdRecojo(idRecojo);
                return Ok(pedido);
            }
            catch (Exception ex)
            {
                _logger.LogError($"[PedidoController][GetPedidoByIdEnvio] {ex.Message}\n {ex.StackTrace}");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("pedidosPendientes")]
        public ActionResult<List<Pedido>> GetPedidosPendientes()
        {
            try
            {
                List<Pedido> pedidos = _movimientos.pedido().GetPedidosPendientes();
                return Ok(pedidos);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[PedidoController][Listar]{ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[PedidoController][Listar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("pedidosEntregados")]
        public ActionResult<List<Pedido>> GetPedidosEntregados()
        {
            try
            {
                List<Pedido> pedidos = _movimientos.pedido().GetPedidosEntregados();
                return Ok(pedidos);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[PedidoController][Listar]{ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[PedidoController][Listar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("pedidosEnviados")]
        public ActionResult<List<Pedido>> GetPedidosEnviados()
        {
            try
            {
                List<Pedido> pedidos = _movimientos.pedido().GetPedidosEnviados();
                return Ok(pedidos);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[PedidoController][Listar]{ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[PedidoController][Listar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("pedidosCancelados")]
        public ActionResult<List<Pedido>> GetPedidosCancelados()
        {
            try
            {
                List<Pedido> pedidos = _movimientos.pedido().GetPedidosCancelados();
                return Ok(pedidos);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[PedidoController][Listar]{ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[PedidoController][Listar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("totalPedidos")]
        public ActionResult GetTotalPedidos()
        {
            try
            {
                var totalPedidos = _movimientos.pedido().GetTotalPedidos();
                return Ok(new { total = totalPedidos });
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[PedidoController][GetTotalPedidos]{ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[PedidoController][GetTotalPedidos] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("sumaTotal")]
        public ActionResult GetSumaTotalPedidos()
        {
            try
            {
                var totalPedidos = _movimientos.pedido().GetSumaTotalPedidos();
                return Ok(new { total = totalPedidos });
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[PedidoController][GetTotalPedidos]{ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[PedidoController][GetTotalPedidos] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }


        [HttpGet]
        [Route("pedidosBuscar")]
        public ActionResult<List<Pedido>> GetPedidosByFilters([FromQuery] int? idPedido, [FromQuery] string numeroDocumento)
        {
            try
            {
                var pedidos = _movimientos.pedido().GetPedidosByFilters(idPedido, numeroDocumento);

                if (pedidos == null || !pedidos.Any())
                {
                    return NotFound();
                }

                return Ok(pedidos);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones similar al código original
                _logger.LogError(
                    $"[PedidoController][GetPedidosByFilters] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

    }
}