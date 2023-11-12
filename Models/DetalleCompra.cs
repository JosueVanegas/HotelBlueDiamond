using System;
using System.Collections.Generic;

namespace Hotel.Models;

public partial class DetalleCompra
{
    public int CompraId { get; set; }

    public int ProductoId { get; set; }

    public decimal? PrecioCompra { get; set; }

    public int? Cantidad { get; set; }

    public virtual Compra Compra { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;
}
