namespace TestCSWithDatabase.Services
{
    public class UserDAO
    {
        string connectionString = @"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TestDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public bool FindUserByPassword()
        {
            bool passwordIsCorrect = false;
            return passwordIsCorrect;
        }
    }
}
