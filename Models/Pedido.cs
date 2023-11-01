using System;
using System.Collections.Generic;

namespace Hotel_Dorado_DesktopApp.Models;

public partial class Pedido
{
    public int PedidoId { get; set; }

    public int? ReservaId { get; set; }

    public DateTime? Fecha { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    public virtual Reserva? Reserva { get; set; }
}
