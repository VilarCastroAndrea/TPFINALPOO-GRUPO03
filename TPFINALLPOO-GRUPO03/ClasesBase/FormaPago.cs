namespace ClasesBase
{
    public class FormaPago
    {
        private int fp_ID;
        private string fp_Descripcion;

        public int Fp_ID { get => fp_ID; set => fp_ID = value; }
        public string Fp_Descripcion { get => fp_Descripcion; set => fp_Descripcion = value; }

        public FormaPago() { }
    }
}
