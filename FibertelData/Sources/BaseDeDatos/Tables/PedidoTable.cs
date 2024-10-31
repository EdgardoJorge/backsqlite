using FibertelDomain.Store.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FibertelData.Sources.BaseDeDatos.Tables
{
    [Table("pedidos", Schema = "Movimientos")]
    public class PedidoTable
    {
        [Key]
        public int idPedido { get; set; }
        [Required]
        public DateTime fechaPedido { get; set; }
        public DateTime? fechaCancelado { get; set; }
        [Required]
        [StringLength(30)]
        public string tipoPedido { get; set; }
        [Required]
        [StringLength(50)]
        public string estado { get; set; }
        [Required]
        [Precision(6, 2)]
        public decimal total { get; set; }
        [Required]
        public int idCliente { get; set; }
        public int? idPersonal { get; set; }
        public int? idEnvio { get; set; }
        public int? idRecojo { get; set; }

        public ClienteTable Cliente {  get; set; }
        public EnvioTable Envio { get; set; }  // Relación con la entidad Envio
        public RecojoTable Recojo { get; set; }  // Relación con la entidad Envio

        public ICollection<DetallePedidoTable> DetallePedidos { get; set; }
    }
}
