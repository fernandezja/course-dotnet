namespace BookStore.Core
{
    public class PrestamoEstado
    {
        public Libro Libro { get; set; }
        public Usuario Usuario { get; set; }
        public bool ExisteEjemplar { get; set; }
        public Ticket Ticket { get; set; }

        public PrestamoEstado(Libro libro, Usuario usuario)
        {
            this.Libro = libro;
            this.Usuario = usuario;
        }
    }
}