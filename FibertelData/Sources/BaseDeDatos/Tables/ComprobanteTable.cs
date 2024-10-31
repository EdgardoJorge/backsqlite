
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FibertelData.Sources.BaseDeDatos.Tables
{
    [Table("comprobantes", Schema = "Movimientos")]
    public class ComprobanteTable
    {
        [Key]
        public int idComprobante { get; set; }
        [Required]
        public DateTime fechaEmision { get; set; }
        [Required]
        [StringLength(30)]
        public string tipoComprobante { get; set; }
        [Required]
        public int idPedido { get; set; }
    }
}
