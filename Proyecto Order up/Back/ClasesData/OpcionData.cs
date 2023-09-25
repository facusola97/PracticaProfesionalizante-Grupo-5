using Back.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.ClasesData
{
    public class OpcionData
    {
        private readonly ApplicationDbContext _context;

        public OpcionData(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AgregarOpcion(Opcion opcionNuevo)
        {
            _context.opciones.Add(opcionNuevo);
            _context.SaveChanges();
        }
        public void EliminarOpcion(int IdOpcion)
        {
            var OpcionEncontrada = _context.opciones.Find(IdOpcion);
            if (OpcionEncontrada != null)
            {
                _context.opciones.Remove(OpcionEncontrada);
                _context.SaveChanges();
            }
        }

        //public void ModificarOpcion(Opcion OpcionModificada)
        //{
        //    var IngredienteEncontrado = _context.opciones.Find(OpcionModificada.IdOpcion);
        //    if (IngredienteEncontrado != null)
        //    {
        //        IngredienteEncontrado.Precio = OpcionModificada.IdOpcion;
        //        _context.SaveChanges();
        ////    }
        

     }
}
