using System;
using System.Collections.Generic;

namespace Hotel.Models;

public partial class CategoriaHabitacion
{
    public int CategoriaHabitacionId { get; set; }

    public string? Descripcion { get; set; }

    public int? Capacidad { get; set; }

    public virtual ICollection<Habitacion> Habitacions { get; set; } = new List<Habitacion>();
}
