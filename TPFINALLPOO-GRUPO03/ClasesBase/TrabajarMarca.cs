using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
   public class TrabajarMarca
    {
        /// <summary>
        /// Lista toda las marcas
        /// </summary>
        /// <returns></returns>
        public static DataTable mostarMarcas()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "MostrarMarcas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        /// <summary>
        /// Alta Marca con stored procedure
        /// </summary>
        /// <param name="marca"></param>
        public static void altaMarca(Marca marca)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "altaMarca";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@marCodigo", marca.Mar_Codigo);
            cmd.Parameters.AddWithValue("@marDescripcion", marca.Mar_Descripcion);
          
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Baja de Marca con stored procedure
        /// </summary>
        /// <param name="codigo"></param>
        public static void bajaMarca(String codigo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "bajaMarca";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Modificar Marca con stored procedure
        /// </summary>
        /// <param name="marca"></param>
        public static void modificarMarca(Marca marca)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modificarMarca";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@codigo", marca.Mar_Codigo);
            cmd.Parameters.AddWithValue("@descripcion", marca.Mar_Descripcion);
           
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
