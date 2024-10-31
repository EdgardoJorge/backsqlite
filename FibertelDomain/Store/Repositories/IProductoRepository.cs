
using FibertelDomain.Auth.Services;
using FibertelDomain.Store.Services;

namespace FibertelDomain.Store.Repositories
{
    public interface IProductoRepository
    {
        public ICategoriaService categoria();
        public IMarcaService marca();
        public IProductoService producto();
        public IAdministradorService administrador();
        public IBannerService banner();
    }
}
