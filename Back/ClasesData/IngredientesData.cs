using Back.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.ClasesData
{
    public class IngredientesData
    {
        private readonly ApplicationDbContext _context; 

        public IngredientesData(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AgregarIngrediente(Ingredientes ingredienteNuevo)
        {
            _context.ingredientes.Add(ingredienteNuevo);
            _context.SaveChanges();
        }

        public void EliminarIngrediente(int id)
        {
            var IngredienteEncontrado = _context.ingredientes.Find(id);
            if (IngredienteEncontrado != null)
            {
                _context.ingredientes.Remove(IngredienteEncontrado);
                _context.SaveChanges();
            }
        }

        public void ModificarProducto(Ingredientes ingredienteModificado)
        {
            var IngredienteEncontrado = _context.ingredientes.Find(ingredienteModificado.IdIngredientes);
            if (IngredienteEncontrado != null)
            {
                IngredienteEncontrado.Precio = ingredienteModificado.Precio;
                _context.SaveChanges();
            }
        }


    }
}
