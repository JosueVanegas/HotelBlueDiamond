using System;
using System.Collections.Generic;

namespace Hotel.Models;

public partial class DatosParaNomina
{
    public string? Cedula { get; set; }

    public string? NombreCompleto { get; set; }

    public string? Cargo { get; set; }

    public decimal? SalarioFijo { get; set; }

    public decimal? Comiciones { get; set; }

    public decimal? SalarioDevengado { get; set; }
}
