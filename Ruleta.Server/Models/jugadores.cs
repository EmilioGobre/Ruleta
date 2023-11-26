using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ruleta.Server.Models
{
    public class jugadores
    {
        [Key]
        public int clave_jugadores { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
    }
}