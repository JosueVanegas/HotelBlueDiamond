using System;
using System.Collections.Generic;

namespace Hotel.Models;

public partial class Piso
{
    public int PisoId { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Habitacion> Habitacions { get; set; } = new List<Habitacion>();
}
