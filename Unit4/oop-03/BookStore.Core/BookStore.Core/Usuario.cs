
namespace BookStore.Core
{
    public class Usuario
    {
        public string Nombre { get; set; }

        public Usuario(string nombre)
        {
            Nombre = nombre;
        }

        public Alerta GenerarAlerta(PrestamoEstado prestamoEstado1)
        {
            var alerta = new Alerta(prestamoEstado1);
            alerta.Fecha = "2024-04-29";

            return alerta;
        }
    }
}
