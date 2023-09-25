using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Reporte
    {
        [Key]
        public int IdReporte { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public DateTime FechaRealizado { get; set; }

        [AllowNull]
        public Usuario? Usuario { get; set; }

        [AllowNull]
        public List<Pedido>? Pedidos { get; set; }
    }
}
