using System;
using System.Collections.Generic;

namespace Hotel.Models;

public partial class DetallePedido
{
    public int PedidoId { get; set; }

    public int ProductoId { get; set; }

    public int? Cantidad { get; set; }

    public virtual Pedido Pedido { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;
}
