﻿using System;
using System.Collections.Generic;

namespace Hotel.Models;

public partial class EstadoHabitacion
{
    public int EstadoId { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Habitacion> Habitacions { get; set; } = new List<Habitacion>();
}
