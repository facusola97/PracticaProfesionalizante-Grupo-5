using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Usuario
    {
        [Key]
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public bool Validate { get; set; }

    }
}

