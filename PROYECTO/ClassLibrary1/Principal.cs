using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Principal
    {

        public List<Pedido> listapedidos = new List<Pedido>();
        public List<Usuario> ListaUsuario = new List<Usuario> ();
        public List<OpcionPedido> ListaOpcionPedido = new List<OpcionPedido> ();
        public List<ReportePedidos> ListaReportesPedidos = new List<ReportePedidos> ();

        public void Altapedidos(Pedido PedidoParametro) 
        {
            Pedido pedido = new Pedido();

            pedido.IdPedido = PedidoParametro.IdPedido;
            pedido.OpcionesPedido = PedidoParametro.OpcionesPedido;
            pedido.Fecha = PedidoParametro.Fecha;   
            pedido.Cargado = PedidoParametro.Cargado;
            
            listapedidos.Add(pedido);



        }

        public void BajaPedido(int IdPedido) 
        {
            var pedidoEliminado = listapedidos.Find (x => x.IdPedido == IdPedido);
            listapedidos.Remove(pedidoEliminado);


        }



        public void ModificarPedido ( Pedido PedidoModificado )
        {
            Pedido pedidoModificado = new Pedido ();
            Pedido pedidonuevo = new Pedido ();

            PedidoModificado.IdPedido = pedidonuevo.IdPedido;
            PedidoModificado.OpcionesPedido = pedidonuevo.OpcionesPedido;
            PedidoModificado.Fecha = pedidonuevo.Fecha;

            var pedidoEliminado = listapedidos.Find (x => x.IdPedido == pedidonuevo.IdPedido);

            listapedidos.Remove (pedidoEliminado);
            listapedidos.Add (PedidoModificado);







        }


        public void AltaUsuario ( string Nombre, string Contraseña, int id )
        {
            Usuario usuario = new Usuario ();

            usuario.id = id;
            usuario.Nombre = Nombre;
            usuario.Contraseña = Contraseña;

            ListaUsuario.Add (usuario);
        }

        public void BajaUsuario ( int id )
        {
            var usuarioEliminado = ListaUsuario.Find (x => x.id == id);
            ListaUsuario.Remove (usuarioEliminado);
        }

        public void ModificacionUsuario ( string Nombre, string Contraseña, int id )
        {
            Usuario usuarioModificado = new Usuario ();
            Usuario usuarioNuevo = new Usuario ();

            usuarioModificado.id = usuarioNuevo.id;
            usuarioModificado.Nombre = usuarioNuevo.Nombre;
            usuarioModificado.Contraseña = usuarioNuevo.Contraseña;

            var usuarioEliminado = ListaUsuario.Find (x => x.id == usuarioNuevo.id);

            ListaUsuario.Remove (usuarioEliminado);
            ListaUsuario.Add (usuarioModificado);
        }

        public void AltaOpcionPedido ( int IdPedido, int IdOpcion )
        {
            OpcionPedido opcionPedido = new OpcionPedido ();

            opcionPedido.IdPedido = IdPedido;
            opcionPedido.IdOpcion = IdOpcion;

            ListaOpcionPedido.Add (opcionPedido);
        }

        public void BajaOpcionPedido ( int IdPedido )
        {
            var opcionPedidoEliminado = ListaOpcionPedido.Find (x => x.IdPedido == IdPedido);
            ListaOpcionPedido.Remove (opcionPedidoEliminado);
        }

        public void ModificacionOpcionPedido ( int IdPedido, int IdOpcion )
        {
            OpcionPedido opcionPedidoModificado = new OpcionPedido ();
            OpcionPedido opcionPedidoNuevo = new OpcionPedido ();

            opcionPedidoModificado.IdPedido = opcionPedidoNuevo.IdPedido;
            opcionPedidoModificado.IdOpcion = opcionPedidoNuevo.IdOpcion;

            var opcionPedidoEliminado = ListaOpcionPedido.Find (x => x.IdPedido == opcionPedidoNuevo.IdPedido);

            ListaOpcionPedido.Remove (opcionPedidoEliminado);
            ListaOpcionPedido.Add (opcionPedidoModificado);
        }

        public void AltaReportePedidos ( int IdReporte, int IdPedido )
        {
            ReportePedidos reportePedidos = new ReportePedidos ();

            reportePedidos.IdReporte = IdReporte;
            reportePedidos.IdPedido = IdReporte;

            ListaReportesPedidos.Add (reportePedidos);
        }

        public void BajaReportePedidos ( int IdReporte )
        {
            var reportePedidosEliminados = ListaReportesPedidos.Find (x => x.IdReporte == IdReporte);
            ListaReportesPedidos.Remove (reportePedidosEliminados);
        }

        public void ModificacionRepostePedidos ( int IdReporte, int IdPedido )
        {
            ReportePedidos reportePedidosModificado = new ReportePedidos ();
            ReportePedidos reportePedidosNuevo = new ReportePedidos ();

            reportePedidosModificado.IdReporte = reportePedidosNuevo.IdReporte;
            reportePedidosModificado.IdPedido = reportePedidosNuevo.IdPedido;

            var reportePedidosEliminados = ListaReportesPedidos.Find (x => x.IdReporte == reportePedidosNuevo.IdReporte);

            ListaReportesPedidos.Remove (reportePedidosEliminados);
            ListaReportesPedidos.Add (reportePedidosModificado);
        }




















    }
}
