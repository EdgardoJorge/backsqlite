
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FibertelData.Sources.BaseDeDatos.Tables
{
    [Table("clientes", Schema = "Movimientos")]
    public class ClienteTable
    {
        [Key]
        public int idCliente { get; set; }
        [Required]
        [StringLength(50)]
        public string razonSocial { get; set; }
        [Required]
        [StringLength(50)]
        public string email { get; set; }
        [Required]
        [StringLength(20)]
        public string telefonoMovil { get; set; }
        [Required]
        [StringLength(20)]
        public string tipoDocumento { get; set; }
        [Required]
        [StringLength(30)]
        public string numeroDocumento { get; set; }
        [StringLength(100)]
        public string? direccionFiscal { get; set; }

        public PedidoTable Pedido { get; set; }
    }
}
