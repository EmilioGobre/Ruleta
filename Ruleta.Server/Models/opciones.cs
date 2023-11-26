using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ruleta.Server.Models
{
    public class opciones
    {
        [Key]
        public int clave_opciones { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        [Required]
        [StringLength(255)]
        public string? foto { get; set; }
    }
}