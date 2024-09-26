using MySql.Data.MySqlClient;

namespace AutoSale
{
    public class Connect
    {
        public MySqlConnection Connection;
        private string Host;
        private string Database;
        private string User;
        private string Password;
        private string ConnectionString;

        public Connect()
        {
            Host = "127.0.0.1";
            Database = "autos";
            User = "root";
            Password = "";

            ConnectionString = "SERVER=" + Host + ";DATABASE=" + Database + ";UID=" + User + ";PASSWORD=" + Password + ";SslMode=None";

            Connection = new MySqlConnection(ConnectionString);
        }

    }
}
