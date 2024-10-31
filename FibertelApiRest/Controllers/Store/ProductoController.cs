using FibertelApiRest.Models;
using FibertelDomain.Errors;
using FibertelDomain.Store.Models;
using FibertelDomain.Store.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FibertelApiRest.Controllers.Store
{
    [ApiController]
    [Route("/api/store/producto")]
    public class ProductoController : ControllerBase
    {
        public readonly IProductoRepository _producto;
        public readonly ILogger<ProductoController> _logger;

        public ProductoController(
            IProductoRepository producto,
            ILogger<ProductoController> logger
        )
        {
            _producto = producto;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<List<Producto>> Listar()
        {
            try
            {
                List<Producto> productos = _producto.producto().GetAll();
                productos = productos.OrderByDescending(p => p.idProducto).ToList();
                return Ok(productos);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[ProductoController][Listar]{ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[ProductoController][Listar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("{idProducto}")]
        public ActionResult<Producto> Obtener([FromRoute] int idProducto)
        {
            try
            {
                Producto? producto = _producto.producto().GetById(idProducto);
                if (producto == null)
                {
                    return NotFound();
                }
                return Ok(producto);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[ProductoController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[ProductoController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpPost]
        [Route("")]
        public ActionResult<Producto> Crear([FromBody] ProductoBody body)
        {
            try
            {
                Producto producto = _producto.producto().Create((Producto)body);

                return Ok(producto);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[ProductoController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[ProductoController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpPut]
        [Route("{idProducto}")]
        public ActionResult<CustomResponse> Actualizar([FromRoute] int idProducto,
        [FromBody] ProductoBody body)
        {
            try
            {
                _producto.producto().Update(idProducto, (Producto)body);

                return Ok(new CustomResponse());
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[ProductoController][Actualizar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[ProductoController][Actualizar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("Buscar")]
        public ActionResult<List<Producto>> Buscar([FromQuery] string Nombre)
        {
            try
            {
                List<Producto> productos = _producto.producto().search(Nombre);
                if (productos == null || !productos.Any())
                {
                    return NotFound();
                }
                return Ok(productos);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[ProductoController][Buscar] {ex.Message}\n {ex.StackTrace}");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[ProductoController][Buscar] {ex.Message}\n {ex.StackTrace}");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

    }
}
