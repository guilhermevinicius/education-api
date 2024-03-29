using Education.Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace Education.Api.Configurations;

public static class ConnectionsConfiguration
{
    public static IServiceCollection AddAppConections(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbConnection(configuration);
        return services;
    }

    private static IServiceCollection AddDbConnection(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("App");
        services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));
        return services;
    }

    public static WebApplication MigrateDatabase(this WebApplication app)
    {
        var environment = Environment
            .GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        if (environment == "EndToEndTest") return app;
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();
        dbContext.Database.Migrate();
        return app;
    }
}