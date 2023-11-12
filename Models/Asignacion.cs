using System;
using System.Collections.Generic;

namespace Hotel.Models;

public partial class Asignacion
{
    public int AsignacionId { get; set; }

    public string? Descripcion { get; set; }

    public decimal? ComisionGenerada { get; set; }

    public bool? Estado { get; set; }

    public DateTime? FechaAsignacion { get; set; }

    public DateTime? FechaConclusion { get; set; }

    public int? EmpleadoId { get; set; }

    public int? HabitacionId { get; set; }

    public virtual Empleado? Empleado { get; set; }

    public virtual Habitacion? Habitacion { get; set; }
}
