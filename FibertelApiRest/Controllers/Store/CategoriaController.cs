using FibertelApiRest.Models;
using FibertelDomain.Errors;
using FibertelDomain.Store.Models;
using FibertelDomain.Store.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FibertelApiRest.Controllers.Store
{
    [ApiController]
    [Route("/api/store/categoria")]
    public class CategoriaController : ControllerBase
    {
        public readonly IProductoRepository _producto;
        public readonly ILogger<CategoriaController> _logger;

        public CategoriaController(
            IProductoRepository producto,
            ILogger<CategoriaController> logger
        )
        {
            _producto = producto;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<List<Categoria>> Listar()
        {
            try
            {
                List<Categoria> categorias = _producto.categoria().GetAll();
                categorias = categorias.OrderByDescending(c => c.idCategoria).ToList();
                return Ok(categorias);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[CategoriaController][Listar]{ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[CategoriaController][Listar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("{idCategoria}")]
        public ActionResult<Categoria> Obtener([FromRoute] int idCategoria)
        {
            try
            {
                Categoria? categoria = _producto.categoria().GetById(idCategoria);
                if (categoria == null)
                {
                    return NotFound();
                }
                return Ok(categoria);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[CategoriaController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[CategoriaController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpPost]
        [Route("")]
        public ActionResult<Categoria> Crear([FromBody] CategoriaBody body)
        {
            try
            {
                Categoria categoria = _producto.categoria().Create((Categoria)body);

                return Ok(categoria);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[CategoriaController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[CategoriaController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpPut]
        [Route("{idCategoria}")]
        public ActionResult<CustomResponse> Actualizar([FromRoute] int idCategoria,
        [FromBody] CategoriaBody body)
        {
            try
            {
                _producto.categoria().Update(idCategoria, (Categoria)body);

                return Ok(new CustomResponse());
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[CategoriaController][Actualizar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[CategoriaController][Actualizar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }
    }
}
