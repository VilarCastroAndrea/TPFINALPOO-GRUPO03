using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
   public class TrabajarLinea
    {

        /// <summary>
        /// Lista las lineas por marca
        /// </summary>
        /// <param name="sPattern"></param>
        /// <returns></returns>
        public static DataTable buscarPorMarca(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscarPorMarca";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Lista toda las marcas
        /// </summary>
        /// <returns></returns>
        public static DataTable listarLineas()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListarLinea";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
