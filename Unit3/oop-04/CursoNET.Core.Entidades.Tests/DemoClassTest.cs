using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CursoNET.Core.Entidades.Tests;


public class DemoClassTest
{
    [Fact]
    public void Debe_crear_una_demo_class()
    {
        var demo1 = new CursoNET.Core.Entidades.DemoClass();
        DemoClass demo2 = new();

        Assert.NotNull(demo1);
        Assert.NotNull(demo2);
    }


    [Fact]
    public void Debe_Setear_Propiedades()
    {
        var demo = new CursoNET.Core.Entidades.DemoClass();
        

        demo.Nombre = "Test Value 1";

        Assert.NotNull(demo);
        Assert.Equal("Test Value 1", demo.Nombre);
    }



    [Fact]
    public void Debe_Saludar()
    {
        var demo = new CursoNET.Core.Entidades.DemoClass();

        demo.Nombre = ".NET";

        Assert.Equal("Hola, .NET", demo.Saludar());
    }


    [Fact]
    public void Test_Instancias()
    {
        var demo1 = new DemoClass();
        var demo2 = new DemoClass();

        demo1.Nombre = ".NET";
        demo2.Nombre = ".NET";

        //Assert.True(demo1 == demo2);

        DemoClass demo3;

        demo3 = demo1;

        Assert.True(demo1 == demo3);

        demo3.Nombre = "Otro Nombre";
        Assert.Equal("Otro Nombre", demo1.Nombre);
    }


    [Fact]
    public void Test_OverrideMetodos()
    {
        var demo1 = new DemoClass();
        var demo2 = new DemoClass();

        demo1.Nombre = ".NET";
        demo2.Nombre = ".NET";

        Assert.Equal(demo1, demo2);
        //Assert.True(demo1 == demo2);

    }


    [Fact]
    public void Test_Constructor()
    {
        var demo1 = new DemoClass("Nombre", "Apellido");

        Assert.NotNull(demo1);
        Assert.Equal("Nombre", demo1.Nombre);
        Assert.Equal("Apellido", demo1.Apellido);



    }

    [Fact]
    public void Test_Tupla()
    {
        var demo1 = new DemoClass("Nombre 1", "Apellido 1");

        Assert.Equal(Tuple.Create("Metodo1", "Apellido 1"), demo1.Metodo1());



    }
}

