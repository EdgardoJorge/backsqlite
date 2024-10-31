using FibertelDomain.Store.Models;
using FibertelDomain.Utils;

namespace FibertelDomain.Store.Services
{
    public interface IProductoService: ICrud<Producto>
    {
        public List<Producto> search(string Nombre);
    }
}
