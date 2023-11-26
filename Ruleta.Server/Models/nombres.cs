using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Ruleta.Server.Models
{
    public class nombres
    {
        [Key]
        public int clave { get; set; }
        [ForeignKey("clave_jugadores")]
        public int nombre_jugador_fk { get; set; }
        public jugadores jugador;
        [ForeignKey("clave_opciones")]
        public int casar_fk { get; set; }
        public opciones casar;
        [ForeignKey("clave_opciones")]
        public int besar_fk { get; set; }
        public opciones besar;
        [ForeignKey("clave_opciones")]
        public int coger_fk { get; set; }
        public opciones coger;
    }
}