namespace ClasesBase
{
    public class Rol
    {
        private string rol_Codigo;
        private string rol_Descripcion;

        public string Rol_Codigo { get => rol_Codigo; set => rol_Codigo = value; }
        public string Rol_Descripcion { get => rol_Descripcion; set => rol_Descripcion = value; }

        public Rol(string codigo, string descripcion)
        {
            Rol_Codigo = codigo;
            Rol_Descripcion = Rol_Descripcion;
        }

        public Rol() { }

    }
}
