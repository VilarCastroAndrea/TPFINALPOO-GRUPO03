using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBase
{
  public class Marca
    {
        
        
            private String mar_Codigo;
            private String mar_Descripcion;

            public string Mar_Descripcion { get => mar_Descripcion; set => mar_Descripcion = value; }
            public string Mar_Codigo { get => mar_Codigo; set => mar_Codigo = value; }

            public Marca(string mar_Codigo, string mar_Descripcion)
            {
                this.Mar_Codigo = mar_Codigo;
                this.Mar_Descripcion = mar_Descripcion;
            }

            public Marca()
            {
            }
        
    }
}
