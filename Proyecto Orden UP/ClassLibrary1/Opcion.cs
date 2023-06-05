using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Opcion
    {
        public int IdOpcion { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }    
        public string Descripcion { get; set; }
        public decimal Precio { get; set; } 
        public List<Ingredientes> Ingredientes { get; set; }

    }
}
