namespace ClasesBase
{
    public class TipoVehiculo
    {
        private int tv_ID;
        private string tv_Descripcion;

        public int Tv_ID { get => tv_ID; set => tv_ID = value; }
        public string Tv_Descripcion { get => tv_Descripcion; set => tv_Descripcion = value; }

        public TipoVehiculo(string descripcion)
        {
            Tv_Descripcion = descripcion;
        }
    }
}
