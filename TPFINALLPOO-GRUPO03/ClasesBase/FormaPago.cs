namespace ClasesBase
{
    public class FormaPago
    {
        private int fp_ID;
        private string fp_Descripcion;
        private bool fp_Disponible;

        public int Fp_ID { get => fp_ID; set => fp_ID = value; }
        public string Fp_Descripcion { get => fp_Descripcion; set => fp_Descripcion = value; }
        public bool Fp_Disponible { get => fp_Disponible; set => fp_Disponible = value; }

        public FormaPago(string descripcion, bool estado)
        {
            Fp_Descripcion = descripcion;
            Fp_Disponible = estado;
        }

        public FormaPago() { }
    }
}
