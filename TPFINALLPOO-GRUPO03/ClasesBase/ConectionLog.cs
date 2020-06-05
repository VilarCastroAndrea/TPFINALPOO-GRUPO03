using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class ConectionLog
    {
        public static DataTable ingresar(string user, string pswd)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agenciaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario";
            cmd.CommandText += " WHERE USU_NombreUsuario LIKE @nombreUsuario";
            cmd.CommandText += " AND USU_Password LIKE @pasword";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@nombreUsuario", "%" + user + "%");
            cmd.Parameters.AddWithValue("@pasword", "%" + pswd + "%");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
