using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Reporte
    {
        public int IdReporte { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public DateTime FechaRealizado { get; set; }
        public Usuario Usuario { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
