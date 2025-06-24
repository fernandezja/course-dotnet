using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CursoNET.Core.Entidades.Tests;


public class EmpleadoTest
{
    [Fact]
    public void Test1()
    {
        var empleado1 = new Empleado();
        empleado1.Nombre = "Demo Nombre Empleado";

       Assert.Equal("Demo Nombre Empleado", empleado1.Nombre);
    }

}

