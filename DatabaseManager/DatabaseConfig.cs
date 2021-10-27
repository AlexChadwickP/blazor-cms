namespace DatabaseManager
{
    public class DatabaseConfig
    {
        private readonly string _connectionString;

        public DatabaseConfig(string host, string username, string password, string database)
        {
            _connectionString = $"Host={host};Username={username};Password={password};Database={database}";
        }

        public string GetConnectionString()
        {
            return _connectionString;
        }
    }
}