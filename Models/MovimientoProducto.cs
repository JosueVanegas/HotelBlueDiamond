using System;
using System.Collections.Generic;

namespace Hotel.Models;

public partial class MovimientoProducto
{
    public int MovimientoId { get; set; }

    public int? ProductoId { get; set; }

    public int? Stock { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Producto? Producto { get; set; }
}
