using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarClaseVehiculo
    {
        public static void altaClase(string valor, bool estado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "altaClase";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@vehiculo", valor);
            cmd.Parameters.AddWithValue("@estado", estado);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void bajaClase(int id, bool estado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "bajaClase";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@estado", estado);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void modificacionClase(ClaseVehiculo cv)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modificarClase";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", cv.Cv_ID);
            cmd.Parameters.AddWithValue("@vehiculo", cv.Cv_Descripcion);
            cmd.Parameters.AddWithValue("@estado", cv.Cv_Disponible);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable listarClaseVehiculo()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM ListarClaseVehiculo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable listarClaseVehDisponible()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarClaseVehDisponible";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dis", true);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
