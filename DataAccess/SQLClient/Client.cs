

namespace DataAccess.SQLClient
{
    public class Client
    {
        public string GetStringConnection()
        {
            var stringConnection = "server=(localdb)\\MSSQLLocalDb;database=HealthApp;Trusted_Connection=true;Integrated Security=False";
            return stringConnection;
        }
    }
}
