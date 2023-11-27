using System;
using System.Collections.Generic;

namespace Hotel.Models;

public partial class Habitacion
{
    public int HabitacionId { get; set; }

    public string? Codigo { get; set; }

    public int? CategoriaHabitacionId { get; set; }

    public int? EstadoId { get; set; }

    public int? PisoId { get; set; }

    public string? Detalles { get; set; }

    public decimal? PrecioPh { get; set; }

    public string? Extras { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Asignacion> Asignacions { get; set; } = new List<Asignacion>();

    public virtual CategoriaHabitacion? CategoriaHabitacion { get; set; }

    public virtual EstadoHabitacion? Estado { get; set; }

    public virtual Piso? Piso { get; set; }

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
