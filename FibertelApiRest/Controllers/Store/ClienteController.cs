using FibertelApiRest.Models;
using FibertelDomain.Errors;
using FibertelDomain.Store.Models;
using FibertelDomain.Store.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FibertelApiRest.Controllers.Store
{
    [ApiController]
    [Route("/api/store/cliente")]
    public class ClienteController : ControllerBase
    {
        public readonly IMovimientosRepository _movimientos;
        public readonly ILogger<ClienteController> _logger;

        public ClienteController(
            IMovimientosRepository movimientos,
            ILogger<ClienteController> logger
        )
        {
            _movimientos = movimientos;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<List<Cliente>> Listar()
        {
            try
            {
                List<Cliente> clientes = _movimientos.cliente().GetAll();
                return Ok(clientes);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[ClienteController][Listar]{ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[ClienteController][Listar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("{idCliente}")]
        public ActionResult<Cliente> Obtener([FromRoute] int idCliente)
        {
            try
            {
                Cliente? cliente = _movimientos.cliente().GetById(idCliente);
                if (cliente == null)
                {
                    return NotFound();
                }
                return Ok(cliente);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[ClienteController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[ClienteController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpPost]
        [Route("")]
        public ActionResult<Cliente> Crear([FromBody] ClienteBody body)
        {
            try
            {
                Cliente cliente = _movimientos.cliente().Create((Cliente)body);

                return Ok(cliente);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[ClienteController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[ClienteController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }
    }
}
