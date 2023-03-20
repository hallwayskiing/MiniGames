using MySql.Data.MySqlClient;

namespace MiniGames.Utils
{
    internal class DatabaseManager
    {
        private MySqlConnection? conn;
        public string ConnectionString { private get; set; }

        public bool IsExistedUser(User user)
        {
            using (conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select password from account where username='" + user.Name + "'", conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows && dr.GetString("password").Equals(user.Password))
                    return true;
                return false;
            }
        }

        public bool IsExistedName(string username)
        {
            using (conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from account where username='" + username + "'", conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows && dr.GetString("username").Equals(username))
                    return true;
                return false;
            }
        }

        public bool IsExistedCode(string code)
        {
            using (conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from codes where code='" + code + "'", conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows && dr.GetString("code").Equals(code))
                    return true;
                return false;
            }
        }

        public void AddUser(User user)
        {
            using (conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into account (username,password) values ('" + user.Name + "','" + user.Password + "')", conn);
                cmd.ExecuteNonQuery();
            }
        }

        public DatabaseManager(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
