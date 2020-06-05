namespace ClasesBase
{
    public class Usuario
    {
        private int usu_ID;
        private string usu_NombreUsuario;
        private string usu_Contraseña;
        private string usu_ApellidoNombre;
        private bool usu_Disponible;
        private string rol_Codigo;

        public int Usu_ID { get => usu_ID; set => usu_ID = value; }
        public string Usu_NombreUsuario { get => usu_NombreUsuario; set => usu_NombreUsuario = value; }
        public string Usu_Contraseña { get => usu_Contraseña; set => usu_Contraseña = value; }
        public string Usu_ApellidoNombre { get => usu_ApellidoNombre; set => usu_ApellidoNombre = value; }
        public bool Usu_Disponible { get => usu_Disponible; set => usu_Disponible = value; }
        public string Rol_Codigo { get => rol_Codigo; set => rol_Codigo = value; }

        public Usuario(string username, string password, string AyN, bool disponible, string codigo)
        {
            Usu_NombreUsuario = username;
            Usu_Contraseña = password;
            Usu_ApellidoNombre = AyN;
            Usu_Disponible = disponible;
            Rol_Codigo = codigo;
        }

        public Usuario(string username, string password, string AyN, string codigo)
        {
            Usu_NombreUsuario = username;
            Usu_Contraseña = password;
            Usu_ApellidoNombre = AyN;
            Rol_Codigo = codigo;
        }

        public Usuario() { }
    }
}
