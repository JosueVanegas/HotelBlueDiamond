using System;
using System.Collections.Generic;

namespace Hotel_Dorado_DesktopApp.Models;

public partial class Cliente
{
    public int ClienteId { get; set; }

    public string? Cedula { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
