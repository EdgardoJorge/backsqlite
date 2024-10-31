using FibertelApiRest.Models;
using FibertelDomain.Errors;
using FibertelDomain.Store.Models;
using FibertelDomain.Store.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FibertelApiRest.Controllers.Store
{
    [ApiController]
    [Route("/api/store/marca")]
    public class MarcaController : ControllerBase
    {
        public readonly IProductoRepository _producto;
        public readonly ILogger<EnvioController> _logger;

        public MarcaController(
            IProductoRepository producto,
            ILogger<EnvioController> logger
        )
        {
            _producto = producto;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<List<Marca>> Listar()
        {
            try
            {
                List<Marca> marcas = _producto.marca().GetAll();
                marcas = marcas.OrderByDescending(m => m.idMarca).ToList();
                return Ok(marcas);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[MarcaController][Listar]{ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[MarcaController][Listar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("{idMarca}")]
        public ActionResult<Marca> Obtener([FromRoute] int idMarca)
        {
            try
            {
                Marca? marca = _producto.marca().GetById(idMarca);
                if (marca == null)
                {
                    return NotFound();
                }
                return Ok(marca);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[MarcaController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[MarcaController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpPost]
        [Route("")]
        public ActionResult<Marca> Crear([FromBody] MarcaBody body)
        {
            try
            {
                Marca marca = _producto.marca().Create((Marca)body);

                return Ok(marca);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[MarcaController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[MarcaController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpPut]
        [Route("{idMarca}")]
        public ActionResult<CustomResponse> Actualizar([FromRoute] int idMarca,
        [FromBody] MarcaBody body)
        {
            try
            {
                _producto.marca().Update(idMarca, (Marca)body);

                return Ok(new CustomResponse());
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[MarcaController][Actualizar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[MarcaController][Actualizar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }
    }
}
