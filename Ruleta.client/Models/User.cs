using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ruleta.Client.Models
{
    public class Users
    {
        public int clave { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
    }
}