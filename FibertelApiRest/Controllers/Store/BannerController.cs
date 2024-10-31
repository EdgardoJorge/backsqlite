
using FibertelApiRest.Models;
using FibertelDomain.Errors;
using FibertelDomain.Store.Models;
using FibertelDomain.Store.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FibertelApiRest.Controllers.Store
{
    [ApiController]
    [Route("/api/store/banner")]
    public class BannerController : ControllerBase
    {
        public readonly IProductoRepository _producto;
        public readonly ILogger _logger;

        public BannerController(
            IProductoRepository producto,
            ILogger<BannerController> logger
        )
        {
            _producto = producto;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<List<Banner>> Listar()
        {
            try
            {
                List<Banner> banners = _producto.banner().GetAll();
                banners = banners.OrderByDescending(b => b.idBanner).ToList();
                return Ok(banners);
            }
            catch (MessageExeption ex) {
                _logger.LogError(
                    $"[BannerController][Listar]{ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[BannerController][Listar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpGet]
        [Route("{idBanner}")]
        public ActionResult<Banner> Obtener([FromRoute] int idBanner)
        {
            try
            {
                Banner? banner = _producto.banner().GetById(idBanner);
                if (banner == null)
                {
                    return NotFound();
                }
                return Ok(banner);
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
        public ActionResult<Banner> Crear([FromBody] BannerBody body)
        {
            try
            {
                Banner banner = _producto.banner().Create((Banner)body);

                return Ok(banner);
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[BannerController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[BannerController][Crear] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpPut]
        [Route("{idBanner}")]
        public ActionResult<CustomResponse> Actualizar([FromRoute] int idBanner,
        [FromBody] BannerBody body)
        {
            try
            {
                _producto.banner().Update(idBanner, (Banner)body);

                return Ok(new CustomResponse());
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[BannerController][Actualizar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[BannerController][Actualizar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }

        [HttpDelete]
        [Route("{idBanner}")]
        public ActionResult<CustomResponse> Eliminar([FromRoute] int idBanner)
        {
            try
            {
                _producto.banner().Delete(idBanner);

                return Ok(new CustomResponse());
            }
            catch (MessageExeption ex)
            {
                _logger.LogError(
                    $"[BannerController][Eliminar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"[BannerController][Eliminar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }


    }
}   
