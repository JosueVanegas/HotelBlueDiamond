using System;
using System.Collections.Generic;

namespace Hotel.Models;

public partial class Compra
{
    public int CompraId { get; set; }

    public DateTime? Fecha { get; set; }

    public int? UsuarioId { get; set; }

    public virtual ICollection<DetalleCompra> DetalleCompras { get; set; } = new List<DetalleCompra>();

    public virtual Usuario? Usuario { get; set; }
}
