
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FibertelData.Sources.BaseDeDatos.Tables
{
    [Table("envios", Schema = "Movimientos")]
    public class EnvioTable
    {
        [Key]
        public int idEnvio { get; set; }
        [Required]
        [StringLength(20)]
        public string region { get; set; }
        [Required]
        [StringLength(30)]
        public string provincia { get; set; }
        [Required]
        [StringLength(50)]
        public string distrito { get; set; }
        [Required]
        [StringLength(100)]
        public string localidad { get; set; }
        [Required]
        [StringLength(100)]
        public string calle { get; set; }
        [Required]
        [StringLength(20)]
        public string nDomicilio { get; set; }
        [Required]
        [StringLength(50)]
        public string codigoPostal { get; set; }
        public DateTime? fechaEnvio { get; set; }
        public DateTime? fechaEntrega { get; set; }
        [StringLength(100)]
        public string? responsableEntrega { get; set; }
        public int? idPersonal { get; set; }

        public PedidoTable Pedido { get; set; }  // Relación con el pedido
    }
}
