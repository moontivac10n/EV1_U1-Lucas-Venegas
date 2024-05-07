using System;
using System.Collections.Generic;

namespace EV1_U1_Lucas_Venegas.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }
}
