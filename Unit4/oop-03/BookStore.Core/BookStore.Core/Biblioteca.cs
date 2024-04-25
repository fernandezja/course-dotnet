

namespace BookStore.Core
{
    public class Biblioteca
    {
        public string Nombre { get; set; }

        public Biblioteca(string nombre)
        {
            Nombre = nombre;
        }

        public Libro Buscar(string nombreLibro)
        {
            return new Libro()
            {
                Nombre = nombreLibro
            };
        }

        public PrestamoEstado SolicitarPrestamo(Libro unLibro, Usuario usuario)
        {
            var prestamoEstado = new PrestamoEstado(unLibro, usuario);

            if (!unLibro.Nombre.Contains("sin ejemplar"))
            {
                prestamoEstado.ExisteEjemplar = true;

                var ticket = new Ticket()
                {
                    FechaEntrega = "2024-04-25",
                    FechaVencimiento = "2024-04-29"
                };

                prestamoEstado.Ticket = ticket;
                return prestamoEstado;
            }

            //Sin ejemplar
            prestamoEstado.ExisteEjemplar = false;
            prestamoEstado.Ticket = null;

            return prestamoEstado;
        }
    }
}
