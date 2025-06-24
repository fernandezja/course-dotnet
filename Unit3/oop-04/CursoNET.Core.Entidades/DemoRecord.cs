using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoNET.Core.Entidades;

public record DemoRecord(string Nombre, string Apellido)
{
    public string Saludar() => $"Hola, {Nombre}";
}

