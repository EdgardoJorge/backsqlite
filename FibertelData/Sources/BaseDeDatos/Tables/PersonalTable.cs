using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelData.Sources.BaseDeDatos.Tables
{
    [Table("personals", Schema = "Movimientos")]
    public class PersonalTable
    {
        [Key]
        public int idPersonal { get; set; }
        [Required]
        [StringLength(50)]
        public string nombres { get; set; }
        [Required]
        [StringLength(50)]
        public string apellidos { get; set; }
        [Required]
        [StringLength(50)]
        public string rol { get; set; }
        [Required]
        [StringLength(50)]
        public string contacto { get; set; }
        [Required]
        [StringLength(20)]
        public string numeroDocumento { get; set; }
        [Required]
        public DateTime inicioOperacion { get; set; }
        public DateTime? finOperacion { get; set; }
    }
}
