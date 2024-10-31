
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FibertelData.Sources.BaseDeDatos.Tables
{
    [Table("recojos", Schema = "Movimientos")]
    public class RecojoTable
    {
        [Key]
        public int idRecojo { get; set; }
        public DateTime? fechaListo { get; set; }
        public DateTime? fechaEntrega { get; set; }
        public string? responsableEntrega { get; set; }
        public PedidoTable Pedido { get; set; }
    }
}
