using System.Data.SqlClient;
using TestCSWithDatabase.Models;

namespace TestCSWithDatabase.Services
{
    public class UserDAO
    {
        string connectionString = @"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TestDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public bool FindUserByPassword(User user)
        {
            string sqlStatement = "SELECT * FROM dbo.User WHERE password = @password";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlStatement, connection);
                cmd.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 40).Value = User.name;
            }
        }
    }
}
