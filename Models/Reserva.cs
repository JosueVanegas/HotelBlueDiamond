using System;
using System.Collections.Generic;

namespace Hotel.Models;

public partial class Reserva
{
    public int ReservaId { get; set; }

    public int? ClienteId { get; set; }

    public int? HabitacionId { get; set; }

    public int? EmpleadoId { get; set; }

    public DateTime? FechaEntrada { get; set; }

    public DateTime? FechaSalida { get; set; }

    public decimal? Adelanto { get; set; }

    public int? HorasReservadas { get; set; }

    public int? CantidadPersonas { get; set; }

    public decimal? TotalDaños { get; set; }

    public decimal? Total { get; set; }

    public bool? Finalizada { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual Empleado? Empleado { get; set; }

    public virtual Habitacion? Habitacion { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
