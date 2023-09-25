using Back.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.ClasesData
{
    internal class PedidoData
    {
        private readonly ApplicationDbContext _context;

        public PedidoData(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AgregarPedido(Pedido pedidoNuevo)
        {
            _context.pedidos.Add(pedidoNuevo);
            _context.SaveChanges();
        }
        public void EliminarPedido(int IdPedido)
        {
            var PedidoEncontrado = _context.pedidos.Find(IdPedido);
            if (PedidoEncontrado != null)
            {
                _context.pedidos.Remove(PedidoEncontrado);
                _context.SaveChanges();
            }
        }

        //public void ModificarPedido(Pedido PedidoModificado)
        //{
        //    var PedidoEncontrado = _context.pedidos.Find(PedidoModificado.IdPedido);
        //    if (PedidoEncontrado != null)
        //    {
        //        PedidoEncontrado.Precio = PedidoModificado.IdPedido;
        //        _context.SaveChanges();
        //    }
        }



    }
}
