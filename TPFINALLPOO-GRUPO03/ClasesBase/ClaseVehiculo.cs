namespace ClasesBase
{
    public class ClaseVehiculo
    {
        private int cv_ID;
        private string cv_Descripcion;
        private bool cv_Disponible;

        public int Cv_ID { get => cv_ID; set => cv_ID = value; }
        public string Cv_Descripcion { get => cv_Descripcion; set => cv_Descripcion = value; }
        public bool Cv_Disponible { get => cv_Disponible; set => cv_Disponible = value; }

        public ClaseVehiculo(string descripcion, bool estado)
        {
            Cv_Descripcion = descripcion;
            Cv_Disponible = estado;
        }

        public ClaseVehiculo() { }
    }
}
