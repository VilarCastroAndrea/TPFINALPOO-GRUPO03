namespace ClasesBase
{
    public class Cliente
    {
        private string cli_DNI;
        private string cli_Apellido;
        private string cli_Nombre;
        private string cli_Direccion;
        private string cli_Telefono;
        private bool cli_Disponible;

        public string Cli_DNI { get => cli_DNI; set => cli_DNI = value; }
        public string Cli_Apellido { get => cli_Apellido; set => cli_Apellido = value; }
        public string Cli_Nombre { get => cli_Nombre; set => cli_Nombre = value; }
        public string Cli_Direccion { get => cli_Direccion; set => cli_Direccion = value; }
        public string Cli_Telefono { get => cli_Telefono; set => cli_Telefono = value; }
        public bool Cli_Disponible { get => cli_Disponible; set => cli_Disponible = value; }

        public Cliente(string dni, string nombre, string apellido, string direccion, string telefono, bool disponible)
        {
            Cli_DNI = dni;
            Cli_Nombre = nombre;
            Cli_Apellido = apellido;
            Cli_Direccion = direccion;
            Cli_Telefono = telefono;
            Cli_Disponible = disponible;
        }

        public Cliente(string dni, string nombre, string apellido, string direccion, string telefono)
        {
            Cli_DNI = dni;
            Cli_Nombre = nombre;
            Cli_Apellido = apellido;
            Cli_Direccion = direccion;
            Cli_Telefono = telefono;
        }

        public Cliente() { }
    }
}
