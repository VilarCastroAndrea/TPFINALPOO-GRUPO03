using System;

namespace ClasesBase
{
    public class Venta
    {
        private int vta_ID;
        private string cli_DNI;
        private string veh_Matricula;
        private int usu_ID;
        private DateTime vta_Fecha;
        private int fp_ID;
        private decimal vta_PrecioFinal;
        private string vta_Estado;

        public int Vta_ID { get => vta_ID; set => vta_ID = value; }
        public string Cli_DNI { get => cli_DNI; set => cli_DNI = value; }
        public string Veh_Matricula { get => veh_Matricula; set => veh_Matricula = value; }
        public int Usu_ID { get => usu_ID; set => usu_ID = value; }
        public DateTime Vta_Fecha { get => vta_Fecha; set => vta_Fecha = value; }
        public int Fp_ID { get => fp_ID; set => fp_ID = value; }
        public decimal Vta_PrecioFinal { get => vta_PrecioFinal; set => vta_PrecioFinal = value; }
        public string Vta_Estado { get => vta_Estado; set => vta_Estado = value; }

        public Venta(int vta_ID, string cli_DNI, string veh_Matricula, int usu_ID, DateTime vta_Fecha, int formaPago, decimal vta_PrecioFinal, string estado)
        {
            Vta_ID = vta_ID;
            Cli_DNI = cli_DNI;
            Veh_Matricula = veh_Matricula;
            Usu_ID = usu_ID;
            Vta_Fecha = vta_Fecha;
            Fp_ID = formaPago;
            Vta_PrecioFinal = vta_PrecioFinal;
            Vta_Estado = estado;
        }

        public Venta() { }

    }
}
