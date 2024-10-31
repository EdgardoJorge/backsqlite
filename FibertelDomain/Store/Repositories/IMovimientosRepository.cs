

using FibertelDomain.Store.Services;

namespace FibertelDomain.Store.Repositories
{
    public interface IMovimientosRepository
    {
        public IDetallePedidoService detallePedido();
        public IPedidoService pedido();
        public IEnvioService envio();
        public IRecojoService recojo();
        public IPersonalService personal();
        public IClienteService cliente();
        public IComprobanteService comprobante();

    }
}
