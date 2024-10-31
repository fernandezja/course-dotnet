using Starwars.Core.Datos;
using Starwars.Core.Entidades;

namespace Starwars.Core.Negocio
{
    public class UsuarioNegocio
    {
        public List<Usuario> Listar() { 
            var usuarioRepository = new UsuarioRepository();
            return usuarioRepository.ListarDB();
            //return usuarioRepository.ListarSimple();
        }
    }
}
