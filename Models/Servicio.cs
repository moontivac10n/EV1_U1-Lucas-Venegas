using System;
using System.Collections.Generic;

namespace EV1_U1_Lucas_Venegas.Models;

public partial class Servicio
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Precio { get; set; }

    public DateOnly FechaRetiro { get; set; }
}
