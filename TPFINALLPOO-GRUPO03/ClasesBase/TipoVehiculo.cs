namespace ClasesBase
{
    public class TipoVehiculo
    {
        private int tv_ID;
        private string tv_Descripcion;
        private bool tv_Disponible;

        public int Tv_ID { get => tv_ID; set => tv_ID = value; }
        public string Tv_Descripcion { get => tv_Descripcion; set => tv_Descripcion = value; }
        public bool Tv_Disponible { get => tv_Disponible; set => tv_Disponible = value; }

        public TipoVehiculo() { }

        public TipoVehiculo(string descripcion, bool estado)
        {
            Tv_Descripcion = descripcion;
            Tv_Disponible = estado;
        }
    }
}
