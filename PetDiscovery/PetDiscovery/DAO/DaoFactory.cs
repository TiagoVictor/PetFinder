using System.Data.SqlClient;
using Npgsql;
namespace PetDiscovery.DAO
{
    class DaoFactory
    {
        NpgsqlConnection con = new NpgsqlConnection();

        //Construtor
        public DaoFactory()
        {
            con.ConnectionString = "server=localhost;Port=5432;user id=postgres;password=Tiago1998;database=PETDISCOVERY";
        }
        //Metodo de conexão
        public NpgsqlConnection Connect()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }
        //Metodo de desconectar
        public void Close()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
