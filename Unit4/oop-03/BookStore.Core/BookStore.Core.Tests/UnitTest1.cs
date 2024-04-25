using System.Net.Sockets;

namespace BookStore.Core.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Buscar_Y_Solicitar_Prestamo_Libro()
        {
            var usuario1 = new Usuario("Jose");

            var biblioteca1 = new Biblioteca("UCP");
            var unLibro1 = biblioteca1.Buscar("Ingenieria de Software");

            var prestamoEstado1 = biblioteca1.SolicitarPrestamo(unLibro1, usuario1);

            if (prestamoEstado1.ExisteEjemplar) { 
                //Entregar ejemplar
                var ticket = prestamoEstado1.Ticket;

                Assert.Equal("2024-04-25", ticket.FechaEntrega);
                Assert.Equal("2024-04-29", ticket.FechaVencimiento);
            }
            else
            {
                //Indicar la fecha de proxima devolucion para alerta!
                var alerta1 = usuario1.GenerarAlerta(prestamoEstado1);

                Assert.Equal("2024-04-29", alerta1.Fecha);
                Assert.Equal("Ingenieria de Software", alerta1.Libro.Nombre);
            }


        }



        [Fact]
        public void Buscar_Y_Solicitar_Prestamo_Libro_ConEjemplarExistente()
        {
            var usuario1 = new Usuario("Jose");

            var biblioteca1 = new Biblioteca("UCP");
            var unLibro1 = biblioteca1.Buscar("Ingenieria de Software");

            var prestamoEstado1 = biblioteca1.SolicitarPrestamo(unLibro1, usuario1);

            Assert.True(prestamoEstado1.ExisteEjemplar);

            var ticket = prestamoEstado1.Ticket;

            Assert.Equal("2024-04-25", ticket.FechaEntrega);
            Assert.Equal("2024-04-29", ticket.FechaVencimiento);
        }


        [Fact]
        public void Buscar_Y_Solicitar_Prestamo_Libro_SinEjemplar()
        {
            var usuario1 = new Usuario("Jose");

            var biblioteca1 = new Biblioteca("UCP");
            var unLibro1 = biblioteca1.Buscar("Ingenieria de Software (sin ejemplar)");

            var prestamoEstado1 = biblioteca1.SolicitarPrestamo(unLibro1, usuario1);

            Assert.False(prestamoEstado1.ExisteEjemplar);
            Assert.Null(prestamoEstado1.Ticket);

            var alerta1 = usuario1.GenerarAlerta(prestamoEstado1);
            
            Assert.Equal("2024-04-29", alerta1.Fecha);
            Assert.Equal("Ingenieria de Software (sin ejemplar)", alerta1.Libro.Nombre);


        }



    }
}