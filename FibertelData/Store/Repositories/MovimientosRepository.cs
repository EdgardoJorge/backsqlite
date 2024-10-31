using FibertelDomain.Store.Repositories;
using FibertelDomain.Store.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelData.Store.Repositories
{
    public class MovimientosRepositoryImpl : IMovimientosRepository
    {
        private readonly IDetallePedidoService _detallePedido;
        private readonly IPedidoService _pedido;
        private readonly IEnvioService _envio;
        private readonly IRecojoService _recojo;
        private readonly IPersonalService _personal;
        private readonly IComprobanteService _comprobante;
        private readonly IClienteService _cliente;

        public MovimientosRepositoryImpl (
            IDetallePedidoService detallePedido,
            IPedidoService pedido,
            IEnvioService envio,
            IRecojoService recojo,
            IPersonalService personal,
            IClienteService cliente,
            IComprobanteService comprobante
        )
        {
            _detallePedido = detallePedido;
            _pedido = pedido;
            _envio = envio;
            _recojo = recojo;
            _personal = personal;
            _cliente = cliente;
            _comprobante = comprobante;
        } 

        public IDetallePedidoService detallePedido()
        {
            return _detallePedido;
        }

        public IPedidoService pedido()
        {
            return _pedido;
        }

        public IEnvioService envio()
        {
            return _envio;
        }

        public IRecojoService recojo()
        {
            return _recojo;
        }

        public IPersonalService personal()
        {
            return _personal;
        }

        public IClienteService cliente()
        {
            return _cliente;
        }

        public IComprobanteService comprobante()
        {
            return _comprobante;
        }
    }
}
