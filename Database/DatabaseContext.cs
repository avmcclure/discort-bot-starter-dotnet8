using System.Data.Common;
using Npgsql;

namespace Database;

public class DatabaseContext(string connectionString)
{
    public DbConnection Connection { get; } = new NpgsqlConnection(connectionString);
}