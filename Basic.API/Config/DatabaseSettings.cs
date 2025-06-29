namespace Basic.API.Config;

public class DatabaseSettings
{
    public const string SectionName = "DatabaseSettings";
    
    public string ConnectionString { get; set; } = string.Empty;
    
    public string Host { get; set; } = "localhost";
    public string Port { get; set; } = "5432";
    public string Database { get; set; } = "basicapi";
    public string Username { get; set; } = "postgres";
    public string Password { get; set; } = "postgres";

    public string GetConnectionString()
    {
        return string.IsNullOrEmpty(ConnectionString)
            ? $"Host={Host};Port={Port};Database={Database};Username={Username};Password={Password}"
            : ConnectionString;
    }
}
