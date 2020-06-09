using System;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarVenta
    {
        /// <summary>
        /// Alta de ventas con stored procedure
        /// </summary>
        /// <param name="venta"></param>
        public static void altaVenta(Venta venta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "altaVenta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@cliDni", venta.Cli_DNI);
            cmd.Parameters.AddWithValue("@matricula", venta.Veh_Matricula);
            cmd.Parameters.AddWithValue("@usuId", venta.Usu_ID);
            cmd.Parameters.AddWithValue("@fecha", venta.Vta_Fecha);
            cmd.Parameters.AddWithValue("@formaDePago", venta.Fp_ID);
            cmd.Parameters.AddWithValue("@precioFinal", venta.Vta_PrecioFinal);
            cmd.Parameters.AddWithValue("@estado", "CONFIRMADA");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Reailiza la modificacion de una venta en la base de datos

        public static void modificarVenta(int id, string estado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modificarVenta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@estado", estado);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Lista toda la venta
        /// </summary>
        /// <returns></returns>
        public static DataTable listarVenta()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarVentas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Busca una venta por cliente por marca y  por rango de fecha
        /// </summary>
        /// <param name="sPattern"></param>
        /// <param name="dni"></param>
        /// <param name="desde"></param>
        /// <param name="hasta"></param>
        /// <returns></returns>
        public static DataTable buscarVenta(string sPattern, string dni, DateTime desde, DateTime hasta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "buscarVenta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", sPattern);
            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.Parameters.AddWithValue("@desde", desde);
            cmd.Parameters.AddWithValue("@hasta", hasta);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
