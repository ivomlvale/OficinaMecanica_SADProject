using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica
{
    public class LigacaoBaseDados
    {
        private LigacaoBaseDados() { }

        public string Password { get; set; }

        private SqlConnection _connection = null;

        public SqlConnection Connection
        {
            get { return _connection; }
        }

        private static LigacaoBaseDados _instance = null;

        public static LigacaoBaseDados Instance()
        {
            if (_instance == null)
                _instance = new LigacaoBaseDados();

            return _instance;
        }

        public bool isConnected()
        {
            string connString = "Data Source=(local);Initial Catalog=OficinaMecanica;Integrated Security=SSPI";

            _connection = new SqlConnection(connString);
            _connection.Open();
            Console.WriteLine("Ligado");

            return true;
        }

        public void Close()
        {
            _connection.Close();
            _connection = null;
        }
    }
}
