using FibertelDomain.Store.Models;
using FibertelDomain.Utils;

namespace FibertelDomain.Store.Services
{
    public interface IPedidoService: ICrud<Pedido>
    {
        public Pedido? GetPedidoByIdEnvio(int idEnvio);
        public Pedido? GetPedidoByIdRecojo(int idRecojo);
        public List<Pedido> GetPedidosPendientes();
        public List<Pedido> GetPedidosEntregados();
        public List<Pedido> GetPedidosEnviados();
        public List<Pedido> GetPedidosCancelados();
        public int GetTotalPedidos();
        public decimal GetSumaTotalPedidos();
        public List<Pedido> GetPedidosByFilters(int? idPedido, string numeroDocumento);
    }
}

