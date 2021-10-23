using Oracle.ManagedDataAccess.Client;

namespace Datos
{
    public class ConnectionManager
    {
        internal OracleConnection _connection;
        public ConnectionManager(string connectionString)
        {
            _connection = new OracleConnection(connectionString);

        }
        public void Open()
        {
            _connection.Open();

        }
        public void Close()
        {
            _connection.Close();
        }

    }
}
