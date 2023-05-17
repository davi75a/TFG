
using MySql.Data.MySqlClient;

namespace TFG
{
    internal class Conexion
    {
        private MySqlConnection conexion;
        private string server = "localhost";
        private string database = "emporium_bd";
        private string user = "root";
        private string password = "admin";
        private string cadanaConexion;
        public static Conexion mConexion;


        public Conexion()
        {
            cadanaConexion = "Database=" + database +
                "; DataSource=" + server +
                "; User Id= " + user +
                "; Password= " + password;

        }

        public MySqlConnection getConxion()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadanaConexion);
                conexion.Open();
            }

            return conexion;
        }
    }
}
