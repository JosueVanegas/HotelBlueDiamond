using System;
using System.Collections.Generic;

namespace Hotel_Dorado_DesktopApp.Models;

public partial class HistorialEstadoHabitacion
{
    public int HistorialId { get; set; }

    public int? HabitacionId { get; set; }

    public int? EstadoId { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public virtual EstadoHabitacion? Estado { get; set; }

    public virtual Habitacion? Habitacion { get; set; }
}
