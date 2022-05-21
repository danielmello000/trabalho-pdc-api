using pdc_api.Model;

namespace pdc_api.Services
{
    public static class UsuarioService
    {
        public static List<Usuario> Usuarios { get; set; } = new List<Usuario>();

        public static Usuario BuscarUsuario(string username)
        {
            return Usuarios.FirstOrDefault(x => x.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
        }

        public static bool CadastrarUsuario(Usuario usuario)
        {
            if(!Usuarios.Where(x => x.Username.Equals(usuario.Username, StringComparison.OrdinalIgnoreCase)).Any())
            {
                Usuarios.Add(usuario);
                return true;
            }

            return false;
        }
    }
}
