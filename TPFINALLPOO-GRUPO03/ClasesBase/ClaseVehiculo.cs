namespace ClasesBase
{
    public class ClaseVehiculo
    {
        private int cv_ID;
        private string cv_Descripcion;

        public int Cv_ID { get => cv_ID; set => cv_ID = value; }
        public string Cv_Descripcion { get => cv_Descripcion; set => cv_Descripcion = value; }

        public ClaseVehiculo(string descripcion)
        {
            Cv_Descripcion = descripcion;
        }

        public ClaseVehiculo() { }
    }
}
