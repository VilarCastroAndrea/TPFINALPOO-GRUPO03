using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBase
{
    class Linea
    {
        private int li_Id;
        private string li_Descripcion;
        private String mar_Codigo;

        public int Li_Id { get => li_Id; set => li_Id = value; }
        public string Li_Descripcion { get => li_Descripcion; set => li_Descripcion = value; }
        public string Mar_Codigo { get => mar_Codigo; set => mar_Codigo = value; }

        public Linea(int li_Id, string li_Descripcion, string mar_Codigo)
        {
            this.li_Id = li_Id;
            this.li_Descripcion = li_Descripcion;
            this.mar_Codigo = mar_Codigo;
        }

        public Linea()
        {
        }
    }
}
