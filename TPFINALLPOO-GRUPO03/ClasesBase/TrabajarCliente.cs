using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCliente
    {
        /// <summary>
        /// Alta cliente con stored procedure
        /// </summary>
        /// <param name="cliente"></param>
        public static void altaCliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "altaCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dni", cliente.Cli_DNI);
            cmd.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@direccion", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@telefono", cliente.Cli_Telefono);
            cmd.Parameters.AddWithValue("@disponible", cliente.Cli_Disponible);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Baja de cliente con stored procedure
        /// </summary>
        /// <param name="dniCliente"></param>
        /// <param name="dis"></param>
        public static void bajaCliente(string dniCliente, bool dis)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "bajaCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dni", dniCliente);
            cmd.Parameters.AddWithValue("@dis", dis);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }



        /// <summary>
        /// Baja de cliente fisica con stored procedure
        /// </summary>
        /// <param name="dniCliente"></param>
        /// <param name="dis"></param>
        public static void bajaClienteFisica(string dniCliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "bajaClienteFisica";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dni", dniCliente);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }




        /// <summary>
        /// Modificar cliente con stored procedure
        /// </summary>
        /// <param name="cliente"></param>
        public static void modificarCliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modificarCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dni", cliente.Cli_DNI);
            cmd.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@direccion", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@telefono", cliente.Cli_Telefono);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Lista todo los clientes
        /// </summary>
        /// <returns></returns>
        public static DataTable ListaCliente()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListarClientes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Listar clientes Disponible
        /// </summary>
        /// <returns></returns>
        public static DataTable ListaClienteD(bool dis)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarClienteDisponible";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dis", dis);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Lista los clientes por apellidos con stored procedure
        /// </summary>
        /// <returns></returns>
        public static DataTable ListaClientesPorApellido()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarClientesApellido";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Busca cliente por dni o apellido
        /// </summary>
        /// <param name="sPattern"></param>
        /// <returns></returns>
        public static DataTable buscarCliente(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscarCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");
            cmd.Parameters.AddWithValue("@pattern2", "%" + sPattern + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        /// <summary>
        /// Busca cliente por dni o apellido no borrado
        /// </summary>
        /// <param name="sPattern"></param>
        /// <returns></returns>
        public static DataTable buscarClienteDisponible(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscarClienteDisponible";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dis", true);
            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");
            cmd.Parameters.AddWithValue("@pattern2", "%" + sPattern + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
