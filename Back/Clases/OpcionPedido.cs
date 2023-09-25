using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class OpcionPedido
    {
        [Key]
        public int IdPedido { get; set; }
        public int IdOpcion { get; set; }
        public Opcion Opcion { get; set; }
        public Pedido Pedido { get; set; }

    }
}
