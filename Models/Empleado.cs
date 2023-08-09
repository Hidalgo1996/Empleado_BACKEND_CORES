using System;
using System.Collections.Generic;

namespace Foro_proyecto.Models
{
    public partial class Empleado
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Genero { get; set; }
        public string? Salario { get; set; }
    }
}
