using Back.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.ClasesData
{
    internal class ReporteData
    {
        private readonly ApplicationDbContext _context;

        public ReporteData(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AgregarReporte(Reporte reporteNuevo)
        {
            _context.reporte.Add(reporteNuevo);
            _context.SaveChanges();
        }
        public void EliminarReporte(int IdReporte)
        {
            var ReporteEncontrado = _context.reporte.Find(IdReporte);
            if (ReporteEncontrado != null)
            {
                _context.reporte.Remove(ReporteEncontrado);
                _context.SaveChanges();
            }
        }

        //public void ModificarReporte(Reporte ReporteModificado)
        //{
        //    var IngredienteEncontrado = _context.ingredientes.Find(ReporteModificado.IdReporte);
        //    if (IngredienteEncontrado != null)
        //    {
        //        IngredienteEncontrado.Precio = ReporteModificado.IdReporte;
        //        _context.SaveChanges();
        //    }
        //}



    }
}
