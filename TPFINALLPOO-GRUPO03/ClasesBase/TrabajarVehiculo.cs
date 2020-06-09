using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarVehiculo
    {
        /// <summary>
        /// Alta vehiculo con stored procedure
        /// </summary>
        /// <param name="vehiculo"></param>
        public static void altaVehiculo(Vehiculo vehiculo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "altaVehiculo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@matricula", vehiculo.Veh_Matricula);
            cmd.Parameters.AddWithValue("@marca", vehiculo.Veh_Marca);
            cmd.Parameters.AddWithValue("@linea", vehiculo.Veh_Linea);
            cmd.Parameters.AddWithValue("@modelo", vehiculo.Veh_Modelo);
            cmd.Parameters.AddWithValue("@color", vehiculo.Veh_Color);
            cmd.Parameters.AddWithValue("@puertas", vehiculo.Veh_Puertas);
            cmd.Parameters.AddWithValue("@GPS", vehiculo.Veh_GPS);
            cmd.Parameters.AddWithValue("@tipovehiculo", vehiculo.Tv_ID);
            cmd.Parameters.AddWithValue("@clasevehiculo", vehiculo.Cv_ID);
            cmd.Parameters.AddWithValue("@precio", vehiculo.Veh_Precio);
            cmd.Parameters.AddWithValue("@disponible", vehiculo.Veh_Disponible);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Baja de Vehiculo con stored procedure
        /// </summary>
        /// <param name="matricula"></param>
        /// <param name="dis"></param>
        public static void bajaVehiculo(string matricula, bool dis)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "bajaVehiculo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@matricula", matricula);
            cmd.Parameters.AddWithValue("@dis", dis);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Borra vehiculos definitivamente
        /// </summary>
        /// <param name="matricula"></param>
        public static void eliminarVehiculo(string matricula)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "eliminarVehiculo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@matricula", matricula);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Modifica Vehiculo con stored procedure
        /// </summary>
        /// <param name="vehiculo"></param>
        public static void modificarVehiculo(Vehiculo vehiculo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modificarVehiculo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@matricula", vehiculo.Veh_Matricula);
            cmd.Parameters.AddWithValue("@marca", vehiculo.Veh_Marca);
            cmd.Parameters.AddWithValue("@linea", vehiculo.Veh_Linea);
            cmd.Parameters.AddWithValue("@modelo", vehiculo.Veh_Modelo);
            cmd.Parameters.AddWithValue("@color", vehiculo.Veh_Color);
            cmd.Parameters.AddWithValue("@puertas", vehiculo.Veh_Puertas);
            cmd.Parameters.AddWithValue("@GPS", vehiculo.Veh_GPS);
            cmd.Parameters.AddWithValue("@tipovehiculo", vehiculo.Tv_ID);
            cmd.Parameters.AddWithValue("@clasevehiculo", vehiculo.Cv_ID);
            cmd.Parameters.AddWithValue("@precio", vehiculo.Veh_Precio);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Busca vehiculo
        /// </summary>
        /// <param name="sPattern"></param>
        /// <returns></returns>
        public static DataTable buscarVehiculo(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscarVehiculo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }



        /// <summary>
        /// Lista todos los vehiculos 
        /// </summary>
        /// <returns></returns>
        public static DataTable listarVehiculo()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarVehiculos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Lista los vehiculos disponible
        /// </summary>
        /// <returns></returns>
        public static DataTable listarVehiculoDisponible(bool dis)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarVehiculoDisponible";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dis", dis);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Lista los vehiculos por marca
        /// </summary>
        /// <returns></returns>
        public static DataTable listaXMarca()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listaMarca";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //Ordena los vehiculos por marca
        public static DataTable ordenarVporMarca()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ordenarVehiculoXMarca";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //ordena los vehiculos por linea
        public static DataTable ordenarVporLinea()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ordenarVehiculoXLinea";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
