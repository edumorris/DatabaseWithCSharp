using DatabaseWithCSharp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EFDatabase;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        var connectionString = "server=localhost:3306;user=manmax;password=P@$$w0r6__;database=school"; // Replace with connection string
    
        /*
            Replace with server version and type.
            Use 'MariaDBServerVersion' for MariaDB
            Alternatively, use 'ServerVersion.AutoDetect(connectionString)'
            For common usages, see pull request #1233
         */
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 31));
        
        // Replace 'YourDbContext' with the name of your own DBContext derived class
        services.AddDbContext<EFTestDbContext>(
            dbContextOptions => dbContextOptions
                .UseMySql(connectionString, serverVersion)
            // The following 3 options help with debugging, but should be changed/removed for production
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors()
        );
    }
}

/*
    Dependencies to use:
        Pomelo.EntityFrameworkCore.MySql
        Microsoft.EntityFrameworkCore.Tools
        EF Migrations
*/