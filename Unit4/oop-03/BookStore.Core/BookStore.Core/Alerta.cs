namespace BookStore.Core
{
    public class Alerta
    {
        public string Fecha { get; set; }
        public Libro Libro { get; set; }

        public Alerta(PrestamoEstado prestamoEstado)
        {
            Libro = prestamoEstado.Libro;
        }
    }
}