using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class IngredientesOpcion
    {
        [Key]
        public int IdOpcion { get; set; }
        public int IdIngredientes { get; set; }

    }
}
