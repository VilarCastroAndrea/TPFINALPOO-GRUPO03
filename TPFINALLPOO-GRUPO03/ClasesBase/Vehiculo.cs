namespace ClasesBase
{
    public class Vehiculo
    {
        private string veh_Matricula;
        private string veh_Marca;
        private string veh_Linea;
        private int veh_Modelo;
        private string veh_Color;
        private int veh_Puertas;
        private bool veh_GPS;
        private int tv_ID;
        private int cv_ID;
        private decimal veh_Precio;
        private bool veh_Disponible;

        public string Veh_Matricula { get => veh_Matricula; set => veh_Matricula = value; }
        public string Veh_Marca { get => veh_Marca; set => veh_Marca = value; }
        public string Veh_Linea { get => veh_Linea; set => veh_Linea = value; }
        public int Veh_Modelo { get => veh_Modelo; set => veh_Modelo = value; }
        public string Veh_Color { get => veh_Color; set => veh_Color = value; }
        public int Veh_Puertas { get => veh_Puertas; set => veh_Puertas = value; }
        public bool Veh_GPS { get => veh_GPS; set => veh_GPS = value; }
        public int Tv_ID { get => tv_ID; set => tv_ID = value; }
        public int Cv_ID { get => cv_ID; set => cv_ID = value; }
        public decimal Veh_Precio { get => veh_Precio; set => veh_Precio = value; }
        public bool Veh_Disponible { get => veh_Disponible; set => veh_Disponible = value; }

        public Vehiculo(string matricula, string marca, string linea, int modelo, string color, int puertas, bool gps, int tipo, int clase, decimal precio, bool disponible)
        {
            Veh_Matricula = matricula;
            Veh_Marca = marca;
            Veh_Linea = linea;
            Veh_Modelo = modelo;
            Veh_Color = color;
            Veh_Puertas = puertas;
            Veh_GPS = gps;
            Tv_ID = tipo;
            Cv_ID = clase;
            Veh_Precio = precio;
            Veh_Disponible = disponible;
        }

        public Vehiculo() { }

    }
}
