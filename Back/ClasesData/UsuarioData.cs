using Back.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.ClasesData
{
    internal class UsuarioData
    {
        private readonly ApplicationDbContext _context;

        public UsuarioData(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AgregarUsuario(Usuario usuarioNuevo)
        {
            _context.usuarios.Add(usuarioNuevo);
            _context.SaveChanges();
        }
        public void EliminarUsuario(int id)
        {
            var UsuarioEncontrado = _context.usuarios.Find(id);
            if (UsuarioEncontrado != null)
            {
                _context.usuarios.Remove(UsuarioEncontrado);
                _context.SaveChanges();
            }
        }

        public void ModificarUsuario(Usuario UsuarioModificado)
        {
            var UsuarioEncontrado = _context.usuarios.Find(UsuarioModificado.id);
            if (UsuarioEncontrado != null)
            {
                UsuarioEncontrado.Contraseña = UsuarioModificado.id.ToString();
                _context.SaveChanges();
            }



        }
}
