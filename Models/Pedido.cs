using System;
using System.Collections.Generic;

namespace Hotel_Dorado_DesktopApp.Models;

public partial class Pedido
{
    public int PedidoId { get; set; }

    public int? ClienteId { get; set; }

    public DateTime? FechaHora { get; set; }

    public decimal? Total { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();
}
