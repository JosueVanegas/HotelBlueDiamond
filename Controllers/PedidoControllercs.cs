using Hotel_Dorado_DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Dorado_DesktopApp.Controllers
{
    public class PedidoControllercs
    {
        private readonly HotelDoradoContext _context;
        public PedidoControllercs(HotelDoradoContext context)
        {
            _context = context;
        }
        public void CrearPedidoConDetalles(DataGridView dataGridView,bool estado)
        {
            var detallesPedido = new List<DetallePedido>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["ProductoID"].Value != null && row.Cells["Cantidad"].Value != null)
                {
                    int productoID = Convert.ToInt32(row.Cells["ProductoID"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                    var detallePedido = new DetallePedido
                    {
                        ProductoId = productoID,
                        Cantidad = cantidad
                    };

                    detallesPedido.Add(detallePedido);
                }
            }

            if (detallesPedido.Count > 0)
            {
                var nuevoPedido = new Pedido
                {
                    Fecha = DateTime.Now,
                    Estado = estado
                };

                _context.Pedidos.Add(nuevoPedido);
                _context.SaveChanges(); // Esto generará el ID para el pedido

                int pedidoIDGenerado = nuevoPedido.PedidoId;

                foreach (var detallePedido in detallesPedido)
                {
                    detallePedido.PedidoId = pedidoIDGenerado;
                }

                _context.DetallePedidos.AddRange(detallesPedido);
                _context.SaveChanges();
            }
        }
    }
}
