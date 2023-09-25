using Back.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Opcion
    {
        [Key]
        public int IdOpcion { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public List<Ingredientes> Ingredientes { get; set; }

    }
}
