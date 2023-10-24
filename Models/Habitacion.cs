using System;
using System.Collections.Generic;

namespace Hotel_Dorado_DesktopApp.Models;

public partial class Habitacion
{
    public int HabitacionId { get; set; }

    public int? CategoriaHabitacionId { get; set; }

    public int? EstadoId { get; set; }

    public int? PisoId { get; set; }

    public virtual CategoriaHabitacion? CategoriaHabitacion { get; set; }

    public virtual EstadoHabitacion? Estado { get; set; }

    public virtual ICollection<HistorialEstadoHabitacion> HistorialEstadoHabitacions { get; set; } = new List<HistorialEstadoHabitacion>();

    public virtual ICollection<Limpieza> Limpiezas { get; set; } = new List<Limpieza>();

    public virtual ICollection<Mantenimiento> Mantenimientos { get; set; } = new List<Mantenimiento>();

    public virtual Piso? Piso { get; set; }

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
