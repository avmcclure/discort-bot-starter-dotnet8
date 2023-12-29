using System.Data.Common;
using Npgsql;
using Shared;

namespace Database;

public class DatabaseContext
{
    private readonly AppSettings _appSettings;
    public DbConnection Connection { get; }

    public DatabaseContext(AppSettings appSettings)
    {
        _appSettings = appSettings;
        Connection = new NpgsqlConnection(_appSettings.DatabaseConnectionString);
    }
}