using FibertelDomain.Store.Models;
using FibertelDomain.Utils;

namespace FibertelDomain.Store.Services
{
    public interface IDetallePedidoService: ICrud<DetallePedido>
    {
        public List<DetallePedido> GetByPedidoId(int idPedido);

    }
}
