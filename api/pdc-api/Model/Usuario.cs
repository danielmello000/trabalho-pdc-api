using pdc_api.Model.Enum;

namespace pdc_api.Model
{
    public class Usuario
    {
        public string Username { get; set; }
        public Signo Signo { get; set; }

        public Usuario(string username)
        {
            Username = username;
        }
    }
}
