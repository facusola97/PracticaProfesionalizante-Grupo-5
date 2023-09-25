
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class ReportePedidos
    {
        [Key]
        public int IdReporte { get; set; }

        public Reporte reporte { get; set; }        

        public int IdPedido { get; set; }

        public Pedido pedido { get; set; }

       
    }
}
